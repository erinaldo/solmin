Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Public Class frmExportar


    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property
    Private _pCCMPN_DESC As String = ""
    Public Property pCCMPN_DESC() As String
        Get
            Return _pCCMPN_DESC
        End Get
        Set(ByVal value As String)
            _pCCMPN_DESC = value
        End Set
    End Property


    Private _pCCLNT As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Enum TipoReporte
        Extendido
        Valorizado
    End Enum

    Private _pTipoReporteExport As TipoReporte = TipoReporte.Extendido
    Public Property pTipoReporteExport() As TipoReporte
        Get
            Return _pTipoReporteExport
        End Get
        Set(ByVal value As TipoReporte)
            _pTipoReporteExport = value
        End Set
    End Property


    Private Sub frmExportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbCompania_Seleccionar()
            CargarCombos()
            CargarLocalidadOD()
            If _pCCLNT > 0 Then
                cmbCliente.pCargar(_pCCLNT)
                cmbCliente_TextChanged()
            End If
            Select Case _pTipoReporteExport
                Case TipoReporte.Extendido
                    lblTipo.Text = "Extendido"
                Case TipoReporte.Valorizado
                    lblTipo.Text = "Valorizado"
            End Select
            KryptonCheckBox1_CheckedChanged(KryptonCheckBox1, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarConsulta() As String
        Dim msg As String = ""
        If cmbCliente.pCodigo = 0 Then
            msg = "Seleccione cliente"
        End If
        Return msg
    End Function

    Private Sub btAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAceptar.Click
        Try

            Dim msg As String = ValidarConsulta()
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim obeDespachoNacional As New beDespachoNacional
            With obeDespachoNacional
                .PSCCMPN = _pCCMPN
                .PSCDVSN = cmbDivision.Division
                .PNCPLNDV = cmbPlanta.Planta
                .PNCCLNT = CDec(IIf(cmbCliente.pCodigo.ToString.Trim = String.Empty, "0", cmbCliente.pCodigo.ToString.Trim))
                .PSTPSRVA = IIf(cboTipoOperacion.SelectedValue.ToString.Trim = String.Empty, "", cboTipoOperacion.SelectedValue.ToString.Trim)
                .PSSESTRG = IIf(cmbEstado.SelectedValue.ToString.Trim = "0", "", cmbEstado.SelectedValue.ToString.Trim)
                .PNNORSCI = CDec(IIf(txtEmbarque.Text.Trim = String.Empty, "0", txtEmbarque.Text.Trim))

                If cboLugarorigen.Resultado IsNot Nothing Then
                    .PNCLCLOR = CDec(CType(cboLugarorigen.Resultado, beLocalidad).CLCLD)
                Else
                    .PNCLCLOR = 0
                End If

                If cboLugarDestino.Resultado IsNot Nothing Then
                    .PNCLCLDS = CDec(CType(cboLugarDestino.Resultado, beLocalidad).CLCLD)
                Else
                    .PNCLCLDS = 0
                End If
                If KryptonCheckBox1.Checked = True Then
                    .PNFECINI = 0
                    .PNFECFIN = 0
                    .PNNESTDO = KryptonComboBox1.SelectedValue
                    .PNCHK_INI = CDec(DateTimePicker1.Value.ToString("yyyyMMdd"))
                    .PNCHK_FIN = CDec(DateTimePicker2.Value.ToString("yyyyMMdd"))
                Else
                    .PNFECINI = CDec(dtpInicio.Value.ToString("yyyyMMdd"))
                    .PNFECFIN = CDec(dtpFin.Value.ToString("yyyyMMdd"))
                    .PNNESTDO = 0
                    .PNCHK_INI = 0
                    .PNCHK_FIN = 0
                End If

            End With

            Select Case _pTipoReporteExport
                Case TipoReporte.Extendido
                    ExportGeneral(obeDespachoNacional)
                Case TipoReporte.Valorizado
                    ExportValorizado(obeDespachoNacional)
            End Select



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ExportGeneral(ByVal obeDespachoNacional As beDespachoNacional)

        Dim oClsFnLocal As New ClsFnDespachoLocal

        Dim oclsDespachoNacional As New clsDespachoNacional()
        Dim dtDespacho As New DataTable
        dtDespacho = oclsDespachoNacional.Listar_Datos_Exportar_General(obeDespachoNacional)

        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim odtExportar As New DataTable
        Dim MdataColumna As String = ""


        odtExportar.Columns.Add("NORSCI").Caption = NPOI_SC.FormatDato("Embarque", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("FORSCI").Caption = NPOI_SC.FormatDato("Fecha apertura", NPOI_SC.keyDatoFecha)
        odtExportar.Columns.Add("TCMLCL_ORIGEN").Caption = NPOI_SC.FormatDato("Origen", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TDRCOR").Caption = NPOI_SC.FormatDato("Dirección Origen", NPOI_SC.keyDatoTexto)


        odtExportar.Columns.Add("TCMLCL_DESTINO").Caption = NPOI_SC.FormatDato("Destino", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TDREN2").Caption = NPOI_SC.FormatDato("Dirección Destino", NPOI_SC.keyDatoTexto)
      
        odtExportar.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato("Medio Transporte", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("NDOCEM").Caption = NPOI_SC.FormatDato("Doc. Embarque", NPOI_SC.keyDatoTexto)

        odtExportar.Columns.Add("TNMAGC").Caption = NPOI_SC.FormatDato("Agente embarcador", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TNMCIN").Caption = NPOI_SC.FormatDato("Cía. Transporte", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("REFNAV_DESC").Caption = NPOI_SC.FormatDato("Tipo Transporte", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TTRMAL").Caption = NPOI_SC.FormatDato("Terminal", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TOBERV").Caption = NPOI_SC.FormatDato("Mercadería", NPOI_SC.keyDatoTexto)

        odtExportar.Columns.Add("NREFCL").Caption = NPOI_SC.FormatDato("Ref. cliente", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("REFDO1").Caption = NPOI_SC.FormatDato("Ref. documento", NPOI_SC.keyDatoTexto)

        odtExportar.Columns.Add("TDSDES").Caption = NPOI_SC.FormatDato("Tipo carga", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("QVOLMR").Caption = NPOI_SC.FormatDato("Volumen(m3)", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("QPSOAR").Caption = NPOI_SC.FormatDato("Peso total(kg)", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("SESTRG").Caption = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)


        odtExportar.Columns.Add("TRECOR").Caption = NPOI_SC.FormatDato("Observación(Ref)", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("OBS").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)



        Dim NameColumna As String = String.Empty
        For Each dc As DataColumn In dtDespacho.Columns
            NameColumna = dc.ColumnName.Trim

            If (NameColumna.EndsWith("-COSTO")) Then
                odtExportar.Columns.Add(NameColumna).Caption = NPOI_SC.FormatDato(dc.Caption.Trim, NPOI_SC.keyDatoNumero)
            End If

            If (NameColumna.EndsWith("-CHK")) Then
                odtExportar.Columns.Add(NameColumna).Caption = NPOI_SC.FormatDato(dc.Caption.Trim, NPOI_SC.keyDatoFecha)
            End If

            'If (NameColumna = "DIF") Then
            '    odtExportar.Columns.Add("DIF").Caption = NPOI_SC.FormatDato(dc.Caption.Trim, NPOI_SC.keyDatoNumero)
            'End If
        Next


        Dim dr As DataRow
        For Each item As DataRow In dtDespacho.Rows
            dr = odtExportar.NewRow
            For Each ItemCol As DataColumn In odtExportar.Columns
                If dtDespacho.Columns(ItemCol.ColumnName) IsNot Nothing Then
                    dr(ItemCol.ColumnName) = item(ItemCol.ColumnName)
                End If
            Next
            odtExportar.Rows.Add(dr)
        Next

        Dim clsCalculoDespacho As New clsDespachoNacional
        Dim pNORSCI As String = ""


        Dim ListaDatatable As New List(Of DataTable)
        ListaDatatable.Add(odtExportar.Copy)

        Dim LisFiltros As New List(Of SortedList)
        Dim itemSortedList As SortedList

        itemSortedList = New SortedList

        itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & " " & cmbCliente.pRazonSocial)
        itemSortedList.Add(itemSortedList.Count, "Compañia:|" & _pCCMPN_DESC)
        itemSortedList.Add(itemSortedList.Count, "División:|" & cmbDivision.DivisionDescripcion)
        itemSortedList.Add(itemSortedList.Count, "Planta:|" & cmbPlanta.DescripcionPlanta)

        If txtEmbarque.Text.Trim <> String.Empty Then
            itemSortedList.Add(itemSortedList.Count, "Embarque:|" & txtEmbarque.Text.Trim)
        End If

        LisFiltros.Add(itemSortedList)

        Dim ListTitulo As New List(Of String)
        ListTitulo.Add("Seguimiento Local")

        'Dim ListNameCombDuplicado As New List(Of String)
        'Dim CombCol As String
        ' ''INFORMACIÓN GENERAL
        '' CombCol = "PAIS:PAIS/1|PUERTO:PAIS,PUERTO/1|FORWARDER:PAIS,PUERTO,FORWARDER/1|TIPO_CARGA:PAIS,PUERTO,FORWARDER,TIPO_CARGA/1|MERCADERIA:PAIS,PUERTO,FORWARDER,TIPO_CARGA,MERCADERIA/1"
        'CombCol = "NORSCI:NORSCI/1|FORSCI:NORSCI,FORSCI/0|TCMLCL_ORIGEN:NORSCI,TCMLCL_ORIGEN/0|TDREN2:NORSCI,TDREN2/0"
        'CombCol = CombCol & "|TDRCOR:NORSCI,TDRCOR/0|TCMLCL_DESTINO:NORSCI,TCMLCL_DESTINO/0|NDOCEM:NORSCI,NDOCEM/0"
        'CombCol = CombCol & "|REFDO1:NORSCI,REFDO1/0|NREFCL:NORSCI,NREFCL/0|TPRVCL:NORSCI,TPRVCL/0|TNMMDT:NORSCI,TNMMDT/0"
        'CombCol = CombCol & "|TNMCIN:NORSCI,TNMCIN/0|REFNAV:NORSCI,REFNAV/0|TDSDES:NORSCI,TDSDES/0|QVOLMR:NORSCI,QVOLMR/0|TTRMAL:NORSCI,TTRMAL/0|TNMAGC:NORSCI,TNMAGC/0"
        'CombCol = CombCol & "|QPSOAR:NORSCI,QPSOAR/0|SESTRG:NORSCI,SESTRG/0|OBSERVACION:NORSCI,OBSERVACION/0|TRECOR:NORSCI,TRECOR/0|156_FRE_CHK:NORSCI,156_FRE_CHK/0"
        'CombCol = CombCol & "|159_FRE_CHK:NORSCI,159_FRE_CHK/0|157_FRE_CHK:NORSCI,157_FRE_CHK/0|160_FRE_CHK:NORSCI,160_FRE_CHK/0"
        'CombCol = CombCol & "|161_FRE_CHK:NORSCI,161_FRE_CHK/0|158_FRE_CHK:NORSCI,158_FRE_CHK/0"
        'CombCol = CombCol & "|FACTOR_SERV:NORSCI,FACTOR_SERV/0|TARIFA:NORSCI,TARIFA/0|VAL_SERV:NORSCI,VAL_SERV/0|VALOROC_ITEM:NORSCI,VALOROC_ITEM/0"
        'CombCol = CombCol & "|TSGNMN:NORSCI,TSGNMN/0|IVLSRV:NORSCI,IVLSRV/0|NUMDCR:NORSCI,NUMDCR/1|NGRPRV:NORSCI,NGRPRV/1|NORCML:NORSCI,NORCML/1"
        'ListNameCombDuplicado.Add(CombCol)

        Dim ListColNFilas As New List(Of String)
        ListColNFilas.Add("OBSERVACION")

        'Dim FilaAgrupacion As New List(Of String)
        'FilaAgrupacion.Add("NORSCI")


        NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, ListColNFilas, LisFiltros, 0, Nothing, Nothing, Nothing)


    End Sub

    Private Sub ExportValorizado(ByVal obeDespachoNacional As beDespachoNacional)
        Dim oClsFnLocal As New ClsFnDespachoLocal
      
        Dim oclsDespachoNacional As New clsDespachoNacional()
        Dim dtDespacho As New DataTable
        dtDespacho = oclsDespachoNacional.Listar_Datos_Exportar_Formato2(obeDespachoNacional)

        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim odtExportar As New DataTable
        Dim MdataColumna As String = ""


        odtExportar.Columns.Add("NORSCI").Caption = NPOI_SC.FormatDato("Embarque", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("FORSCI").Caption = NPOI_SC.FormatDato("Fecha apertura", NPOI_SC.keyDatoFecha)
        odtExportar.Columns.Add("TCMLCL_ORIGEN").Caption = NPOI_SC.FormatDato("Origen", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TCMLCL_DESTINO").Caption = NPOI_SC.FormatDato("Destino", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TNMMDT").Caption = NPOI_SC.FormatDato("Medio Transporte", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("NDOCEM").Caption = NPOI_SC.FormatDato("Doc. Embarque", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TTRMAL").Caption = NPOI_SC.FormatDato("Terminal", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TNMAGC").Caption = NPOI_SC.FormatDato("Agente embarcador", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TOBERV").Caption = NPOI_SC.FormatDato("Mercadería", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TDSDES").Caption = NPOI_SC.FormatDato("Tipo carga", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("QVOLMR").Caption = NPOI_SC.FormatDato("Volumen(m3)", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("QPSOAR").Caption = NPOI_SC.FormatDato("Peso total(kg)", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("SESTRG").Caption = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)



        '162    FECHA INGRESO
        '156    FECHA SOLICITUD
        '159    REQUERIMIENTO TRANSPORTE
        '157    SALIDA DE ALMACEN
        '160    INGRESO TERMINAL
        '161    FECHA DE EMBARQUE
        '158    FECHA LLEGADA


        odtExportar.Columns.Add("162_FRE_CHK").Caption = NPOI_SC.FormatDato("Fecha ingreso", NPOI_SC.keyDatoFecha)
        odtExportar.Columns.Add("159_FRE_CHK").Caption = NPOI_SC.FormatDato("Fecha Req. Transporte", NPOI_SC.keyDatoFecha)
        '  odtExportar.Columns.Add("FSLDAL").Caption = NPOI_SC.FormatDato("Fecha salida almacén", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("160_FRE_CHK").Caption = NPOI_SC.FormatDato("Fecha ingreso terminal", NPOI_SC.keyDatoFecha)
        odtExportar.Columns.Add("161_FRE_CHK").Caption = NPOI_SC.FormatDato("Fecha embarque", NPOI_SC.keyDatoFecha)

        odtExportar.Columns.Add("REFNAV_DESC").Caption = NPOI_SC.FormatDato("Tipo Transporte", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("TNMCIN").Caption = NPOI_SC.FormatDato("Cía. Transporte", NPOI_SC.keyDatoTexto)

        odtExportar.Columns.Add("158_FRE_CHK").Caption = NPOI_SC.FormatDato("Fecha llegada destino", NPOI_SC.keyDatoFecha)
        odtExportar.Columns.Add("TRECOR").Caption = NPOI_SC.FormatDato("Observación(Ref)", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("OBSERVACION").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("NORCML").Caption = NPOI_SC.FormatDato("Orden de compra", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("VALOROC_ITEM").Caption = NPOI_SC.FormatDato("Valor O/C ($)", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("TPRVCL").Caption = NPOI_SC.FormatDato("Proveedor", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("NGRPRV").Caption = NPOI_SC.FormatDato("Guía Prov.", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("NUMDCR").Caption = NPOI_SC.FormatDato("Guía Remisión", NPOI_SC.keyDatoTexto)

        odtExportar.Columns.Add("QMTLRG_DET").Caption = NPOI_SC.FormatDato("Largo(cm)", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("QMTANC_DET").Caption = NPOI_SC.FormatDato("Ancho(cm)", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("QMTALT_DET").Caption = NPOI_SC.FormatDato("Alto(cm)", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("QCTPQT_DET").Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("QPSOMR_DET").Caption = NPOI_SC.FormatDato("Peso(kg)", NPOI_SC.keyDatoNumero)


        odtExportar.Columns.Add("PESO_VOLUMEN").Caption = NPOI_SC.FormatDato("Peso Volumen", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("PESO_FACTOR", Type.GetType("System.Decimal")).Caption = NPOI_SC.FormatDato("Peso Factor", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("FACTOR_SERV").Caption = NPOI_SC.FormatDato("Factor Servicio", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("TSGNMN").Caption = NPOI_SC.FormatDato("Moneda", NPOI_SC.keyDatoTexto)
        odtExportar.Columns.Add("IVLSRV").Caption = NPOI_SC.FormatDato("Tarifa", NPOI_SC.keyDatoNumero)
        odtExportar.Columns.Add("VAL_SERV").Caption = NPOI_SC.FormatDato("Valor servicio", NPOI_SC.keyDatoNumero)

        'odtExportar.Columns.Add("QFACTOR_SERV") ' SE QUITA DESPUES


        Dim dr As DataRow
        For Each item As DataRow In dtDespacho.Rows
            dr = odtExportar.NewRow
            For Each ItemCol As DataColumn In odtExportar.Columns
                If dtDespacho.Columns(ItemCol.ColumnName) IsNot Nothing Then
                    dr(ItemCol.ColumnName) = item(ItemCol.ColumnName)
                End If
            Next
            odtExportar.Rows.Add(dr)
        Next

        Dim clsCalculoDespacho As New clsDespachoNacional
        Dim pNORSCI As String = ""
        Dim qFactorxCierre As Decimal = 0
        Dim Visitado As New Hashtable
        For Fila As Integer = 0 To odtExportar.Rows.Count - 1
            pNORSCI = odtExportar.Rows(Fila)("NORSCI")
            'odtExportar.Rows(Fila)("PESO_VOLUMEN") = oClsFnLocal.Calcular_Peso_Volumen(odtExportar.Rows(Fila)("QMTLRG_DET"), odtExportar.Rows(Fila)("QMTANC_DET"), odtExportar.Rows(Fila)("QMTALT_DET"), odtExportar.Rows(Fila)("QCTPQT_DET"))
            'odtExportar.Rows(Fila)("PESO_FACTOR") = oClsFnLocal.Calcular_Peso_Factor_Servicio(odtExportar.Rows(Fila)("QPSOMR_DET"), odtExportar.Rows(Fila)("PESO_VOLUMEN"))
            If Not Visitado.Contains(pNORSCI) Then
                Visitado.Add(pNORSCI, Fila)
            Else
                odtExportar.Rows(Fila)("QVOLMR") = 0
                odtExportar.Rows(Fila)("QPSOAR") = 0
                odtExportar.Rows(Fila)("FACTOR_SERV") = 0
                odtExportar.Rows(Fila)("IVLSRV") = 0
                odtExportar.Rows(Fila)("VAL_SERV") = 0
                odtExportar.Rows(Fila)("VALOROC_ITEM") = 0
            End If
        Next


        'Visitado.Clear()
        'For Each item As DataRow In odtExportar.Rows
        '    pNORSCI = item("NORSCI")
        '    qFactorxCierre = item("QFACTOR_SERV")
        '    If Not Visitado.Contains(pNORSCI) Then
        '        Visitado.Add(pNORSCI, pNORSCI)

        '        If qFactorxCierre > 0 Then
        '            item("FACTOR_SERV") = qFactorxCierre
        '        Else
        '            item("FACTOR_SERV") = Val("" & odtExportar.Compute("SUM(PESO_FACTOR)", "NORSCI='" & pNORSCI & "'"))
        '        End If
        '        item("VAL_SERV") = item("FACTOR_SERV") * Val("" & item("IVLSRV"))
        '    End If
        'Next

        'odtExportar.Columns.Remove("QFACTOR_SERV")


        Dim ListaDatatable As New List(Of DataTable)
        ListaDatatable.Add(odtExportar.Copy)

        Dim LisFiltros As New List(Of SortedList)
        Dim itemSortedList As SortedList

        itemSortedList = New SortedList

        itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & " " & cmbCliente.pRazonSocial)
        itemSortedList.Add(itemSortedList.Count, "Compañia:|" & _pCCMPN_DESC)
        itemSortedList.Add(itemSortedList.Count, "División:|" & cmbDivision.DivisionDescripcion)
        itemSortedList.Add(itemSortedList.Count, "Planta:|" & cmbPlanta.DescripcionPlanta)

        If txtEmbarque.Text.Trim <> String.Empty Then
            itemSortedList.Add(itemSortedList.Count, "Embarque:|" & txtEmbarque.Text.Trim)
        End If

        LisFiltros.Add(itemSortedList)

        Dim ListTitulo As New List(Of String)
        ListTitulo.Add("Seguimiento Local")

        Dim ListNameCombDuplicado As New List(Of String)
        Dim CombCol As String
        ''INFORMACIÓN GENERAL
        ' CombCol = "PAIS:PAIS/1|PUERTO:PAIS,PUERTO/1|FORWARDER:PAIS,PUERTO,FORWARDER/1|TIPO_CARGA:PAIS,PUERTO,FORWARDER,TIPO_CARGA/1|MERCADERIA:PAIS,PUERTO,FORWARDER,TIPO_CARGA,MERCADERIA/1"
        CombCol = "NORSCI:NORSCI/1|FORSCI:NORSCI,FORSCI/0|TCMLCL_ORIGEN:NORSCI,TCMLCL_ORIGEN/0|TDREN2:NORSCI,TDREN2/0"
        CombCol = CombCol & "|TDRCOR:NORSCI,TDRCOR/0|TCMLCL_DESTINO:NORSCI,TCMLCL_DESTINO/0|NDOCEM:NORSCI,NDOCEM/0"
        CombCol = CombCol & "|REFDO1:NORSCI,REFDO1/0|NREFCL:NORSCI,NREFCL/0|TPRVCL:NORSCI,TPRVCL/0|TNMMDT:NORSCI,TNMMDT/0"
        CombCol = CombCol & "|TNMCIN:NORSCI,TNMCIN/0|REFNAV_DESC:NORSCI,REFNAV_DESC/0|TDSDES:NORSCI,TDSDES/0|QVOLMR:NORSCI,QVOLMR/0|TTRMAL:NORSCI,TTRMAL/0|TNMAGC:NORSCI,TNMAGC/0"
        CombCol = CombCol & "|QPSOAR:NORSCI,QPSOAR/0|SESTRG:NORSCI,SESTRG/0|OBSERVACION:NORSCI,OBSERVACION/0|TRECOR:NORSCI,TRECOR/0|156_FRE_CHK:NORSCI,156_FRE_CHK/0"
        CombCol = CombCol & "|159_FRE_CHK:NORSCI,159_FRE_CHK/0|157_FRE_CHK:NORSCI,157_FRE_CHK/0|162_FRE_CHK:NORSCI,162_FRE_CHK/0|160_FRE_CHK:NORSCI,160_FRE_CHK/0"
        CombCol = CombCol & "|161_FRE_CHK:NORSCI,161_FRE_CHK/0|158_FRE_CHK:NORSCI,158_FRE_CHK/0|FINGAL:NORSCI,FINGAL/0|FSLDAL:NORSCI,FSLDAL/0"
        CombCol = CombCol & "|FACTOR_SERV:NORSCI,FACTOR_SERV/0|TARIFA:NORSCI,TARIFA/0|VAL_SERV:NORSCI,VAL_SERV/0|VALOROC_ITEM:NORSCI,VALOROC_ITEM/0"
        CombCol = CombCol & "|TSGNMN:NORSCI,TSGNMN/0|IVLSRV:NORSCI,IVLSRV/0|NUMDCR:NORSCI,NUMDCR/0|NGRPRV:NORSCI,NGRPRV/0|NORCML:NORSCI,NORCML/0|TOBERV:NORSCI,TOBERV/0"
        ListNameCombDuplicado.Add(CombCol)

        Dim ListColNFilas As New List(Of String)
        ListColNFilas.Add("OBSERVACION")

        Dim FilaAgrupacion As New List(Of String)
        FilaAgrupacion.Add("NORSCI")


        NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, ListColNFilas, LisFiltros, 0, ListNameCombDuplicado, Nothing, FilaAgrupacion)



    End Sub



   

    Private Sub CargarLocalidadOD()
        Dim objDt As List(Of beLocalidad)
        Dim obj_Logica_Localidad As New Negocio.clsLocalidad
        objDt = obj_Logica_Localidad.Listar_Localidades()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción "
        oListColum.Add(2, oColumnas)

        Me.cboLugarorigen.DataSource = objDt
        Me.cboLugarorigen.ListColumnas = oListColum
        Me.cboLugarorigen.Cargas()
        Me.cboLugarorigen.DispleyMember = "TCMLCL"
        Me.cboLugarorigen.ValueMember = "CLCLD"

        Dim oListColum2 As New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CLCLD"
        oColumnas.DataPropertyName = "CLCLD"
        oColumnas.HeaderText = "Código"
        oListColum2.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMLCL"
        oColumnas.DataPropertyName = "TCMLCL"
        oColumnas.HeaderText = "Descripción "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum2.Add(2, oColumnas)

        Me.cboLugarDestino.DataSource = objDt
        Me.cboLugarDestino.ListColumnas = oListColum2
        Me.cboLugarDestino.Cargas()
        Me.cboLugarDestino.DispleyMember = "TCMLCL"
        Me.cboLugarDestino.ValueMember = "CLCLD"

    End Sub
    Private Sub CargarCombos()

        'Cargar Cliente
        cmbCliente.pAccesoPorUsuario = True
        cmbCliente.pRequerido = True
        cmbCliente.pUsuario = HelpUtil.UserName

        'Cargar Combo Tipo operacion embarque
        Dim oclsEstado As New clsEstado()
        Dim oclsDespachoNacional As New clsDespachoNacional

        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim dr As DataRow
        dr = dtTipoOperacion.NewRow
        dr("COD") = "0"
        dr("TEX") = "TODOS"

        dtTipoOperacion.Rows.InsertAt(dr, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        cboTipoOperacion.SelectedValue = "NA"
        cboTipoOperacion.Enabled = False

        'Cargar Combo Estado aduanero
        cmbEstado.DataSource = oclsEstado.Estado_Aduanero
        cmbEstado.ValueMember = "COD"
        cmbEstado.DisplayMember = "TEX"
        cmbEstado.SelectedValue = "A"

    End Sub

    Private Sub KryptonCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonCheckBox1.CheckedChanged
        dtpInicio.Enabled = Not KryptonCheckBox1.Checked
        dtpFin.Enabled = Not KryptonCheckBox1.Checked
        KryptonComboBox1.ComboBox.Enabled = KryptonCheckBox1.Checked
        DateTimePicker1.Enabled = KryptonCheckBox1.Checked
        DateTimePicker2.Enabled = KryptonCheckBox1.Checked
    End Sub

    Private Sub cmbCliente_TextChanged() Handles cmbCliente.TextChanged

        Dim PNCCLNT As Decimal = 0
        If Me.cmbCliente.pCodigo > 0 Then
            PNCCLNT = Me.cmbCliente.pCodigo
        Else
            Exit Sub
        End If
        Try
            Dim CCMPN As String = _pCCMPN
            Dim CDVSN As String = cmbDivision.Division
            Dim oclCheckPoint As New clsCheckPoint
            Dim dtCheckPoint As New DataTable
            dtCheckPoint = oclCheckPoint.Lista_CheckPoint_X_Cliente(PNCCLNT, CCMPN, CDVSN, "L", "A")
            KryptonComboBox1.DataSource = dtCheckPoint
            KryptonComboBox1.DisplayMember = "TCOLUM"
            KryptonComboBox1.ValueMember = "NESTDO"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbCompania_Seleccionar()
        Try
            cmbDivision.Usuario = HelpUtil.UserName
            cmbDivision.Compania = _pCCMPN
            If _pCCMPN = "EZ" Then
                cmbDivision.DivisionDefault = "S"
                cmbDivision.pHabilitado = False
            End If
            cmbDivision.pActualizar()
            cmbDivision_Seleccionar(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            cmbPlanta.Usuario = HelpUtil.UserName
            cmbPlanta.CodigoCompania = cmbDivision.Compania
            cmbPlanta.CodigoDivision = cmbDivision.Division
            cmbPlanta.PlantaDefault = 1
            cmbPlanta.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class

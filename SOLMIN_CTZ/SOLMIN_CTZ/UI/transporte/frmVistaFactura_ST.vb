
Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmVistaFactura_ST
    'Private dblConsistencia As Double
    'Private strTipoMoneda As String
    Private strDivision As String
    Private strCodDiv As String
    Private strCodCom As String
    Private strCodPlanta As String
    Private strMoneda As String
    Private dblCliente As Double
    Private dblTipoCambio As Double
    Private intZonaFact As Int32 = 0
    Private strOrgVenta As String = ""
    Private oFacturaNeg As New Factura_Transporte_BLL
    'Private oDtDocumento As DataTable
    Private bolBuscar As Boolean
    Private lstrConsistenciaOperacion As String
    Private oDtCabFactura As DataTable
    Private oDtDetFactura As DataTable
    Private oDtDetFacturaDetallada As DataTable
    Private dblNumFacImp As Int64
    Private strCompFacImp As String
    Private strTipoDocFacImp As String
    Private lintCountFactura As Integer
    Private lboolEstado As Int32 = 0
    Private lintImprimir As Int32 = 0
    Private ldtpFechaFactura As Date = Now
    Private lstrIGV As String = ""
    Private lhashIGV As New Hashtable
    Private lintFATNSR As Int64 = 0
    Private lhashItemFact As New Hashtable
    Private TipoOperacion As Int32 = 0
    Private intFlagFact As Int32 = 0
    Private dblDocumentoOrigen As Double = 0
    Private dblFechaDocumentoOrigen As Double = 0
    Private dblTipoDocumentoOrigen As Double = 0
    Public WriteOnly Property pEstado() As Int32
        Set(ByVal value As Int32)
            lboolEstado = value
        End Set
    End Property

    Public WriteOnly Property pTipoOperacion() As Int32
        Set(ByVal value As Int32)
            TipoOperacion = value
        End Set
    End Property

    Public WriteOnly Property FlagFactura() As Int32
        Set(ByVal value As Int32)
            intFlagFact = value
        End Set
    End Property
    Public WriteOnly Property DocumentoOrigen() As Double
        Set(ByVal value As Double)
            dblDocumentoOrigen = value
        End Set
    End Property
    Public WriteOnly Property FechaDocumentoOrigen() As Double
        Set(ByVal value As Double)
            dblFechaDocumentoOrigen = value
        End Set
    End Property
    Public WriteOnly Property TipoDocumentoOrigen() As Double
        Set(ByVal value As Double)
            dblTipoDocumentoOrigen = value
        End Set
    End Property

    Sub New(ByVal pstrConsistencia As String, ByVal pstrDivision As String, ByVal pstrCodDiv As String, ByVal pstrCodCom As String, ByVal pdblCliente As Double, ByVal pstrCodPlanta As String, ByVal pstrMoneda As String, ByVal pintZonaFacturacion As Int32, ByVal pstrOrgVenta As String, ByVal FechaFactura As Date, ByVal FechaAtencion As Int64)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        strDivision = pstrDivision
        strCodDiv = pstrCodDiv
        strCodCom = pstrCodCom
        dblCliente = pdblCliente
        strCodPlanta = pstrCodPlanta
        strMoneda = pstrMoneda
        oFacturaNeg.Tipomoneda = pstrMoneda
        lstrConsistenciaOperacion = pstrConsistencia
        intZonaFact = pintZonaFacturacion
        strOrgVenta = pstrOrgVenta
        ldtpFechaFactura = FechaFactura
        lintFATNSR = FechaAtencion
        bolBuscar = False
    End Sub

    Private Sub frmVistaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oDt As DataTable
        Dim oFiltro As New Hashtable
        lintCountFactura = 0
        oFiltro.Add("PNCMNDA1", "100")
        oFiltro.Add("PNFCMBO", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PSCCMPN", strCodCom)

        oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
        If oDt.Rows.Count > 0 Then
            dblTipoCambio = oDt.Rows(0).Item("IVNTA").ToString.Trim
            oFacturaNeg.TipoCambio = dblTipoCambio
            Me.txtTipoCambio.Text = dblTipoCambio

            oFiltro.Add("PSCDVSN", strCodDiv)
            oFiltro.Add("PNCCLNT", dblCliente)
            oFiltro.Add("PSCUSCRT", ConfigurationWizard.UserName)
            oFacturaNeg.Llenar_Documentos(oFiltro)
            Me.Llenar_Combos()
            txtDivision.Text = strDivision
        Else
            HelpClass.MsgBox("No se puede generar la factura por no existir Tipo de cambio para el día " & Format(Now, "dd/MM/yyyy"))
            Me.Close()
        End If
        'Crear_Grilla_Consistencias()
    End Sub

    Private Sub Llenar_Combos()
        ' Dim oFacturaNeg As New Factura_Transporte_BLL
        Dim oFiltro As New Hashtable
        Dim oDt As DataTable

        bolBuscar = False
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCDVSN", strCodDiv)
        oFiltro.Add("PSCUSCRT", ConfigurationWizard.UserName)
        oDt = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
        Me.cmbGiro.DataSource = oDt
        cmbGiro.ValueMember = "CGRONG"
        bolBuscar = True
        cmbGiro.DisplayMember = "TCMGRN"
        If oDt.Rows.Count = 1 Then
            Me.cmbGiro.Enabled = False
        End If
        If oDt.Rows.Count <= 0 Then
            Me.btnGenerar.Visible = False
        Else
            Me.btnGenerar.Visible = True
        End If

        oDt = New DataTable
        oFiltro.Add("PNCCLNFC", dblCliente)
        oDt = oFacturaNeg.Lista_Planta_Cliente(oFiltro)
        Me.cmbPlantaCliente.DataSource = oDt
        cmbPlantaCliente.ValueMember = "CPLNCL"
        cmbPlantaCliente.DisplayMember = "TDRCPL"
        'If oDt.Rows.Count = 1 Then
        cmbPlantaCliente.SelectedValue = 1 'CType(strCodPlanta, Double)
        Me.cmbPlantaCliente.Enabled = False
        Select Case oFacturaNeg.oTipoDocumento
            Case 1
                Me.lblTipoDocumento.Text = "FACTURA"
            Case 6
                Me.lblTipoDocumento.Text = "PARTE"
            Case 7
                Me.lblTipoDocumento.Text = "BOLETA DE VENTA"
        End Select
        'End If
    End Sub

    Private Sub cmbGiro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGiro.SelectedIndexChanged
        Actualizar_Punto_Venta()
    End Sub

    Private Sub Actualizar_Punto_Venta()
        Me.Cursor = Cursors.WaitCursor
        If bolBuscar Then
            'Dim oFacturaNeg As New Factura_Transporte_BLL
            Dim oFiltro As New Hashtable

            oFiltro.Add("CGRONG", cmbGiro.SelectedValue)
            Me.cmbPtoVenta.DataSource = oFacturaNeg.Lista_Punto_Venta(oFiltro)
            cmbPtoVenta.DisplayMember = "TOBSAD"
            cmbPtoVenta.ValueMember = "NPTOVT"
            If Me.cmbPtoVenta.Items.Count <= 0 Then
                Me.btnGenerar.Visible = False
            Else
                Me.btnGenerar.Visible = True
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click, btnCancelarImpr.Click
        Me.Limpiar_Datos_Factura()
        Me.KryptonHeaderGroup1.Enabled = True
        Me.btnImprimirfactura.Visible = False
        Me.btnCancelarImpr.Visible = False
        If Me.lblNumFact.Text = "" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.lblNumFact.Text = ""
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Me.Cursor = Cursors.WaitCursor

        Datos_Generales_Factura()
        Generar_Factura()

        Dim objHash As New Hashtable
        objHash.Add("CCMPN", strCodCom.PadLeft(2, "0"))
        objHash.Add("CDVSN", strCodDiv)
        objHash.Add("CRGVTA", strOrgVenta.PadLeft(3, "0"))
        objHash.Add("CCLNT", dblCliente.ToString.PadLeft(6, "0"))
        Dim strEstado As String = ""
        Dim strResultado As String = oFacturaNeg.Validar_Cliente_SAP(objHash, strEstado)
        Select Case strEstado
            Case ""
                HelpClass.MsgBox("ERROR : Ocurrio un Problema de Conexión", MessageBoxIcon.Information)
                Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            Case "B", "C", "D"
                HelpClass.MsgBox("ADVERTENCIA : " & "Cliente " & strResultado, MessageBoxIcon.Information)
                Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Datos_Generales_Factura()
        Dim oDtNew As DataTable
        Dim oFiltro As New Hashtable
        Dim strCliente As String = ""
        oFiltro.Add("PNCCLNFC", dblCliente)
        oFiltro.Add("PSCCMPN", strCodCom)
        oDtNew = oFacturaNeg.Lista_Datos_Cliente(oFiltro)
        strCliente = "Sres.:".PadRight(130, " ") & "Código:    " & oDtNew.Rows(0).Item("CCLNT").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TCMPCL").ToString.Trim & ("" & oDtNew.Rows(0).Item("TCMCL1")).ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TDRCOR").ToString.Trim & "    " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & IIf(oDtNew.Rows(0).Item("NRUC").ToString.Trim = "0", "", oDtNew.Rows(0).Item("NRUC").ToString.Trim) & " ".PadRight(90, " ") & "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(ldtpFechaFactura, "dd/MM/yyyy")
        Me.txtCliente.Text = strCliente
    End Sub

    Private Sub Generar_Factura()
        Dim intCant As Integer
        Dim strOperacionSnPeso As String = ""
        intCant = IIf(oFacturaNeg.oTipoDocumento.ToString.Equals("7"), 1, Obtener_Cantidad_Facturas(strOperacionSnPeso))
        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant, lboolEstado)
            If Me.Tag = 3 Then 'lOTE
                Mostrar_Factura_Lote()
            Else
                Mostrar_Factura(intCant)
            End If
            KryptonHeaderGroup1.Enabled = False
            Me.btnImprimirfactura.Visible = True
            Me.btnCancelarImpr.Visible = True
            'If Me.lboolEstado <> 0 Then
            '  Dim strReferencia As String
            '  For intIndice As Integer = 0 To intCant - 1
            '    strReferencia = ""
            '    strReferencia = strReferencia & "POR SERVICIOS LOGISTICOS DE MERCADERIA VARIAS DE " & vbCrLf
            '              strReferencia = strReferencia & "FLETE. TRANSPORTE TERRESTRE DEL "
            '    CType(Me.tabFactura.TabPages(intIndice).Controls(0), ctrlFactura).Referencia2 = strReferencia
            '  Next
            'End If
        ElseIf intCant = -1 Then
            Me.btnCancelarImpr.Visible = False
            Me.btnImprimirfactura.Visible = False
            HelpClass.MsgBox("No se Registró el Peso Volumen de las Operaciones : " & strOperacionSnPeso.Trim)
        Else
            Me.btnCancelarImpr.Visible = False
            Me.btnImprimirfactura.Visible = False
            HelpClass.MsgBox("No existen Facturas para crear")
        End If
    End Sub
    Private Sub Mostrar_Factura_Lote()
        Dim octrlFact As ctrlFactura_ST
        Dim X As Integer = 0
        Dim dt_LoteFactura As DataTable = oFacturaNeg.ObtieneLote()
        Dim drLoteSelect() As DataRow
        Dim tbFactura_Lote As TabControl
        Dim drItem As DataRow
        Dim dr As DataRow
        Dim lint_contador As Integer = 0
        Dim sb As System.Text.StringBuilder

        tabFactura.TabPages.RemoveAt(0)
        For lint_row As Integer = 0 To dt_LoteFactura.Rows.Count - 1
            drItem = dt_LoteFactura.Rows(lint_row)
            Me.tabFactura.TabPages.Add(lint_contador, "LOTE : " & drItem.Item("LOTE").ToString())
            Me.tabFactura.TabPages.Item(lint_contador).UseVisualStyleBackColor = True

            tbFactura_Lote = New TabControl()
            tbFactura_Lote.Dock = DockStyle.Fill
            tbFactura_Lote.Name = "TAB_" & lint_row.ToString
            drLoteSelect = dt_LoteFactura.Select("LOTE= '" & drItem.Item("LOTE") & "' ")
            'tbFactura_Lote.TabPages(lint_contador).Tag = drLoteSelect(0)("NDCCTC").ToString()
            'Obtiene las Facturas Por Lote
            For i As Integer = 0 To drLoteSelect.Length - 1
                dr = drLoteSelect(i)
                tbFactura_Lote.TabPages.Add(i, "")
                tbFactura_Lote.TabPages(i).Tag = dr("NDCCTC").ToString
                tbFactura_Lote.TabPages.Item(i).UseVisualStyleBackColor = True
                tbFactura_Lote.TabPages(i).Text = Me.lblTipoDocumento.Text & " " & dr("NDCCTC").ToString
                octrlFact = New ctrlFactura_ST(oDtDetFactura, dr("NDCCTC").ToString, strMoneda, lhashIGV(Integer.Parse(dr("NDCCTC").ToString)).ToString.Trim, 0, oFacturaNeg.oTipoDocumento)
                octrlFact.NumFactura = "N°          "
                sb = New System.Text.StringBuilder()
                sb.Append("RUTA: ")
                sb.Append(oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom))
                sb.AppendLine()
                sb.Append("LOTE : ")
                sb.Append(drItem.Item("LOTE").ToString())
                octrlFact.Referencia1 = sb.ToString ' "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom) & Chr(10) & "LOTE : " & drItem.Item("LOTE").ToString()
                tbFactura_Lote.TabPages(i).Controls.Add(octrlFact)
            Next
            'Añade el nuevo Tab al Tab de Principal
            Me.tabFactura.TabPages(lint_contador).Controls.Add(tbFactura_Lote)
            lint_row = lint_row + drLoteSelect.Length - 1
            lint_contador = lint_contador + 1
        Next
    End Sub

    Private Sub Mostrar_Factura(ByVal intCant As Integer)
        Dim octrlFact As ctrlFactura_ST
        Dim X As Integer = 0

        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True
        Next X

        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = Me.lblTipoDocumento.Text
            Select Case Me.Tag
                Case 0
                    octrlFact = New ctrlFactura_ST(oDtDetFactura, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 0, oFacturaNeg.oTipoDocumento)
                    octrlFact.NumFactura = "N°          "
                    octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom)
                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
                Case 1
                    oDtDetFacturaDetallada = Mostrar_Factura_Consolidada(lint_Contador + 1, oDtDetFactura.Copy)
                    octrlFact = New ctrlFactura_ST(oDtDetFacturaDetallada, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 1, oFacturaNeg.oTipoDocumento)
                    octrlFact.NumFactura = "N°          "
                    octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom)
                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
                    lhashItemFact.Add(lint_Contador + 1, octrlFact.dtgDetalle.RowCount)
                Case 2
                    oDtDetFacturaDetallada = Mostrar_Factura_Detallada(lint_Contador + 1, oDtDetFactura.Copy)
                    octrlFact = New ctrlFactura_ST(oDtDetFacturaDetallada, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 1, oFacturaNeg.oTipoDocumento)
                    octrlFact.NumFactura = "N°          "
                    octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom)
                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
                    lhashItemFact.Add(lint_Contador + 1, octrlFact.dtgDetalle.RowCount)
            End Select
        Next
    End Sub

    Private Function Mostrar_Factura_Detallada(ByVal lintNumeroFactura As Int32, ByVal objData As DataTable) As DataTable
        Dim objDataReturn As DataTable
        Dim pobjFiltro As New Hashtable
        pobjFiltro.Add("PSNOPRCN", lstrConsistenciaOperacion)
        pobjFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
        pobjFiltro.Add("PSCCMPN", strCodCom)
        pobjFiltro.Add("PSCDVSN", strCodDiv)
        objDataReturn = oFacturaNeg.Mostrar_Factura_Detallada(pobjFiltro, lintNumeroFactura, objData)
        Return objDataReturn
    End Function

    Private Function Mostrar_Factura_Consolidada(ByVal lintNumeroFactura As Int32, ByVal objData As DataTable) As DataTable
        Dim objDataReturn As DataTable
        Dim pobjFiltro As New Hashtable
        pobjFiltro.Add("PSNOPRCN", lstrConsistenciaOperacion)
        pobjFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
        pobjFiltro.Add("PSCCMPN", strCodCom)
        pobjFiltro.Add("PSCDVSN", strCodDiv)
        objDataReturn = oFacturaNeg.Mostrar_Factura_Consolidada(pobjFiltro, lintNumeroFactura, objData)
        Return objDataReturn
    End Function

    Private Function Obtener_Cantidad_Facturas(ByRef strOperacionSnPeso As String) As Integer
        Dim oFiltro As New Hashtable
        oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCMNDA", strMoneda)
        oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PNFATNSR", lintFATNSR)
        oFiltro.Add("PSOPERACIONES", strOperacionSnPeso)
        Dim returnCant As Integer
        If TipoOperacion = 0 Then
            If Me.Tag = 3 Then

                Dim frmLote As New frmlotefactura
                frmLote.odtListLote = oFacturaNeg.Traer_Facturas_Lote(oFiltro).Copy
                frmLote.ShowDialog()
                returnCant = oFacturaNeg.Cantidad_Facturas_Lote(oFiltro, frmLote.odtListLote)
                strOperacionSnPeso = oFiltro("PSOPERACIONES")

            Else
                returnCant = oFacturaNeg.Cantidad_Facturas(oFiltro)  ', lboolEstado)
            End If
        Else
            returnCant = oFacturaNeg.Cantidad_ReFacturas(oFiltro)
        End If
        Return returnCant
    End Function

    Private Sub Generar_Cabecera(ByVal pintCant As Double)
        Dim oFiltro As New Hashtable

        oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
        oFiltro.Add("CANTFACT", pintCant)
        oFiltro.Add("PNCCLNFC", dblCliente)
        oFiltro.Add("PSCDVSN", strCodDiv)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PNTPCAM", dblTipoCambio)
        oFiltro.Add("PNCPLDVN", strCodPlanta)
        oFiltro.Add("PNCMNDA1", strMoneda)
        oFiltro.Add("PNCZNFCC", intZonaFact)
        oFiltro.Add("PSCRGVTA", strOrgVenta)
        oFiltro.Add("PDFECFAC", ldtpFechaFactura)
        oFiltro.Add("PNFATNSR", lintFATNSR)
        oFiltro.Add("PNNDCMOR", dblDocumentoOrigen)
        oFiltro.Add("PNFDCMOR", dblFechaDocumentoOrigen)
        oFiltro.Add("PNCTPDCO", dblTipoDocumentoOrigen)
        oFacturaNeg.PuntoVenta = Me.cmbPtoVenta.SelectedValue
        oFacturaNeg.GiroNegocio = Me.cmbGiro.SelectedValue
        oFacturaNeg.PlantaCliente = Me.cmbPlantaCliente.SelectedValue
        oDtCabFactura = oFacturaNeg.Lista_Cabecera_Factura(oFiltro)
        Me.dtgCabeceraFactura.DataSource = oDtCabFactura
    End Sub

    Private Sub Generar_Detalles(ByVal pintCant As Integer, ByVal lboolEstado As Integer)
        Dim oFiltro As New Hashtable
        oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
        oFiltro.Add("CANTFACT", pintCant)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCMNDA", strMoneda)
        oFiltro.Add("PSSTATUS", lboolEstado)
        oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PNFATNSR", lintFATNSR)
        If TipoOperacion = 0 Then
            If Me.Tag = 3 Then
                oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura_Lote(oFiltro, lhashIGV)
            Else
                oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura2(oFiltro, lhashIGV)
            End If
        Else
            oDtDetFactura = oFacturaNeg.Lista_Detalle_ReFacturas(oFiltro, lhashIGV)
        End If
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub

    Private Sub Grabar_Factura(ByVal pintFact As Integer)
        Dim strNumFact As Int64 = 0
        Dim objFiltro As New Hashtable 'Filtro
        Dim intValor As Int32 = 0
        Try
            Cursor = Cursors.WaitCursor
            lstrIGV = lhashIGV(pintFact).ToString.Trim

            oFacturaNeg.Grabar_Factura(pintFact, oDtCabFactura, oDtDetFactura, strNumFact, intFlagFact)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 1, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura_ST).Referencia1)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 2, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura_ST).Referencia2)
            'If TipoOperacion = 0 Then
            intValor = Registrar_Orden_Interna_Factura(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact, CType(oDtCabFactura.Rows(0).Item("FDCCTC").ToString.Trim, Int64))
            'End If
            'Me.TabPage1.Text = "Factura N°" & strNumFact
            Me.tabFactura.TabPages(pintFact - 1).Text = "Factura N°" & strNumFact
            CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura_ST).NumFactura = "N° " & strNumFact
            lblNumFact.Text = "N° " & strNumFact
        Catch ex As Exception
            Cursor = Cursors.Default
            strNumFact = 0
            HelpClass.MsgBox("Error al grabar la factura " & vbCrLf & ex.Message)
        End Try
        If strNumFact <> 0 Then
            Cursor = Cursors.Default
            HelpClass.MsgBox("Se grabó correctamente la Factura N° " & strNumFact)
            Cursor = Cursors.WaitCursor
            If lintImprimir = 1 Then
                Imprime_Factura(strNumFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim)
            End If
            Cursor = Cursors.Default
            'habilitar en produccion 
            Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
            If intValor = 1 And TipoOperacion = 0 Then
                Cerrar_Orden_Interna(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact)
                'Me.SendProcess(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact)
                'Shell(Application.StartupPath & "/external/SOLMIN_ST_SAP_SYNC.exe " & oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim & " " & oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim & " " & strNumFact, AppWinStyle.Hide)
            End If
            If MsgBox("Desea Imprimir Sustento?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                Dim obj_Logica As New Factura_Transporte_BLL
                Dim objPrintForm As New PrintForm
                Dim objDsSustento As New DataSet
                Dim objDtSustento As New DataTable
                Dim objetoRepFact As New rptSustento_Factura
                Dim objetoRepBole As New rptSustento_Boleta
                Dim objParametroSustento As New Hashtable
                Try
                    If strNumFact.ToString.Trim.Length = 0 Then Exit Sub
                    objParametroSustento.Add("PNCTPODC", oDtCabFactura.Rows(0).Item("CTPODC"))
                    objParametroSustento.Add("PNNDCMFC", strNumFact.ToString)
                    objParametroSustento.Add("PSCCMPN", oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim)
                    objParametroSustento.Add("PSCDVSN", strCodDiv)
                    objDtSustento = HelpClass.GetDataSetNative(obj_Logica.Listar_Sustento_Factura(objParametroSustento))
                    objDtSustento.TableName = "RZCT01"

                    If objDtSustento.Rows.Count = 0 Then
                        HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    objDsSustento.Tables.Add(objDtSustento.Copy)

                    Select Case oDtCabFactura.Rows(0).Item("CTPODC")
                        Case 1
                            objetoRepFact.SetDataSource(objDsSustento)

                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "FACTURA N° " & strNumFact.ToString
                            objPrintForm.ShowForm(objetoRepFact, Me)
                        Case 7
                            objetoRepBole.SetDataSource(objDsSustento)

                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "BOLETA DE VENTA N° " & strNumFact.ToString
                            objPrintForm.ShowForm(objetoRepBole, Me)
                    End Select

                Catch : End Try
            End If
        End If
    End Sub

    Private Sub Grabar_Factura_Lote(ByVal pintFact As Integer, ByRef tabFacturaTemp As TabPage)
        Dim strNumFact As Int64 = 0
        Dim objFiltro As New Hashtable 'Filtro
        Dim intValor As Int32 = 0
        Dim ctrlVisorFactura As ctrlFactura_ST = CType(tabFacturaTemp.Controls(0), ctrlFactura_ST)
        Try
            Cursor = Cursors.WaitCursor
            lstrIGV = lhashIGV(pintFact).ToString.Trim
            oFacturaNeg.Grabar_Factura_Lote(pintFact, oDtCabFactura, oDtDetFactura, strNumFact, intFlagFact)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 1, oDtCabFactura, ctrlVisorFactura.Referencia1)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 2, oDtCabFactura, ctrlVisorFactura.Referencia2)
            'If TipoOperacion = 0 Then
            intValor = Registrar_Orden_Interna_Factura_Lote(pintFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact, CType(oDtCabFactura.Rows(0).Item("FDCCTC").ToString.Trim, Int64))
            'End If
            'Me.TabPage1.Text = "Factura N°" & strNumFact
            tabFacturaTemp.Text = "Factura N°" & strNumFact
            ctrlVisorFactura.NumFactura = "N° " & strNumFact
            lblNumFact.Text = "N° " & strNumFact
        Catch ex As Exception
            Cursor = Cursors.Default
            strNumFact = 0
            HelpClass.MsgBox("Error al grabar la factura " & vbCrLf & ex.Message)
        End Try
        If strNumFact <> 0 Then
            Cursor = Cursors.Default
            HelpClass.MsgBox("Se grabó correctamente la Factura N° " & strNumFact)
            Cursor = Cursors.WaitCursor
            If lintImprimir = 1 Then
                Imprime_Factura(strNumFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim)
            End If
            Cursor = Cursors.Default
            'habilitar en produccion 
            Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
            If intValor = 1 And TipoOperacion = 0 Then
                Cerrar_Orden_Interna(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact)
                'Me.SendProcess(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact)
                'Shell(Application.StartupPath & "/external/SOLMIN_ST_SAP_SYNC.exe " & oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim & " " & oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim & " " & strNumFact, AppWinStyle.Hide)
            End If
            If MsgBox("Desea Imprimir Sustento?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                'Dim obj_Logica As New Factura_Transporte_BLL
                Dim objPrintForm As New PrintForm
                Dim objDsSustento As New DataSet
                Dim objDtSustento As New DataTable
                Dim objetoRepFact As New rptSustento_Factura
                Dim objetoRepBole As New rptSustento_Boleta
                Dim objParametroSustento As New Hashtable
                Try
                    If strNumFact.ToString.Trim.Length = 0 Then Exit Sub
                    objParametroSustento.Add("PNCTPODC", oDtCabFactura.Rows(0).Item("CTPODC"))
                    objParametroSustento.Add("PNNDCMFC", strNumFact.ToString)
                    objParametroSustento.Add("PSCCMPN", oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim)
                    objParametroSustento.Add("PSCDVSN", strCodDiv)

                    Dim drSelect As DataRow()
                    drSelect = oFacturaNeg.ObtieneServicios_Factura(pintFact)

                    objDtSustento = HelpClass.GetDataSetNative(oFacturaNeg.Listar_Sustento_Factura_Lote(objParametroSustento, drSelect))
                    objDtSustento.TableName = "RZCT01"

                    If objDtSustento.Rows.Count = 0 Then
                        HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    objDsSustento.Tables.Add(objDtSustento.Copy)

                    Select Case oDtCabFactura.Rows(0).Item("CTPODC")
                        Case 1
                            objetoRepFact.SetDataSource(objDsSustento)

                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "FACTURA N° " & strNumFact.ToString
                            objPrintForm.ShowForm(objetoRepFact, Me)
                        Case 7
                            objetoRepBole.SetDataSource(objDsSustento)

                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
                            CType(objetoRepBole.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "BOLETA DE VENTA N° " & strNumFact.ToString
                            objPrintForm.ShowForm(objetoRepBole, Me)
                    End Select

                Catch : End Try
            End If
        End If
    End Sub

    Private Sub Cerrar_Orden_Interna(ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long)
        Dim oFiltro As Hashtable
        Dim oValor As Int32 = 0
        Try
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PSCTPODC", pstrTipoDoc)
            oFiltro.Add("PSNDCCTC", pstrNumFact)
            If oFacturaNeg.Cerrar_Orden_Interna_Factura(oFiltro) = 0 Then
                HelpClass.MsgBox("Error al cerrar Orden / Interna Factura ", MessageBoxIcon.Information)
            End If
        Catch : End Try

    End Sub

    Private Sub Enviar_Factura_SAP(ByVal pstrCompania As String, ByVal pstrTipoDoc As String, ByVal pstrNumFact As String)
        Dim oFiltro As Hashtable
        Dim oDt As DataTable
        Dim strNumSAP As String = ""

        Try
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania.PadLeft(2, "0"))
            oFiltro.Add("PSCTPODC", pstrTipoDoc.PadLeft(3, "0"))
            oFiltro.Add("PSNDCCTC", pstrNumFact.PadLeft(10, "0"))
            oFacturaNeg.Enviar_Documento_SAP(oFiltro)
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PNCTPODC", pstrTipoDoc)
            oFiltro.Add("PNNDCCTC", pstrNumFact)
            oDt = oFacturaNeg.Comprobar_Envio_Documento_SAP(oFiltro)
            If oDt.Rows.Count > 0 Then
                strNumSAP = oDt.Rows(0).Item("NDCMSP").ToString.Trim
                Cursor = Cursors.Default
                HelpClass.MsgBox("Se envió correctamente al SAP con N° de Documento SAP " & vbCrLf & strNumSAP)
            End If
        Catch ex As Exception
            HelpClass.MsgBox("Error al enviar documento al SAP " & ex.Message)
        End Try
    End Sub

    Private Function Registrar_Orden_Interna_Factura(ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long, ByVal pintFecFac As Int64) As Int32
        Dim oFiltro As Hashtable
        Dim oValor As Int32 = 0
        Try
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PSCTPODC", pstrTipoDoc)
            oFiltro.Add("PSNDCCTC", pstrNumFact)
            oFiltro.Add("PNFECFAC", pintFecFac)
            If Me.strMoneda.Trim = "DOL" Then
                oFiltro.Add("PNMONEDA", 100)
            Else
                oFiltro.Add("PNMONEDA", 1)
            End If

            If oFacturaNeg.Registrar_Orden_Interna_Factura(oFiltro) = 0 Then
                HelpClass.MsgBox("Error al enviar Orden / Interna Factura ", MessageBoxIcon.Information)
                oValor = 0
            Else
                oValor = 1
            End If

        Catch : End Try
        Return oValor
    End Function


    Private Function Registrar_Orden_Interna_Factura_Lote(ByVal pintFact As Integer, ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long, ByVal pintFecFac As Int64) As Int32
        Dim oFiltro As Hashtable
        Dim oValor As Int32 = 0
        Try
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PSCTPODC", pstrTipoDoc)
            oFiltro.Add("PSNDCCTC", pstrNumFact)


            'Crea los Parametros para la Temporal
            Dim drSelect As DataRow() = Nothing
            Dim sbNOPRCN As New System.Text.StringBuilder()
            Dim sbNGUIRM As New System.Text.StringBuilder()
            Dim sbCSRVC As New System.Text.StringBuilder()
            Dim sbISRVGU As New System.Text.StringBuilder()

            drSelect = oFacturaNeg.ObtieneServicios_Factura(pintFact)
            For row As Integer = 0 To drSelect.Length - 1
                sbNOPRCN.Append(drSelect(row).Item("NOPRCN"))
                sbNGUIRM.Append(drSelect(row).Item("NGUIRM"))
                sbCSRVC.Append(drSelect(row).Item("CRBCTC"))
                sbISRVGU.Append(drSelect(row).Item("ISRVGU"))
                If row < drSelect.Length - 1 Then
                    sbNOPRCN.Append(",")
                    sbNGUIRM.Append(",")
                    sbCSRVC.Append(",")
                    sbISRVGU.Append(",")
                End If
            Next

            oFiltro.Add("PSNOPRCN", sbNOPRCN.ToString)
            oFiltro.Add("PSNGUIRM", sbNGUIRM.ToString)
            oFiltro.Add("PSCSRVC", sbCSRVC.ToString)
            oFiltro.Add("PSISRVGU", sbISRVGU.ToString)

            oFiltro.Add("PNFECFAC", pintFecFac)
            If Me.strMoneda.Trim = "DOL" Then
                oFiltro.Add("PNMONEDA", 100)
            Else
                oFiltro.Add("PNMONEDA", 1)
            End If

            If oFacturaNeg.Registrar_Orden_Interna_Factura_Lote(oFiltro) = 0 Then
                HelpClass.MsgBox("Error al enviar Orden / Interna Factura ", MessageBoxIcon.Information)
                oValor = 0
            Else
                oValor = 1
            End If

        Catch : End Try
        Return oValor
    End Function

    Private Sub btnImprimirfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirfactura.Click
        Dim strEstado As String = ""
        Select Case Me.Tag
            Case 0, 3
                For lintIndice As Int32 = 0 To oFacturaNeg.NroItemFactura.Count - 1
                    If oFacturaNeg.NroItemFactura(lintIndice) > 15 Then
                        strEstado = strEstado & oFacturaNeg.NroItemFactura(lintIndice) & ","
                    End If
                Next
            Case 1, 2
                For lintIndice As Int32 = 0 To lhashItemFact.Count - 1
                    If lhashItemFact(lintIndice + 1) > 15 Then
                        strEstado = strEstado & oFacturaNeg.NroItemFactura(lintIndice) & ","
                    End If
                Next
        End Select

        If strEstado.Trim.Length > 0 Then
            strEstado.Trim.Substring(0, strEstado.Trim.Length - 1)
            HelpClass.MsgBox("Se excedió Nro Máximo de Item la Factura N° ", MessageBoxIcon.Warning)
            Exit Sub
        Else
            'If MessageBox.Show("Está seguro de Procesar / Imprimir la Factura (Yes) ,  Solo Procesar (No) , Cancelar Operación (Cancelar)", "Factura", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) Then
            Select Case MessageBox.Show("Desea : " & Chr(13) & _
                                        "(   Si   )-->(Guardar y Imprimir la Factura)" & Chr(13) & _
                                        "(   No   )-->(Solo Guardar)" & Chr(13) & _
                                        "(Cancelar)-->(Cancelar Proceso)", "Factura", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                Case Windows.Forms.DialogResult.Yes
                    lintImprimir = 1
                Case Windows.Forms.DialogResult.No
                    lintImprimir = 2
                Case Windows.Forms.DialogResult.Cancel
                    Exit Sub
            End Select
            'End If

            Dim tabLoteFactura As TabControl
            If Me.Tag = 3 Then 'Lote
                For intContador As Integer = 0 To Me.tabFactura.TabCount - 1
                    tabLoteFactura = CType(Me.tabFactura.TabPages(intContador).Controls(0), TabControl)
                    For i As Integer = 0 To tabLoteFactura.TabCount - 1
                        Grabar_Factura_Lote(Integer.Parse(tabLoteFactura.TabPages(i).Tag), CType(tabLoteFactura.TabPages(i), TabPage))
                        Me.lblNumFact.Tag = Integer.Parse(tabLoteFactura.TabPages(i).Tag)
                    Next
                Next
            Else
                For intContador As Integer = 1 To Me.tabFactura.TabCount
                    Grabar_Factura(intContador) 'Me.tabFactura.SelectedIndex + 1)
                    Me.lblNumFact.Tag = intContador
                Next
            End If
            Me.btnImprimirfactura.Visible = False
            Me.btnGenerar.Visible = False
            Me.lblNumFact.Tag = New Object
        End If
    End Sub

    Private Sub Limpiar_Datos_Factura()
        oFacturaNeg.Limpiar_Datos_Factura()
    End Sub

    Private Sub tabFactura_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFactura.TabIndexChanged
        lblNumFact.Text = tabFactura.SelectedTab.Text.Trim
    End Sub

    Public Sub Imprime_Factura(ByVal pdblNumFacImp As Int64, ByVal pstrCompania As String, ByVal pstrTipoDoc As String)
        Try
            Dim prn As New Printing.PrintDocument

            dblNumFacImp = pdblNumFacImp
            strCompFacImp = pstrCompania
            strTipoDocFacImp = pstrTipoDoc
            With prn
                AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
                prn.Print()
                RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
            End With
            dblNumFacImp = 0
            strCompFacImp = ""
            strTipoDocFacImp = ""
        Catch ex As Exception
            HelpClass.MsgBox("Error al imprimir la factura N° " & pdblNumFacImp & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim oDs As DataSet
        Dim oFiltro As New Hashtable
        'Dim myFont As New Font("Curier New", 8)
        Dim myFont As New Font("Nina Negrita", 8, FontStyle.Bold)
        ' Dim myFont As New Font(System.Drawing.SystemFonts.CaptionFont.Italic. , 8, FontStyle.Bold)
        Dim intCont As Integer
        Dim oDr() As DataRow
        Dim intPosLinea As Integer = 0
        Dim dblTotal As Double = 0
        Dim bolIGV As Boolean = False
        Dim strMonto As String = ""
        Dim strMoneda_Local As String = ""
        Dim strDescripcionDetalle As String = ""
        Dim bolFlete As Boolean = False
        Dim dblSubTotalSoles As Double = 0
        Dim dblTarifa As Double = 0
        Dim dblIGV As Double = 0
        oFiltro.Add("PSCCMPN", strCompFacImp)
        oFiltro.Add("PSCDVSN", strCodDiv)
        oFiltro.Add("PNCTPODC", strTipoDocFacImp)
        oFiltro.Add("PNNDCCTC", dblNumFacImp)
        oFiltro.Add("PNESTADO", Me.Tag)
        oDs = oFacturaNeg.Lista_Datos_Factura(oFiltro)

        args.Graphics.DrawString("Sres.:", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 80)
        args.Graphics.DrawString("Código:  " & oDs.Tables(0).Rows(0).Item("CCLNT").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 370, 80)
        args.Graphics.DrawString(oDs.Tables(0).Rows(0).Item("TCMPCL").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 93)
        args.Graphics.DrawString(oDs.Tables(0).Rows(0).Item("TDRCOR").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 106)
        args.Graphics.DrawString("Num.R.U.C.:  " & oDs.Tables(0).Rows(0).Item("NRUC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 119)
        args.Graphics.DrawString("Zona Cobranza:  " & oDs.Tables(0).Rows(0).Item("CZNCBD").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 350, 119)
        args.Graphics.DrawString("Fecha Doc.:  " & oDs.Tables(0).Rows(0).Item("FECHA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 132)

        args.Graphics.DrawString("Referencia:", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 180)
        args.Graphics.DrawString("No. Control : " & dblNumFacImp, New Font(myFont, FontStyle.Regular), Brushes.Black, 600, 180)

        oDr = oDs.Tables(2).Select("CTPDCC = 1")
        intPosLinea = 202
        For intCont = 0 To oDr.Length - 1
            args.Graphics.DrawString(oDr(intCont).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
            intPosLinea = intPosLinea + 13
        Next intCont

        'If Me.lboolEstado = 0 Then -------ACD
        args.Graphics.DrawString("Cod", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 270)
        args.Graphics.DrawString("Descripción", New Font(myFont, FontStyle.Regular), Brushes.Black, 75, 270)
        args.Graphics.DrawString("Cantidad", New Font(myFont, FontStyle.Regular), Brushes.Black, 365, 270)
        args.Graphics.DrawString("Importe", New Font(myFont, FontStyle.Regular), Brushes.Black, 565, 270)
        args.Graphics.DrawString("Importe", New Font(myFont, FontStyle.Regular), Brushes.Black, 745, 270)
        args.Graphics.DrawString("Rub", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 283)
        args.Graphics.DrawString("Rubro", New Font(myFont, FontStyle.Regular), Brushes.Black, 75, 283)
        args.Graphics.DrawString("Aplicada", New Font(myFont, FontStyle.Regular), Brushes.Black, 365, 283)
        args.Graphics.DrawString("Tarifa", New Font(myFont, FontStyle.Regular), Brushes.Black, 565, 283)
        args.Graphics.DrawString("Rubro", New Font(myFont, FontStyle.Regular), Brushes.Black, 745, 283)
        'Else
        '  args.Graphics.DrawString("DETALLE", New Font(myFont, FontStyle.Regular), Brushes.Black, 300, 270) -------ACD
        'End If
        args.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 15, 296)

        If Me.strMoneda = "DOL" Then
            strMoneda_Local = "USD"
        Else
            strMoneda_Local = "S/."
        End If
        intPosLinea = 309
        Select Case Me.Tag
            Case 0, 3
                For intCont = 0 To oDs.Tables(1).Rows.Count - 1
                    If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                        args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
                        args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("TCMTRF").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
                        args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 345, intPosLinea)
                        args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 415, intPosLinea)
                        args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
                        args.Graphics.DrawString(strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea) 'oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim

                        If strMoneda_Local = "USD" Then
                            dblTarifa = CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double)
                            If oFacturaNeg.oTipoDocumento = 7 Then
                                dblIGV = 1 + CType(lstrIGV, Double) / 100
                                dblTarifa = dblTarifa * dblIGV
                            End If
                            args.Graphics.DrawString(Format(dblTarifa, "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                            dblTotal = dblTotal + dblTarifa
                        Else
                            dblTarifa = CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double)
                            If oFacturaNeg.oTipoDocumento = 7 Then
                                dblIGV = 1 + CType(lstrIGV, Double) / 100
                                dblTarifa = dblTarifa * dblIGV
                            End If
                            args.Graphics.DrawString(Format(dblTarifa, "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                            dblTotal = dblTotal + dblTarifa
                        End If
                        dblSubTotalSoles = dblSubTotalSoles + oDs.Tables(1).Rows(intCont).Item("IVLDCS")
                    Else
                        bolIGV = True
                        intPosLinea = intPosLinea - 13
                    End If
                    intPosLinea = intPosLinea + 13
                Next intCont
            Case 1, 2

                For intCont = 0 To oDs.Tables(3).Rows.Count - 1
                    If oDs.Tables(3).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                        args.Graphics.DrawString(oDs.Tables(3).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
                        args.Graphics.DrawString(oDs.Tables(3).Rows(intCont).Item("TCMTRF").ToString.Trim & "       " & oDs.Tables(3).Rows(intCont).Item("RUTA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
                        args.Graphics.DrawString(Format(CType(oDs.Tables(3).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 345, intPosLinea)
                        args.Graphics.DrawString(oDs.Tables(3).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 415, intPosLinea)
                        If strMoneda_Local = "USD" Then
                            dblTarifa = oDs.Tables(3).Rows(intCont).Item("IVLDCD")
                            args.Graphics.DrawString(Format(dblTarifa / oDs.Tables(3).Rows(intCont).Item("QAPCTC"), "###,###,###,###.00000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
                            args.Graphics.DrawString(strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea)
                            If oFacturaNeg.oTipoDocumento = 7 Then
                                dblIGV = 1 + CType(lstrIGV, Double) / 100
                                dblTarifa = dblTarifa * dblIGV
                            End If
                            args.Graphics.DrawString(Format(dblTarifa, "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                            dblTotal = dblTotal + dblTarifa
                        Else
                            dblTarifa = oDs.Tables(3).Rows(intCont).Item("IVLDCS")
                            args.Graphics.DrawString(Format(dblTarifa / oDs.Tables(3).Rows(intCont).Item("QAPCTC"), "###,###,###,###.00000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
                            args.Graphics.DrawString(strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea)
                            If oFacturaNeg.oTipoDocumento = 7 Then
                                dblIGV = 1 + CType(lstrIGV, Double) / 100
                                dblTarifa = dblTarifa * dblIGV
                            End If
                            args.Graphics.DrawString(Format(dblTarifa, "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                            dblTotal = dblTotal + dblTarifa
                        End If
                        dblSubTotalSoles = dblSubTotalSoles + oDs.Tables(3).Rows(intCont).Item("IVLDCS")
                    End If
                    intPosLinea = intPosLinea + 13
                Next intCont
                If lstrIGV <> "" Then
                    bolIGV = True
                    intPosLinea = intPosLinea - 13
                End If
        End Select

        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Subtotal: ", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)

        intPosLinea = intPosLinea + 13

        If bolIGV Then
            If oFacturaNeg.oTipoDocumento = 1 Then args.Graphics.DrawString("IGV " & lstrIGV & " %:", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
            If oFacturaNeg.oTipoDocumento = 1 Then
                If strMoneda_Local = "USD" Then
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    dblTotal = dblTotal + (dblTotal * (CType(lstrIGV, Double) / 100)) 'oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD")
                Else
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    dblTotal = dblTotal + (dblTotal * (CType(lstrIGV, Double) / 100)) 'oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS")
                End If
            End If
            intPosLinea = intPosLinea + 13
        End If
        dblSubTotalSoles = dblSubTotalSoles + (dblSubTotalSoles * (CType(lstrIGV, Double) / 100))

        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Total: " & strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,###.00").PadLeft(15, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13

        If strMoneda_Local = "USD" Then
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
        Else
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
        End If
        Dim strValorReferencial As String = Format(oDtCabFactura.Rows(lintCountFactura).Item("VLRFDT"), "###,###,###,###.00")
        args.Graphics.DrawString("Son: " & strMonto, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 660)
        args.Graphics.DrawString(strMoneda_Local & "    " & Format(dblTotal, "###,###,###,###.00").PadLeft(16, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 630, 720)

        args.Graphics.DrawString("Reg. MTC 150491-CNG VALOR REFERENCIAL S/." & strValorReferencial, New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 730)
        If oFacturaNeg.oTipoDocumento = 1 Then
            Select Case oDtCabFactura.Rows(lintCountFactura).Item("NDSPGD")
                Case 4
                    If dblSubTotalSoles > 400 OrElse oDtCabFactura.Rows(lintCountFactura).Item("VLRFDT") > 400 Then
                        args.Graphics.DrawString("OP. SUJETA AL S.P.O.T. CON EL GOB.CENTRAL POR EL  " & oDs.Tables(0).Rows(0).Item("NDSPGD") & " % " & " -  CUENTA " & IIf(strCodCom.Trim.Equals("EZ"), "362956", "").ToString, New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 743)
                    End If
                Case 9, 12
                    If dblSubTotalSoles > 700 OrElse oDtCabFactura.Rows(lintCountFactura).Item("VLRFDT") > 700 Then
                        args.Graphics.DrawString("OP. SUJETA AL S.P.O.T. CON EL GOB.CENTRAL POR EL  " & oDs.Tables(0).Rows(0).Item("NDSPGD") & " % " & " -  CUENTA " & IIf(strCodCom.Trim.Equals("EZ"), "362956", "").ToString, New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 743)
                    End If
            End Select
        End If
        If Me.lboolEstado = 0 Then
            args.Graphics.DrawString("VENCIDO EL PLAZO DE PAGO SE COBRARAN INT. MORAS Y GTOS. ADM", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 756)
        End If
        lintCountFactura += 1
    End Sub

    Private Sub SendProcess(ByVal pCompania As String, ByVal pTipoDoc As Int32, ByVal pNumFact As Long)

        Dim wk As New WorkSap
        wk.pstrCompania = pCompania
        wk.pstrTipoDoc = pTipoDoc
        wk.pstrNumFact = pNumFact
        wk.ProcesoCierreOrden = AddressOf Cerrar_Orden_Interna
        Dim t As New Threading.Thread(AddressOf wk.IniciaCierreOrden)
        t.IsBackground = True
        t.Start()

    End Sub

    Delegate Sub CierreOrdenInterna(ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long)

    Class WorkSap

        Public pstrTipoDoc As Integer
        Public pstrCompania As String
        Public pstrNumFact As Long
        Public ProcesoCierreOrden As CierreOrdenInterna

        Public Sub IniciaCierreOrden()
            ProcesoCierreOrden(pstrCompania, pstrTipoDoc, pstrNumFact)
        End Sub

    End Class

End Class

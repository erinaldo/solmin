Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports SOLMIN_CTZ.ENTIDADES
Imports System.Text
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmVistaReFactura_ST

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
    Private lstrConsistenciaOperacion As List(Of ConsistenciaOperacion)
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
    Private TipoDocumento As Int32 = 0
    Private TipoDocReferencia As Int32

    'Private FechaFacturacion As String = ""

    Private _TNC As Int32 = 0
    Public Property TipoNC() As Int32
        Get
            Return _TNC
        End Get
        Set(ByVal value As Int32)
            _TNC = value
        End Set
    End Property

    Public WriteOnly Property pEstado() As Int32
        Set(ByVal value As Int32)
            lboolEstado = value
        End Set
    End Property

    'Public WriteOnly Property pFechaFactura() As String
    '    Set(ByVal value As String)
    '        FechaFacturacion = value
    '    End Set
    'End Property

    Public WriteOnly Property pTipoOperacion() As Int32
        Set(ByVal value As Int32)
            TipoOperacion = value
        End Set
    End Property

    Public WriteOnly Property pTipoDocumento() As Int32
        Set(ByVal value As Int32)
            TipoDocumento = value
        End Set
    End Property

    Public WriteOnly Property pTipoDocumentoReferencia() As Int32
        Set(ByVal value As Int32)
            TipoDocReferencia = value
        End Set
    End Property

    Sub New(ByVal pstrConsistencia As List(Of ConsistenciaOperacion), ByVal pstrDivision As String, ByVal pstrCodDiv As String, ByVal pstrCodCom As String, ByVal pdblCliente As Double, ByVal pstrCodPlanta As String, ByVal pstrMoneda As String, ByVal pintZonaFacturacion As Int32, ByVal pstrOrgVenta As String, ByVal FechaFactura As Date, ByVal FechaAtencion As Int64)
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

    Private Sub frmVistaReFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            oFiltro.Add("PNCTPODC", TipoDocumento)
            oFiltro.Add("PSCUSCRT", ConfigurationWizard.UserName)
            oFacturaNeg.Llenar_Documentos_Notas(oFiltro)
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
        Select Case TipoDocumento
            Case 2
                Me.lblTipoDocumento.Text = "NOTA DE DEBITO"
            Case 3
                Me.lblTipoDocumento.Text = "NOTA DE CREDITO"
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
        Call Me.Eliminar_Servicios_A_ReFacturar()
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

        Datos_Generales_ReFactura_Notas()
        Generar_ReFactura_Notas()

        Dim objHash As New Hashtable
        objHash.Add("CCMPN", strCodCom.PadLeft(2, "0"))
        objHash.Add("CDVSN", strCodDiv)
        objHash.Add("CRGVTA", strOrgVenta.PadLeft(3, "0"))
        objHash.Add("CCLNT", dblCliente.ToString.PadLeft(6, "0"))
        Dim strEstado As String = ""
        Dim strResultado As String = oFacturaNeg.Validar_Cliente_SAP(objHash, strEstado)
        Select Case strEstado
            Case ""
                '--ACTIVAR DESPUES DE PRUEBA
                HelpClass.MsgBox("ERROR : Ocurrio un Problema de Conexión", MessageBoxIcon.Information)
                'Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
            Case "B", "C", "D"
                HelpClass.MsgBox("ADVERTENCIA : " & "Cliente " & strResultado, MessageBoxIcon.Information)
                Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Datos_Generales_ReFactura_Notas()
        Dim oDtNew As DataTable
        Dim oFiltro As New Hashtable
        Dim strCliente As String = ""
        'Dim consistencia() As String = lstrConsistenciaOperacion.Split("-")
        oFiltro.Add("PNCCLNFC", dblCliente)
        oFiltro.Add("PSCCMPN", strCodCom)
        oDtNew = oFacturaNeg.Lista_Datos_Cliente(oFiltro)
        strCliente = "Sres.:".PadRight(130, " ") & "Código:    " & oDtNew.Rows(0).Item("CCLNT").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TCMPCL").ToString.Trim & ("" & oDtNew.Rows(0).Item("TCMCL1")).ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TDRCOR").ToString.Trim & "    " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & IIf(oDtNew.Rows(0).Item("NRUC").ToString.Trim = "0", "", oDtNew.Rows(0).Item("NRUC").ToString.Trim) & " ".PadRight(90, " ") & "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(ldtpFechaFactura, "dd/MM/yyyy")
        strCliente = strCliente & vbCrLf & "Tip.Doc.Origen:  " & TipoDocReferencia & " Num.Doc.Origen:  " & lstrConsistenciaOperacion(0).Factura & " Fec.Doc.Origen:  " & IIf(TipoDocumento = 3, HelpClass_ST.CFecha_10_10(lstrConsistenciaOperacion(0).Fecha), HelpClass_ST.CFecha_10_10(lstrConsistenciaOperacion(0).Fecha))

        Me.txtCliente.Text = strCliente
    End Sub

    Private Sub Generar_ReFactura_Notas()
        Dim intCant As Integer

        intCant = IIf(oFacturaNeg.oTipoDocumento.ToString.Equals("7"), 1, Obtener_Cantidad_ReFacturas_Notas())
        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant, lboolEstado)
            Mostrar_Factura(intCant)
            ' KryptonHeaderGroup1.Enabled = True
            Me.btnImprimirfactura.Visible = True
            Me.btnCancelarImpr.Visible = True
        Else
            Me.btnCancelarImpr.Visible = False
            Me.btnImprimirfactura.Visible = False
            HelpClass.MsgBox("No existen Facturas para crear")
        End If
    End Sub

    Private Sub Mostrar_Factura(ByVal intCant As Integer)
        Dim octrlFact As ctrlReFactura_ST
        Dim consistencia As String = ""
        Dim X As Integer = 0
        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True
        Next X

        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = Me.lblTipoDocumento.Text
            Select Case Me.Tag
                Case 0

                    octrlFact = New ctrlReFactura_ST(oDtDetFactura, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 0, oFacturaNeg.oTipoDocumento)
                    octrlFact.NumFactura = "N°          "
                    octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(ListOperaciones, strCodCom)
                    octrlFact.GridSoloLectura = True
                    octrlFact.TipoOperacion = Me.TipoDocumento

                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
                Case 1
                    oDtDetFacturaDetallada = Mostrar_Factura_Consolidada(lint_Contador + 1, oDtDetFactura.Copy, lstrConsistenciaOperacion(0).TipoCambioFactura)
                    octrlFact = New ctrlReFactura_ST(oDtDetFacturaDetallada, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 1, oFacturaNeg.oTipoDocumento)
                    octrlFact.NumFactura = "N°          "
                    octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(ListOperaciones, strCodCom)
                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
                    lhashItemFact.Add(lint_Contador + 1, octrlFact.dtgDetalle.RowCount)
                Case 2
                    oDtDetFacturaDetallada = Mostrar_Factura_Detallada(lint_Contador + 1, oDtDetFactura.Copy)
                    octrlFact = New ctrlReFactura_ST(oDtDetFacturaDetallada, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 1, oFacturaNeg.oTipoDocumento)
                    octrlFact.NumFactura = "N°          "
                    octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(ListOperaciones, strCodCom)
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

    Private Function Mostrar_Factura_Consolidada(ByVal lintNumeroFactura As Int32, ByVal objData As DataTable, Optional ByVal TipoCambioFactura As Double = 0) As DataTable
        Dim objDataReturn As DataTable
        Dim pobjFiltro As New Hashtable
        pobjFiltro.Add("PSNOPRCN", ListUnique(ListOperaciones))
        pobjFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd")) 'fecha documento
        pobjFiltro.Add("PNCTPODC", TipoDocumento)
        pobjFiltro.Add("PSCCMPN", strCodCom)
        pobjFiltro.Add("PSCDVSN", strCodDiv)
        pobjFiltro.Add("PNTPCMBO", TipoCambioFactura)
        objDataReturn = oFacturaNeg.Mostrar_ReFactura_Consolidada(pobjFiltro, lintNumeroFactura, objData, TipoNC, TipoCambioFactura)
        Return objDataReturn
    End Function

    Private Function Obtener_Cantidad_ReFacturas_Notas() As Integer
        Dim oFiltro As New Hashtable
        oFiltro.Add("PNNOPRCN", ListUnique(ListOperaciones))
        oFiltro.Add("PNNDCMFC", ListUnique(ListFacturas))
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCMNDA", strMoneda)
        oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd")) ' fecha del documento
        oFiltro.Add("PNFATNSR", lintFATNSR)
        oFiltro.Add("PNCTPODC", TipoDocumento)
        Return oFacturaNeg.Cantidad_ReFacturas_Notas(oFiltro)

    End Function

    Private Sub Generar_Cabecera(ByVal pintCant As Double)
        Dim oFiltro As New Hashtable
        oFiltro.Add("PNNOPRCN", ListUnique(ListOperaciones))
        oFiltro.Add("CANTFACT", pintCant)
        oFiltro.Add("PNCCLNFC", dblCliente)
        oFiltro.Add("PSCDVSN", strCodDiv)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PNTPCAM", dblTipoCambio) 'dblTipoCambio
        oFiltro.Add("PNCPLDVN", strCodPlanta)
        oFiltro.Add("PNCMNDA1", strMoneda)
        oFiltro.Add("PNCZNFCC", intZonaFact)
        oFiltro.Add("PSCRGVTA", strOrgVenta)
        oFiltro.Add("PDFECFAC", ldtpFechaFactura)
        oFiltro.Add("PNFATNSR", lintFATNSR)
        oFacturaNeg.PuntoVenta = Me.cmbPtoVenta.SelectedValue
        oFacturaNeg.GiroNegocio = Me.cmbGiro.SelectedValue
        oFacturaNeg.PlantaCliente = Me.cmbPlantaCliente.SelectedValue
        oDtCabFactura = oFacturaNeg.Lista_Cabecera_ReFactura(oFiltro)
        Me.dtgCabeceraFactura.DataSource = oDtCabFactura
    End Sub

    Private Sub Generar_Detalles(ByVal pintCant As Integer, ByVal lboolEstado As Integer)
        Dim oFiltro As New Hashtable
        oFiltro.Add("PNNOPRCN", ListUnique(ListOperaciones))
        oFiltro.Add("PNNDCMFC", ListUnique(ListFacturas))
        oFiltro.Add("CANTFACT", pintCant)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCMNDA", strMoneda)
        oFiltro.Add("PSSTATUS", lboolEstado)
        oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd")) ' fecha documento
        oFiltro.Add("PNFATNSR", lintFATNSR)
        oFiltro.Add("PNCTPODC", TipoDocumento)
        oFacturaNeg.ListaOperaciones = lstrConsistenciaOperacion
        oDtDetFactura = oFacturaNeg.Lista_Detalle_ReFacturas_Notas2(oFiltro, lhashIGV)
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub

    Private Sub Grabar_ReFactura(ByVal pintFact As Integer)
        Dim strNumFact As Int64 = 0
        Dim objFiltro As New Hashtable 'Filtro
        Dim intValor As Int32 = 0
        Dim miGridDetalle As DataGridView
        Dim intTipoDoc As Integer = 1
        Dim intTipoCambs As Double = 1
        Dim intTipoCambd As Double = dblTipoCambio 'Me.dblTipoCambio
        Dim numFilasGrid As Integer
        'Dim consistencia() As String = lstrConsistenciaOperacion.Split("-")

        Try

            Cursor = Cursors.WaitCursor
            lstrIGV = lhashIGV(pintFact).ToString.Trim
            miGridDetalle = CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura_ST).dtgDetalle
            numFilasGrid = miGridDetalle.RowCount

            'If TipoDocumento = 3 Then intTipoDoc = -1
            'If Me.strMoneda = "DOL" Then
            '    intTipoCambs = dblTipoCambio
            '    intTipoCambd = 1
            'End If

            'For RowIndex = 0 To numFilasGrid - 4
            '    oDtCabFactura.Rows(RowIndex).Item("IVLAFS") = intTipoDoc * (miGridDetalle.Item("IMPORTE", numFilasGrid - 3).Value) * intTipoCambs 'SUB-TOTAL
            '    oDtCabFactura.Rows(RowIndex).Item("IVLIGS") = intTipoDoc * (miGridDetalle.Item("IMPORTE", numFilasGrid - 2).Value) * intTipoCambs 'IGV
            '    oDtCabFactura.Rows(RowIndex).Item("ITTFCS") = intTipoDoc * (miGridDetalle.Item("IMPORTE", numFilasGrid - 1).Value) * intTipoCambs 'TOTAL
            '    oDtDetFactura.Rows(RowIndex).Item("ITRCTC") = intTipoDoc * (miGridDetalle.Item("TARIFA", RowIndex).Value) * intTipoCambs 'TARIFA
            '    oDtDetFactura.Rows(RowIndex).Item("IVLDCS") = intTipoDoc * (miGridDetalle.Item("IMPORTE", RowIndex).Value) * intTipoCambs 'IMPORTE

            '    oDtCabFactura.Rows(RowIndex).Item("IVLAFD") = intTipoDoc * (miGridDetalle.Item("IMPORTE", numFilasGrid - 3).Value) / intTipoCambd 'SUB-TOTAL
            '    oDtCabFactura.Rows(RowIndex).Item("IVLIGD") = intTipoDoc * (miGridDetalle.Item("IMPORTE", numFilasGrid - 2).Value) / intTipoCambd 'IGV
            '    oDtCabFactura.Rows(RowIndex).Item("ITTFCD") = intTipoDoc * (miGridDetalle.Item("IMPORTE", numFilasGrid - 1).Value) / intTipoCambd 'TOTAL
            '    oDtDetFactura.Rows(RowIndex).Item("IVLDCD") = intTipoDoc * (miGridDetalle.Item("IMPORTE", RowIndex).Value) / intTipoCambd 'IMPORTE

            oDtCabFactura.Rows(0).Item("CTPODC") = Me.TipoDocumento
            oDtCabFactura.Rows(0).Item("CTPDCO") = TipoDocReferencia
            oDtCabFactura.Rows(0).Item("NDCMOR") = lstrConsistenciaOperacion(0).Factura.ToString.Split(",").GetValue(0)
            oDtCabFactura.Rows(0).Item("FDCMOR") = HelpClass_ST.CFecha_de_10_a_8(lstrConsistenciaOperacion(0).Fecha)
            'Next
            'oDtDetFactura.Rows(RowIndex).Item("IVLDCS") = intTipoDoc * (miGridDetalle.Item("IMPORTE", 2).Value) * intTipoCambs 'IMPORTE - 999
            'oDtDetFactura.Rows(RowIndex).Item("IVLDCD") = intTipoDoc * (miGridDetalle.Item("IMPORTE", 2).Value) / intTipoCambd 'IMPORTE - 999
            oFacturaNeg.ListaOperaciones = lstrConsistenciaOperacion
            oFacturaNeg.Grabar_ReFactura(pintFact, oDtCabFactura, oDtDetFactura, strNumFact)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 1, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura_ST).Referencia1)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 2, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura_ST).Referencia2)

            If TipoOperacion = 2 Then
                intValor = Registrar_Orden_Interna_Factura(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact, CType(oDtCabFactura.Rows(0).Item("FDCCTC").ToString.Trim, Int64))
            End If

            'Me.TabPage1.Text = "Factura N°" & strNumFact
            Me.tabFactura.TabPages(pintFact - 1).Text = Me.lblTipoDocumento.Text & " N°" & strNumFact
            CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura_ST).NumFactura = "N° " & strNumFact
            lblNumFact.Text = "N° " & strNumFact
        Catch ex As Exception
            Cursor = Cursors.Default
            strNumFact = 0
            HelpClass.MsgBox("Error al grabar la " & Me.lblTipoDocumento.Text & vbCrLf & ex.Message)
        End Try
        If strNumFact <> 0 Then
            Cursor = Cursors.Default
            HelpClass.MsgBox("Se grabó correctamente la " & Me.lblTipoDocumento.Text & " N° " & strNumFact)
            Cursor = Cursors.WaitCursor
            If lintImprimir = 1 Then
                Imprime_Factura(strNumFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim)
            End If
            Cursor = Cursors.Default
            'habilitar en produccion 
            Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)

            'If intValor = 1 Then
            '  Cerrar_Orden_Interna(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact)

            'Me.SendProcess(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact)
            'Shell(Application.StartupPath & "/external/SOLMIN_ST_SAP_SYNC.exe " & oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim & " " & oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim & " " & strNumFact, AppWinStyle.Hide)
            'End If
            'If MsgBox("Desea Imprimir Sustento?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            '  Dim obj_Logica As New Factura_Transporte_BLL
            '  Dim objPrintForm As New PrintForm
            '  Dim objDsSustento As New DataSet
            '  Dim objDtSustento As New DataTable
            '  Dim objetoRepFact As New rptSustento_Factura
            '  Dim objetoRepBole As New rptSustento_Boleta
            '  Dim objParametroSustento As New Hashtable
            '  Try
            '    If strNumFact.ToString.Trim.Length = 0 Then Exit Sub
            '    objParametroSustento.Add("PNCTPODC", oDtCabFactura.Rows(0).Item("CTPODC"))
            '    objParametroSustento.Add("PNNDCMFC", strNumFact.ToString)
            '    objParametroSustento.Add("PSCCMPN", oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim)
            '    objParametroSustento.Add("PSCDVSN", strCodDiv)
            '    objDtSustento = HelpClass.GetDataSetNative(obj_Logica.Listar_Sustento_Factura(objParametroSustento))
            '    objDtSustento.TableName = "RZCT01"

            '    If objDtSustento.Rows.Count = 0 Then
            '      HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
            '      Exit Sub
            '    End If
            '    objDsSustento.Tables.Add(objDtSustento.Copy)

            '    Select Case oDtCabFactura.Rows(0).Item("CTPODC")
            '      Case 1
            '        objetoRepFact.SetDataSource(objDsSustento)

            '        CType(objetoRepFact.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = MainModule.USUARIO
            '        CType(objetoRepFact.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
            '        CType(objetoRepFact.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
            '        CType(objetoRepFact.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
            '        CType(objetoRepFact.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "FACTURA N° " & strNumFact.ToString
            '        objPrintForm.ShowForm(objetoRepFact, Me)
            '      Case 7
            '        objetoRepBole.SetDataSource(objDsSustento)

            '        CType(objetoRepBole.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = MainModule.USUARIO
            '        CType(objetoRepBole.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
            '        CType(objetoRepBole.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
            '        CType(objetoRepBole.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
            '        CType(objetoRepBole.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "BOLETA DE VENTA N° " & strNumFact.ToString
            '        objPrintForm.ShowForm(objetoRepBole, Me)
            '    End Select

            '  Catch : End Try
            'End If
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
                HelpClass.MsgBox("Error al enviar Orden Interna", MessageBoxIcon.Information)
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
            Case 0
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
            For intContador As Integer = 1 To Me.tabFactura.TabCount
                Grabar_ReFactura(intContador) 'Me.tabFactura.SelectedIndex + 1)
                Call Me.Eliminar_Servicios_A_ReFacturar()
                Me.lblNumFact.Tag = intContador
                Me.btnImprimirfactura.Visible = False
                Me.btnGenerar.Visible = False
            Next
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
        Dim intMulti As Integer = 1
        ' Dim consistencia() As String = lstrConsistenciaOperacion.Split("-")

        If TipoDocumento = 3 Then intMulti = -1

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
        args.Graphics.DrawString("Tip.Doc.Origen: " & Me.TipoDocReferencia & "  Num.Doc.Origen:  " & lstrConsistenciaOperacion(0).Factura & " Fec.Doc.Origen:  " & lstrConsistenciaOperacion(0).Fecha, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 155)

        args.Graphics.DrawString("Referencia:", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 180)
        args.Graphics.DrawString("No. Control : " & dblNumFacImp, New Font(myFont, FontStyle.Regular), Brushes.Black, 600, 180)

        oDr = oDs.Tables(2).Select("CTPDCC = 1") 'PORQUE 
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
            Case 0
                For intCont = 0 To oDs.Tables(1).Rows.Count - 1
                    If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                        args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
                        args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("TCMTRF").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
                        args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 345, intPosLinea)
                        args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 415, intPosLinea)
                        args.Graphics.DrawString(Format(intMulti * CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
                        args.Graphics.DrawString(strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea) 'oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim

                        If strMoneda_Local = "USD" Then
                            dblTarifa = CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double)
                            If oFacturaNeg.oTipoDocumento = 7 Then 'PORQUE
                                dblIGV = 1 + CType(lstrIGV, Double) / 100
                                dblTarifa = dblTarifa * dblIGV
                            End If
                            args.Graphics.DrawString(Format(dblTarifa, "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                            dblTotal = dblTotal + dblTarifa
                        Else
                            dblTarifa = CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double)
                            If oFacturaNeg.oTipoDocumento = 7 Then ' PORQUE
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
            'CAMBIO DE TIPO DOC=1 AS 2 Y 3
            'If oFacturaNeg.oTipoDocumento = 2 OrElse oFacturaNeg.oTipoDocumento = 3 Then
            args.Graphics.DrawString("IGV " & lstrIGV & " %:", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
            'If oFacturaNeg.oTipoDocumento = 2 OrElse oFacturaNeg.oTipoDocumento = 3 Then
            If strMoneda_Local = "USD" Then
                args.Graphics.DrawString(Format(intMulti * CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                dblTotal = dblTotal + (dblTotal * (CType(lstrIGV, Double) / 100)) 'oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD")
            Else
                args.Graphics.DrawString(Format(intMulti * CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                dblTotal = dblTotal + (dblTotal * (CType(lstrIGV, Double) / 100)) 'oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS")
            End If
            'End If
            intPosLinea = intPosLinea + 13
        End If

        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Total: " & strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,###.00").PadLeft(15, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        'args.Graphics.DrawString("Referencia:", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 180)
        'intPosLinea = intPosLinea + 13
        oDr = oDs.Tables(2).Select("CTPDCC = 2") 'PORQUE 
        'intPosLinea = 202
        For intCont = 0 To oDr.Length - 1
            args.Graphics.DrawString(oDr(intCont).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
            intPosLinea = intPosLinea + 13
        Next intCont


        If strMoneda_Local = "USD" Then
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
        Else
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
        End If
        Dim strValorReferencial As String = Format(oDtCabFactura.Rows(lintCountFactura).Item("VLRFDT"), "###,###,###,###.00")
        args.Graphics.DrawString("Son: " & strMonto, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 660)
        args.Graphics.DrawString(strMoneda_Local & "    " & (Format(dblTotal, "###,###,###,###.00").PadLeft(16, "*")), New Font(myFont, FontStyle.Regular), Brushes.Black, 630, 720)
        If strTipoDocFacImp = 2 Then
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
            args.Graphics.DrawString("VENCIDO EL PLAZO DE PAGO SE COBRARAN INT. MORAS Y GTOS. ADM", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 756)
        End If
        lintCountFactura += 1
    End Sub

    Private Function ListUnique(ByVal listaFactuas As String) As String
        Dim lista() As String = listaFactuas.Split(",")
        Dim oHas As New Hashtable
        Dim Factura As String = ""
        Dim sbLista As New StringBuilder
        Dim Texto As String = ""
        For intX As Integer = 0 To lista.Length - 1
            Factura = ("" & lista(intX)).Trim
            If Factura.Length > 0 Then
                If Not oHas.Contains(Factura) Then
                    oHas(Factura) = Factura
                    sbLista.Append(Factura & ",")
                End If
            End If
        Next
        Texto = sbLista.ToString
        Texto = Texto.Substring(0, Texto.LastIndexOf(","))
        Return Texto
    End Function
    Private Function ListOperaciones() As String
        Dim result As String = ""
        Dim list As String = ""
        For a As Integer = 0 To lstrConsistenciaOperacion.Count - 1

            result += lstrConsistenciaOperacion(a).Operacion & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Function ListFechaFacturas() As String
        Dim result As String = ""
        Dim list As String = ""
        For a As Integer = 0 To lstrConsistenciaOperacion.Count - 1
            result += lstrConsistenciaOperacion(a).Fecha & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Function ListFacturas() As String
        Dim result As String = ""
        Dim list As String = ""
        For a As Integer = 0 To lstrConsistenciaOperacion.Count - 1
            result += lstrConsistenciaOperacion(a).Factura & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function
    Private Sub Eliminar_Servicios_A_ReFacturar()
        Dim RefacturaBLL As New ReFacturacion_BLL
        Dim param As New Hashtable
        Try
            param.Add("PNNOPRCN", ListUnique(ListOperaciones))
            param.Add("PNNDCMFC", ListUnique(ListFacturas))
            param.Add("PNCTPDFC", 1)
            param.Add("PSCCPMN", strCodCom)
            RefacturaBLL.Eliminar_Servicios_A_ReFacturar(param)
        Catch ex As Exception
        End Try
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


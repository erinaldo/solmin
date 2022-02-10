Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports System.Threading
Imports System.data

Public Class frmVistaParteTransferencia


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


    Private lstrConsistenciaOperacion As String
    Private oDtCabFactura As DataTable
    Private oDtDetFactura As DataTable
    Private oDtDetFacturaDetallada As DataTable
    Private dblNumFacImp As Int64
    Private strCompFacImp As String
    Private strTipoDocFacImp As String
    Private lintCountFactura As Integer

    Private lintImprimir As Int32 = 0
    Private ldtpFechaFactura As Date = Now
    Private lstrIGV As String = ""
    Private lhashIGV As New Hashtable
    'Private lintFATNSR As Int64 = 0
    Private lintFATNSR As Int64 = Now.ToString("yyyyMMdd")
    Private lhashItemFact As New Hashtable


    Private CodAprobador As String = ""


    Dim hiloCompania As String
    Dim hiloTipoDoc As Int32
    Dim hiloNumFact As Long

 
    Private lboolEstado As Int32 = 0


    Private _EsXPreLiquidacion As Boolean = False
    Public Property EsXPreLiquidacion() As Boolean
        Get
            Return _EsXPreLiquidacion
        End Get
        Set(ByVal value As Boolean)
            _EsXPreLiquidacion = value
        End Set
    End Property



    Private _TipoVistaImpresion As NEGOCIO.clsComun.VistaImpresion = NEGOCIO.clsComun.VistaImpresion.Neutro
    Public Property TipoVistaImpresion() As NEGOCIO.clsComun.VistaImpresion
        Get
            Return _TipoVistaImpresion
        End Get
        Set(ByVal value As NEGOCIO.clsComun.VistaImpresion)
            _TipoVistaImpresion = value
        End Set
    End Property


    Private dblNumDocOrigen As Decimal = 0
    Public WriteOnly Property NumDocOrigen() As Decimal
        Set(ByVal value As Decimal)
            dblNumDocOrigen = value
        End Set
    End Property
    Private dblFechaDocOrigen As Decimal = 0
    Public WriteOnly Property FechaDocOrigen() As Decimal
        Set(ByVal value As Decimal)
            dblFechaDocOrigen = value
        End Set
    End Property
    Private dblTipoDocOrigen As Decimal = 0
    Public WriteOnly Property TipoDocOrigen() As Decimal
        Set(ByVal value As Decimal)
            dblTipoDocOrigen = value
        End Set
    End Property

    'Sub New(ByVal pstrConsistencia As String, ByVal pstrDivision As String, ByVal pstrCodDiv As String, ByVal pstrCodCom As String, ByVal pdblCliente As Double, ByVal pstrCodPlanta As String, ByVal pstrMoneda As String, ByVal pintZonaFacturacion As Int32, ByVal pstrOrgVenta As String, ByVal FechaFactura As Date, ByVal FechaAtencion As Int64, ByVal Aprobador As String)
    '    ' Llamada necesaria para el Diseñador de Windows Forms.
    '    InitializeComponent()

    '    strDivision = pstrDivision
    '    strCodDiv = pstrCodDiv
    '    strCodCom = pstrCodCom
    '    dblCliente = pdblCliente
    '    strCodPlanta = pstrCodPlanta
    '    strMoneda = pstrMoneda
    '    oFacturaNeg.Tipomoneda = pstrMoneda
    '    lstrConsistenciaOperacion = pstrConsistencia
    '    intZonaFact = pintZonaFacturacion
    '    strOrgVenta = pstrOrgVenta
    '    ldtpFechaFactura = FechaFactura
    '    lintFATNSR = FechaAtencion
    '    CodAprobador = Aprobador
    'End Sub

    Sub New(ByVal pstrConsistencia As String, ByVal pstrDivision As String, ByVal pstrCodDiv As String, ByVal pstrCodCom As String, ByVal pdblCliente As Double, ByVal pstrCodPlanta As String, ByVal pstrMoneda As String, ByVal pintZonaFacturacion As Int32, ByVal pstrOrgVenta As String, ByVal Aprobador As String)
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
        'ldtpFechaFactura = FechaFactura
        'lintFATNSR = FechaAtencion
        CodAprobador = Aprobador
    End Sub


    Private Sub frmVistaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.Tag = val(_TipoVistaImpresion)
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
                txtTipoCambio.Text = dblTipoCambio

                oFiltro.Add("PSCDVSN", strCodDiv)
                oFiltro.Add("PNCCLNT", dblCliente)
                oFiltro.Add("PSCUSCRT", USUARIO)
                oFacturaNeg.Llenar_Documentos(oFiltro)
                Llenar_Combos()
                txtDivision.Text = strDivision
            Else
                MessageBox.Show("No se puede generar la factura por no existir Tipo de cambio para el día " & Format(Now, "dd/MM/yyyy"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Llenar_Combos()

        Dim oFiltro As New Hashtable
        Dim oDt As DataTable

        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCDVSN", strCodDiv)
        oFiltro.Add("PSCUSCRT", USUARIO)
        oDt = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
        cmbGiro.DataSource = oDt
        cmbGiro.ValueMember = "CGRONG"

        cmbGiro.DisplayMember = "TCMGRN"
        If oDt.Rows.Count = 1 Then
            cmbGiro.Enabled = False
        End If

        cmbGiro_SelectionChangeCommitted(cmbGiro, Nothing)

        If oDt.Rows.Count <= 0 Then
            btnGenerar.Visible = False
        Else
            btnGenerar.Visible = True
        End If

        oDt = New DataTable
        oFiltro.Add("PNCCLNFC", dblCliente)
        oDt = oFacturaNeg.Lista_Planta_Cliente(oFiltro)
        cmbPlantaCliente.DataSource = oDt
        cmbPlantaCliente.ValueMember = "CPLNCL"
        cmbPlantaCliente.DisplayMember = "TDRCPL"

        cmbPlantaCliente.SelectedValue = 1
        cmbPlantaCliente.Enabled = False
        btnGenerar.Visible = False
        Select Case oFacturaNeg.oTipoDocumento
            Case 1, 51
                Me.lblTipoDocumento.Text = "FACTURA"
            Case 7, 57
                Me.lblTipoDocumento.Text = "BOLETA"
            Case 6
                Me.lblTipoDocumento.Text = "PARTE TRANSFERENCIA"
                btnGenerar.Visible = True
        End Select

    End Sub

    Private Sub cmbGiro_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGiro.SelectionChangeCommitted
        Try

            Dim oFiltro As New Hashtable
            oFiltro.Add("CGRONG", cmbGiro.SelectedValue)
            cmbPtoVenta.DataSource = oFacturaNeg.Lista_Punto_Venta(oFiltro)
            cmbPtoVenta.DisplayMember = "TOBSAD"
            cmbPtoVenta.ValueMember = "NPTOVT"
            If cmbPtoVenta.Items.Count <= 0 Then
                btnGenerar.Visible = False
            Else
                btnGenerar.Visible = True
            End If

        Catch ex As Exception
            btnGenerar.Visible = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click, btnCancelarImpr.Click
        Limpiar_Datos_Factura()
        KryptonHeaderGroup1.Enabled = True
        btnImprimirfactura.Visible = False
        btnCancelarImpr.Visible = False
        If lblNumFact.Text = "" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            lblNumFact.Text = ""
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        Try
          
            Datos_Generales_Factura()
            Generar_Factura()

        Catch ex As Exception
            Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & IIf(oDtNew.Rows(0).Item("NRUC").ToString.Trim = "0", "", oDtNew.Rows(0).Item("NRUC").ToString.Trim) & " ".PadRight(90, " ") '& "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(ldtpFechaFactura, "dd/MM/yyyy")
        Me.txtCliente.Text = strCliente
    End Sub

    Private Sub Generar_Factura()
        Dim intCant As Integer
        Dim strOperacionSnPeso As String = ""

        intCant = Obtener_Cantidad_Facturas(strOperacionSnPeso) ' IIf(oFacturaNeg.oTipoDocumento.ToString.Equals("7") Or oFacturaNeg.oTipoDocumento.ToString.Equals("57"), 1, Obtener_Cantidad_Facturas(strOperacionSnPeso))

        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant)
            Mostrar_Factura(intCant)
            KryptonHeaderGroup1.Enabled = False
            Me.btnImprimirfactura.Visible = True
            Me.btnCancelarImpr.Visible = True
        Else
            Me.btnCancelarImpr.Visible = False
            Me.btnImprimirfactura.Visible = False
            MessageBox.Show("No existen Facturas para crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private oHasResumenVista As Hashtable
    Private Sub Mostrar_Factura(ByVal intCant As Integer)
        Dim octrlFact As ctrlFactura
        Dim X As Integer = 0

        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True
        Next X

        oHasResumenVista = New Hashtable

        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = Me.lblTipoDocumento.Text

            Dim ValorReferencial As Decimal = 0
            Dim PorcentajeDetraccion As Decimal = 0

            If oDtCabFactura.Rows.Count > 0 Then
                ValorReferencial = Convert.ToDecimal(oDtCabFactura.Rows(lint_Contador).Item("VLRFDT").ToString)
                PorcentajeDetraccion = Convert.ToDecimal(oDtCabFactura.Rows(lint_Contador).Item("NDSPGD").ToString)
            End If

            Select Case _TipoVistaImpresion
                Case NEGOCIO.clsComun.VistaImpresion.Normal

                    oDtDetFacturaDetallada = oFacturaNeg.Mostrar_Factura_ParteTransferencia_General(lint_Contador + 1, oDtDetFactura.Copy, lhashIGV(lint_Contador + 1))
                    oHasResumenVista.Add(lint_Contador + 1, oDtDetFacturaDetallada.Copy)

                    octrlFact = New ctrlFactura(oDtDetFacturaDetallada, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 0, oFacturaNeg.oTipoDocumento, ctrlFactura.FormatoVista.ParteTransferencia, ValorReferencial, PorcentajeDetraccion)

                    octrlFact.NumFactura = "N°          "

                    octrlFact.Referencia1 = Obtener_Referencia1()
                    octrlFact.Referencia2 = Obtener_Referencia2()


                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)

            End Select

        Next
    End Sub
    Private Function Obtener_Referencia1() As String
        Dim referencia1 As String = ""
        Dim dtref1 As DataTable = oFacturaNeg.Obtener_Referencia_Documento(lstrConsistenciaOperacion, strCodCom).Tables(0)

        Dim ref_mercancia As String = ""

        If dtref1.Rows.Count > 0 Then
            If dtref1.Rows(0).Item("TRFMRC").ToString.Trim <> "" Then
                ref_mercancia = "Mercancía: " + dtref1.Rows(0).Item("TRFMRC").ToString
            End If

            referencia1 = "ORDEN: " + dtref1.Rows(0).Item("TCMRCD").ToString + Chr(13) + Chr(10) + ref_mercancia
        End If
        referencia1 = referencia1.Trim
        Return referencia1
    End Function



    Private Function Obtener_Referencia2() As String
        Dim referencia2 As String = ""
        Dim dtref2 As DataTable = oFacturaNeg.Obtener_Referencia_Documento(lstrConsistenciaOperacion, strCodCom).Tables(1)
        Dim HasVisitado As New Hashtable
        Dim Guia As String = ""
        Dim CantidadG As Decimal = 0
        If dtref2.Rows.Count > 0 Then

            For i As Integer = 0 To dtref2.Rows.Count - 1
                If i = 0 Then
                    referencia2 = "Guías: "
                End If
                Guia = dtref2.Rows(i).Item("NRGUCL").ToString().Trim
                If Not HasVisitado.Contains(Guia) Then
                    HasVisitado(Guia) = Guia
                    CantidadG = CantidadG + 1
                    referencia2 = referencia2 + Guia + ","
                    If CantidadG = 4 Or CantidadG = 11 Or CantidadG = 18 Or CantidadG = 25 Or CantidadG = 32 Or CantidadG = 39 Or CantidadG = 46 Or CantidadG = 53 Then
                        referencia2 = referencia2 + Chr(13) + Chr(10)
                    End If
                End If
            Next
            referencia2 = referencia2.Substring(0, referencia2.Length - 1)

        End If

        Return referencia2

    End Function
    Private Function Mostrar_Factura_Detallada(ByVal lintNumeroFactura As Int32, ByVal objData As DataTable, ByVal IGV As Decimal) As DataTable
        Dim objDataReturn As New DataTable
        objDataReturn = oFacturaNeg.Mostrar_Factura_Detallada_General(lintNumeroFactura, objData, IGV)
        Return objDataReturn
    End Function

    Private Function Mostrar_Factura_Consolidada(ByVal lintNumeroFactura As Int32, ByVal objData As DataTable, ByVal IGV As Decimal) As DataTable
        Dim objDataReturn As New DataTable
        objDataReturn = oFacturaNeg.Mostrar_Factura_Consolidada_General(lintNumeroFactura, objData, IGV)
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
        returnCant = oFacturaNeg.Cantidad_Facturas_General(oFiltro)
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
        oFiltro.Add("PNNDCMOR", dblNumDocOrigen)
        oFiltro.Add("PNFDCMOR", dblFechaDocOrigen)
        oFiltro.Add("PNCTPDCO", dblTipoDocOrigen)
        oFacturaNeg.PuntoVenta = cmbPtoVenta.SelectedValue
        oFacturaNeg.GiroNegocio = cmbGiro.SelectedValue
        oFacturaNeg.PlantaCliente = cmbPlantaCliente.SelectedValue
        oDtCabFactura = oFacturaNeg.Lista_Cabecera_Factura(oFiltro)
        Me.dtgCabeceraFactura.DataSource = oDtCabFactura
    End Sub

    Private Sub Generar_Detalles(ByVal pintCant As Integer)
        Dim oFiltro As New Hashtable
        oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
        oFiltro.Add("CANTFACT", pintCant)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCMNDA", strMoneda)
        oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PNFATNSR", lintFATNSR)
        oDtDetFactura = oFacturaNeg.Lista_Detalle_ParteTransferencia_General(oFiltro, lhashIGV, _EsXPreLiquidacion)
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub

    Private Sub Grabar_Factura(ByVal pintFact As Integer)
        Dim strNumFact As Int64 = 0
        Dim objFiltro As New Hashtable
        Dim intValor As Int32 = 0
        Dim dtVistaFact As New DataTable
        Try
            lstrIGV = lhashIGV(pintFact).ToString.Trim
            dtVistaFact = oHasResumenVista(pintFact)
           
            oFacturaNeg.Grabar_Factura_General(pintFact, oDtCabFactura, oDtDetFactura, strNumFact, dtVistaFact, lstrIGV, _TipoVistaImpresion, True, "", False)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 1, oDtCabFactura, CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia1)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 2, oDtCabFactura, CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia2)

            intValor = Registrar_Orden_Interna_Factura(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact, CType(oDtCabFactura.Rows(0).Item("FDCCTC").ToString.Trim, Int64))

            tabFactura.TabPages(pintFact - 1).Text = lblTipoDocumento.Text.Trim & " N°" & strNumFact

            CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).NumFactura = "N° " & strNumFact
            lblNumFact.Text = "N° " & strNumFact
        Catch ex As Exception
            strNumFact = 0
            MessageBox.Show("Error al grabar el documento " & vbCrLf & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If strNumFact <> 0 Then

            MessageBox.Show("Se grabó correctamente la " & lblTipoDocumento.Text.Trim & " N° " & strNumFact, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            'If lintImprimir = 1 Then
            '    Imprime_Factura(strNumFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim)
            'End If

            Dim result As String = oFacturaNeg.RegistrarVentaInternaSAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC"), strNumFact, CodAprobador)  'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            If (result <> "") Then
                MessageBox.Show(result, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim frm As New frmVistarptParteTransf()
            frm.PSCCMPN = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
            frm.PNCTPODC = oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim
            frm.PNNDCCTC = strNumFact
            frm.ShowDialog()

            If MsgBox("Desea Imprimir Sustento?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                Dim obj_Logica As New Factura_Transporte_BLL
                Dim objPrintForm As New PrintForm
                Dim objDsSustento As New DataSet
                Dim objDtSustento As New DataTable
                Dim objetoRepFact As New rptSustento_Transferencia

                Dim objParametroSustento As New Hashtable
                Dim strNumDE As String = String.Empty
                Try
                    If strNumFact.ToString.Trim.Length = 0 Then Exit Sub
                    objParametroSustento.Add("PNCTPODC", oDtCabFactura.Rows(0).Item("CTPODC"))
                    objParametroSustento.Add("PNNDCMFC", strNumFact.ToString)
                    objParametroSustento.Add("PSCCMPN", oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim)
                    objParametroSustento.Add("PSCDVSN", strCodDiv)
                    objDtSustento = HelpClass.GetDataSetNative(obj_Logica.Listar_Sustento_Factura(objParametroSustento))
                    objDtSustento.TableName = "RZCT01"

                    If objDtSustento.Rows.Count = 0 Then
                        MessageBox.Show("No tiene registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    objDsSustento.Tables.Add(objDtSustento.Copy)


                    Select Case oDtCabFactura.Rows(0).Item("CTPODC")

                        Case 6
                            objetoRepFact.SetDataSource(objDsSustento)
                            strNumDE = Obtener_Numero_Documento_Electronico(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = MainModule.USUARIO
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
                            CType(objetoRepFact.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "PTR N° " & strNumFact.ToString & "     " & strNumDE
                            objPrintForm.ShowForm(objetoRepFact, Me)
                         
                    End Select

                Catch : End Try
            End If
        End If
    End Sub

    Private Function Obtener_Numero_Documento_Electronico(ByVal pstrCompania As String, ByVal pstrTipoDoc As String, ByVal pstrNumFact As String) As String
        Dim oFiltro As Hashtable
        Dim oDt As New DataTable

        Dim oFacturaNegSAP As New Factura_Transporte_BLL
        Dim strNumSAPFE As String = String.Empty
        oFiltro = New Hashtable
        oFiltro.Add("PSCCMPN", pstrCompania)
        oFiltro.Add("PNCTPODC", pstrTipoDoc.ToString.Trim.PadLeft(3, "0"))
        oFiltro.Add("PNNDCCTC", pstrNumFact.ToString.Trim.PadLeft(10, "0"))
        oDt = oFacturaNegSAP.Comprobar_Envio_Documento_SAP(oFiltro)

        If oDt.Rows.Count > 0 Then
            strNumSAPFE = oDt.Rows(0).Item("NDCCTE").ToString.Trim
        End If

        Return strNumSAPFE

    End Function

    'Private Sub Cerrar_Orden_Interna_Hilos()
    '    Cerrar_Orden_Interna(hiloCompania, hiloTipoDoc, hiloNumFact)
    'End Sub

    'Private Sub Cerrar_Orden_Interna(ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long)
    '    Dim oFiltro As Hashtable
    '    Dim oValor As Int32 = 0
    '    Try
    '        oFiltro = New Hashtable
    '        oFiltro.Add("PSCCMPN", pstrCompania)
    '        oFiltro.Add("PSCTPODC", pstrTipoDoc)
    '        oFiltro.Add("PSNDCCTC", pstrNumFact)
    '        If oFacturaNeg.Cerrar_Orden_Interna_Factura(oFiltro) = 0 Then
    '            MessageBox.Show("Error al cerrar Orden / Interna Factura N° " & pstrNumFact.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    Catch : End Try

    'End Sub

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

            If oFacturaNeg.Registrar_Orden_Interna_Factura_General(oFiltro, False) = 0 Then
                MessageBox.Show("Error al enviar Orden / Interna Factura ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                oValor = 0
            Else
                oValor = 1
            End If

        Catch : End Try
        Return oValor
    End Function

    Private Sub btnImprimirfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirfactura.Click

      
        Select Case MessageBox.Show("Desea continuar con la emisión del documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                For intContador As Integer = 1 To Me.tabFactura.TabCount
                    Me.Grabar_Factura(intContador)
                    Me.lblNumFact.Tag = intContador
                Next

                Me.btnImprimirfactura.Visible = False
                Me.btnGenerar.Visible = False
                Me.lblNumFact.Tag = New Object
        End Select
    End Sub

    Private Sub Limpiar_Datos_Factura()
        oFacturaNeg.Limpiar_Datos_Factura()
    End Sub

    Private Sub tabFactura_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFactura.TabIndexChanged
        lblNumFact.Text = tabFactura.SelectedTab.Text.Trim
    End Sub

    

    


End Class


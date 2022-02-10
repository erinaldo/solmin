Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones


Public Class frmVistaFacturaElectronico


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
    'Private strCompFacImp As String
    Private strTipoDocFacImp As String
    Private lintCountFactura As Integer

    Private lintImprimir As Int32 = 0
    'Private ldtpFechaFactura As Date = Now
    Private ldtpFechaFactura As Date = Now.ToString("dd/MM/yyyy")
    Private lstrIGV As String = ""
    Private lhashIGV As New Hashtable
    'Private lintFATNSR As Int64 = 0
    Private lintFATNSR As Int64 = Now.ToString("yyyyMMdd")
    Private lhashItemFact As New Hashtable

 
    Private pValorizacionOK As Boolean = True
 
    Public EsXPreLiquidacion As Boolean = False

    Public pDialog As Boolean = False
    'Private _EsXPreLiquidacion As Boolean = False
    'Public Property EsXPreLiquidacion() As Boolean
    '    Get
    '        Return _EsXPreLiquidacion
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _EsXPreLiquidacion = value
    '    End Set
    'End Property



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

    Public PNNROPL As Decimal = 0
    Public EsxPreDocumento As Boolean = False
    '-----------------------------------
    'Private _EsxPreDocumento As Boolean = False
    'Public Property EsxPreDocumento() As Boolean
    '    Get
    '        Return _EsxPreDocumento
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _EsxPreDocumento = value
    '    End Set
    'End Property

    Public PreDocumento As String = ""

    'Private _PreDocumento As String
    'Public Property PreDocumento() As String
    '    Get
    '        Return _PreDocumento
    '    End Get
    '    Set(ByVal value As String)
    '        _PreDocumento = value
    '    End Set
    'End Property
    'Sub New(ByVal pstrConsistencia As String, ByVal pstrDivision As String, ByVal pstrCodDiv As String, ByVal pstrCodCom As String, ByVal pdblCliente As Double, ByVal pstrCodPlanta As String, ByVal pstrMoneda As String, ByVal pintZonaFacturacion As Int32, ByVal pstrOrgVenta As String, ByVal FechaFactura As Date, ByVal FechaAtencion As Int64, ValorizacionOK As Boolean)
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

    '    pValorizacionOK = ValorizacionOK
    'End Sub

    Sub New(ByVal pstrConsistencia As String, ByVal pstrDivision As String, ByVal pstrCodDiv As String, ByVal pstrCodCom As String, ByVal pdblCliente As Double, ByVal pstrCodPlanta As String, ByVal pstrMoneda As String, ByVal pintZonaFacturacion As Int32, ByVal pstrOrgVenta As String, ValorizacionOK As Boolean)
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
        'strOrgVenta = pstrOrgVenta
        'ldtpFechaFactura = FechaFactura
        'lintFATNSR = FechaAtencion

        pValorizacionOK = ValorizacionOK
    End Sub


    Private Sub frmVistaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim oDt As DataTable
            Dim oFiltro As New Hashtable
            lintCountFactura = 0
            oFiltro.Add("PNCMNDA1", "100")
            oFiltro.Add("PNFCMBO", Format(ldtpFechaFactura, "yyyyMMdd"))
            oFiltro.Add("PSCCMPN", strCodCom)

            Dim dtorgVenta As New DataTable
            dtorgVenta = oFacturaNeg.Lista_OrgVenta_Cliente(strCodCom, dblCliente)

            If dtorgVenta.Rows.Count > 0 Then
                strOrgVenta = ("" & dtorgVenta.Rows(0)("CRGVTA")).ToString.Trim
            End If
            If strOrgVenta.Length = 0 Then
                MessageBox.Show("Cliente sin Org Venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            txtorgventa.Text = strOrgVenta

            oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
            If oDt.Rows.Count > 0 Then
                dblTipoCambio = oDt.Rows(0).Item("IVNTA").ToString.Trim
                oFacturaNeg.TipoCambio = dblTipoCambio
                txtTipoCambio.Text = dblTipoCambio

                oFiltro.Add("PSCDVSN", strCodDiv)
                oFiltro.Add("PNCCLNT", dblCliente)
                oFiltro.Add("PSCUSCRT", USUARIO)
                oFacturaNeg.Llenar_Documentos_Electronico(oFiltro)
                If oFacturaNeg.oDtDocumentos.Rows.Count > 0 Then
                    oFacturaNeg.oTipoDocumento = oFacturaNeg.oDtDocumentos.Rows(0)("CTPODC")
                    oFacturaNeg.oFlagSoloConsulta = oFacturaNeg.oDtDocumentos.Rows(0)("FLAG_CONSULTA")
                End If
                Llenar_Combos()

                cmbPtoVenta.DataSource = oFacturaNeg.oDtDocumentos
                cmbPtoVenta.DisplayMember = "TOBSAD"
                cmbPtoVenta.ValueMember = "NPTOVT"
                If cmbPtoVenta.Items.Count <= 0 Then
                    btnGenerar.Visible = False
                Else
                    btnGenerar.Visible = True
                End If

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

        'If oDt.Rows.Count <= 0 Then
        '    btnGenerar.Visible = False
        'Else
        '    btnGenerar.Visible = True
        'End If

        'cmbGiro_SelectionChangeCommitted(cmbGiro, Nothing)

        oDt = New DataTable
        oFiltro.Add("PNCCLNFC", dblCliente)
        oDt = oFacturaNeg.Lista_Planta_Cliente(oFiltro)
        cmbPlantaCliente.DataSource = oDt
        cmbPlantaCliente.ValueMember = "CPLNCL"
        cmbPlantaCliente.DisplayMember = "TDRCPL"
        'If oDt.Rows.Count = 1 Then
        cmbPlantaCliente.SelectedValue = 1
        cmbPlantaCliente.Enabled = False
        Select Case oFacturaNeg.oTipoDocumento
            Case 1, 51
                Me.lblTipoDocumento.Text = "FACTURA"
            Case 7, 57
                Me.lblTipoDocumento.Text = "BOLETA"
            Case 6
                Me.lblTipoDocumento.Text = "PARTE TRANSFERENCIA"
                'btnGenerar.Visible = False
        End Select

    End Sub

    


    'Private Sub cmbGiro_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGiro.SelectionChangeCommitted
    '    Try

    '        Dim oFiltro As New Hashtable
    '        oFiltro.Add("CGRONG", cmbGiro.SelectedValue)
    '        cmbPtoVenta.DataSource = oFacturaNeg.Lista_Punto_Venta(oFiltro)
    '        cmbPtoVenta.DisplayMember = "TOBSAD"
    '        cmbPtoVenta.ValueMember = "NPTOVT"
    '        If cmbPtoVenta.Items.Count <= 0 Then
    '            btnGenerar.Visible = False
    '        Else
    '            btnGenerar.Visible = True
    '        End If

    '    Catch ex As Exception
    '        btnGenerar.Visible = False
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End Try
    'End Sub

    

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

                Dim objHash As New Hashtable
                objHash.Add("CCMPN", strCodCom.PadLeft(2, "0"))
                objHash.Add("CDVSN", strCodDiv)
                objHash.Add("CRGVTA", strOrgVenta.PadLeft(3, "0"))
                objHash.Add("CCLNT", dblCliente.ToString.PadLeft(6, "0"))
                Dim strEstado As String = ""

                Dim msjRef As String = ObtenerDatosCliente(strCodCom.Trim, dblCliente.ToString.Trim)

                Dim strResultado As String = oFacturaNeg.Validar_Cliente_SAP(objHash, strEstado)
                Select Case strEstado
                    Case ""
                        MessageBox.Show("ERROR : Ocurrió un Problema de Conexión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                    Case "B", "C", "D"
                        MessageBox.Show("ADVERTENCIA : " & "Cliente " & strResultado & Chr(13) & msjRef, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                        Exit Sub
                End Select

                REM ECM-HUNDRED-INICIO
                Dim objHash1 As New Hashtable
                objHash1.Add("CCMPN", strCodCom)
                objHash1.Add("PNCCLNT", dblCliente.ToString.Trim.PadLeft(6, "0"))

                Select Case oFacturaNeg.Validar_Cliente_Electronico_AS(objHash1)
                    Case ""
                        MessageBox.Show("ERROR : Ocurrio un Problema de Conexión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                    Case "1"
                        Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                    Case "0"
                        MessageBox.Show("Cliente no habilitado para electrónico." & Chr(13) & msjRef, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                    Case "2"
                        MessageBox.Show("Cliente no inscrito." & Chr(13) & msjRef, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                End Select
                REM ECM-HUNDRED-FIN

        Catch ex As Exception
            Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Function ObtenerDatosCliente(ByVal Compania As String, ByVal Cliente As String) As String
        Dim oOptionAccess As New SOLMIN_ST.NEGOCIO.Seguridad(MainModule.USUARIO)
        Dim dtCliente As DataTable = oOptionAccess.ListarDatosClientes(Compania, Cliente)
        Dim msjeRef As String = String.Empty
        Dim Descliente As String = String.Empty
        Dim codSap As String = String.Empty
        Dim sector As String = String.Empty
        Dim OrgVta As String = String.Empty

        If dtCliente.Rows.Count > 0 Then
            Descliente = dtCliente.Rows(0)("CCLNT").ToString.Trim() & " " & dtCliente.Rows(0)("TCMPCL").ToString.Trim()
            codSap = dtCliente.Rows(0)("CODSAP").ToString.Trim()
            sector = "(" & dtCliente.Rows(0)("CODSECTOR").ToString.Trim() & " " & dtCliente.Rows(0)("CRGVTA").ToString.Trim() & " )"
            sector = sector & dtCliente.Rows(0)("SECTOR").ToString.Trim() & " (Org. Vta " & dtCliente.Rows(0)("ORGVENTA").ToString.Trim() & " )"
            msjeRef = String.Format("Ref :{0} Cod SAP: {1} " & Environment.NewLine & "Sector: {2}", Descliente, codSap, sector)


        End If
        Return msjeRef
    End Function

    Private Sub Datos_Generales_Factura()
        Dim oDtNew As DataTable
        Dim oFiltro As New Hashtable
        Dim strCliente As String = ""
        oFiltro.Add("PNCCLNFC", dblCliente)
        oFiltro.Add("PSCCMPN", strCodCom)
        oDtNew = oFacturaNeg.Lista_Datos_Cliente(oFiltro)
        strCliente = "Sres.:".PadRight(130, " ") & "Código:    " & oDtNew.Rows(0).Item("CCLNT").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TCMPCL") & ("" & oDtNew.Rows(0).Item("TCMCL1"))
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TDRCOR").ToString.Trim & "    " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & IIf(oDtNew.Rows(0).Item("NRUC").ToString.Trim = "0", "", oDtNew.Rows(0).Item("NRUC").ToString.Trim) & " ".PadRight(90, " ") & "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(ldtpFechaFactura, "dd/MM/yyyy")
        Me.txtCliente.Text = strCliente
    End Sub

    Private Sub Generar_Factura()
        Dim intCant As Integer
        'Dim strOperacionSnPeso As String = ""

        intCant = Obtener_Cantidad_Facturas(EsxPreDocumento)
        'intCant = Obtener_Cantidad_Facturas(strOperacionSnPeso, EsxPreDocumento)
        
        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant)
            'Select Case _TipoVistaImpresion
            '    Case NEGOCIO.clsComun.VistaImpresion.Lote
            '        Mostrar_Factura_Lote()
            '    Case Else
            '        Mostrar_Factura(intCant)
            'End Select
            Mostrar_Factura(intCant)
            oFacturaNeg.Calcular_Vista_Impresion_Aux(oHasResumenVista, lhashIGV, _TipoVistaImpresion, intCant, oDtCabFactura)

            KryptonHeaderGroup1.Enabled = False
            Me.btnImprimirfactura.Visible = True
            Me.btnCancelarImpr.Visible = True

            'ElseIf intCant = -1 Then
            '    Me.btnCancelarImpr.Visible = False
            '    Me.btnImprimirfactura.Visible = False
            '    MessageBox.Show("No se Registró el Peso Volumen de las Operaciones : " & strOperacionSnPeso.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Me.btnCancelarImpr.Visible = False
            Me.btnImprimirfactura.Visible = False
            MessageBox.Show("No existen Facturas para crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If pValorizacionOK = False Then
            Me.btnImprimirfactura.Visible = False
        End If

    End Sub


    'Private Sub Mostrar_Factura_Lote()
    '    Dim octrlFact As ctrlFactura
    '    Dim X As Integer = 0
    '    Dim dt_LoteFacturaTemp As DataTable = oFacturaNeg.ObtieneLote()

    '    Dim view As DataView = New DataView(dt_LoteFacturaTemp)
    '    view.Sort = "NDCCTC"
    '    Dim dt_LoteFactura As New DataTable
    '    dt_LoteFactura = view.ToTable

    '    Dim drLoteSelect() As DataRow
    '    Dim tbFactura_Lote As TabControl
    '    Dim drItem As DataRow
    '    Dim dr As DataRow
    '    Dim lint_contador As Integer = 0
    '    Dim sb As System.Text.StringBuilder

    '    Dim oDtFactVista As DataTable
    '    Dim oDtFactVistaCopy As New DataTable
    '    oDtFactVistaCopy = oDtDetFactura.Clone()
    '    oHasResumenVista = New Hashtable


    '    tabFactura.TabPages.RemoveAt(0)
    '    For lint_row As Integer = 0 To dt_LoteFactura.Rows.Count - 1
    '        drItem = dt_LoteFactura.Rows(lint_row)
    '        Me.tabFactura.TabPages.Add(lint_contador, "LOTE : " & drItem.Item("LOTE").ToString())
    '        Me.tabFactura.TabPages.Item(lint_contador).UseVisualStyleBackColor = True
    '        tbFactura_Lote = New TabControl()
    '        tbFactura_Lote.Dock = DockStyle.Fill
    '        tbFactura_Lote.Name = "TAB_" & lint_row.ToString
    '        drLoteSelect = dt_LoteFactura.Select("LOTE= '" & drItem.Item("LOTE") & "' ")

    '        'Obtiene las Facturas Por Lote
    '        For i As Integer = 0 To drLoteSelect.Length - 1
    '            dr = drLoteSelect(i)
    '            tbFactura_Lote.TabPages.Add(i, "")
    '            tbFactura_Lote.TabPages(i).Tag = dr("NDCCTC").ToString
    '            tbFactura_Lote.TabPages.Item(i).UseVisualStyleBackColor = True
    '            tbFactura_Lote.TabPages(i).Text = Me.lblTipoDocumento.Text & " " & dr("NDCCTC").ToString




    '            oDtFactVista = oDtFactVistaCopy.Copy
    '            Dim numFact As Int32 = 0
    '            For Each item As DataRow In oDtDetFactura.Rows
    '                If item("NDCCTC") = dr("NDCCTC").ToString Then
    '                    numFact = item("NDCCTC")
    '                    oDtFactVista.ImportRow(item)
    '                End If
    '            Next
    '            oHasResumenVista.Add(numFact, oDtFactVista)

    '            Dim ValorReferencial As Decimal = 0
    '            Dim PorcentajeDetraccion As Decimal = 0

    '            If oDtCabFactura.Rows.Count > 0 Then
    '                ValorReferencial = Convert.ToDecimal(oDtCabFactura.Rows(lint_contador).Item("VLRFDT").ToString)
    '                PorcentajeDetraccion = Convert.ToDecimal(oDtCabFactura.Rows(lint_contador).Item("NDSPGD").ToString)
    '            End If




    '            octrlFact = New ctrlFactura(oDtDetFactura, dr("NDCCTC").ToString, strMoneda, lhashIGV(Integer.Parse(dr("NDCCTC").ToString)).ToString.Trim, 0, oFacturaNeg.oTipoDocumento, ctrlFactura.FormatoVista.Electronico, ValorReferencial, PorcentajeDetraccion)

    '            octrlFact.NumFactura = "N°          "
    '            sb = New System.Text.StringBuilder()
    '            sb.Append("RUTA: ")
    '            sb.Append(oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom))
    '            sb.AppendLine()
    '            sb.Append("LOTE : ")
    '            sb.Append(drItem.Item("LOTE").ToString())
    '            octrlFact.Referencia1 = sb.ToString
    '            tbFactura_Lote.TabPages(i).Controls.Add(octrlFact)
    '        Next
    '        'Añade el nuevo Tab al Tab de Principal
    '        Me.tabFactura.TabPages(lint_contador).Controls.Add(tbFactura_Lote)
    '        lint_row = lint_row + drLoteSelect.Length - 1
    '        lint_contador = lint_contador + 1
    '    Next
    'End Sub

    Private oHasResumenVista As Hashtable
    Private Sub Mostrar_Factura(ByVal intCant As Integer)
        Dim octrlFact As ctrlFactura
        Dim X As Integer = 0

        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True
        Next X

        oHasResumenVista = New Hashtable

        Dim RefCabecera As String = oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom)

        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = Me.lblTipoDocumento.Text

            Dim ValorReferencial As Decimal = 0
            Dim PorcentajeDetraccion As Decimal = 0
            Dim OrdenCompraCliente As String = ""

            If oDtCabFactura.Rows.Count > 0 Then
                ValorReferencial = Convert.ToDecimal(oDtCabFactura.Rows(lint_Contador).Item("VLRFDT").ToString)
                PorcentajeDetraccion = Convert.ToDecimal(oDtCabFactura.Rows(lint_Contador).Item("NDSPGD").ToString)
                OrdenCompraCliente = ("" & oDtCabFactura.Rows(lint_Contador).Item("OCOMPRA")).ToString.Trim
            End If

            Select Case _TipoVistaImpresion
                Case NEGOCIO.clsComun.VistaImpresion.Normal

                    Dim oDtFactVista As DataTable = oDtDetFactura.Clone
                    For Each item As DataRow In oDtDetFactura.Rows
                        If Val(item("NDCCTC")) = lint_Contador + 1 Then
                            oDtFactVista.ImportRow(item)
                        End If
                    Next

                    oHasResumenVista.Add(lint_Contador + 1, oDtFactVista)

                    octrlFact = New ctrlFactura(oDtDetFactura, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 0, oFacturaNeg.oTipoDocumento, ctrlFactura.FormatoVista.Electronico, ValorReferencial, PorcentajeDetraccion, OrdenCompraCliente)

                    octrlFact.NumFactura = "N°          "
                    'octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom)
                    octrlFact.Referencia1 = "RUTA: " & RefCabecera
                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)

                Case NEGOCIO.clsComun.VistaImpresion.Resumido

                    oDtDetFacturaDetallada = Mostrar_Factura_Consolidada(lint_Contador + 1, oDtDetFactura.Copy, lhashIGV(lint_Contador + 1))

                    oHasResumenVista.Add(lint_Contador + 1, oDtDetFacturaDetallada.Copy)

                    octrlFact = New ctrlFactura(oDtDetFacturaDetallada, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 0, oFacturaNeg.oTipoDocumento, ctrlFactura.FormatoVista.Electronico, ValorReferencial, PorcentajeDetraccion, OrdenCompraCliente)

                    octrlFact.NumFactura = "N°          "

                    'octrlFact.OCompra = "" 'OMVB

                    'octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom)
                    octrlFact.Referencia1 = "RUTA: " & RefCabecera

                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
                    lhashItemFact.Add(lint_Contador + 1, octrlFact.dtgDetalle.RowCount)

                Case NEGOCIO.clsComun.VistaImpresion.Detallado

                    oDtDetFacturaDetallada = Mostrar_Factura_Detallada(lint_Contador + 1, oDtDetFactura.Copy, lhashIGV(lint_Contador + 1))




                    oHasResumenVista.Add(lint_Contador + 1, oDtDetFacturaDetallada.Copy)

                    octrlFact = New ctrlFactura(oDtDetFacturaDetallada, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 0, oFacturaNeg.oTipoDocumento, ctrlFactura.FormatoVista.Electronico, ValorReferencial, PorcentajeDetraccion, OrdenCompraCliente)
                    octrlFact.NumFactura = "N°          "
                    'octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion, strCodCom)
                    octrlFact.Referencia1 = "RUTA: " & RefCabecera
                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
                    lhashItemFact.Add(lint_Contador + 1, octrlFact.dtgDetalle.RowCount)

            End Select
           
        Next
    End Sub

   
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



    'Private Function Obtener_Cantidad_Facturas(ByRef strOperacionSnPeso As String) As Integer
    '    Dim oFiltro As New Hashtable
    '    oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
    '    oFiltro.Add("PSCCMPN", strCodCom)
    '    oFiltro.Add("PSCMNDA", strMoneda)
    '    oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
    '    oFiltro.Add("PNFATNSR", lintFATNSR)
    '    oFiltro.Add("PSOPERACIONES", strOperacionSnPeso)
    '    Dim returnCant As Integer

    '    Select Case _TipoVistaImpresion

    '        Case NEGOCIO.clsComun.VistaImpresion.Lote
    '            Dim frmLote As New frmlotefactura
    '            frmLote.odtListLote = oFacturaNeg.Traer_Facturas_Lote_General(oFiltro).Copy
    '            frmLote.ShowDialog()
    '            returnCant = oFacturaNeg.Cantidad_Facturas_Lote_General(oFiltro, frmLote.odtListLote)
    '            strOperacionSnPeso = oFiltro("PSOPERACIONES")
    '        Case Else
    '            returnCant = oFacturaNeg.Cantidad_Facturas_General(oFiltro)
    '    End Select

    '    Return returnCant
    'End Function

    'FIXSUMMIT-20200124
    'Private Function Obtener_Cantidad_Facturas(ByRef strOperacionSnPeso As String, ByVal EsXPreDocumento As Boolean) As Integer
    Private Function Obtener_Cantidad_Facturas(ByVal EsXPreDocumento As Boolean) As Integer
        Dim oFiltro As New Hashtable
        oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
        oFiltro.Add("PSPREDOC", PreDocumento)
        oFiltro.Add("PNNROPL", PNNROPL)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCMNDA", strMoneda)
        oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PNFATNSR", lintFATNSR)
        'oFiltro.Add("PSOPERACIONES", strOperacionSnPeso)
        Dim returnCant As Integer

        If EsXPreDocumento = True Then
            returnCant = oFacturaNeg.Cantidad_Facturas_General_Predocumentos(oFiltro)
        Else
            returnCant = oFacturaNeg.Cantidad_Facturas_General(oFiltro)
        End If

        'Select Case _TipoVistaImpresion

        '    Case NEGOCIO.clsComun.VistaImpresion.Lote
        '        Dim frmLote As New frmlotefactura
        '        frmLote.odtListLote = oFacturaNeg.Traer_Facturas_Lote_General(oFiltro).Copy
        '        frmLote.ShowDialog()
        '        returnCant = oFacturaNeg.Cantidad_Facturas_Lote_General(oFiltro, frmLote.odtListLote)
        '        strOperacionSnPeso = oFiltro("PSOPERACIONES")
        '    Case Else
        '        If EsXPreDocumento = True Then
        '            returnCant = oFacturaNeg.Cantidad_Facturas_General_Predocumentos(oFiltro)
        '        Else
        '            returnCant = oFacturaNeg.Cantidad_Facturas_General(oFiltro)
        '        End If
        'End Select

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

        'oFiltro.Add("PNOCompra", strOCompra) 'OMVB REQ11072019


        oFacturaNeg.PuntoVenta = cmbPtoVenta.SelectedValue
        oFacturaNeg.GiroNegocio = cmbGiro.SelectedValue
        oFacturaNeg.PlantaCliente = cmbPlantaCliente.SelectedValue
        oDtCabFactura = oFacturaNeg.Lista_Cabecera_Factura(oFiltro)
        Me.dtgCabeceraFactura.DataSource = oDtCabFactura
    End Sub


    'Private Sub Generar_Detalles(ByVal pintCant As Integer)
    '    Dim oFiltro As New Hashtable
    '    oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
    '    oFiltro.Add("CANTFACT", pintCant)
    '    oFiltro.Add("PSCCMPN", strCodCom)
    '    oFiltro.Add("PSCMNDA", strMoneda)
    '    oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
    '    oFiltro.Add("PNFATNSR", lintFATNSR)


    '    Select Case _TipoVistaImpresion
    '        Case NEGOCIO.clsComun.VistaImpresion.Lote
    '            oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura_Lote_General(oFiltro, lhashIGV, _EsXPreLiquidacion)
    '        Case Else
    '            oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura_General(oFiltro, lhashIGV, _EsXPreLiquidacion)
    '    End Select

    '    Me.dtgDetalleFactura.DataSource = oDtDetFactura
    'End Sub

    Private Sub Generar_Detalles(ByVal pintCant As Integer)
        Dim oFiltro As New Hashtable
        oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
        oFiltro.Add("PSPREDOC", PreDocumento)
        oFiltro.Add("PNNROPL", PNNROPL)
        oFiltro.Add("CANTFACT", pintCant)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCMNDA", strMoneda)
        oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PNFATNSR", lintFATNSR)
        '------------------------------------------------------------------------------
        'Select Case _TipoVistaImpresion
        '    Case NEGOCIO.clsComun.VistaImpresion.Lote
        '        oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura_Lote_General(oFiltro, lhashIGV, _EsXPreLiquidacion)
        '    Case Else
        '        oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura_General(oFiltro, lhashIGV, _EsXPreLiquidacion, _EsxPreDocumento) '20200121-FACTPLUS

        'End Select
        oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura_General(oFiltro, lhashIGV, EsXPreLiquidacion, EsxPreDocumento) '20200121-FACTPLUS
        '------------------------------------------------------------------------------
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub


    Private Sub Grabar_Factura(ByVal pintFact As Integer)
        Dim strNumFact As Int64 = 0
        Dim objFiltro As New Hashtable
        Dim intValor As Int32 = 0
        Dim dtVistaFact As New DataTable
        Dim RefCabecera As String = ""
        Dim RefDetalle As String = ""
        Dim strOCompra As String 'OMVB REQ11072019
        'Dim msgReversionProv As String = ""
        'Dim msgErrorGeneracion As String = ""
        'Dim msjeGeneracionFac As String = ""
        Dim msgerror As String = ""
        Dim msjeGeneracionFac As String = ""

        Try
            lstrIGV = lhashIGV(pintFact).ToString.Trim
            dtVistaFact = oHasResumenVista(pintFact)
            'OMVB REQ11072019 ORDEN DE COMPRA
            strOCompra = CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).txtOCompra.Text.Trim
            RefCabecera = ("" & CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia1).ToString.Trim
            RefDetalle = ("" & CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia2).ToString.Trim
            If strOCompra <> "" Then
                RefCabecera = "OC:" & strOCompra & " " & RefCabecera
            End If
            ' Dim myRow() As Data.DataRow
            ' myRow = oDtCabFactura.Select("PNOCompra = ''")
            ' myRow(0)("PNOCompra") = OCompraVFE
            'oDtCabFactura.Rows(0)("OCompra") = OCompraVFE
            'OMVB REQ11072019 ORDEN DE COMPRA
            oFacturaNeg.Grabar_Factura_General(pintFact, oDtCabFactura, oDtDetFactura, strNumFact, dtVistaFact, lstrIGV, _TipoVistaImpresion, True, strOCompra, EsxPreDocumento)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 1, oDtCabFactura, RefCabecera)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 2, oDtCabFactura, RefDetalle)
            intValor = Registrar_Orden_Interna_Factura(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact, CType(oDtCabFactura.Rows(0).Item("FDCCTC").ToString.Trim, Int64))
            tabFactura.TabPages(pintFact - 1).Text = lblTipoDocumento.Text.Trim & " N°" & strNumFact

            CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).NumFactura = "N° " & strNumFact
            lblNumFact.Text = "N° " & strNumFact
        Catch ex As Exception
            strNumFact = 0
            MessageBox.Show("Error al grabar el documento " & Chr(10) & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If strNumFact <> 0 Then
            'habilitar en produccion 
            'Dim msgEnvioSAP As String = ""
            msjeGeneracionFac = "Se grabó correctamente la " & lblTipoDocumento.Text.Trim & " N° " & strNumFact

            If intValor > 0 Then
                msgerror = Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
            End If
            If msgerror.Length > 0 Then
                msjeGeneracionFac = msjeGeneracionFac & Chr(10) & msgerror
                'msgErrorGeneracion = msgErrorGeneracion.Trim
            End If


            'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
            Try
                objFiltro = New Hashtable
                objFiltro("PSCCMPN") = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                objFiltro("PNCTPODC") = oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim
                objFiltro("PNNDCMFC") = strNumFact.ToString
                oFacturaNeg.fintRevertirProvisionXFactura(objFiltro, EsxPreDocumento)

                Dim oDt As DataTable
                oDt = Estimacion_Ingreso_Revertir(strNumFact)

              


                'Invocar el Servicio Web con los parametros devueltos del SP
                'If Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.Server = "RANSA" Then


                If oDt.Rows.Count > 0 Then

                    Dim dt_url_servicio As New DataTable
                    Dim oda_url_servicio As New NEGOCIO.UrlServicios_BLL
                    dt_url_servicio = oda_url_servicio.Listar_Url_Servicio("SDESTSAPSALM", "", "", 0)
                    Dim url_ws_servicio As String = ""
                    If dt_url_servicio.Rows.Count > 0 Then
                        url_ws_servicio = ("" & dt_url_servicio.Rows(0)("URL")).ToString.Trim
                    End If


                    Dim IdEstimacion As Double, AnioContaSap As Double, FechaDocCtaCte As Double
                    Dim NroDocEstimacionSap As String, CodSociedadSap As String, NumDocElectronico As String

                    For index As Integer = 0 To oDt.Rows.Count - 1
                        IdEstimacion = oDt.Rows(index).Item("IDESTM")
                        NroDocEstimacionSap = oDt.Rows(index).Item("NDESAP").ToString.Trim
                        CodSociedadSap = oDt.Rows(index).Item("CSCDSP").ToString.Trim
                        AnioContaSap = oDt.Rows(index).Item("ACNTSP")
                        NumDocElectronico = oDt.Rows(index).Item("NDCCTE").ToString.Trim
                        FechaDocCtaCte = oDt.Rows(index).Item("FDCFCC").ToString.Trim
                        'INI-ECM-ActualizacionTarifario[RF001]-160516
                        Dim wssalmon As New NEGOCIO.ws_reversion_Ingreso.ws_salmon
                        wssalmon.Url = url_ws_servicio
                        wssalmon.ws_reversion_ingreso(IdEstimacion, CodSociedadSap, NroDocEstimacionSap, AnioContaSap, NumDocElectronico, FechaDocCtaCte)
                        'FIN-ECM-ActualizacionTarifario[RF001]-160516
                    Next
                End If

                'End If

            Catch ex As Exception
                msgerror = "REVERSION PROVISION : " & ex.Message
            End Try
            'Dim msgGeneral As String = "Se grabó correctamente la " & lblTipoDocumento.Text.Trim & " N° " & strNumFact
            'If msgEnvioSAP.Length > 0 Then
            '    msgGeneral = msgGeneral & Chr(10) & msgEnvioSAP
            'End If
            If msgerror.Length > 0 Then
                msjeGeneracionFac = msjeGeneracionFac & Chr(10) & msgerror
                'msgErrorGeneracion = msgErrorGeneracion.Trim
            End If
            'msgGeneral = (msgGeneral & Chr(10) & msgErrorGeneracion).Trim

            'CSR-HUNDRED-ESTIMACION-INGRESO-FIN
            MessageBox.Show(msjeGeneracionFac, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("Se grabó correctamente la " & lblTipoDocumento.Text.Trim & " N° " & strNumFact, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'If MsgBox("Desea Imprimir Sustento?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            '    Dim obj_Logica As New Factura_Transporte_BLL
            '    Dim objPrintForm As New PrintForm
            '    Dim objDsSustento As New DataSet
            '    Dim objDtSustento As New DataTable
            '    Dim objetoRepFact As New rptSustento_Factura
            '    Dim objetoRepBole As New rptSustento_Boleta
            '    Dim objParametroSustento As New Hashtable
            '    Dim strNumDE As String = String.Empty
            '    'Try
            '    If strNumFact.ToString.Trim.Length = 0 Then Exit Sub
            '    objParametroSustento.Add("PNCTPODC", oDtCabFactura.Rows(0).Item("CTPODC"))
            '    objParametroSustento.Add("PNNDCMFC", strNumFact.ToString)
            '    objParametroSustento.Add("PSCCMPN", oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim)
            '    objParametroSustento.Add("PSCDVSN", strCodDiv)
            '    objDtSustento = HelpClass.GetDataSetNative(obj_Logica.Listar_Sustento_Factura(objParametroSustento))
            '    objDtSustento.TableName = "RZCT01"

            '    If objDtSustento.Rows.Count = 0 Then
            '        MessageBox.Show("No tiene registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Exit Sub
            '    End If
            '    objDsSustento.Tables.Add(objDtSustento.Copy)


            '    Select Case oDtCabFactura.Rows(0).Item("CTPODC")
            '        Case 51
            '            objetoRepFact.SetDataSource(objDsSustento)
            '            strNumDE = Obtener_Numero_Documento_Electronico(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
            '            CType(objetoRepFact.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = MainModule.USUARIO
            '            CType(objetoRepFact.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
            '            CType(objetoRepFact.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
            '            CType(objetoRepFact.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
            '            CType(objetoRepFact.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "FACTURA N° " & strNumFact.ToString & "     " & strNumDE
            '            objPrintForm.ShowForm(objetoRepFact, Me)
            '        Case 57
            '            objetoRepBole.SetDataSource(objDsSustento)
            '            strNumDE = Obtener_Numero_Documento_Electronico(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
            '            CType(objetoRepBole.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = MainModule.USUARIO
            '            CType(objetoRepBole.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
            '            CType(objetoRepBole.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
            '            CType(objetoRepBole.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
            '            CType(objetoRepBole.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "BOLETA DE VENTA N° " & strNumFact.ToString & "     " & strNumDE
            '            objPrintForm.ShowForm(objetoRepBole, Me)
            '    End Select

            '    'Catch : End Try
            'End If
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

    'Private Sub Grabar_Factura_Lote(ByVal pintFact As Integer, ByRef tabFacturaTemp As TabPage)
    '    Dim strNumFact As Int64 = 0
    '    Dim objFiltro As New Hashtable 'Filtro
    '    Dim intValor As Int32 = 0
    '    Dim dtVistaFact As New DataTable
    '    Dim ctrlVisorFactura As ctrlFactura = CType(tabFacturaTemp.Controls(0), ctrlFactura)
    '    Try
    '        lstrIGV = lhashIGV(pintFact).ToString.Trim

    '        dtVistaFact = oHasResumenVista(pintFact)

    '        oFacturaNeg.Grabar_Factura_Lote_General(pintFact, oDtCabFactura, oDtDetFactura, strNumFact, lstrIGV, dtVistaFact, _TipoVistaImpresion)



    '        oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 1, oDtCabFactura, ctrlVisorFactura.Referencia1)
    '        oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 2, oDtCabFactura, ctrlVisorFactura.Referencia2)
    '        'omvb
    '        oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 3, oDtCabFactura, ctrlVisorFactura.OCompra)
    '        'omvb


    '        intValor = Registrar_Orden_Interna_Factura_Lote(pintFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact, CType(oDtCabFactura.Rows(0).Item("FDCCTC").ToString.Trim, Int64))

    '        tabFacturaTemp.Text = "Factura N°" & strNumFact
    '        ctrlVisorFactura.NumFactura = "N° " & strNumFact
    '        lblNumFact.Text = "N° " & strNumFact
    '    Catch ex As Exception

    '        strNumFact = 0
    '        MessageBox.Show("Error al grabar la factura " & vbCrLf & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    If strNumFact <> 0 Then

    '        MessageBox.Show("Se grabó correctamente la Factura N° " & strNumFact, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        'habilitar en produccion 

    '        If intValor > 0 Then
    '            Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
    '        End If



    '        If MsgBox("Desea Imprimir Sustento?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then

    '            Dim objPrintForm As New PrintForm
    '            Dim objDsSustento As New DataSet
    '            Dim objDtSustento As New DataTable
    '            Dim objetoRepFact As New rptSustento_Factura
    '            Dim objetoRepBole As New rptSustento_Boleta
    '            Dim objParametroSustento As New Hashtable
    '            Dim strNumDE As String = String.Empty
    '            'Try
    '            If strNumFact.ToString.Trim.Length = 0 Then Exit Sub
    '            objParametroSustento.Add("PNCTPODC", oDtCabFactura.Rows(0).Item("CTPODC"))
    '            objParametroSustento.Add("PNNDCMFC", strNumFact.ToString)
    '            objParametroSustento.Add("PSCCMPN", oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim)
    '            objParametroSustento.Add("PSCDVSN", strCodDiv)

    '            Dim drSelect As DataRow()
    '            drSelect = oFacturaNeg.ObtieneServicios_Factura(pintFact)

    '            objDtSustento = HelpClass.GetDataSetNative(oFacturaNeg.Listar_Sustento_Factura_Lote(objParametroSustento, drSelect))
    '            objDtSustento.TableName = "RZCT01"

    '            If objDtSustento.Rows.Count = 0 Then
    '                MessageBox.Show("No tiene registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Exit Sub
    '            End If
    '            objDsSustento.Tables.Add(objDtSustento.Copy)

    '            Select Case oDtCabFactura.Rows(0).Item("CTPODC")
    '                Case 51
    '                    objetoRepFact.SetDataSource(objDsSustento)
    '                    strNumDE = Obtener_Numero_Documento_Electronico(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
    '                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = MainModule.USUARIO
    '                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
    '                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
    '                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
    '                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "FACTURA N° " & strNumFact.ToString
    '                    CType(objetoRepFact.ReportDefinition.ReportObjects("lblNumDE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strNumDE
    '                    objPrintForm.ShowForm(objetoRepFact, Me)
    '                Case 57
    '                    objetoRepBole.SetDataSource(objDsSustento)
    '                    strNumDE = Obtener_Numero_Documento_Electronico(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
    '                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = MainModule.USUARIO
    '                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
    '                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
    '                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
    '                    CType(objetoRepBole.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "BOLETA DE VENTA N° " & strNumFact.ToString & "   " & strNumDE
    '                    objPrintForm.ShowForm(objetoRepBole, Me)
    '            End Select

    '            'Catch : End Try
    '        End If
    '    End If
    'End Sub

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

    Private Function Enviar_Factura_SAP(ByVal pstrCompania As String, ByVal pstrTipoDoc As String, ByVal pstrNumFact As String) As String
        Dim oFiltro As Hashtable
        Dim oDt As DataTable
        Dim strNumSAP As String = ""
        Dim msg As String = ""
        Try
            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PSCTPODC", pstrTipoDoc.ToString.Trim.PadLeft(3, "0"))
            oFiltro.Add("PSNDCCTC", pstrNumFact.ToString.Trim.PadLeft(10, "0"))
            oFacturaNeg.Enviar_Documento_SAP_FE(oFiltro)

            oFiltro = New Hashtable
            oFiltro.Add("PSCCMPN", pstrCompania)
            oFiltro.Add("PNCTPODC", pstrTipoDoc.ToString.Trim.PadLeft(3, "0"))
            oFiltro.Add("PNNDCCTC", pstrNumFact.ToString.Trim.PadLeft(10, "0"))
            oDt = oFacturaNeg.Comprobar_Envio_Documento_SAP(oFiltro)

            If oDt.Rows.Count > 0 Then
                strNumSAP = oDt.Rows(0).Item("NDCMSP").ToString.Trim

            Else
                msg = "ENVIO SAP : No se generó el documento SAP"
                '  MessageBox.Show("No se generó el documento SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            msg = "ENVIO SAP : Error al enviar documento al SAP " & ex.Message
            'MessageBox.Show("Error al enviar documento al SAP " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return msg
    End Function


    Private Function Registrar_Orden_Interna_Factura(ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long, ByVal pintFecFac As Int64) As Int32
        Dim oFiltro As Hashtable
        Dim oValor As Int32 = 0
        'Try
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
        oValor = oFacturaNeg.Registrar_Orden_Interna_Factura_General(oFiltro, EsxPreDocumento)
        'If oFacturaNeg.Registrar_Orden_Interna_Factura_General(oFiltro) = 0 Then
        '    MessageBox.Show("Error al enviar Orden / Interna Factura ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    oValor = 0
        'Else
        '    oValor = 1
        'End If
        'Catch : End Try
        Return oValor
    End Function


    'Private Function Registrar_Orden_Interna_Factura_Lote(ByVal pintFact As Integer, ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long, ByVal pintFecFac As Int64) As Int32
    '    Dim oFiltro As Hashtable
    '    Dim oValor As Int32 = 0
    '    'Try
    '    oFiltro = New Hashtable
    '    oFiltro.Add("PSCCMPN", pstrCompania)
    '    oFiltro.Add("PSCTPODC", pstrTipoDoc)
    '    oFiltro.Add("PSNDCCTC", pstrNumFact)


    '    'Crea los Parametros para la Temporal
    '    Dim drSelect As DataRow() = Nothing
    '    Dim sbNOPRCN As New System.Text.StringBuilder()
    '    Dim sbNGUIRM As New System.Text.StringBuilder()
    '    Dim sbCSRVC As New System.Text.StringBuilder()
    '    Dim sbISRVGU As New System.Text.StringBuilder()

    '    drSelect = oFacturaNeg.ObtieneServicios_Factura(pintFact)
    '    For row As Integer = 0 To drSelect.Length - 1
    '        sbNOPRCN.Append(drSelect(row).Item("NOPRCN"))
    '        sbNGUIRM.Append(drSelect(row).Item("NGUIRM"))
    '        sbCSRVC.Append(drSelect(row).Item("CRBCTC"))
    '        sbISRVGU.Append(drSelect(row).Item("ISRVGU"))
    '        If row < drSelect.Length - 1 Then
    '            sbNOPRCN.Append(",")
    '            sbNGUIRM.Append(",")
    '            sbCSRVC.Append(",")
    '            sbISRVGU.Append(",")
    '        End If
    '    Next

    '    oFiltro.Add("PSNOPRCN", sbNOPRCN.ToString)
    '    oFiltro.Add("PSNGUIRM", sbNGUIRM.ToString)
    '    oFiltro.Add("PSCSRVC", sbCSRVC.ToString)
    '    oFiltro.Add("PSISRVGU", sbISRVGU.ToString)

    '    oFiltro.Add("PNFECFAC", pintFecFac)
    '    If Me.strMoneda.Trim = "DOL" Then
    '        oFiltro.Add("PNMONEDA", 100)
    '    Else
    '        oFiltro.Add("PNMONEDA", 1)
    '    End If

    '    If oFacturaNeg.Registrar_Orden_Interna_Factura_Lote(oFiltro) = 0 Then
    '        MessageBox.Show("Error al enviar Orden / Interna Factura ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        oValor = 0
    '    Else
    '        oValor = 1
    '    End If

    '    'Catch : End Try
    '    Return oValor
    'End Function

    Private Sub btnImprimirfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirfactura.Click

        Try
            Dim strEstado As String = ""

            Select Case MessageBox.Show("Se procederá a facturar y enviar el documento electrónico. ¿Está seguro de continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                Case Windows.Forms.DialogResult.Yes
                    lintImprimir = 2
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            End Select
            'Dim tabLoteFactura As TabControl
            'Select Case _TipoVistaImpresion
            '    Case NEGOCIO.clsComun.VistaImpresion.Lote
            '        For intContador As Integer = 0 To Me.tabFactura.TabCount - 1
            '            tabLoteFactura = CType(Me.tabFactura.TabPages(intContador).Controls(0), TabControl)
            '            For i As Integer = 0 To tabLoteFactura.TabCount - 1
            '                Grabar_Factura_Lote(Integer.Parse(tabLoteFactura.TabPages(i).Tag), CType(tabLoteFactura.TabPages(i), TabPage))
            '                Me.lblNumFact.Tag = Integer.Parse(tabLoteFactura.TabPages(i).Tag)
            '            Next
            '        Next
            '    Case Else
            '        For intContador As Integer = 1 To Me.tabFactura.TabCount
            '            Grabar_Factura(intContador)
            '            Me.lblNumFact.Tag = intContador
            '        Next
            'End Select
            pDialog = True
            For intContador As Integer = 1 To Me.tabFactura.TabCount
                Grabar_Factura(intContador)
                Me.lblNumFact.Tag = intContador
            Next
            Me.btnImprimirfactura.Visible = False
            Me.btnGenerar.Visible = False
            Me.lblNumFact.Tag = New Object
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Limpiar_Datos_Factura()
        oFacturaNeg.Limpiar_Datos_Factura()
    End Sub

    Private Sub tabFactura_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFactura.TabIndexChanged
        lblNumFact.Text = tabFactura.SelectedTab.Text.Trim
    End Sub

    'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
    Private Function Estimacion_Ingreso_Revertir(ByVal strNumFact As Long) As DataTable
        Dim oDtNew As DataTable
        Dim oFiltro As New Hashtable
        Dim oFactura_Transporte_BLL As New Factura_Transporte_BLL
        oFiltro.Add("PSCCMPN", oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim) 'Compañía
        oFiltro.Add("PNCTPODC", oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim) 'Tipo de Documento
        oFiltro.Add("PNNDCFCC", strNumFact) 'Nro. Documento 
        oFiltro.Add("PNNSECFC", 0) 'Nro. Revisión
        oDtNew = oFactura_Transporte_BLL.Estimacion_Ingreso_Revertir(oFiltro)
        Return oDtNew
    End Function

    'CSR-HUNDRED-ESTIMACION-INGRESO-FIN

End Class


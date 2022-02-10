Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports System.Text
Public Class frmVistaReFacturaElectronico

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

    Private oDtCabFactura As DataTable
    Private oDtDetFactura As DataTable
    Private oDtDetFacturaDetallada As DataTable
    Private dblNumFacImp As Int64
    Private strCompFacImp As String
    Private strTipoDocFacImp As String
    Private lintCountFactura As Integer

    Private lintImprimir As Int32 = 0

    Private lstrIGV As String = ""
    Private lhashIGV As New Hashtable
    Private lintFATNSR As Int64 = 0
    Private lhashItemFact As New Hashtable
    'Private _dtListaServicioDoc As New DataTable
    Public dtListaServicioDoc As New DataTable

    Public TipoVistaImpresion As NEGOCIO.clsComun.VistaImpresion = NEGOCIO.clsComun.VistaImpresion.Neutro

    'Private _TipoVistaImpresion As NEGOCIO.clsComun.VistaImpresion = NEGOCIO.clsComun.VistaImpresion.Neutro
    'Public Property TipoVistaImpresion() As NEGOCIO.clsComun.VistaImpresion
    '    Get
    '        Return _TipoVistaImpresion
    '    End Get
    '    Set(ByVal value As NEGOCIO.clsComun.VistaImpresion)
    '        _TipoVistaImpresion = value
    '    End Set
    'End Property

    'Public Property dtListaServicioDoc() As DataTable
    '    Get
    '        Return _dtListaServicioDoc
    '    End Get
    '    Set(ByVal value As DataTable)
    '        _dtListaServicioDoc = value
    '    End Set
    'End Property

    Public oHashListaOpeLiberar As New Hashtable
    'Private _oHashListaOpeLiberar As New Hashtable
    'Public Property oHashListaOpeLiberar() As Hashtable
    '    Get
    '        Return _oHashListaOpeLiberar
    '    End Get
    '    Set(ByVal value As Hashtable)
    '        _oHashListaOpeLiberar = value
    '    End Set
    'End Property

    Public TipoDocumentoEmision As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento = NEGOCIO.clsComun.TipoDocumento.Neutro

    'Private _TipoDocumentoEmision As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento = NEGOCIO.clsComun.TipoDocumento.Neutro
    'Public Property TipoDocumentoEmision() As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento
    '    Get
    '        Return _TipoDocumentoEmision
    '    End Get
    '    Set(ByVal value As SOLMIN_ST.NEGOCIO.clsComun.TipoDocumento)
    '        _TipoDocumentoEmision = value
    '    End Set
    'End Property


    Public EsXPreLiquidacion As Boolean = False

    'Private _EsXPreLiquidacion As Boolean = False
    'Public Property EsXPreLiquidacion() As Boolean
    '    Get
    '        Return _EsXPreLiquidacion
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _EsXPreLiquidacion = value
    '    End Set
    'End Property

    Public ldtpFechaFactura As Date = Date.Now

    'Private _ldtpFechaFactura As Date = Date.Now
    'Public Property ldtpFechaFactura() As Date
    '    Get
    '        Return _ldtpFechaFactura
    '    End Get
    '    Set(ByVal value As Date)
    '        _ldtpFechaFactura = value
    '    End Set
    'End Property

   
    Public TipoDocOrigen As String = ""

    'Private _TipoDocOrigen As String = ""
    'Public Property TipoDocOrigen() As String
    '    Get
    '        Return _TipoDocOrigen
    '    End Get
    '    Set(ByVal value As String)
    '        _TipoDocOrigen = value
    '    End Set
    'End Property

    Public NumDocOrigen As Decimal = 0

    'Private _NumDocOrigen As Decimal = 0
    'Public Property NumDocOrigen() As Decimal
    '    Get
    '        Return _NumDocOrigen
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _NumDocOrigen = value
    '    End Set
    'End Property


    Public FechaDocOrigen As Decimal = 0

    'Private _FechaDocOrigen As Decimal = 0
    'Public Property FechaDocOrigen() As Decimal
    '    Get
    '        Return _FechaDocOrigen
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _FechaDocOrigen = value
    '    End Set
    'End Property

    Public TipoDocOrigenOPRef As String = 0

    'Private _TipoDocOrigenOPRef As String = 0
    'Public Property TipoDocOrigenOPRef() As String
    '    Get
    '        Return _TipoDocOrigenOPRef
    '    End Get
    '    Set(ByVal value As String)
    '        _TipoDocOrigenOPRef = value
    '    End Set
    'End Property

    Public NumDocOrigenOPRef As Decimal = 0

    'Private _NumDocOrigenOPRef As Decimal = 0
    'Public Property NumDocOrigenOPRef() As Decimal
    '    Get
    '        Return _NumDocOrigenOPRef
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _NumDocOrigenOPRef = value
    '    End Set
    'End Property

    Public FechaDocOrigenOPRef As Decimal = 0

    'Private _FechaDocOrigenOPRef As Decimal = 0
    'Public Property FechaDocOrigenOPRef() As Decimal
    '    Get
    '        Return _FechaDocOrigenOPRef
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _FechaDocOrigenOPRef = value
    '    End Set
    'End Property


    Public TipoCambioOrigen As Decimal = 0

    'Private _TipoCambioOrigen As Decimal = 0
    'Public Property TipoCambioOrigen() As Decimal
    '    Get
    '        Return _TipoCambioOrigen
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _TipoCambioOrigen = value
    '    End Set
    'End Property

    Public CodMotivo As Integer = 0

    'Private _CodMotivo As Integer = 0
    'Public Property CodMotivo() As Integer
    '    Get
    '        Return _CodMotivo
    '    End Get
    '    Set(ByVal value As Integer)
    '        _CodMotivo = value
    '    End Set
    'End Property

    Public Motivo As String = ""

    'Private _Motivo As String = ""
    'Public Property Motivo() As String
    '    Get
    '        Return _Motivo
    '    End Get
    '    Set(ByVal value As String)
    '        _Motivo = value
    '    End Set
    'End Property

    Sub New(ByVal pstrDivision As String, ByVal pstrCodDiv As String, ByVal pstrCodCom As String, ByVal pdblCliente As Double, ByVal pstrCodPlanta As String, ByVal pstrMoneda As String, ByVal pintZonaFacturacion As Int32, ByVal pstrOrgVenta As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        strDivision = pstrDivision
        strCodDiv = pstrCodDiv
        strCodCom = pstrCodCom
        dblCliente = pdblCliente
        strCodPlanta = pstrCodPlanta
        strMoneda = pstrMoneda
        oFacturaNeg.Tipomoneda = pstrMoneda
        intZonaFact = pintZonaFacturacion
        'strOrgVenta = pstrOrgVenta

    End Sub

    Private Sub frmVistaReFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim oDt As DataTable
            Dim oFiltro As New Hashtable
            Dim TipoCambioActual As Decimal = 0
            lintCountFactura = 0
            oFiltro.Add("PNCMNDA1", "100")
            oFiltro.Add("PNFCMBO", Format(ldtpFechaFactura, "yyyyMMdd"))
            oFiltro.Add("PSCCMPN", strCodCom)

            oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)


            Dim dtorgVenta As New DataTable
            dtorgVenta = oFacturaNeg.Lista_OrgVenta_Cliente(strCodCom, dblCliente)

            If dtorgVenta.Rows.Count > 0 Then
                strOrgVenta = ("" & dtorgVenta.Rows(0)("CRGVTA")).ToString.Trim
            End If
            If strOrgVenta.Length = 0 Then
                MessageBox.Show("Cliente sin Org Venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If



            oFacturaNeg.dtServiciosTodosOp = dtListaServicioDoc
            'oFacturaNeg.oTipoDocumentoOrigen = _TipoDocOrigen
            oFacturaNeg.oTipoDocumentoOrigen = TipoDocOrigen
            If oDt.Rows.Count > 0 Then
                'dblTipoCambio = oDt.Rows(0).Item("IVNTA").ToString.Trim
                TipoCambioActual = oDt.Rows(0).Item("IVNTA").ToString.Trim

                oFacturaNeg.TipoCambio = TipoCambioActual
                Me.txtTipoCambio.Text = TipoCambioActual

                Select Case TipoDocumentoEmision

                    Case NEGOCIO.clsComun.TipoDocumento.NotaCreditoE
                        If TipoCambioOrigen = 0 Then
                            'If _TipoCambioOrigen = 0 Then
                            HelpClass.MsgBox("No se puede generar el documento por no existir Tipo de cambio en documento origen")
                            Me.Close()
                        End If
                        'oFacturaNeg.TipoCambio = _TipoCambioOrigen
                        'Me.txtTipoCambio.Text = _TipoCambioOrigen
                        oFacturaNeg.TipoCambio = TipoCambioOrigen
                        Me.txtTipoCambio.Text = TipoCambioOrigen

                    Case NEGOCIO.clsComun.TipoDocumento.NotaDebito, NEGOCIO.clsComun.TipoDocumento.NotaDebitoE

                End Select
                dblTipoCambio = oFacturaNeg.TipoCambio

                oFiltro.Add("PSCDVSN", strCodDiv)
                oFiltro.Add("PNCTPODC", Val(TipoDocumentoEmision))
                'oFiltro.Add("PNCTPODC", Val(_TipoDocumentoEmision))
                oFiltro.Add("PSCUSCRT", MainModule.USUARIO)
                oFacturaNeg.Llenar_Documentos_Notas_FE(oFiltro)
                Me.Llenar_Combos()
                txtDivision.Text = strDivision
            Else
                'HelpClass.MsgBox("No se puede generar el documento por no existir Tipo de cambio para el día " & Format(Now, "dd/MM/yyyy"))
                MessageBox.Show("No se puede generar el documento por no existir Tipo de cambio para el día " & Format(Now, "dd/MM/yyyy"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Me.Close()
            End If
            'Crear_Grilla_Consistencias()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub Llenar_Combos()

        Dim oFiltro As New Hashtable
        Dim oDt As DataTable

        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCDVSN", strCodDiv)
        oFiltro.Add("PSCUSCRT", MainModule.USUARIO)
        oDt = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
        Me.cmbGiro.DataSource = oDt
        cmbGiro.ValueMember = "CGRONG"
        cmbGiro.DisplayMember = "TCMGRN"

        cmbGiro_SelectionChangeCommitted(cmbGiro, Nothing)

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

        cmbPlantaCliente.SelectedValue = 1
        Me.cmbPlantaCliente.Enabled = False
        Select Case TipoDocumentoEmision
            'Select Case _TipoDocumentoEmision
            Case NEGOCIO.clsComun.TipoDocumento.NotaCreditoE
                Me.lblTipoDocumento.Text = "NOTA DE CREDITO"
            Case NEGOCIO.clsComun.TipoDocumento.NotaDebitoE
                Me.lblTipoDocumento.Text = "NOTA DE DEBITO"
        End Select

    End Sub

    Private Sub Actualizar_Punto_Venta()
       
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
       
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click, btnCancelarImpr.Click
        Me.Limpiar_Datos_Factura()
        'Call Me.Eliminar_Servicios_A_ReFacturar()
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
        Try
            Datos_Generales_ReFactura_Notas()
            Generar_ReFactura_Notas()
            If TipoDocOrigen = 0 And TipoDocOrigenOPRef = 0 Then
                'If _TipoDocOrigen = 0 And _TipoDocOrigenOPRef = 0 Then
                MessageBox.Show("No tiene documento origen.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End If

            Dim objHash As New Hashtable
            objHash.Add("CCMPN", strCodCom.PadLeft(2, "0"))
            objHash.Add("CDVSN", strCodDiv)
            objHash.Add("CRGVTA", strOrgVenta.PadLeft(3, "0"))
            objHash.Add("CCLNT", dblCliente.ToString.PadLeft(6, "0"))
            Dim strEstado As String = ""
            Dim strResultado As String = oFacturaNeg.Validar_Cliente_SAP(objHash, strEstado)

            Dim msjRef As String = ObtenerDatosCliente(strCodCom.Trim, dblCliente.ToString.Trim)

            Select Case strEstado
                Case ""
                    '--ACTIVAR DESPUES DE PRUEBA
                    HelpClass.MsgBox("ERROR : Ocurrio un Problema de Conexión", MessageBoxIcon.Information)
                    Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                    'Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                Case "B", "C", "D"
                    HelpClass.MsgBox("ADVERTENCIA : " & "Cliente " & strResultado & Chr(13) & msjRef, MessageBoxIcon.Information)
                    Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                    Exit Sub
            End Select

            REM ECM-HUNDRED-INICIO
            Dim objHash1 As New Hashtable
            objHash1.Add("CCMPN", strCodCom.Trim)
            'objHash1.Add("CZNFC", intZonaFact.ToString.Trim.PadLeft(3, "0"))
            'objHash1.Add("CCLNT", dblCliente.ToString.Trim.PadLeft(6, "0"))
            'objHash1.Add("CRGVTA", strOrgVenta.ToString.Trim.PadLeft(3, "0"))

            objHash1.Add("PNCCLNT", dblCliente.ToString.Trim.PadLeft(6, "0"))

            'Dim strResultado1 As String = oFacturaNeg.Validar_Cliente_Electronico(objHash1)

            Select Case oFacturaNeg.Validar_Cliente_Electronico_AS(objHash1)
                Case ""
                    MessageBox.Show("ERROR : Ocurrio un Problema de Conexión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                Case "1"
                    Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                Case "0"
                    MessageBox.Show("Cliente no habilitado para electronico." & Chr(13) & msjRef, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                Case "2"
                    MessageBox.Show("Cliente no inscrito." & Chr(13) & msjRef, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.btnImprimirfactura.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
            End Select
            REM ECM-HUNDRED-FIN

        Catch ex As Exception
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
            msjeRef = String.Format("Ref :{0} Cod SAP:{1} " & Environment.NewLine & "Sector: {2}", Descliente, codSap, sector)

        End If
        Return msjeRef
    End Function

    Private Sub Datos_Generales_ReFactura_Notas()
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
        'strCliente = strCliente & vbCrLf & "Tip.Doc.Origen:  " & TipoDocReferencia & " Num.Doc.Origen:  " & lstrConsistenciaOperacion(0).Factura & " Fec.Doc.Origen:  " & IIf(TipoDocumento = 3, HelpClass.CFecha_10_10(lstrConsistenciaOperacion(0).Fecha), HelpClass.CFecha_10_10(lstrConsistenciaOperacion(0).Fecha))
        'strCliente = strCliente & "   Tip.Doc.Origen:  " & _TipoDocOrigen & " Num.Doc.Origen:  " & _NumDocOrigen & " Fec.Doc.Origen:  " & HelpClass.CNumero8Digitos_a_Fecha(_FechaDocOrigen)
        'strCliente = strCliente & vbCrLf & "Motivo:  " & _CodMotivo & " - " & _Motivo
        strCliente = strCliente & "   Tip.Doc.Origen:  " & TipoDocOrigen & " Num.Doc.Origen:  " & NumDocOrigen & " Fec.Doc.Origen:  " & HelpClass.CNumero8Digitos_a_Fecha(FechaDocOrigen)
        strCliente = strCliente & vbCrLf & "Motivo:  " & CodMotivo & " - " & Motivo

        Me.txtCliente.Text = strCliente
    End Sub

    Private Sub Generar_ReFactura_Notas()
        Dim intCant As Integer

        intCant = Obtener_Cantidad_ReFacturas_Notas()
        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant)
            Mostrar_Factura(intCant)
            'oFacturaNeg.Calcular_Vista_Impresion_Aux(oHasResumenVista, lhashIGV, _TipoVistaImpresion, intCant, oDtCabFactura)
            oFacturaNeg.Calcular_Vista_Impresion_Aux(oHasResumenVista, lhashIGV, TipoVistaImpresion, intCant, oDtCabFactura)

            KryptonHeaderGroup1.Enabled = False
            Me.btnImprimirfactura.Visible = True
            Me.btnCancelarImpr.Visible = True
        Else
            Me.btnCancelarImpr.Visible = False
            Me.btnImprimirfactura.Visible = False
            HelpClass.MsgBox("No existen Facturas para crear")
        End If
    End Sub

    Private oHasResumenVista As Hashtable
    Private Sub Mostrar_Factura(ByVal intCant As Integer)
        Dim octrlFact As ctrlReFactura
        Dim consistencia As String = ""
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

            Select Case TipoVistaImpresion

                'Select Case _TipoVistaImpresion

                Case NEGOCIO.clsComun.VistaImpresion.Resumido

                    'oDtDetFacturaDetallada = Mostrar_Factura_Consolidada(lint_Contador + 1, oDtDetFactura.Copy, lstrConsistenciaOperacion(0).TipoCambioFactura)
                    oDtDetFacturaDetallada = Mostrar_Factura_Consolidada(lint_Contador + 1, oDtDetFactura.Copy, lhashIGV(lint_Contador + 1))
                    oHasResumenVista.Add(lint_Contador + 1, oDtDetFacturaDetallada)
                    octrlFact = New ctrlReFactura(oDtDetFacturaDetallada, lint_Contador + 1, strMoneda, lhashIGV(lint_Contador + 1).ToString.Trim, 0, oFacturaNeg.oTipoDocumento, True, PorcentajeDetraccion)
                    octrlFact.NumFactura = "N°          "
                    octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(ListOperaciones, strCodCom)
                    Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
                    lhashItemFact.Add(lint_Contador + 1, octrlFact.dtgDetalle.RowCount)

            End Select

        Next

    End Sub

    Private Function Mostrar_Factura_Consolidada(ByVal lintNumeroFactura As Int32, ByVal objData As DataTable, ByVal IGV As Decimal) As DataTable

        Dim objDataReturn As DataTable
        objDataReturn = oFacturaNeg.Mostrar_ReFactura_Consolidada_General(lintNumeroFactura, objData, IGV)
        Return objDataReturn

    End Function

    Private Function Obtener_Cantidad_ReFacturas_Notas() As Integer
        Return oFacturaNeg.Cantidad_ReFacturas_Notas_General(strMoneda)

    End Function


    Private Sub Generar_Cabecera(ByVal pintCant As Double)
        Dim oFiltro As New Hashtable
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

    Private Sub Generar_Detalles(ByVal pintCant As Integer)
        Dim oFiltro As New Hashtable
        oFiltro.Add("CANTFACT", pintCant)
        oFacturaNeg.ListaOperaciones1 = dtListaServicioDoc
        'oDtDetFactura = oFacturaNeg.Lista_Detalle_ReFacturas_Notas_General(oFiltro, _EsXPreLiquidacion, lhashIGV)
        oDtDetFactura = oFacturaNeg.Lista_Detalle_ReFacturas_Notas_General(oFiltro, EsXPreLiquidacion, lhashIGV)
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub

    Private Sub Grabar_ReFactura(ByVal pintFact As Integer)
        Dim strNumFact As Int64 = 0
        Dim objFiltro As New Hashtable 'Filtro
        Dim intValor As Int32 = 0
        Dim miGridDetalle As DataGridView
        Dim intTipoCambs As Double = 1
        Dim intTipoCambd As Double = dblTipoCambio 'Me.dblTipoCambio
        Dim numFilasGrid As Integer
        Dim dtVistaDocumento As New DataTable
        'Dim msgError As String = ""
        'Dim msgSAP As String = ""
        Dim msgRefactura As String = ""
        Dim msgError As String = ""
        Try


            lstrIGV = lhashIGV(pintFact).ToString.Trim
            miGridDetalle = CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).dtgDetalle
            numFilasGrid = miGridDetalle.RowCount

            'oDtCabFactura.Rows(0).Item("CTPODC") = Val(_TipoDocumentoEmision)
            'oDtCabFactura.Rows(0).Item("CTPDCO") = _TipoDocOrigen
            'oDtCabFactura.Rows(0).Item("NDCMOR") = _NumDocOrigen
            'oDtCabFactura.Rows(0).Item("FDCMOR") = _FechaDocOrigen

            'oDtCabFactura.Rows(0).Item("CTPDCOOP") = _TipoDocOrigenOPRef
            'oDtCabFactura.Rows(0).Item("NDCMOROP") = _NumDocOrigenOPRef
            'oDtCabFactura.Rows(0).Item("FDCMOROP") = _FechaDocOrigenOPRef
            oDtCabFactura.Rows(0).Item("CTPODC") = Val(TipoDocumentoEmision)
            oDtCabFactura.Rows(0).Item("CTPDCO") = TipoDocOrigen
            oDtCabFactura.Rows(0).Item("NDCMOR") = NumDocOrigen
            oDtCabFactura.Rows(0).Item("FDCMOR") = FechaDocOrigen

            oDtCabFactura.Rows(0).Item("CTPDCOOP") = TipoDocOrigenOPRef
            oDtCabFactura.Rows(0).Item("NDCMOROP") = NumDocOrigenOPRef
            oDtCabFactura.Rows(0).Item("FDCMOROP") = FechaDocOrigenOPRef



            oFacturaNeg.ListaOperaciones1 = dtListaServicioDoc
            dtVistaDocumento = oHasResumenVista(pintFact)
            oFacturaNeg.oHashNumOpeSel = Me.oHashListaOpeLiberar
            'oFacturaNeg.Grabar_ReFactura_General(pintFact, oDtCabFactura, oDtDetFactura, dtVistaDocumento, lstrIGV, strNumFact, Me.CodMotivo, _TipoVistaImpresion)
            oFacturaNeg.Grabar_ReFactura_General(pintFact, oDtCabFactura, oDtDetFactura, dtVistaDocumento, lstrIGV, strNumFact, Me.CodMotivo, TipoVistaImpresion)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 1, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).Referencia1)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 2, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).Referencia2)


            intValor = Registrar_Orden_Interna_Factura(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact, CType(oDtCabFactura.Rows(0).Item("FDCCTC").ToString.Trim, Int64))


            Me.tabFactura.TabPages(pintFact - 1).Text = Me.lblTipoDocumento.Text & " N°" & strNumFact
            CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).NumFactura = "N° " & strNumFact
            lblNumFact.Text = "N° " & strNumFact
        Catch ex As Exception

            strNumFact = 0
            msgError = "Error al grabar la " & Me.lblTipoDocumento.Text & vbCrLf & ex.Message
            'HelpClass.MsgBox("Error al grabar la " & Me.lblTipoDocumento.Text & vbCrLf & ex.Message)
        End Try
        If strNumFact <> 0 Then
            msgRefactura = "Se grabó correctamente la " & Me.lblTipoDocumento.Text & " N° " & strNumFact
            If intValor > 0 Then
                msgError = Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
            End If
            If msgError.Length > 0 Then
                msgRefactura = msgRefactura & Chr(10) & msgError
            End If

            MessageBox.Show(msgRefactura, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'HelpClass.MsgBox("Se grabó correctamente la " & Me.lblTipoDocumento.Text & " N° " & strNumFact)
        End If
    End Sub

    'Private Sub Cerrar_Orden_Interna(ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long)
    '    Dim oFiltro As Hashtable
    '    Dim oValor As Int32 = 0
    '    Try
    '        oFiltro = New Hashtable
    '        oFiltro.Add("PSCCMPN", pstrCompania)
    '        oFiltro.Add("PSCTPODC", pstrTipoDoc)
    '        oFiltro.Add("PSNDCCTC", pstrNumFact)
    '        If oFacturaNeg.Cerrar_Orden_Interna_Factura(oFiltro) = 0 Then
    '            HelpClass.MsgBox("Error al cerrar Orden / Interna Factura ", MessageBoxIcon.Information)
    '        End If
    '    Catch : End Try

    'End Sub

    Private Function Enviar_Factura_SAP(ByVal pstrCompania As String, ByVal pstrTipoDoc As String, ByVal pstrNumFact As String) As String
        Dim oFiltro As Hashtable
        Dim oDt As DataTable
        Dim strNumSAP As String = ""
        Dim msgError As String = ""

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
                msgError = "Se envió correctamente al SAP con N° de Documento SAP " & vbCrLf & strNumSAP
                'Cursor = Cursors.Default
                'HelpClass.MsgBox("Se envió correctamente al SAP con N° de Documento SAP " & vbCrLf & strNumSAP)
            Else
                msgError = "No se generó el documento SAP"
                'MessageBox.Show("No se generó el documento SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            msgError = "Error al enviar documento al SAP " & ex.Message
            'HelpClass.MsgBox("Error al enviar documento al SAP " & ex.Message)
        End Try
        Return msgError
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

        If oFacturaNeg.Registrar_Orden_Interna_Factura_General(oFiltro, False) = 0 Then
            HelpClass.MsgBox("Error al enviar Orden Interna", MessageBoxIcon.Information)
            oValor = 0
        Else
            oValor = 1
        End If

        'Catch : End Try
        Return oValor
    End Function

    Private Sub btnImprimirfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirfactura.Click

        Try
            Dim strEstado As String = ""

            Select Case MessageBox.Show("Está Seguro de Procesar el Documento.", "Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                Case Windows.Forms.DialogResult.Yes
                    lintImprimir = 2
                Case Windows.Forms.DialogResult.No
                    Exit Sub

            End Select

            For intContador As Integer = 1 To Me.tabFactura.TabCount
                Grabar_ReFactura(intContador)
                Me.lblNumFact.Tag = intContador
                Me.btnImprimirfactura.Visible = False
                Me.btnGenerar.Visible = False
            Next
            Me.lblNumFact.Tag = New Object

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

        For Each row As DataRow In dtListaServicioDoc.Rows
            result += row("NOPRCN").ToString & ","
        Next

        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function


  

    Private Function ListFechaFacturas() As String
        Dim result As String = ""
        Dim list As String = ""
        For Each row As DataRow In dtListaServicioDoc.Rows
            result += row("").ToString & ","
        Next
        list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function



   
    Private Function ListFacturas() As String
        Dim result As String = ""
        Dim list As String = numDocOrigen.ToString
        'For Each row As DataRow In dtListaServicioDoc.Rows
        '    result += row("").ToString & ","
        'Next
        'list = result.Substring(0, result.LastIndexOf(","))
        Return list
    End Function


    'Private Sub Eliminar_Servicios_A_ReFacturar()
    '    Dim RefacturaBLL As New ReFacturacion_BLL
    '    Dim param As New Hashtable
    '    Try
    '        param.Add("PNNOPRCN", ListUnique(ListOperaciones))
    '        param.Add("PNNDCMFC", ListUnique(ListFacturas))
    '        param.Add("PNCTPDFC", 1)
    '        param.Add("PSCCPMN", strCodCom)
    '        RefacturaBLL.Eliminar_Servicios_A_ReFacturar(param)
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub SendProcess(ByVal pCompania As String, ByVal pTipoDoc As Int32, ByVal pNumFact As Long)

    '    Dim wk As New WorkSap
    '    wk.pstrCompania = pCompania
    '    wk.pstrTipoDoc = pTipoDoc
    '    wk.pstrNumFact = pNumFact
    '    wk.ProcesoCierreOrden = AddressOf Cerrar_Orden_Interna
    '    Dim t As New Threading.Thread(AddressOf wk.IniciaCierreOrden)
    '    t.IsBackground = True
    '    t.Start()

    'End Sub

    'Delegate Sub CierreOrdenInterna(ByVal pstrCompania As String, ByVal pstrTipoDoc As Int32, ByVal pstrNumFact As Long)

    'Class WorkSap

    '    Public pstrTipoDoc As Integer
    '    Public pstrCompania As String
    '    Public pstrNumFact As Long
    '    Public ProcesoCierreOrden As CierreOrdenInterna

    '    Public Sub IniciaCierreOrden()
    '        ProcesoCierreOrden(pstrCompania, pstrTipoDoc, pstrNumFact)
    '    End Sub

    'End Class

    Private Sub cmbGiro_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGiro.SelectionChangeCommitted
        Actualizar_Punto_Venta()
    End Sub

End Class
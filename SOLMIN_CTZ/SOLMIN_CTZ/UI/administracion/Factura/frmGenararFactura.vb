Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Text
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmGenararFactura
    Private pTamanioReferencia1 As Integer = 380
    Private pTamanioReferencia2 As Integer = 624
    Private pTamanioFilas As Integer = 4
    Private NumeroDocumento As Integer = 0 'CSR-HUNDRED-ESTIMACION-INGRESO

    Sub New(ByVal ListaoFacturacion As List(Of SOLMIN_CTZ.Entidades.FacturaSIL))
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'oFact = oFacturacion
        mListaoFact = ListaoFacturacion
        strMoneda = ListaoFacturacion(0).CMNDA1
        oFacturaNeg = New SOLMIN_CTZ.NEGOCIO.clsFactura
        bolBuscar = False
    End Sub


#Region "Declaracion de Variables"

    Private strMoneda As String
    Private dblTipoCambio As Double
    Private oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
    Private bolBuscar As Boolean
    Private oDtCabFactura As DataTable
    Private oDtDetFactura As DataTable
    Private dblNumFacImp As Double
    Private strCompFacImp As String
    Private strTipoDocFacImp As String
    Private oFact As New SOLMIN_CTZ.Entidades.FacturaSIL
    Private mListaoFact As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
    Private lintImprimir As Int32 = 0
    Private pdblIGV As Decimal = 0
    Private phashIGV As Hashtable
    Private dtpFechaFactura As Date
    Public Grabar As Boolean = False

#End Region

#Region "Procedimientos y Funciones"

    Private Sub CargarDatos()

        Dim oFiltro As New Filtro
        Dim oDtRegionVenta As DataTable
        oFiltro.Parametro1 = mListaoFact(0).PSCCMPN  'strCodCom
        oFiltro.Parametro2 = mListaoFact(0).PSCDVSN  'strCodDiv
        oFiltro.Parametro3 = mListaoFact(0).CCLNFC 'dblCliente
        oFacturaNeg.Llenar_Documentos(oFiltro)
        Llenar_Combos()
        'If Val(mListaoFact(0).NOPRCN) <> 0 Then
        '    oDtRegionVenta = oFacturaNeg.Lista_Region_Venta_X_Operacion(mListaoFact(0))
        '    If oDtRegionVenta.Rows.Count = 0 Then
        '        txtRegionVenta.Text = "Anulada"
        '        btnFacturar.Enabled = False
        '    Else
        '        txtRegionVenta.Text = oDtRegionVenta.Rows(0).Item("CRGVTA")
        '    End If
        'Else
        '    txtRegionVenta.Text = mListaoFact(0).CRGVTA
        'End If

        txtRegionVenta.Text = mListaoFact(0).CRGVTA
    End Sub

    Private Sub TipoDeCambio()
        Dim oDt As DataTable
        'Dim oFiltro As New Filtro
        Dim oFiltro As New Hashtable
        'oFiltro.Parametro1 = "100" 'tipo cambio dolares
        'oFiltro.Parametro2 = Format(Me.dtpFechaFac.Value, "yyyyMMdd")

        oFiltro("CMNDA1") = "100" 'tipo cambio dolares
        oFiltro("FCMBO") = Format(Me.dtpFechaFac.Value, "yyyyMMdd")
 

        oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
        If oDt.Rows.Count > 0 Then
            lblError.Visible = False
            btnFacturar.Enabled = ButtonEnabled.True
            dblTipoCambio = oDt.Rows(0).Item("IVNTA").ToString.Trim
            oFacturaNeg.TipoCambio = dblTipoCambio
            Me.txtTipoCambio.Text = dblTipoCambio
        Else
            lblError.Visible = True
            btnFacturar.Enabled = False
            txtTipoCambio.Text = ""
        End If

    End Sub

    ''' <summary>
    ''' Habilita que la fecha de la factura se cambien solo los primeros 3 días de cada mes
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Private Sub HabilitarFechaFactura()
        dtpFechaFactura = oFacturaNeg.FechaActualServidor()
        dtpFechaFac.Value = dtpFechaFactura
        Select Case dtpFechaFactura.Day
            Case 1, 2, 3
                Me.dtpFechaFac.Visible = True
                Me.lblFechaFactura.Visible = True
        End Select
    End Sub

    Private Sub Llenar_Combos()
        'Dim oFiltro As New Filtro
        Dim oFiltro As New Hashtable
        Dim oDt As DataTable

        bolBuscar = False
        'oFiltro.Parametro1 = mListaoFact(0).PSCCMPN 'strCodCom
        'oFiltro.Parametro2 = mListaoFact(0).PSCDVSN 'strCodDiv

        oFiltro("CCMPN") = mListaoFact(0).PSCCMPN 'strCodCom
        oFiltro("CDVSN") = mListaoFact(0).PSCDVSN 'strCodDiv

        oDt = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
        Me.cmbGiro.DataSource = oDt
        cmbGiro.ValueMember = "CGRONG"
        bolBuscar = True
        cmbGiro.DisplayMember = "TCMGRN"
        If oDt.Rows.Count = 1 Then
            Me.cmbGiro.Enabled = False
        End If
        If oDt.Rows.Count <= 0 Then
            Me.btnFacturar.Enabled = False
        Else
            Me.btnFacturar.Enabled = True
        End If
        CargarPlantaFacturar()
        'oFiltro = New Filtro
        oFiltro = New Hashtable
        oFiltro("CCLNT") = mListaoFact(0).CCLNFC 'dblCliente
        'oFiltro.Parametro1 = mListaoFact(0).CCLNFC 'dblCliente
        oDt = oFacturaNeg.Lista_Planta_Cliente(oFiltro)
        Me.cmbPlantaCliente.DataSource = oDt
        cmbPlantaCliente.ValueMember = "CPLNCL"
        cmbPlantaCliente.DisplayMember = "TDRCPL"
        If oDt.Rows.Count = 1 Then
            Me.cmbPlantaCliente.Enabled = False
        End If
    End Sub


    Private Sub Generar_Boleta()
        Dim intCant As Integer
        intCant = 1 'Obtener_Cantidad_Facturas()
        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant)
            Mostrar_Boleta(intCant)
            Me.btnFacturar.Enabled = True
        Else
            Me.btnFacturar.Enabled = False
            HelpClass.MsgBox("No existen Facturas para crear")
        End If
    End Sub
    ''Falta saber que es lo que hace
    Private Sub Generar_Factura()
        Dim intCant As Integer

        intCant = Obtener_Cantidad_Facturas()
        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant)
            Mostrar_Factura(intCant)
            Me.btnFacturar.Enabled = True
        Else
            Me.btnFacturar.Enabled = False
            HelpClass.MsgBox("No existen Facturas para crear")
        End If
    End Sub

    Private Sub Mostrar_Boleta(Optional ByVal intCant As Integer = 1)
        Dim octrlFact As ctrlFactura
        Dim X As Integer = 0
        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True
        Next X
        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = "Boleta " & lint_Contador.ToString
            octrlFact = New ctrlFactura(mListaoFact(0).PSCTPDCI.Trim.ToString, oDtDetFactura, lint_Contador + 1, phashIGV.Item(lint_Contador + 1), mListaoFact.Item(0).TIPOFACTURA) 'pdblIGV
            octrlFact.NumFactura = "N°          "
            If mListaoFact(0).PSCDVSN = "S" Then   'strCodDiv
                octrlFact.Referencia1 = Obtener_Referencia_Factura_SIL()
            End If
            Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
        Next
    End Sub

    Private Sub Mostrar_Factura(Optional ByVal intCant As Integer = 1)
        Dim octrlFact As ctrlFactura
        Dim X As Integer = 0
        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True

        Next X
        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = "Factura " & lint_Contador.ToString
            octrlFact = New ctrlFactura(mListaoFact(0).PSCTPDCI.Trim.ToString, oDtDetFactura, lint_Contador + 1, phashIGV.Item(lint_Contador + 1), mListaoFact.Item(0).TIPOFACTURA) 'pdblIGV
            octrlFact.NumFactura = "N°          "
            If mListaoFact(0).PSCDVSN = "S" Then   'strCodDiv
                octrlFact.Referencia1 = Obtener_Referencia_Factura_SIL()
            End If
            AddHandler octrlFact.btnReferencia1.Click, AddressOf referencia1_Click
            AddHandler octrlFact.btnReferencia2.Click, AddressOf referencia2_Click
            Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
            Me.tabFactura.TabPages(lint_Contador).Tag = lint_Contador + 1
        Next
    End Sub
    Private Sub referencia1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim textoReferencia As String
        Dim oDsDoc As DataSet
        Dim srtTexto As String = ""
        Dim numFilas As Integer = 0
        Dim pintTab As Integer = Me.tabFactura.SelectedTab.Tag
        oDsDoc = CType(phtOperacioFacturar.Item(pintTab), DataSet)
        Dim dt As New DataTable
        dt.Columns.Add("TRDCCL", GetType(String))
        Dim dr As DataRow
        Dim referencia As String = ""
        Dim strReferencia As New StringBuilder
        textoReferencia = CType(Me.tabFactura.TabPages(pintTab - 1).Controls(0), ctrlFactura).Referencia1.ToString.Trim
        For i As Long = 0 To oDsDoc.Tables(0).Rows.Count - 1
            If oDsDoc.Tables(0).Rows(i)("TRDCCL").ToString.Trim <> "" Then
                If referencia <> oDsDoc.Tables(0).Rows(i)("TRDCCL").ToString.Trim Then
                    dr = dt.NewRow
                    dr("TRDCCL") = oDsDoc.Tables(0).Rows(i)("TRDCCL").ToString.Trim
                    dt.Rows.Add(dr)
                    strReferencia.AppendLine(oDsDoc.Tables(0).Rows(i)("TRDCCL").ToString.Trim)
                End If
                referencia = oDsDoc.Tables(0).Rows(i)("TRDCCL").ToString.Trim
            End If
        Next
        If textoReferencia.ToString.Trim.Length > 0 Then
            srtTexto = textoReferencia.ToString.Trim & vbNewLine & strReferencia.ToString.Trim
        Else
            srtTexto = strReferencia.ToString.Trim
        End If
        For Each CR As String In srtTexto.ToString.Split(vbNewLine)
            numFilas += 1
        Next
        If strReferencia.Length < pTamanioReferencia1 Then
            If numFilas > pTamanioFilas Then
                Dim frmReferencia As New FormReferenciaFactura
                frmReferencia.DataSource = dt
                frmReferencia.TipoReferencia = 1
                frmReferencia.TextoInicial = textoReferencia.ToString.Trim
                If frmReferencia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    CType(Me.tabFactura.TabPages(pintTab - 1).Controls(0), ctrlFactura).Referencia1 = frmReferencia.Referencia_Factura.ToString.Trim
                End If
            Else
                CType(Me.tabFactura.TabPages(pintTab - 1).Controls(0), ctrlFactura).Referencia1 = srtTexto.ToString.Trim
            End If
        Else
            Dim frmReferencia As New FormReferenciaFactura
            frmReferencia.DataSource = dt
            frmReferencia.TipoReferencia = 1
            frmReferencia.TextoInicial = textoReferencia.ToString.Trim
            If frmReferencia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CType(Me.tabFactura.TabPages(pintTab - 1).Controls(0), ctrlFactura).Referencia1 = frmReferencia.Referencia_Factura.ToString.Trim
            End If
        End If
    End Sub
    Private Sub referencia2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim textoReferencia As String
        Dim oDsDoc As DataSet
        Dim srtTexto As String = ""
        Dim numFilas As Integer = 0
        Dim pintTab As Integer = Me.tabFactura.SelectedTab.Tag
        oDsDoc = CType(phtOperacioFacturar.Item(pintTab), DataSet)
        Dim dt As New DataTable
        dt.Columns.Add("TRFSRC", GetType(String))
        Dim dr As DataRow
        Dim referencia As String = ""
        Dim strReferencia As New StringBuilder
        textoReferencia = CType(Me.tabFactura.TabPages(pintTab - 1).Controls(0), ctrlFactura).Referencia2.ToString.Trim
        For i As Long = 0 To oDsDoc.Tables(0).Rows.Count - 1
            If oDsDoc.Tables(0).Rows(i)("TRFSRC").ToString.Trim <> "" Then
                If referencia <> oDsDoc.Tables(0).Rows(i)("TRFSRC").ToString.Trim Then
                    dr = dt.NewRow
                    dr("TRFSRC") = oDsDoc.Tables(0).Rows(i)("TRFSRC").ToString.Trim
                    dt.Rows.Add(dr)
                    strReferencia.AppendLine(oDsDoc.Tables(0).Rows(i)("TRFSRC").ToString.Trim)
                End If
                referencia = oDsDoc.Tables(0).Rows(i)("TRFSRC").ToString.Trim
            End If
        Next
        If textoReferencia.ToString.Trim.Length > 0 Then
            srtTexto = textoReferencia.ToString.Trim & vbNewLine & strReferencia.ToString.Trim
        Else
            srtTexto = strReferencia.ToString.Trim
        End If
        For Each CR As String In srtTexto.ToString.Split(vbNewLine)
            numFilas += 1
        Next
        If strReferencia.Length < pTamanioReferencia2 Then
            If numFilas > pTamanioFilas Then
                Dim frmReferencia As New FormReferenciaFactura
                frmReferencia.DataSource = dt
                frmReferencia.TipoReferencia = 2
                frmReferencia.TextoInicial = textoReferencia.ToString.Trim
                If frmReferencia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    CType(Me.tabFactura.TabPages(pintTab - 1).Controls(0), ctrlFactura).Referencia2 = frmReferencia.Referencia_Factura.ToString.Trim
                End If
            Else
                CType(Me.tabFactura.TabPages(pintTab - 1).Controls(0), ctrlFactura).Referencia2 = srtTexto.ToString.Trim
            End If
        Else
            Dim frmReferencia As New FormReferenciaFactura
            frmReferencia.DataSource = dt
            frmReferencia.TipoReferencia = 2
            frmReferencia.TextoInicial = textoReferencia.ToString.Trim
            If frmReferencia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CType(Me.tabFactura.TabPages(pintTab - 1).Controls(0), ctrlFactura).Referencia2 = frmReferencia.Referencia_Factura.ToString.Trim
            End If
        End If

    End Sub
    Private Function Obtener_Referencia_Factura_SIL()
        Dim strReferencia As String = ""
        Dim strObs As String = ""
        Dim strOC As String = ""
        Dim strOS As String = ""
        Dim strDUA As String = ""
        Dim strOCAnt As String = ""
        Dim strOSAnt As String = ""
        Dim strDUAAnt As String = ""
        Dim oFiltro As New Filtro
        Dim intCont As Integer
        Dim oDt As DataTable

        For intLista As Integer = 0 To mListaoFact.Count - 1
            oFiltro.Parametro1 = mListaoFact(intLista).NSECFC 'dblConsistencia
            oFiltro.Parametro2 = mListaoFact(intLista).NOPRCN
            'oDt = oFacturaNeg.Lista_Unidad_Consistencia_SIL(oFiltro)
            If oDt.Rows.Count = 1 Then
                If oDt.Rows(0).Item("CUNDMD").ToString.Trim = "OS" Then
                    'oDt = oFacturaNeg.Lista_Referencia_Factura_SIL(oFiltro)
                    For intCont = 0 To oDt.Rows.Count - 1
                        If intCont = 0 Then
                            strOCAnt = oDt.Rows(intCont).Item("NORCML").ToString.Trim
                            strDUAAnt = oDt.Rows(intCont).Item("TNRODU").ToString.Trim
                            strOSAnt = oDt.Rows(intCont).Item("PNNMOS").ToString.Trim
                            strOC = oDt.Rows(intCont).Item("NORCML").ToString.Trim
                            strDUA = oDt.Rows(intCont).Item("TNRODU").ToString.Trim
                            strOS = oDt.Rows(intCont).Item("PNNMOS").ToString.Trim
                        Else
                            If strOCAnt <> oDt.Rows(intCont).Item("NORCML").ToString.Trim Then
                                strOCAnt = oDt.Rows(intCont).Item("NORCML").ToString.Trim
                                strOC = strOC & ", " & oDt.Rows(intCont).Item("NORCML").ToString.Trim
                            End If
                            If strDUAAnt <> oDt.Rows(intCont).Item("TNRODU").ToString.Trim Then
                                strDUAAnt = oDt.Rows(intCont).Item("TNRODU").ToString.Trim
                                strDUA = strDUA & ", " & oDt.Rows(intCont).Item("TNRODU").ToString.Trim
                            End If
                            If strOSAnt <> oDt.Rows(intCont).Item("PNNMOS").ToString.Trim Then
                                strOSAnt = oDt.Rows(intCont).Item("PNNMOS").ToString.Trim
                                strOS = strOS & ", " & oDt.Rows(intCont).Item("PNNMOS").ToString.Trim
                            End If
                        End If
                    Next intCont
                    strReferencia = "O/S : " & strOS & "     DUA : " & strDUA
                    strReferencia = strReferencia & vbCrLf & "O/C : " & strOC

                    oDt = oFacturaNeg.Lista_Observacion_Factura_SIL(oFiltro)
                    For intCont = 0 To oDt.Rows.Count - 1
                        If intCont = 0 Then
                            strObs = oDt.Rows(intCont).Item("TOBS").ToString.Trim
                        Else
                            strObs = strObs & " " & oDt.Rows(intCont).Item("TOBS").ToString.Trim
                        End If
                    Next intCont
                    If strObs.Trim <> "" Then
                        strReferencia = strReferencia & vbCrLf & strObs
                    End If
                End If
            End If

        Next
        Return strReferencia
    End Function

    Private Function Obtener_Cantidad_Facturas() As Integer
        Dim ListaoFiltro As New List(Of Filtro)
        Dim oFiltro As New Filtro
        Dim nRetorno As Integer = 0
        For intCant As Integer = 0 To mListaoFact.Count - 1
            oFiltro = New Filtro
            oFiltro.Parametro1 = mListaoFact(intCant).NSECFC  'dblConsistencia
            oFiltro.Parametro3 = HelpClass.CtypeDate(Me.dtpFechaFac.Value)  'dblConsistencia
            oFiltro.Parametro4 = mListaoFact(intCant).NOPRCN
            ListaoFiltro.Add(oFiltro)
        Next
        'nRetorno = oFacturaNeg.Cantidad_Facturas(ListaoFiltro, False) 'csr-hotfix/031116_Visualizacion_Formato_Factura
        Return nRetorno
    End Function

    Private Sub Generar_Cabecera(ByVal pintCant As Double)
        Dim oFiltro As New Filtro

        oFiltro.Parametro1 = mListaoFact(0).NSECFC 'dblConsistencia
        oFiltro.Parametro2 = pintCant
        oFiltro.Parametro3 = mListaoFact(0).CCLNFC 'dblCliente
        oFiltro.Parametro4 = mListaoFact(0).PSCDVSN 'strCodDiv
        oFiltro.Parametro5 = mListaoFact(0).PSCCMPN 'strCodCom
        oFiltro.Parametro6 = dblTipoCambio
        oFiltro.Parametro7 = cmbPlantaFacturar.SelectedValue 'oFact.CPLNDV  'strCodPlanta
        oFiltro.Parametro8 = strMoneda
        oFiltro.Parametro9 = Me.txtRegionVenta.Text 'mListaoFact(0).CRGVTA
        oFiltro.Parametro10 = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
        oFacturaNeg.GiroNegocio = Me.cmbGiro.SelectedValue
        If Me.cmbPtoVenta.Items.Count > 0 Then
            oFacturaNeg.PuntoVenta = Me.cmbPtoVenta.SelectedValue
        Else
            oFacturaNeg.PuntoVenta = ""
        End If
        oFacturaNeg.PlantaCliente = Me.cmbPlantaCliente.SelectedValue
        oDtCabFactura = oFacturaNeg.Lista_Cabecera_Factura(oFiltro)
        Me.dtgCabeceraFactura.DataSource = oDtCabFactura
    End Sub

    Private phtOperacioFacturar As Hashtable

    Private Sub Generar_Detalles(ByVal pintCant As Integer)
        Dim oFiltro As New Filtro
        oFiltro.Parametro2 = pintCant
        oFiltro.Parametro3 = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
        phashIGV = New Hashtable
        oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura(mListaoFact, oFiltro, phashIGV, phtOperacioFacturar, mListaoFact.Item(0).TIPOFACTURA, False) 'pdblIGV 'csr-hotfix/031116_Visualizacion_Formato_Factura
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub

    'Private Function ValidarCliente() As Boolean
    '    Dim dataTable As New DataTable
    '    Dim msgError As String = ""

    '    'If Not (New clsCliente).PerteneceASalmon(mListaoFact(0).PSCCMPN) Then
    '    '    Me.HabilitarControlesClienteNoValido(True)
    '    '    Return True
    '    'Else

    '    dataTable = oFacturaNeg.ValidarClienteSAP(mListaoFact(0).PSCCMPN, txtRegionVenta.Text.Trim.PadLeft(3, "0"), mListaoFact(0).CCLNFC.ToString.PadLeft(6, "0"), msgError)

    '    If (Not String.IsNullOrEmpty(msgError)) Then
    '        MessageBox.Show(msgError)
    '        Me.HabilitarControlesClienteNoValido(False)
    '        Return False
    '    End If

    '    If (dataTable.Rows.Count = 0) Then
    '        MessageBox.Show("No se pudo obtener datos del cliente")
    '        Me.HabilitarControlesClienteNoValido(False)
    '        Return False
    '    End If

    '    If (dataTable.Rows(0).Item("FLSTSE").ToString().Trim() <> "0") Then
    '        MessageBox.Show("Cliente habilitado para la Facturación electrónica")
    '        Me.HabilitarControlesClienteNoValido(False)
    '        Return False
    '    End If

    '    Me.HabilitarControlesClienteNoValido(True)
    '    Return True
    '    'End If

    'End Function

    Private Sub HabilitarControlesClienteNoValido(ByVal bool As Boolean)
        btnFacturar.Enabled = bool
        cmbGiro.Enabled = bool
        dtpFechaFac.Enabled = bool
    End Sub

    Private Sub Validar()
        Dim objHash As New Hashtable
        objHash.Add("CCMPN", mListaoFact(0).PSCCMPN)
        objHash.Add("CDVSN", mListaoFact(0).PSCDVSN)
        objHash.Add("CRGVTA", txtRegionVenta.Text.Trim.PadLeft(3, "0"))
        objHash.Add("CCLNT", mListaoFact(0).CCLNFC.ToString.PadLeft(6, "0"))
        Dim strEstado As String = ""
        Dim strResultado As String = oFacturaNeg.fstrValidarClienteSAP(objHash, strEstado)
        Select Case strEstado
            Case ""
                HelpClass.MsgBox("ERROR : Ocurrio un Problema de Conexión", MessageBoxIcon.Information)
                Me.btnFacturar.Enabled = True 'False
                cmbGiro.Enabled = False
                dtpFechaFac.Enabled = False
            Case "B", "C", "D"
                HelpClass.MsgBox("ADVERTENCIA : " & "Cliente " & strResultado, MessageBoxIcon.Information)
                Me.btnFacturar.Enabled = False
                cmbGiro.Enabled = False
                dtpFechaFac.Enabled = False
            Case Else 'ECM-HUNDRED-SOPORTE[180716]
                'ValidarCliente()
                Dim msgError As String = ""
             
                msgError = oFacturaNeg.ValidarClienteSAP(mListaoFact(0).PSCCMPN, txtRegionVenta.Text.Trim.PadLeft(3, "0"), mListaoFact(0).CCLNFC.ToString.PadLeft(6, "0"))
                If msgError.Length > 0 Then
                    btnFacturar.Enabled = True
                    MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

        End Select
    End Sub


    Private Sub Datos_Generales_Factura()
        Dim oDtNew As DataTable
        'Dim oFiltro As New Filtro
        Dim oFiltro As New Hashtable
        Dim strCliente As String
        'oFiltro.Parametro1 = mListaoFact(0).CCLNFC 'dblCliente
        oFiltro("CCLNT") = mListaoFact(0).CCLNFC 'dblCliente

        oDtNew = oFacturaNeg.Lista_Datos_Cliente(oFiltro)
        strCliente = "Sres.:".PadRight(130, " ") & "Código:    " & oDtNew.Rows(0).Item("CCLNT").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TCMPCL").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TDRCOR").ToString.Trim & "    " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & oDtNew.Rows(0).Item("NRUC").ToString.Trim & " ".PadRight(90, " ") & "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim
        'Modificado por AZORRILLAP 2011-03-01
        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(Me.dtpFechaFac.Value, "dd/MM/yyyy")

        Me.txtCliente.Text = strCliente
    End Sub

    'Pendiente a revisar
    Private Sub Actualizar_Punto_Venta()
        Me.Cursor = Cursors.WaitCursor
        If bolBuscar Then
            Dim oFiltro As New Filtro
            oFiltro.Parametro1 = cmbGiro.SelectedValue
            Me.cmbPtoVenta.DataSource = oFacturaNeg.Lista_Punto_Venta(oFiltro)
            cmbPtoVenta.DisplayMember = "NPTOVT"
            cmbPtoVenta.ValueMember = "NPTOVT"
            If Me.cmbPtoVenta.Items.Count <= 0 Then
                Me.btnFacturar.Enabled = False
            Else
                Me.btnFacturar.Enabled = True
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CargarPlantaFacturar()
        Me.Cursor = Cursors.WaitCursor
        If bolBuscar Then
            'Dim oFiltro As New Filtro
            Dim oFiltro As New Hashtable
            'oFiltro.Parametro1 = mListaoFact(0).PSCCMPN
            'oFiltro.Parametro2 = mListaoFact(0).PSCDVSN

            oFiltro("CCMPN") = mListaoFact(0).PSCCMPN
            oFiltro("CDVSN") = mListaoFact(0).PSCDVSN
      

            Me.cmbPlantaFacturar.DataSource = oFacturaNeg.Lista_Planta_Facturar(oFiltro)
            cmbPlantaFacturar.DisplayMember = "TPLNTA"
            cmbPlantaFacturar.ValueMember = "CPLNDV"
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ActualizarTempDocumentoHistorial(ByVal pintFact As Int32)
        'ACTUALIZAR CABECERA Y DETALLE HISTORIAL
        '*************************************************************
        'For Each Item As DataRow In oFacturaNeg.dtFacturaOperacion.Rows
        '    If Item("FACTURA") = pintFact Then
        '        For Each ItemCab As DataRow In oDtCabFactura.Rows
        '            If ItemCab("FACTURA") = pintFact Then
        '                Item("CTPODC") = ItemCab("CTPODC")
        '                Item("NDCCTC") = ItemCab("NDCCTC")
        '                Item("FDCCTC") = ItemCab("FDCCTC")
        '                Exit For
        '            End If
        '        Next
        '    End If
        'Next
        'For Each Item As DataRow In oFacturaNeg.dtFacturaOperacionDet.Rows
        '    If Item("FACTURA") = pintFact Then
        '        For Each ItemCab As DataRow In oDtCabFactura.Rows
        '            If ItemCab("FACTURA") = pintFact Then
        '                Item("CTPODC") = ItemCab("CTPODC")
        '                Item("NDCCTC") = ItemCab("NDCCTC")
        '                Exit For
        '            End If
        '        Next
        '    End If
        'Next

        Dim oDsDoc As DataSet
        oDsDoc = CType(phtOperacioFacturar.Item(pintFact), DataSet)
        For Each Item As DataRow In oDsDoc.Tables(0).Rows
            If Item("FACTURA") = pintFact Then
                For Each ItemCab As DataRow In oDtCabFactura.Rows
                    If ItemCab("FACTURA") = pintFact Then
                        Item("CTPODC") = ItemCab("CTPODC")
                        Item("NDCCTC") = ItemCab("NDCCTC")
                        Item("FDCCTC") = ItemCab("FDCCTC")
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    'Public Function ObtenerMasAntiguaReferenciaDocumento(ByVal CCLNT As Decimal, ByVal numFactura As Decimal) As DataTable
    '    oFacturaDato.Lista_Operaciones_Historial_x_Cliente(CCLNT,dtOperacionesFactura
    'End Function
    'Private Function UnirOperaciones(ByVal dr() As DataRow) As String
    '    Dim ListVisitados As New List(Of String)
    '    Dim lisOperacion As String = ""
    '    Dim NOPRCN As String = ""
    '    For FILA As Integer = 0 To dr.Length - 1
    '        NOPRCN = dr(FILA)("NOPRCN")
    '        If Not ListVisitados.Contains(NOPRCN) Then
    '            ListVisitados.Add(NOPRCN)
    '            lisOperacion = lisOperacion & NOPRCN & ","
    '        End If
    '    Next
    '    If lisOperacion.Length > 0 Then
    '        lisOperacion = lisOperacion.Substring(0, lisOperacion.Length - 1)
    '    End If
    '    Return lisOperacion
    'End Function
    'If dtOperacionesFactura.Rows(FILA_OP)("FACTURA") = pintFact Then

    Private Sub EvaluarFechaPrimeroDocumento(ByRef CTPDCO As Decimal, ByRef NDCMOR As Decimal, ByRef FDCMOR As Decimal, ByVal dt As DataTable)
        CTPDCO = 0
        NDCMOR = 0
        FDCMOR = 0
        Dim MenorFecha As Decimal = 0, MenorDocFactura = 0
        If dt.Rows.Count > 0 Then
            MenorFecha = dt.Rows(0)("FDCFCC")
            Dim dr() As DataRow
            For FILA As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(FILA)("FDCFCC") <= MenorFecha Then
                    MenorFecha = dt.Rows(FILA)("FDCFCC")
                End If
            Next
            dr = dt.Select("FDCFCC='" & MenorFecha & "'")
            If dr.Length > 0 Then
                MenorDocFactura = dr(0)("NDCFCC")
                For Fila As Integer = 0 To dr.Length - 1
                    If dt.Rows(Fila)("NDCFCC") <= MenorDocFactura Then
                        MenorDocFactura = dr(Fila)("NDCFCC")
                        CTPDCO = dr(Fila)("CTPODC")
                        NDCMOR = dr(Fila)("NDCFCC")
                        FDCMOR = dr(Fila)("FDCFCC")
                    End If
                Next
            End If
        End If
    End Sub

    Private Function UnificarOperacionesxFactura(ByVal pintFact As Integer, ByVal dtOperacionDocHistDet As DataTable)
        Dim dtOpJoinxFactura As New DataTable
        dtOpJoinxFactura.Columns.Add("FACTURA")
        dtOpJoinxFactura.Columns.Add("NOPRCN")
        dtOpJoinxFactura.Columns.Add("NCRROP")
        dtOpJoinxFactura.Columns.Add("CTPODC")
        dtOpJoinxFactura.Columns.Add("NDCCTC")
        dtOpJoinxFactura.Columns.Add("CCLNT")
        dtOpJoinxFactura.Columns.Add("CCMPN")
        Dim dr As DataRow
        Dim drServicioOp() As DataRow
        Dim ListVisitados As New List(Of String)
        Dim CodVisitados As String = ""
        Dim sbServicios As New StringBuilder
        For Each Item As DataRow In dtOperacionDocHistDet.Rows
            If Item("FACTURA") = pintFact Then
                CodVisitados = Item("FACTURA") & "_" & Item("NOPRCN")
                sbServicios.Length = 0
                If Not ListVisitados.Contains(CodVisitados) Then
                    drServicioOp = dtOperacionDocHistDet.Select("FACTURA='" & pintFact & "' AND NOPRCN='" & Item("NOPRCN") & "'")
                    For FilaServ As Int32 = 0 To drServicioOp.Length - 1
                        sbServicios.Append(drServicioOp(FilaServ)("NCRROP"))
                        If FilaServ < drServicioOp.Length - 1 Then
                            sbServicios.Append(",")
                        End If
                    Next
                    dr = dtOpJoinxFactura.NewRow
                    dr("FACTURA") = Item("FACTURA")
                    dr("NOPRCN") = Item("NOPRCN")
                    dr("CCLNT") = Item("CCLNT")
                    dr("CCMPN") = Item("CCMPN")
                    dr("CTPODC") = Item("CTPODC")
                    dr("NDCCTC") = Item("NDCCTC")
                    dr("NCRROP") = sbServicios.ToString.Trim
                    dtOpJoinxFactura.Rows.Add(dr)
                    ListVisitados.Add(CodVisitados)
                End If
            End If
        Next
        Return dtOpJoinxFactura
    End Function

    Private Sub ActualizarDocumentoOrigenFactura(ByVal pintFact As Integer, ByVal dtOperacionDocHistDet As DataTable)
        Try
            Dim dtHistorial As New DataTable
            Dim dt As New DataTable
            Dim CTPODC As Decimal = 0, NOPRCN = 0, NDCCTC = 0, CCLNT = 0
            Dim CTPDCO As Decimal = 0, NDCMOR = 0, FDCMOR = 0
            Dim CTPDCO_REF As Decimal = 0, NDCMOR_REF = 0, FDCMOR_REF = 0
            Dim listServicios As String = "", CCMPN = ""
            Dim dtOpJoinxFactura As New DataTable
            dtOpJoinxFactura = UnificarOperacionesxFactura(pintFact, dtOperacionDocHistDet)
            For FILA As Integer = 0 To dtOpJoinxFactura.Rows.Count - 1
                CCLNT = dtOpJoinxFactura.Rows(FILA)("CCLNT")
                NOPRCN = dtOpJoinxFactura.Rows(FILA)("NOPRCN")
                listServicios = dtOpJoinxFactura.Rows(FILA)("NCRROP")
                CTPODC = dtOpJoinxFactura.Rows(FILA)("CTPODC")
                NDCCTC = dtOpJoinxFactura.Rows(FILA)("NDCCTC")
                dt = oFacturaNeg.Lista_Operaciones_Historial_x_Cliente(CCLNT, NOPRCN, listServicios, CTPODC, NDCCTC)
                If FILA = 0 Then
                    dtHistorial = dt.Copy
                Else
                    For INDEX_SERV As Integer = 0 To dt.Rows.Count - 1
                        dtHistorial.ImportRow(dt.Rows(INDEX_SERV))
                    Next
                End If
            Next
            If dtHistorial.Rows.Count > 0 Then
                CCLNT = dtHistorial.Rows(0)("CCLNT")
                '****TIENES SER DIFERENTES A US DOUMENTO ACTUAL
                CTPODC = dtOpJoinxFactura.Rows(0)("CTPODC")
                NDCCTC = dtOpJoinxFactura.Rows(0)("NDCCTC")
                '******************************************
                CCMPN = dtHistorial.Rows(0)("CCMPN")
                EvaluarFechaPrimeroDocumento(CTPDCO_REF, NDCMOR_REF, FDCMOR_REF, dtHistorial)
                oFacturaNeg.Actualizar_Referencia_Documento_Cuenta_Corriente(CCMPN, CTPODC, NDCCTC, CTPDCO_REF, NDCMOR_REF, FDCMOR_REF)
            End If

            'For FILA As Integer = 0 To dtOpJoinxFactura.Rows.Count - 1
            'Next
            ''PARA FACTURAS :GENERALMENTE PARA UN REFACTURA
            'Dim ListVisitados As New List(Of String)
            'Dim lisOperacion As String = ""
            'Dim dr() As DataRow
            'Dim dt As New DataTable
            'dt = dtOperacionDocHistDet.Copy
            'Dim COD_UNICO As String = "", PSCCMPN As String = ""
            'Dim CTPDCO As Decimal = 0, NDCMOR = 0, FDCMOR = 0
            'Dim CTPDCO_REF As Decimal = 0, NDCMOR_REF = 0, FDCMOR_REF = 0
            'For FILA As Integer = 0 To dt.Rows.Count - 1
            '    If dt.Rows(FILA)("FACTURA") = pintFact AndAlso dt.Rows(FILA)("CTPODC") = 1 Then
            '        COD_UNICO = dt.Rows(FILA)("CTPODC") & "_" & dt.Rows(FILA)("NDCCTC")
            '        If Not ListVisitados.Contains(COD_UNICO) Then
            '            dr = dt.Select("NDCCTC='" & dt.Rows(FILA)("NDCCTC") & "' AND CTPODC='" & dt.Rows(FILA)("CTPODC") & "'")
            '            If dr.Length > 0 Then
            '                lisOperacion = UnirOperaciones(dr)
            '                CCLNT = dt.Rows(FILA)("CCLNT")
            '                CTPODC = dt.Rows(FILA)("CTPODC")
            '                NDCCTC = dt.Rows(FILA)("NDCCTC")
            '                PSCCMPN = dt.Rows(FILA)("CCMPN")
            '                dtHistorial = oFacturaNeg.Lista_Operaciones_Historial_x_Cliente(CCLNT, lisOperacion, CTPODC, NDCCTC)
            '                If dtHistorial.Rows.Count > 0 Then
            '                    EvaluarFechaPrimeroDocumento(CTPDCO_REF, NDCMOR_REF, FDCMOR_REF, dtHistorial)
            '                    oFacturaNeg.Actualizar_Referencia_Documento_Cuenta_Corriente(PSCCMPN, CTPODC, NDCCTC, CTPDCO_REF, NDCMOR_REF, FDCMOR_REF)
            '                End If
            '            End If
            '            ListVisitados.Add(COD_UNICO)
            '        End If
            '    End If
            'Next
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub ActualizarDocumentoOrigenFactura(ByVal pintFact As Integer, ByVal dtOperacionDocHistDet As DataTable)
    '    Try
    '        'PARA FACTURAS :GENERALMENTE PARA UN REFACTURA
    '        Dim ListVisitados As New List(Of String)
    '        Dim lisOperacion As String = ""
    '        Dim dr() As DataRow
    '        Dim dt As New DataTable
    '        dt = dtOperacionDocHistDet.Copy
    '        Dim CTPODC As Decimal = 0, NDCCTC = 0, CCLNT = 0
    '        Dim COD_UNICO As String = "", PSCCMPN As String = ""
    '        Dim CTPDCO As Decimal = 0, NDCMOR = 0, FDCMOR = 0
    '        Dim dtHistorial As New DataTable
    '        Dim CTPDCO_REF As Decimal = 0, NDCMOR_REF = 0, FDCMOR_REF = 0
    '        For FILA As Integer = 0 To dt.Rows.Count - 1
    '            If dt.Rows(FILA)("FACTURA") = pintFact AndAlso dt.Rows(FILA)("CTPODC") = 1 Then
    '                COD_UNICO = dt.Rows(FILA)("CTPODC") & "_" & dt.Rows(FILA)("NDCCTC")
    '                If Not ListVisitados.Contains(COD_UNICO) Then
    '                    dr = dt.Select("NDCCTC='" & dt.Rows(FILA)("NDCCTC") & "' AND CTPODC='" & dt.Rows(FILA)("CTPODC") & "'")
    '                    If dr.Length > 0 Then
    '                        lisOperacion = UnirOperaciones(dr)
    '                        CCLNT = dt.Rows(FILA)("CCLNT")
    '                        CTPODC = dt.Rows(FILA)("CTPODC")
    '                        NDCCTC = dt.Rows(FILA)("NDCCTC")
    '                        PSCCMPN = dt.Rows(FILA)("CCMPN")
    '                        dtHistorial = oFacturaNeg.Lista_Operaciones_Historial_x_Cliente(CCLNT, lisOperacion, CTPODC, NDCCTC)
    '                        If dtHistorial.Rows.Count > 0 Then
    '                            EvaluarFechaPrimeroDocumento(CTPDCO_REF, NDCMOR_REF, FDCMOR_REF, dtHistorial)
    '                            oFacturaNeg.Actualizar_Referencia_Documento_Cuenta_Corriente(PSCCMPN, CTPODC, NDCCTC, CTPDCO_REF, NDCMOR_REF, FDCMOR_REF)
    '                        End If
    '                    End If
    '                    ListVisitados.Add(COD_UNICO)
    '                End If
    '            End If
    '        Next
    '    Catch ex As Exception
    '    End Try
    'End Sub


    Private Sub Grabar_Factura(ByVal pintFact As Integer)
        Dim strNumFact As String = ""
        Dim objFiltro As New Filtro

        Try
            Cursor = Cursors.WaitCursor
            Dim oDs As DataSet
            oDs = phtOperacioFacturar.Item(pintFact)

            oFacturaNeg.Grabar_Factura(pintFact, oDtCabFactura, oDs.Tables(1), strNumFact)
            oFacturaNeg.Grabar_Referencia_Factura(pintFact, 1, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia1, strNumFact)
            oFacturaNeg.Grabar_Referencia_Factura(pintFact, 2, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia2, strNumFact)
            ' Dim sr As String = ""
            ''*****HISTORIAL DOCUMENTO**********************
            ActualizarTempDocumentoHistorial(pintFact)
            ''**********************************************

            Dim obeFacturaHistorialDet As FacturaHistorialDet
            For intCount As Integer = 0 To oDs.Tables(0).Rows.Count - 1
                'objFiltro.Parametro1 = oDs.Tables(0).Rows(intCount).Item("NOPRCN") 'dblConsistencia
                'objFiltro.Parametro2 = oDs.Tables(0).Rows(intCount).Item("NRTFSV")
                'objFiltro.Parametro3 = oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim
                'objFiltro.Parametro4 = strNumFact
                'objFiltro.Parametro5 = oDs.Tables(0).Rows(intCount).Item("NCRDCC")
                'objFiltro.Parametro6 = oDs.Tables(0).Rows(intCount).Item("NCRROP")
                ''oFacturaNeg.Actualizar_Detalle_Facturado_X_Operacion(objFiltro)
                'oFacturaNeg.Actualizar_Detalle_Facturado_X_Operacion_V2(objFiltro)
                obeFacturaHistorialDet = New FacturaHistorialDet
                obeFacturaHistorialDet.PNNOPRCN = oDs.Tables(0).Rows(intCount).Item("NOPRCN")
                obeFacturaHistorialDet.PNNRTFSV = oDs.Tables(0).Rows(intCount).Item("NRTFSV")
                obeFacturaHistorialDet.PNCTPODC = oDs.Tables(0).Rows(intCount).Item("CTPODC")
                obeFacturaHistorialDet.PNNDCFCC = oDs.Tables(0).Rows(intCount).Item("NDCCTC")
                obeFacturaHistorialDet.PNNCRDCC = oDs.Tables(0).Rows(intCount).Item("NCRDCC")
                obeFacturaHistorialDet.PNNCRROP = oDs.Tables(0).Rows(intCount).Item("NCRROP")
                obeFacturaHistorialDet.PSNTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                oFacturaNeg.Actualizar_Detalle_Facturado_X_Operacion_V2(obeFacturaHistorialDet)
            Next intCount

            Dim dtOperacionDocHistCab As New DataTable
            Dim dtOperacionDocHistDet As New DataTable
            oFacturaNeg.Formar_Cabecera_Detalle_Historial(dtOperacionDocHistCab, dtOperacionDocHistDet, oDs.Tables(0), pintFact)

            ' ActualizarDocumentoOrigenFactura(pintFact, dtOperacionDocHistDet)


            'oFacturaNeg.Grabar_Historial_Documento(oFacturaNeg.dtFacturaOperacion, oFacturaNeg.dtFacturaOperacionDet, pintFact, oDs.Tables(0).Copy)
            'oFacturaNeg.Grabar_Historial_Documento(oDs.Tables(0))

            oFacturaNeg.Grabar_Historial_Documento(dtOperacionDocHistCab, dtOperacionDocHistDet, pintFact)

            ActulizaNombreServicio(oDs.Tables(0).Copy, strNumFact, pintFact)

            'ActulizaNombreServicioHistorial(oDs.Tables(0).Copy, strNumFact, pintFact, oFacturaNeg.dtFacturaOperacion.Copy)
            ActulizaNombreServicioHistorial(dtOperacionDocHistDet, strNumFact, pintFact)

            'Actualizar_NombreServicio_Historial
            ''CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).dtgDetalle.Rows(0).Cells("")
            '*****HISTORIAL DOCUMENTO**********************
            'ActualizarTempDocumentoHistorial(pintFact)

            '*****************************************
            'Me.TabPage1.Text = "Factura N°" & strNumFact
            'CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).NumFactura = "N° " & strNumFact
            'lblNumFact.Text = "N° " & strNumFact.


            'ACTUALIZAMOS LA FACTURA CON LA DETRACCION CORRESPONDIENTE
            If mListaoFact(0).PSCTPDCI = "RU" Then
                Dim obeEntidad As New FacturaHistorialCab
                With obeEntidad
                    .PSCCMPN = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                    .PNCTPODC = oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim
                    .PNNDCFCC = strNumFact
                End With
                If oFacturaNeg.fintActualizarFacturaDetracionSPOT(obeEntidad) = -1 Then
                    HelpClass.ErrorMsgBox()
                End If
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            strNumFact = ""
            HelpClass.MsgBox("Error al grabar la factura " & vbCrLf & ex.Message)
        End Try
        If strNumFact <> "" Then
            Cursor = Cursors.Default
            Dim msje As String = ""

            If mListaoFact(0).PSCTPDCI = "RU" Then
                msje = "Se grabó correctamente la Factura N° " & strNumFact
            Else
                msje = "Se grabó correctamente la Boleta N° " & strNumFact
            End If
            If lintImprimir = 1 Then
                Imprime_Factura(strNumFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim)
            End If
            'Grabar RZCT01A, RZCT02A
            If Grabar_FacturaElectronica(strNumFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim) Then 'Desarrollador 3 JD
                HelpClass.MsgBox(msje)
            End If
            'Comentado por mientras
            Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact)
        End If

        NumeroDocumento = strNumFact 'CSR-HUNDRED-ESTIMACION-INGRESO
        Cursor = Cursors.Default
    End Sub

    Private Sub Enviar_Factura_SAP(ByVal pstrCompania As String, ByVal pstrTipoDoc As String, ByVal pstrNumFact As String)
        Dim oFiltro As New Filtro
        Dim oDt As DataTable
        Dim strNumSAP As String = ""

        Try
            oFiltro.Parametro1 = pstrCompania.PadLeft(2, "0")
            oFiltro.Parametro2 = pstrTipoDoc.PadLeft(3, "0")
            oFiltro.Parametro3 = pstrNumFact.PadLeft(10, "0")
            oFacturaNeg.Enviar_Documento_SAP(oFiltro)
            oFiltro.Parametro1 = pstrCompania
            oFiltro.Parametro2 = pstrTipoDoc
            oFiltro.Parametro3 = pstrNumFact
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

    Private Sub Limpiar_Datos_Factura()
        oFacturaNeg.Limpiar_Datos_Factura()
    End Sub

    Public Sub Imprime_Factura(ByVal pdblNumFacImp As Double, ByVal pstrCompania As String, ByVal pstrTipoDoc As String)
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

    'Private Function ListaReferencias(ByVal RefText As String, ByVal MaxFilas As Int32, ByVal MaxCaractxFila As Int32) As SortedList
    '    Dim HasFilas As New SortedList
    '    Dim texto As String = ""
    '    Dim textoTempo As String = ""
    '    Dim itemFila As Int32 = 0

    '    For Each Item As String In RefText.Split("|")
    '        textoTempo = Item.Replace(Chr(10), "")
    '        If textoTempo.Trim.Length > 0 Then
    '            While textoTempo.Trim.Length > 0 '85 tipo 1
    '                If textoTempo.Trim.Length > MaxCaractxFila + 1 Then
    '                    HasFilas(HasFilas.Count - 1) = textoTempo.Substring(0, MaxCaractxFila)
    '                    textoTempo = textoTempo.Substring(MaxCaractxFila, textoTempo.Length - MaxCaractxFila)
    '                Else
    '                    If textoTempo.Trim.Length > 0 Then
    '                        HasFilas(HasFilas.Count - 1) = textoTempo
    '                    End If
    '                    textoTempo = ""
    '                End If
    '            End While
    '            If HasFilas.Count >= MaxFilas Then
    '                Exit For
    '            End If
    '        End If
    '    Next
    '    Return HasFilas
    'End Function

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim oDs As DataSet
        Dim oFiltro As New Filtro
        Dim myFont As New Font("Arial", 8)
        Dim intCont As Integer
        Dim oDr() As DataRow
        Dim intPosLinea As Integer = 0
        Dim dblTotal As Double = 0
        Dim bolIGV As Boolean = False
        Dim strMonto As String = ""
        Dim strMoneda As String = ""
        Dim dblSubTotalSoles As Double = 0
        Dim dblTotalSoles As Double = 0
        Dim oDtDetalleFac As New DataTable
        'Dim drawFormat As New StringFormat

        'drawFormat.Alignment = StringAlignment.Near
        oFiltro.Parametro1 = strCompFacImp
        oFiltro.Parametro2 = strTipoDocFacImp
        oFiltro.Parametro3 = dblNumFacImp
        oDs = oFacturaNeg.Lista_Datos_Factura(oFiltro)

        'Se debe de imprimir segun el tipo de impresion
        oDtDetalleFac = oDs.Tables(1).Clone


        Select Case mListaoFact.Item(0).TIPOFACTURA
            Case 1

                Dim IntCodRubro As Integer = 0
                Dim dblMontoSoles As Double = 0
                Dim dblMontoDolare As Double = 0
                Dim IntCantidadRows As Integer = 0
                Dim oDrTemp() As DataRow
                Dim oDtTemp As DataTable
                oDtTemp = oDs.Tables(1).Copy
                While (1) 'Se repite por la cantidad de Detalles de la Factura
                    If oDtTemp.Rows.Count = 0 Then
                        Exit While
                    End If
                    dblMontoSoles = 0
                    dblMontoDolare = 0
                    IntCodRubro = Val(oDtTemp.Rows(0).Item("NRRUBR"))
                    oDrTemp = oDtTemp.Select("NRRUBR='" & IntCodRubro & "'")
                    For IntCantidadRows = 0 To oDrTemp.Length - 1
                        dblMontoSoles = oDrTemp(IntCantidadRows).Item("IVLDCS") + dblMontoSoles
                        dblMontoDolare = oDrTemp(IntCantidadRows).Item("IVLDCD") + dblMontoDolare
                    Next
                    oDrTemp(0).Item("IVLDCS") = dblMontoSoles
                    oDrTemp(0).Item("IVLDCD") = dblMontoDolare
                    oDtDetalleFac.ImportRow(oDrTemp(0))

                    For IntCantidadRows = 0 To oDrTemp.Length - 1
                        oDtTemp.Rows.Remove(oDrTemp(IntCantidadRows))
                    Next

                End While
            Case 2
                For Each dr As DataRow In oDs.Tables(1).Rows
                    oDtDetalleFac.ImportRow(dr)
                Next
        End Select

        oDs.Tables(1).Clear()
        For Each dr As DataRow In oDtDetalleFac.Rows
            oDs.Tables(1).ImportRow(dr)
        Next

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
        'se junta todas las filas
        Dim srtCadenas As String = ""
        'For i As Integer = 0 To oDr.Length - 1
        '    srtCadenas = srtCadenas & oDr(i).Item("TOBCTC").ToString
        'Next
        'srtCadenas = srtCadenas.Replace(Chr(13), "//")
        'imprimir en filas de 70

        Dim HasFilas As New SortedList
        Dim texto As String = ""
        Dim textoTempo As String = ""
        Dim itemFila As Int32 = 0

        'For intCont = 0 To oDr.Length - 1
        '    texto = texto & oDr(intCont).Item("TOBCTC").ToString.Replace(Chr(10), "")
        'Next


        For intCont = 0 To oDr.Length - 1
            texto = ("" & oDr(intCont).Item("TOBCTC")).ToString.Trim.Replace(Chr(10), "")
            'texto = texto & oDr(intCont).Item("TOBCTC").ToString.Replace(Chr(10), "")
            If texto.Length > 0 Then
                HasFilas(HasFilas.Count - 1) = texto
                If HasFilas.Count >= 4 Then
                    Exit For
                End If
            End If
        Next


        'For Each Item As String In texto.Split("|")
        '    textoTempo = Item
        '    'If itemFila > 0 Then
        '    '    textoTempo = Chr(13) & Item
        '    'End If
        '    If textoTempo.Trim.Length > 0 Then
        '        While textoTempo.Length > 0
        '            If textoTempo.Length > 85 Then
        '                'nuevoTexto = nuevoTexto & textoTempo.Substring(0, 69) & Chr(13)
        '                HasFilas(HasFilas.Count - 1) = textoTempo.Substring(0, 85).Trim
        '                textoTempo = textoTempo.Substring(85, textoTempo.Length - 85).Trim
        '            Else
        '                HasFilas(HasFilas.Count - 1) = textoTempo.Trim
        '                'nuevoTexto = nuevoTexto & textoTempo
        '                textoTempo = ""
        '            End If
        '        End While
        '        If HasFilas.Count >= 4 Then
        '            Exit For
        '            'itemFila = itemFila + 1
        '            'If itemFila >= 4 Then
        '            '    Exit For
        '            'End If
        '        End If
        '    End If
        'Next



        'For intCont = 0 To oDr.Length - 1
        '    srtCadenas = oDr(intCont).Item("TOBCTC").ToString
        '    srtCadenas = srtCadenas.Replace(vbCrLf, "//")
        '    args.Graphics.DrawString(srtCadenas, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
        '    intPosLinea = intPosLinea + 13
        'Next intCont
        'HasFilas = ListaReferencias(texto, 4, 85)
        For Each item As DictionaryEntry In HasFilas
            srtCadenas = item.Value
            args.Graphics.DrawString(srtCadenas, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
            intPosLinea = intPosLinea + 13
        Next


        'For intCont = 0 To oDr.Length - 1
        '    srtCadenas = oDr(intCont).Item("TOBCTC").ToString
        '    srtCadenas = srtCadenas.Replace(vbCrLf, "//")
        '    args.Graphics.DrawString(srtCadenas, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
        '    intPosLinea = intPosLinea + 13
        'Next intCont



        'se separa por enter
        'For Each strFila As String In srtCadenas.Split(Chr(13))
        '    args.Graphics.DrawString(strFila.ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
        '    intPosLinea = intPosLinea + 13
        'Next
        'For intCont = 0 To oDr.Length - 1
        '    args.Graphics.DrawString(oDr(intCont).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
        '    intPosLinea = intPosLinea + 13
        'Next intCont

        'Si el tipo es por Rubro la variable mListaoFact.Item(0).TIPOFACTURA sera igual a "1"

        If mListaoFact.Item(0).TIPOFACTURA = 2 Then


            args.Graphics.DrawString("Cod", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 270)
            args.Graphics.DrawString("Rub", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 283)

            args.Graphics.DrawString("Descripción", New Font(myFont, FontStyle.Regular), Brushes.Black, 75, 270)
            args.Graphics.DrawString("Rubro", New Font(myFont, FontStyle.Regular), Brushes.Black, 75, 283)

            If Not Me.chkDescripcionManual.Checked Then
                args.Graphics.DrawString("Observación", New Font(myFont, FontStyle.Regular), Brushes.Black, 300, 270)
            End If
            args.Graphics.DrawString("Cantidad", New Font(myFont, FontStyle.Regular), Brushes.Black, 485, 270)
            args.Graphics.DrawString("Aplicada", New Font(myFont, FontStyle.Regular), Brushes.Black, 485, 283)

            args.Graphics.DrawString("Importe", New Font(myFont, FontStyle.Regular), Brushes.Black, 625, 270)
            args.Graphics.DrawString("Tarifa", New Font(myFont, FontStyle.Regular), Brushes.Black, 625, 283)


        Else
            args.Graphics.DrawString("Descripción", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 270)
        End If



        args.Graphics.DrawString("Importe", New Font(myFont, FontStyle.Regular), Brushes.Black, 745, 270)
        args.Graphics.DrawString("Rubro", New Font(myFont, FontStyle.Regular), Brushes.Black, 745, 283)


        intPosLinea = 296

        For intCont = 0 To oDs.Tables(1).Rows.Count - 1
            If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                Dim NOMSER As String = String.Empty
                Dim TOBS As String = String.Empty
                Dim NOMSRV As String = String.Empty

                Dim oDtNew As New DataTable


                oFiltro.Parametro1 = mListaoFact.Item(0).PSCCMPN
                oFiltro.Parametro2 = mListaoFact.Item(0).PSCDVSN
                oFiltro.Parametro3 = oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim
                oFiltro.Parametro4 = oDs.Tables(1).Rows(intCont).Item("NRTFSV")
                oDtNew = oFacturaNeg.Lista_Datos_Servicio(oFiltro)


                If mListaoFact.Item(0).TIPOFACTURA = 2 Then

                    NOMSER = oDtNew.Rows(0).Item("NOMSER").ToString.Trim 'Descripcion
                    TOBS = oDtNew.Rows(0).Item("TOBS").ToString.Trim ' observacion
                    NOMSRV = oDs.Tables(1).Rows(intCont).Item("NCRDCC") & " " & oDs.Tables(1).Rows(intCont).Item("CRBCTC") & " " & NOMSER
                    If TOBS.Length > 34 Then
                        TOBS = TOBS.Substring(0, 34)
                    End If

                    args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea) 'codigo del rubro

                    If Me.chkDescripcionManual.Checked Then
                        args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("NOMSRV").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
                    Else
                        args.Graphics.DrawString(NOMSER, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
                        args.Graphics.DrawString(TOBS, New Font(myFont, FontStyle.Regular), Brushes.Black, 300, intPosLinea)
                    End If
                    'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 465, intPosLinea) 'cantidad aplicada
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,##0.00000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 465, intPosLinea) 'cantidad aplicada
                    args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 555, intPosLinea) '' tipo
                    'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 590, intPosLinea) 'importe tarifa
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,##0.000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 590, intPosLinea) 'importe tarifa
                    args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 680, intPosLinea) 'moneda
                    'If mListaoFact(0).PSCTPDCI = "RU" Then
                    '    args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 680, intPosLinea) 'moneda
                    'Else
                    '    args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim + oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim(), New Font(myFont, FontStyle.Regular), Brushes.Black, 680, intPosLinea) 'moneda
                    'End If
                Else
                    If Me.chkDescripcionManual.Checked Then
                        NOMSER = oDs.Tables(1).Rows(intCont).Item("NOMSRV").ToString.Trim
                    Else
                        NOMSER = oDtNew.Rows(0).Item("TCMTRF").ToString.Trim
                    End If


                    args.Graphics.DrawString(NOMSER, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)

                End If

                If oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                    strMoneda = "USD"
                Else
                    strMoneda = "S/."
                End If
                If mListaoFact(0).PSCTPDCI = "RU" Then
                    If strMoneda = "USD" Then
                        args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                        'dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim
                        dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), 2)
                    Else
                        args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                        'dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim
                        dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), 2)
                    End If
                    '***
                Else
                    If strMoneda = "USD" Then
                        args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim + (oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim / 100 * oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim), Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                        ' dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim + (oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim / 100 * oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim)
                        dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim + (oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim / 100 * oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim), Double), 2)
                    Else
                        args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim + (oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim / 100 * oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim), Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                        'dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim + (oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim / 100 * oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim)
                        dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim + (oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim / 100 * oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim), Double), 2)
                    End If
                End If
                '***
                ' dblSubTotalSoles = dblSubTotalSoles + oDs.Tables(1).Rows(intCont).Item("IVLDCS")
                dblSubTotalSoles = dblSubTotalSoles + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS"), Double), 2)
            Else
                bolIGV = True
                intPosLinea = intPosLinea - 13
            End If
            intPosLinea = intPosLinea + 13
        Next intCont

        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        If mListaoFact(0).PSCTPDCI = "RU" Then
            args.Graphics.DrawString("Subtotal: ", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
            args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
            'args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
            intPosLinea = intPosLinea + 13

            If bolIGV Then
                args.Graphics.DrawString("IGV " & oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim & " %:", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
                If strMoneda = "USD" Then
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
                    'dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim
                    dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), 2)
                Else
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    'dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim
                    dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), 2)
                End If
                intPosLinea = intPosLinea + 13
            End If
        End If
        'dblTotalSoles = dblSubTotalSoles + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS")
        dblTotalSoles = dblSubTotalSoles + Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS"), Double), 2)
        If mListaoFact(0).PSCTPDCI = "RU" Then
            args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
            intPosLinea = intPosLinea + 13
        End If
        args.Graphics.DrawString("Total: " & strMoneda, New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00").PadLeft(15, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13

        oDr = oDs.Tables(2).Select("CTPDCC = 2")
        intPosLinea = intPosLinea + 13

        'For intCont = 0 To oDr.Length - 1
        '    srtCadenas = oDr(intCont).Item("TOBCTC").ToString
        '    srtCadenas = srtCadenas.Replace(vbCrLf, "//")
        '    args.Graphics.DrawString(srtCadenas, New Font(myFont, FontStyle.Regular), Brushes.Black, 0, intPosLinea)
        '    intPosLinea = intPosLinea + 13
        'Next intCont

        texto = ""
        HasFilas = New SortedList
        For intCont = 0 To oDr.Length - 1
            '  texto = texto & oDr(intCont).Item("TOBCTC").ToString.Trim
            texto = ("" & oDr(intCont).Item("TOBCTC")).ToString.Trim
            If texto.Length > 0 Then
                HasFilas(HasFilas.Count - 1) = texto
                If HasFilas.Count >= 5 Then
                    Exit For
                End If
            End If
        Next
        'HasFilas = ListaReferencias(texto, 5, 115)
        For Each item As DictionaryEntry In HasFilas
            srtCadenas = item.Value
            args.Graphics.DrawString(srtCadenas, New Font(myFont, FontStyle.Regular), Brushes.Black, 0, intPosLinea)
            intPosLinea = intPosLinea + 13
        Next

        'CSR-HUNDRED-240815-AJUSTE-MONEDA-INICIO
        Dim strMensajeError As String = ""
        Dim dtMoneda As DataTable
        Dim oMoneda_DAL As New Ransa.Controls.Moneda.Moneda_DAL
        Dim Soles As String = ""
        Dim Dolares As String = ""

        dtMoneda = oMoneda_DAL.fdtListar_Listar_Moneda(strMensajeError)

        For Each dr As DataRow In dtMoneda.Rows
            If (dr("CMNDA1") = 1) Then
                Soles = dr("TMNDA").ToString
            ElseIf (dr("CMNDA1") = 100) Then
                Dolares = dr("TMNDA").ToString
            End If
        Next

        'CSR-HUNDRED-240815-AJUSTE-MONEDA-FIN



        If strMoneda = "USD" Then
            'strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & Dolares 'CSR-HUNDRED-240815-AJUSTE-MONEDA  " Dolares Americanos"
        Else
            'strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & Soles 'CSR-HUNDRED-240815-AJUSTE-MONEDA " Nuevos Soles"
        End If
        args.Graphics.DrawString("Son: " & strMonto, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 660)
        args.Graphics.DrawString(strMoneda & "    " & Format(dblTotal, "###,###,###,##0.00").PadLeft(16, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 630, 720)

        args.Graphics.DrawString("VENCIDO EL PLAZO DE PAGO SE COBRARAN INT. MORAS Y GTOS. ADM", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 730)
        If mListaoFact(0).PSCTPDCI = "RU" Then
            Dim pnMonto As Decimal = 0
            Dim pnPorcentaje As Decimal = 0
            pnMonto = oDs.Tables(1).Rows(0).Item("IAFCDT")
            pnPorcentaje = oDs.Tables(1).Rows(0).Item("IPRCDT")

            If (dblTotalSoles) >= pnMonto And pnPorcentaje > 0 Then
                args.Graphics.DrawString("OP. SUJETA AL S.P.O.T. CON EL GOB.CENTRAL POR EL " & pnPorcentaje.ToString & "% - CUENTA 362956", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 743)


            End If

        End If
    End Sub


#End Region

#Region "Eventos de Control"

    Private Sub frmVistaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambiado por Azorrillap 2011-03-01
        HabilitarFechaFactura()
        oFacturaNeg.ListaoFact = mListaoFact

        Try
            Dim sbListOperacion As New StringBuilder
            Dim strOperacion As String = ""
            Dim ListVisit As New Hashtable
            For Each Item As FacturaSIL In mListaoFact
                If Not ListVisit.Contains(Item.NOPRCN) Then
                    ListVisit.Add(Item.NOPRCN, Item.NOPRCN)
                    sbListOperacion.Append(Item.NOPRCN)
                    sbListOperacion.Append(",")
                End If
            Next
            If sbListOperacion.Length > 0 Then
                strOperacion = sbListOperacion.ToString.Trim
                strOperacion = strOperacion.Substring(0, strOperacion.Length - 1)
            End If
            Dim dtOrigen As New DataTable
            oFacturaNeg.CTPDCO = 0
            oFacturaNeg.NDCMOR = 0
            oFacturaNeg.FDCMOR = 0
            If strOperacion.Length > 0 Then
                'DOC ORIGEN MAS ANTIGUO
                dtOrigen = oFacturaNeg.Lista_Doc_Origen_Operacion(strOperacion)
                If dtOrigen.Rows.Count > 0 Then
                    oFacturaNeg.CTPDCO = dtOrigen.Rows(0)("CTPDCO")
                    oFacturaNeg.NDCMOR = dtOrigen.Rows(0)("NDCMOR")
                    oFacturaNeg.FDCMOR = dtOrigen.Rows(0)("FDCMOR")
                End If
            End If

        Catch ex As Exception

        End Try
        '=================================
        TipoDeCambio()
        CargarDatos()
        Datos_Generales_Factura()

        Obtener_Datos_Adicionales_Factura() 'CSR-HUNDRED

        If mListaoFact(0).PSCTPDCI = "RU" Then
            Label2.Text = "FACTURA"
            btnFacturar.Text = "Facturar"
            Generar_Factura()
        Else
            Label2.Text = "BOLETA"
            btnFacturar.Text = "Boleta"
            Generar_Boleta()
        End If


        Validar()
        '<[AHM]>
        'Me.ValidarCliente() ECM-HUNDRED-SOPORTE[180716]
        '</[AHM]>
        'ValidarClienteFE()

    End Sub

    'CSR-HUNDRED-INICIO
    Private Sub Obtener_Datos_Adicionales_Factura()
        Dim oDtNew As DataTable
        'Dim oFiltro As New Filtro
        Dim oFiltro As New Hashtable
        Dim strCompania As String

        'oFiltro.Parametro1 = mListaoFact(0).PSCCMPN 'dblCompania
        oFiltro("CCMPN") = mListaoFact(0).PSCCMPN 'dblCompania


        oDtNew = oFacturaNeg.Lista_Datos_Adicionales_Factura(oFiltro)

        strCompania = oDtNew.Rows(0).Item("TDRCOR").ToString.Trim
        strCompania = strCompania & vbCrLf & oDtNew.Rows(0).Item("TDPRT").ToString.Trim & " - " & oDtNew.Rows(0).Item("TPRVN").ToString.Trim & " - " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCompania = strCompania & vbCrLf & "CT : +" & oDtNew.Rows(0).Item("NTLFN").ToString.Trim
        strCompania = strCompania & vbCrLf & oDtNew.Rows(0).Item("NTLFN2").ToString.Trim
        strCompania = strCompania & vbCrLf & "Fax : +" & oDtNew.Rows(0).Item("NFAX").ToString.Trim

        Me.LbDatos_Adicional_Factura.Text = strCompania

        Me.LbDatos_Adicional_Factura_Ruc.Text = "R.U.C.: " & oDtNew.Rows(0).Item("NRUC").ToString.Trim

    End Sub
    'CSR-HUNDRED-FIN

    Private Sub ValidarClienteFE()

        Try

            Dim objHash As New Hashtable
            'Dim objFiltro As New Filtro
            Dim objFiltro As New Hashtable
            Dim oDtPlanta As DataTable

            'objFiltro.Parametro1 = mListaoFact(0).PSCCMPN 'strCodDiv
            'objFiltro.Parametro2 = mListaoFact(0).PSCDVSN 'strCodCom
            'objFiltro.Parametro3 = cmbPlantaFacturar.SelectedValue 'oFact.CPLNDV  'strCodPlanta

            objFiltro("CCMPN") = mListaoFact(0).PSCCMPN 'strCodDiv
            objFiltro("CDVSN") = mListaoFact(0).PSCDVSN 'strCodCom
            objFiltro("CPLNDV") = cmbPlantaFacturar.SelectedValue 'oFact.CPLNDV  'strCodPlanta
 


            oDtPlanta = oFacturaNeg.Lista_Datos_Planta(objFiltro)

            objHash.Add("CCMPN", mListaoFact(0).PSCCMPN)
            objHash.Add("CZNFCC", oDtPlanta.Rows(0).Item("CZNFCC").ToString.PadLeft(3, "0"))
            objHash.Add("CCLNT", mListaoFact(0).CCLNFC.ToString.PadLeft(6, "0"))
            objHash.Add("CRGVTA", txtRegionVenta.Text.Trim.PadLeft(3, "0"))


            Dim strEstado As String = ""
            Dim strResultado As String = oFacturaNeg.fstrValidarClienteSAPFE(objHash, strEstado)
            Select Case strResultado
                Case ""
                    HelpClass.MsgBox("ERROR : Ocurrió un Problema de Conexión", MessageBoxIcon.Information)
                    Me.btnFacturar.Enabled = False
                    cmbGiro.Enabled = False
                    dtpFechaFac.Enabled = False
                Case "1"
                    HelpClass.MsgBox("ADVERTENCIA : " & "Cliente habilitado para la Facturación electrónica ", MessageBoxIcon.Information)
                    Me.btnFacturar.Enabled = False
                    cmbGiro.Enabled = False
                    dtpFechaFac.Enabled = False
                Case "2"
                    HelpClass.MsgBox("ADVERTENCIA : " & "Cliente, Negocio y la Zona de facturación no están configurados en el SAP ", MessageBoxIcon.Information)
                    Me.btnFacturar.Enabled = False
                    cmbGiro.Enabled = False
                    dtpFechaFac.Enabled = False
            End Select

        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Datos_Generales_Factura()
        Generar_Factura()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmbGiro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGiro.SelectedIndexChanged
        Actualizar_Punto_Venta()
    End Sub

    Private Sub tabFactura_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFactura.SelectedIndexChanged
        lblNumFact.Text = tabFactura.SelectedTab.Text.Trim
    End Sub

    Private Sub dtpFechaFac_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaFac.ValueChanged
        TipoDeCambio()
    End Sub

#End Region

    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click

        If Me.cmbPtoVenta.SelectedValue Is Nothing Then
            MessageBox.Show("Verifique el Punto de Venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Datos_Generales_Factura()
        If mListaoFact(0).PSCTPDCI = "RU" Then
            Generar_Factura()
            'Imprime la Factura
            Try
                ImprimirFactura()
            Catch ex As Exception
                MessageBox.Show("Error al guardar el cliente de la operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            Generar_Boleta()
            Try
                ImprimirBoleta()
            Catch ex As Exception
                MessageBox.Show("Error al guardar el cliente de la operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If


        'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
        Dim oDt As DataTable
        oDt = Estimacion_Ingreso_Revertir()

        'Invocar el Servicio Web con los parametros devueltos del SP
        If oDt.Rows.Count > 0 Then
            Dim IdEstimacion As Double, AnioContaSap As Double, FechaDocCtaCte As Double
            Dim NroDocEstimacionSap As String, CodSociedadSap As String, NumDocElectronico As String
            IdEstimacion = oDt.Rows(0).Item("IDESTM")
            NroDocEstimacionSap = oDt.Rows(0).Item("NDESAP").ToString.Trim
            CodSociedadSap = oDt.Rows(0).Item("CSCDSP").ToString.Trim
            AnioContaSap = oDt.Rows(0).Item("ACNTSP")
            NumDocElectronico = oDt.Rows(0).Item("NDCCTE").ToString.Trim
            FechaDocCtaCte = oDt.Rows(0).Item("FDCFCC")

            'INI-ECM-ActualizacionTarifario[RF001]-160516
            Dim WsSalmon As New Ransa.Controls.ServicioOperacion.ws_reversion_Ingreso.ws_salmon
            WsSalmon.ws_reversion_ingreso(IdEstimacion, CodSociedadSap, NroDocEstimacionSap, AnioContaSap, NumDocElectronico, FechaDocCtaCte)
            'FIN-ECM-ActualizacionTarifario[RF001]-160516
        End If
        'CSR-HUNDRED-ESTIMACION-INGRESO-FIN

        Me.Cursor = Cursors.Default

    End Sub



    Private Sub ImprimirBoleta()
        Dim strEstado As String = ""
        For lintIndice As Int32 = 0 To oFacturaNeg.NroItemFactura.Count - 1
            If oFacturaNeg.NroItemFactura(lintIndice) > 15 Then
                strEstado = strEstado & oFacturaNeg.NroItemFactura(lintIndice) & ","
            End If
        Next
        If strEstado.Trim.Length > 0 Then
            strEstado.Trim.Substring(0, strEstado.Trim.Length - 1)
            HelpClass.MsgBox("Se excedió Nro Máximo de Item la Boleta N° ", MessageBoxIcon.Warning)
            Exit Sub
        Else
            Select Case MessageBox.Show("Desea : " & Chr(13) & _
                                    "(   Si   )-->(Guardar e Imprimir la Boleta)" & Chr(13) & _
                                    "(   No   )-->(Solo Guardar)" & Chr(13) & _
                                    "(Cancelar)-->(Cancelar Proceso)", "Boleta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                Case Windows.Forms.DialogResult.Yes
                    lintImprimir = 1
                    Grabar = True
                Case Windows.Forms.DialogResult.No
                    lintImprimir = 2
                    Grabar = True
                Case Windows.Forms.DialogResult.Cancel
                    Grabar = False
                    Exit Sub
            End Select
            For intContador As Integer = 1 To Me.tabFactura.TabCount
                Grabar_Factura(intContador)
                Me.lblNumFact.Tag = intContador
            Next
            Me.lblNumFact.Tag = New Object

            Me.Close()
        End If
    End Sub
    Private Sub ImprimirFactura()
        Dim strEstado As String = ""
        For lintIndice As Int32 = 0 To oFacturaNeg.NroItemFactura.Count - 1
            If oFacturaNeg.NroItemFactura(lintIndice) > 15 Then
                strEstado = strEstado & oFacturaNeg.NroItemFactura(lintIndice) & ","
            End If
        Next
        If strEstado.Trim.Length > 0 Then
            strEstado.Trim.Substring(0, strEstado.Trim.Length - 1)
            HelpClass.MsgBox("Se excedió Nro Máximo de Item la Factura N° ", MessageBoxIcon.Warning)
            Exit Sub
        Else
            Select Case MessageBox.Show("Desea : " & Chr(13) & _
                                    "(   Si   )-->(Guardar e Imprimir la Factura)" & Chr(13) & _
                                    "(   No   )-->(Solo Guardar)" & Chr(13) & _
                                    "(Cancelar)-->(Cancelar Proceso)", "Factura", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

                'Select Case MessageBox.Show("Desea : " & Chr(13) & _
                '                       "(Si)-->(Guardar)" & Chr(13) & _
                '                       "(No)-->(Cancelar Proceso)", "Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

                Case Windows.Forms.DialogResult.Yes
                    lintImprimir = 1
                    Grabar = True
                Case Windows.Forms.DialogResult.No
                    lintImprimir = 2
                    Grabar = True
                Case Windows.Forms.DialogResult.Cancel
                    Grabar = False
                    Exit Sub
            End Select
            For intContador As Integer = 1 To Me.tabFactura.TabCount
                Grabar_Factura(intContador)
                Me.lblNumFact.Tag = intContador
            Next
            Me.lblNumFact.Tag = New Object

            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub chkDescripcionManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDescripcionManual.CheckedChanged
        For intCont As Integer = 0 To Me.tabFactura.Controls.Count - 1
            CType(Me.tabFactura.TabPages(intCont).Controls(0), ctrlFactura).ModificarDescripcionFactura = Not Me.chkDescripcionManual.Checked
        Next
    End Sub

    'oDtCabFactura.Copy, oDs.Tables(0).Copy

    Private Sub ActulizaNombreServicio(ByVal dtServFactura As DataTable, ByVal strNumFac As String, ByVal intControls As Integer)
        If Me.chkDescripcionManual.Checked Then
            Dim oDtServicios As New DataTable
            Dim oDtAux As New DataTable
            Dim pobjFiltro As New Filtro
            Dim oFactura As New SOLMIN_CTZ.NEGOCIO.clsFactura
            Dim oDtDatos As New DataTable
            'For intCant As Integer = 0 To mListaoFact.Count - 1
            '    If mListaoFact(intCant).NSECFC = 0 Then
            '        pobjFiltro.Parametro1 = mListaoFact(intCant).NOPRCN
            '        pobjFiltro.Parametro3 = HelpClass.CtypeDate(Me.dtpFechaFac.Value) ' se adiciono
            '        'oDtAux = oFactura.Lista_Detalle_ServiciosXOperacion(pobjFiltro)
            '        oDtAux = oFactura.Lista_Detalle_ServiciosXOperacion_V2(pobjFiltro)
            '    Else
            '        pobjFiltro.Parametro1 = mListaoFact(intCant).NSECFC
            '        pobjFiltro.Parametro3 = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
            '        'oDtAux = oFactura.Lista_Detalle_ServiciosXRevision(pobjFiltro)
            '        oDtAux = oFactura.Lista_Detalle_ServiciosXRevision_V2(pobjFiltro)
            '    End If
            '    If intCant = 0 Then oDtServicios = oDtAux.Clone

            '    For Each dr As DataRow In oDtAux.Rows
            '        oDtServicios.ImportRow(dr)
            '    Next
            'Next
            oDtServicios = dtServFactura.Copy


            'obeFacturaHistorialDet.PNNOPRCN = oDs.Tables(0).Rows(intCount).Item("NOPRCN")
            'obeFacturaHistorialDet.PNNRTFSV = oDs.Tables(0).Rows(intCount).Item("NRTFSV")
            'obeFacturaHistorialDet.PNCTPODC = oDtCabFactura.Rows(0).Item("CTPODC")
            'obeFacturaHistorialDet.PNNDCFCC = strNumFact
            'obeFacturaHistorialDet.PNNCRDCC = oDs.Tables(0).Rows(intCount).Item("NCRDCC")
            'obeFacturaHistorialDet.PNNCRROP = oDs.Tables(0).Rows(intCount).Item("NCRROP")

            oDtDatos = CType(Me.tabFactura.TabPages(intControls - 1).Controls(0), ctrlFactura).DevuelveDatos
            For Each dr As DataRow In oDtDatos.Rows
                For Each drServicio As DataRow In oDtServicios.Rows
                    pobjFiltro = New Filtro
                    If mListaoFact.Item(0).TIPOFACTURA = 2 Then
                        If strNumFac = drServicio("NDCCTC") AndAlso dr("NCRDCC") = drServicio("NCRDCC") Then
                            pobjFiltro.Parametro1 = drServicio("NOPRCN")
                            pobjFiltro.Parametro2 = drServicio("NRTFSV")
                            pobjFiltro.Parametro3 = drServicio("NDCCTC")
                            pobjFiltro.Parametro4 = drServicio("NCRDCC")
                            pobjFiltro.Parametro5 = dr("SERVICIO")
                            oFacturaNeg.Actualizar_NombreServicio(pobjFiltro)
                        End If
                    Else
                        If strNumFac = drServicio("NDCCTC") And dr("NRRUBR") = drServicio("NRRUBR") Then
                            pobjFiltro.Parametro1 = drServicio("NOPRCN")
                            pobjFiltro.Parametro2 = drServicio("NRTFSV")
                            pobjFiltro.Parametro3 = drServicio("NDCCTC")
                            pobjFiltro.Parametro4 = drServicio("NCRDCC")
                            pobjFiltro.Parametro5 = dr("SERVICIO")
                            oFacturaNeg.Actualizar_NombreServicio(pobjFiltro)
                        End If
                    End If

                Next
            Next

        End If
    End Sub


    'Private Sub ActulizaNombreServicioHistorial(ByVal dtServFactura As DataTable, ByVal strNumFac As String, ByVal intControls As Integer, ByVal dtFacturaOperacion As DataTable)
    '    If Me.chkDescripcionManual.Checked Then
    '        Dim NCRRFC As Decimal = 0
    '        Dim oDtServicios As New DataTable
    '        Dim oDtAux As New DataTable
    '        Dim pobjFiltro As New Filtro
    '        Dim oFactura As New SOLMIN_CTZ.NEGOCIO.clsFactura
    '        Dim oDtDatos As New DataTable
    '        oDtServicios = dtServFactura.Copy

    '        Dim drCorrelativo() As DataRow

    '        oDtDatos = CType(Me.tabFactura.TabPages(intControls - 1).Controls(0), ctrlFactura).DevuelveDatos
    '        For Each dr As DataRow In oDtDatos.Rows
    '            For Each drServicio As DataRow In oDtServicios.Rows
    '                pobjFiltro = New Filtro
    '                If mListaoFact.Item(0).TIPOFACTURA = 2 Then
    '                    If strNumFac = drServicio("NDCCTC") AndAlso dr("NCRDCC") = drServicio("NCRDCC") Then

    '                        drCorrelativo = dtFacturaOperacion.Select("NOPRCN='" & drServicio("NOPRCN") & "' AND NDCCTC='" & drServicio("NDCCTC") & "'")
    '                        If drCorrelativo.Length > 0 Then
    '                            NCRRFC = drCorrelativo(0)("NCRRFC")
    '                            pobjFiltro.Parametro1 = drServicio("NOPRCN")
    '                            pobjFiltro.Parametro2 = drServicio("NRTFSV")
    '                            pobjFiltro.Parametro3 = NCRRFC
    '                            pobjFiltro.Parametro4 = drServicio("NCRDCC")
    '                            pobjFiltro.Parametro5 = dr("SERVICIO")
    '                            oFacturaNeg.Actualizar_NombreServicio_Historial(pobjFiltro)
    '                        End If

    '                    End If
    '                Else
    '                    If strNumFac = drServicio("NDCCTC") And dr("NRRUBR") = drServicio("NRRUBR") Then
    '                        drCorrelativo = dtFacturaOperacion.Select("NOPRCN='" & drServicio("NOPRCN") & "' AND NDCCTC='" & drServicio("NDCCTC") & "'")
    '                        If drCorrelativo.Length > 0 Then
    '                            NCRRFC = drCorrelativo(0)("NCRRFC")
    '                            pobjFiltro.Parametro1 = drServicio("NOPRCN")
    '                            pobjFiltro.Parametro2 = drServicio("NRTFSV")
    '                            pobjFiltro.Parametro3 = NCRRFC
    '                            pobjFiltro.Parametro4 = drServicio("NCRDCC")
    '                            pobjFiltro.Parametro5 = dr("SERVICIO")
    '                            oFacturaNeg.Actualizar_NombreServicio_Historial(pobjFiltro)
    '                        End If
    '                    End If
    '                End If

    '            Next
    '        Next

    '    End If
    'End Sub

    'Private Sub ActulizaNombreServicio(ByVal strNumFac As String, ByVal intControls As Integer)
    '    If Me.chkDescripcionManual.Checked Then


    '        Dim oDtServicios As New DataTable
    '        Dim oDtAux As New DataTable
    '        Dim pobjFiltro As New Filtro
    '        Dim oFactura As New SOLMIN_CTZ.NEGOCIO.clsFactura
    '        Dim oDtDatos As New DataTable

    '        For intCant As Integer = 0 To mListaoFact.Count - 1
    '            If mListaoFact(intCant).NSECFC = 0 Then
    '                pobjFiltro.Parametro1 = mListaoFact(intCant).NOPRCN
    '                pobjFiltro.Parametro3 = HelpClass.CtypeDate(Me.dtpFechaFac.Value) ' se adiciono
    '                'oDtAux = oFactura.Lista_Detalle_ServiciosXOperacion(pobjFiltro)
    '                oDtAux = oFactura.Lista_Detalle_ServiciosXOperacion_V2(pobjFiltro)
    '            Else
    '                pobjFiltro.Parametro1 = mListaoFact(intCant).NSECFC
    '                pobjFiltro.Parametro3 = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
    '                'oDtAux = oFactura.Lista_Detalle_ServiciosXRevision(pobjFiltro)
    '                oDtAux = oFactura.Lista_Detalle_ServiciosXRevision_V2(pobjFiltro)
    '            End If
    '            If intCant = 0 Then oDtServicios = oDtAux.Clone

    '            For Each dr As DataRow In oDtAux.Rows
    '                oDtServicios.ImportRow(dr)
    '            Next

    '        Next
    '        oDtDatos = CType(Me.tabFactura.TabPages(intControls - 1).Controls(0), ctrlFactura).DevuelveDatos
    '        For Each dr As DataRow In oDtDatos.Rows
    '            For Each drServicio As DataRow In oDtServicios.Rows
    '                pobjFiltro = New Filtro
    '                If mListaoFact.Item(0).TIPOFACTURA = 2 Then
    '                    If strNumFac = drServicio("NDCFCC") And dr("NCRDCC") = drServicio("NCRDCC") Then
    '                        pobjFiltro.Parametro1 = drServicio("NOPRCN")
    '                        pobjFiltro.Parametro2 = drServicio("NRTFSV")
    '                        pobjFiltro.Parametro3 = drServicio("NDCFCC")
    '                        pobjFiltro.Parametro4 = drServicio("NCRDCC")
    '                        pobjFiltro.Parametro5 = dr("SERVICIO")
    '                        oFacturaNeg.Actualizar_NombreServicio(pobjFiltro)
    '                    End If
    '                Else
    '                    If strNumFac = drServicio("NDCFCC") And dr("NRRUBR") = drServicio("NRRUBR") Then
    '                        pobjFiltro.Parametro1 = drServicio("NOPRCN")
    '                        pobjFiltro.Parametro2 = drServicio("NRTFSV")
    '                        pobjFiltro.Parametro3 = drServicio("NDCFCC")
    '                        pobjFiltro.Parametro4 = drServicio("NCRDCC")
    '                        pobjFiltro.Parametro5 = dr("SERVICIO")
    '                        oFacturaNeg.Actualizar_NombreServicio(pobjFiltro)
    '                    End If
    '                End If

    '            Next
    '        Next

    '    End If
    'End Sub

    Private Sub ActulizaNombreServicioHistorial(ByVal dtOperacionDocHistDet As DataTable, ByVal strNumFac As String, ByVal pintFact As Integer)
        If Me.chkDescripcionManual.Checked Then
            Dim NCRRFC As Decimal = 0
            Dim oDtServicios As New DataTable
            Dim oDtAux As New DataTable
            Dim pobjFiltro As New Filtro
            Dim oFactura As New SOLMIN_CTZ.NEGOCIO.clsFactura
            Dim oDtDatos As New DataTable
            oDtServicios = dtOperacionDocHistDet.Copy

            Dim drCorrelativo() As DataRow

            oDtDatos = CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).DevuelveDatos
            For Each dr As DataRow In oDtDatos.Rows
                For Each drServicio As DataRow In oDtServicios.Rows
                    pobjFiltro = New Filtro
                    If mListaoFact.Item(0).TIPOFACTURA = 2 Then
                        If strNumFac = drServicio("NDCCTC") AndAlso dr("NCRDCC") = drServicio("NCRDCC") Then
                            drCorrelativo = dtOperacionDocHistDet.Select("NOPRCN='" & drServicio("NOPRCN") & "' AND NDCCTC='" & drServicio("NDCCTC") & "' AND FACTURA='" & pintFact & "'")
                            If drCorrelativo.Length > 0 Then
                                NCRRFC = drCorrelativo(0)("NCRRFC")
                                pobjFiltro.Parametro1 = drServicio("NOPRCN")
                                pobjFiltro.Parametro2 = drServicio("NRTFSV")
                                pobjFiltro.Parametro3 = NCRRFC
                                pobjFiltro.Parametro4 = drServicio("NCRDCC")
                                pobjFiltro.Parametro5 = dr("SERVICIO")
                                oFacturaNeg.Actualizar_NombreServicio_Historial(pobjFiltro)
                            End If

                        End If
                    Else
                        If strNumFac = drServicio("NDCCTC") And dr("NRRUBR") = drServicio("NRRUBR") Then
                            drCorrelativo = dtOperacionDocHistDet.Select("NOPRCN='" & drServicio("NOPRCN") & "' AND NDCCTC='" & drServicio("NDCCTC") & "'")
                            If drCorrelativo.Length > 0 Then
                                NCRRFC = drCorrelativo(0)("NCRRFC")
                                pobjFiltro.Parametro1 = drServicio("NOPRCN")
                                pobjFiltro.Parametro2 = drServicio("NRTFSV")
                                pobjFiltro.Parametro3 = NCRRFC
                                pobjFiltro.Parametro4 = drServicio("NCRDCC")
                                pobjFiltro.Parametro5 = dr("SERVICIO")
                                oFacturaNeg.Actualizar_NombreServicio_Historial(pobjFiltro)
                            End If
                        End If
                    End If

                Next
            Next

        End If
    End Sub

    Public Function Grabar_FacturaElectronica(ByVal pdblNumFacImp As Double, ByVal pstrCompania As String, ByVal pstrTipoDoc As String) As Boolean
        Try
            dblNumFacImp = pdblNumFacImp
            strCompFacImp = pstrCompania
            strTipoDocFacImp = pstrTipoDoc
            Grabar_factura_electronica()
            dblNumFacImp = 0
            strCompFacImp = ""
            strTipoDocFacImp = ""
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub Grabar_factura_electronica()  'JM

        Dim objFact_Cab_FE As New FacturaElectronica
        Dim objFact_Det_FE As FacturaElectronicaDet
        Dim Negocio_FE As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim oDs As DataSet
        Dim oFiltro As New Filtro
        Dim intCont As Integer
        Dim oDr() As DataRow
        Dim intPosLinea As Integer = 0
        Dim dblTotal As Double = 0
        Dim bolIGV As Boolean = False
        Dim strMonto As String = ""
        Dim strMoneda As String = ""
        Dim dblSubTotalSoles As Double = 0
        Dim dblTotalSoles As Double = 0
        Dim oDtDetalleFac As New DataTable()
        Dim _NCRDCC As Integer = 0

        oFiltro.Parametro1 = strCompFacImp
        oFiltro.Parametro2 = strTipoDocFacImp
        oFiltro.Parametro3 = dblNumFacImp
        oDs = oFacturaNeg.Lista_Datos_Factura_Electronica(oFiltro)
        oDtDetalleFac = oDs.Tables(1).Clone
        Select Case mListaoFact.Item(0).TIPOFACTURA
            Case 1
                Dim IntCodRubro As Integer = 0
                Dim dblMontoSoles As Double = 0
                Dim dblMontoDolare As Double = 0
                Dim IntCantidadRows As Integer = 0
                Dim oDrTemp() As DataRow
                Dim oDtTemp As DataTable
                oDtTemp = oDs.Tables(1).Copy
                While (1) 'Se repite por la cantidad de Detalles de la Factura
                    If oDtTemp.Rows.Count = 0 Then
                        Exit While
                    End If
                    dblMontoSoles = 0
                    dblMontoDolare = 0
                    IntCodRubro = Val(oDtTemp.Rows(0).Item("NRRUBR"))
                    oDrTemp = oDtTemp.Select("NRRUBR='" & IntCodRubro & "'")
                    For IntCantidadRows = 0 To oDrTemp.Length - 1
                        dblMontoSoles = oDrTemp(IntCantidadRows).Item("IVLDCS") + dblMontoSoles
                        dblMontoDolare = oDrTemp(IntCantidadRows).Item("IVLDCD") + dblMontoDolare
                    Next
                    oDrTemp(0).Item("IVLDCS") = dblMontoSoles
                    oDrTemp(0).Item("IVLDCD") = dblMontoDolare
                    oDtDetalleFac.ImportRow(oDrTemp(0))

                    For IntCantidadRows = 0 To oDrTemp.Length - 1
                        oDtTemp.Rows.Remove(oDrTemp(IntCantidadRows))
                    Next

                End While
            Case 2
                For Each dr As DataRow In oDs.Tables(1).Rows
                    oDtDetalleFac.ImportRow(dr)
                Next
        End Select

        oDs.Tables(1).Clear()
        For Each dr As DataRow In oDtDetalleFac.Rows
            oDs.Tables(1).ImportRow(dr)
        Next

        'DATOS DE LA CABECERA ----------------------------
        objFact_Cab_FE.CCMPN = mListaoFact.Item(0).PSCCMPN 'codigo compañia 
        objFact_Cab_FE.NDCCTC = CInt(dblNumFacImp) 'Nro. documento
        objFact_Cab_FE.CTPODC = strTipoDocFacImp 'Tipo Documento
        objFact_Cab_FE.NINDRN = oDs.Tables(1).Rows(0).Item("NINDRN").ToString.Trim ' Nro. Índice Renovación
        objFact_Cab_FE.FDCCTC = CType(oDs.Tables(0).Rows(0).Item("FECHA").ToString.Trim, Date).ToString("yyyyMMdd") ' Fecha Doc.
        objFact_Cab_FE.CRGVTA = txtRegionVenta.Text 'Código Región de Venta
        objFact_Cab_FE.CTPCTR = cmbPtoVenta.SelectedValue 'Punto de venta
        objFact_Cab_FE.CCLNT = oDs.Tables(0).Rows(0).Item("CCLNT").ToString.Trim  ' Código  cliente

        objFact_Cab_FE.CCLNOP = mListaoFact.Item(0).CCLNOP

        objFact_Cab_FE.CDDRSP = oDs.Tables(0).Rows(0).Item("CDDRSP").ToString.Trim 'Código Cliente SAP 
        objFact_Cab_FE.CGRONG = cmbGiro.SelectedValue 'Código Tipo de deposito
        objFact_Cab_FE.CZNFCC = oDs.Tables(0).Rows(0).Item("CZNFCC").ToString.Trim  ' Zona Cobranza
        objFact_Cab_FE.CMNDA = mListaoFact.Item(0).CMNDA1 'Codigo  Moneda
        objFact_Cab_FE.NFORFA = 0 'Estado de forma de impresion  
        '--------------------------------------------------
        oDr = oDs.Tables(2).Select("CTPDCC = 1 OR CTPDCC = 51") 'JM
        'se junta todas las filas
        Dim srtCadenas As String = ""

        Dim HasFilas As New SortedList
        Dim texto As String = ""
        Dim textoTempo As String = ""
        Dim itemFila As Int32 = 0

        For intCont = 0 To oDr.Length - 1
            texto = ("" & oDr(intCont).Item("TOBCTC")).ToString.Trim.Replace(Chr(10), "")
            If texto.Length > 0 Then
                HasFilas(HasFilas.Count - 1) = texto
                If HasFilas.Count >= 4 Then
                    Exit For
                End If
            End If
        Next

        For Each item As DictionaryEntry In HasFilas
            srtCadenas = item.Value
        Next

        'Recorre los detalles..
        For intCont = 0 To oDs.Tables(1).Rows.Count - 1
            objFact_Det_FE = New FacturaElectronicaDet

            If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                Dim oDtNew As New DataTable
                oFiltro.Parametro1 = mListaoFact.Item(0).PSCCMPN
                oFiltro.Parametro2 = mListaoFact.Item(0).PSCDVSN
                oFiltro.Parametro3 = oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim
                oFiltro.Parametro4 = oDs.Tables(1).Rows(intCont).Item("NRTFSV")
                oDtNew = oFacturaNeg.Lista_Datos_Servicio(oFiltro)
                _NCRDCC = _NCRDCC + 1
                With objFact_Det_FE
                    'LLenando datos factura electronica..........................
                    .CCMPN = mListaoFact.Item(0).PSCCMPN  'codigo compañia 
                    .NDCCTC = CInt(dblNumFacImp) 'Nro. documento
                    .CTPODC = strTipoDocFacImp 'codigo tipo documento  ver si esta lleno 
                    .CSRVNV = oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim 'codigo rubro
                    .NCRDCC = _NCRDCC 'Código Int Det Documento
                    .NINDRN = CInt(oDs.Tables(1).Rows(intCont).Item("NINDRN")) 'Nro. Índice Renovación

                    If mListaoFact.Item(0).TIPOFACTURA = 2 Then

                        If Me.chkDescripcionManual.Checked Then
                            .NOMSER = oDs.Tables(1).Rows(intCont).Item("NOMSRV").ToString.Trim 'Descripcion del rubro 
                        Else
                            .NOMSER = oDtNew.Rows(0).Item("NOMSER").ToString.Trim  'Descripcion del rubro
                            .TOBCTC = oDtNew.Rows(0).Item("TOBS").ToString.Trim ' observacion
                        End If
                        .CSRVNV = oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim 'codigo rubro
                        .QAPCTC = CDec(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim) 'Cantidad 
                        .CUNCNA = oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim ' Unidad Medida
                        .ITRCTC = CDec(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim) 'Tarifa
                    Else
                        If Me.chkDescripcionManual.Checked Then
                            .NOMSER = oDs.Tables(1).Rows(intCont).Item("NOMSRV").ToString.Trim
                        Else
                            .NOMSER = oDtNew.Rows(0).Item("TCMTRF").ToString.Trim
                        End If
                        .CSRVNV = _NCRDCC
                        .QAPCTC = 1 'Cantidad 
                        .CUNCNA = "UNI" ' Unidad Medida
                    End If

                    If oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                        strMoneda = "USD"
                    Else
                        strMoneda = "S/."
                    End If

                    'If mListaoFact(0).PSCTPDCI = "RU" Then
                    If strMoneda = "USD" Then
                        .IVLDCS = Math.Round(CDec(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim), 2) 'Dolares   2 decimales
                        dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), 2) '2 decimales
                    Else
                        .IVLDCS = Math.Round(CDec(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim), 2) 'soles 2 decimales
                        dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), 2) '2 decimales
                    End If

                    If mListaoFact.Item(0).TIPOFACTURA = 1 Then
                        .ITRCTC = .IVLDCS
                    End If

                    dblSubTotalSoles = dblSubTotalSoles + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS"), Double), 2)

                End With
                Negocio_FE.Grabar_Detalle_Factura_Electronica(objFact_Det_FE)
            Else
                bolIGV = True
            End If
        Next intCont

        objFact_Cab_FE.IVLDCS = Math.Round(dblTotal, 2)   'Sub Total

        If bolIGV Then
            objFact_Cab_FE.PIGVA = oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim

            If strMoneda = "USD" Then
                objFact_Cab_FE.IVLIGS = Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), 2)
                dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), 2)

            Else
                objFact_Cab_FE.IVLIGS = Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), 2)
                dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), 2)
            End If

        End If

        dblTotalSoles = dblSubTotalSoles + Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS"), Double), 2)

        oDr = oDs.Tables(2).Select("CTPDCC = 2 OR CTPDCC = 52 ") 'JM
        texto = ""
        HasFilas = New SortedList
        For intCont = 0 To oDr.Length - 1
            texto = ("" & oDr(intCont).Item("TOBCTC")).ToString.Trim
            If texto.Length > 0 Then
                HasFilas(HasFilas.Count - 1) = texto
                If HasFilas.Count >= 5 Then
                    Exit For
                End If
            End If
        Next
        For Each item As DictionaryEntry In HasFilas
            srtCadenas = item.Value
        Next
        If strMoneda = "USD" Then
            objFact_Cab_FE.ITTFCS = Math.Round(dblTotal, 2) 'Importe Total Dolares
        Else
            objFact_Cab_FE.ITTFCS = Math.Round(dblTotal, 2) 'Importe Total Soles
        End If

        If mListaoFact(0).PSCTPDCI = "RU" Then
            Dim pnmonto As Decimal = 0
            Dim pnporcentaje As Decimal = 0
            pnmonto = oDs.Tables(1).Rows(0).Item("iafcdt")
            pnporcentaje = oDs.Tables(1).Rows(0).Item("iprcdt")
            If (dblTotalSoles) >= pnmonto And pnporcentaje > 0 Then
                objFact_Cab_FE.NDSPGD = oDs.Tables(1).Rows(0).Item("IPRCDT") 'valor spot
            End If
        End If

        Negocio_FE.Grabar_Cabecera_Factura_ELectronica(objFact_Cab_FE) 'GRABAR FACTURA ELECTRONICA CABECERA

    End Sub

    'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
    Private Function Estimacion_Ingreso_Revertir() As DataTable
        Dim oDtNew As DataTable
        'Dim oFiltro As New Filtro
        Dim oFiltro As New Hashtable

        'oFiltro.Parametro1 = oDtCabFactura.Rows(0).Item("CCMPN") 'Compañía
        'oFiltro.Parametro12 = oDtCabFactura.Rows(0).Item("CTPODC") 'Tipo de Documento
        'oFiltro.Parametro13 = NumeroDocumento 'Nro. Documento 
        'oFiltro.Parametro14 = 0 'Nro. Revisión

        oFiltro("CCMPN") = oDtCabFactura.Rows(0).Item("CCMPN") 'Compañía
        oFiltro("CTPODC") = oDtCabFactura.Rows(0).Item("CTPODC") 'Tipo de Documento
        oFiltro("NDCFCC") = NumeroDocumento 'Nro. Documento 
        oFiltro("NSECFC") = 0 'Nro. Revisión
 

        oDtNew = oFacturaNeg.Estimacion_Ingreso_Revertir(oFiltro)

        Return oDtNew
    End Function

    'CSR-HUNDRED-ESTIMACION-INGRESO-FIN

End Class
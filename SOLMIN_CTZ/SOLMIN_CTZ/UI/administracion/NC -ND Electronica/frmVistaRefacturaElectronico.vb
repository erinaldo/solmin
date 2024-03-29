Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class frmVistaRefacturaElectronico

    Private _dtServiciosTodosOp As New DataTable
    Public Property dtServiciosTodosOp() As DataTable
        Get
            Return _dtServiciosTodosOp
        End Get
        Set(ByVal value As DataTable)
            _dtServiciosTodosOp = value
        End Set
    End Property


    Sub New(ByVal ListaoFacturacion As List(Of SOLMIN_CTZ.Entidades.FacturaSIL))
        ' Llamada necesaria para el Dise�ador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().

        mListaoFact = ListaoFacturacion
        strMoneda = ListaoFacturacion(0).CMNDA1
        oFacturaNeg = New SOLMIN_CTZ.NEGOCIO.clsFactura
        bolBuscar = False

        oFacturaNeg.AccionRefactura = 1
    End Sub

    Private _TipoDocumento As clsComun.TipoDocumento = clsComun.TipoDocumento.Neutro
    Public Property TipoDocumento() As clsComun.TipoDocumento
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As clsComun.TipoDocumento)
            _TipoDocumento = value
        End Set
    End Property

    Private _TipoNota As Decimal = 0 'JM
    Public Property TipoNota() As Decimal
        Get
            Return _TipoNota
        End Get
        Set(ByVal value As Decimal)
            _TipoNota = value
        End Set
    End Property


#Region "Declaracion de Variables"

    Private strMoneda As String
    Private dblTipoCambio As Double
    Private dblTipoCambioDoc As Double
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
        'Dim oDtRegionVenta As DataTable
        oFiltro.Parametro1 = mListaoFact(0).PSCCMPN  'strCodCom
        oFiltro.Parametro2 = mListaoFact(0).PSCDVSN  'strCodDiv
        oFiltro.Parametro3 = mListaoFact(0).CCLNFC 'dblCliente
        oFiltro.Parametro4 = Val(TipoDocumento)
        oFacturaNeg.Lista_Documentos_Permitidos_Refactura(oFiltro)
        If oFacturaNeg.oDtDocumentos.Rows.Count > 0 Then
            oFacturaNeg.oTipoDocumento = oFacturaNeg.oDtDocumentos.Rows(0)("CTPODC")
            oFacturaNeg.oFlagSoloConsulta = ("" & oFacturaNeg.oDtDocumentos.Rows(0)("FLAG_CONSULTA")).ToString.Trim
        End If


        Llenar_Combos()
       
        txtRegionVenta.Text = mListaoFact(0).CRGVTA
    End Sub

    Private Sub TipoDeCambio()
        Dim oDt As DataTable

        Dim oFiltro As New Hashtable


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

        Select Case TipoDocumento   'JM   agrege Electronico
            Case clsComun.TipoDocumento.NotaCredito, clsComun.TipoDocumento.NotaCreditoElectronico
                dblTipoCambioDoc = mListaoFact(0).ITCCTC
                oFacturaNeg.TipoCambioDocOrigen = dblTipoCambioDoc
            Case clsComun.TipoDocumento.NotaDebito, clsComun.TipoDocumento.NotaDebitoElectronico
            Case clsComun.TipoDocumento.Factura
        End Select
    End Sub




    ''' <summary>
    ''' Habilita que la fecha de la factura se cambien solo los primeros 3 d�as de cada mes
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

        Dim oFiltro As New Hashtable
        Dim oDt As DataTable

        bolBuscar = False
     

  
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

        oFiltro = New Hashtable

        oFiltro("CCLNT") = mListaoFact(0).CCLNFC

        oDt = oFacturaNeg.Lista_Planta_Cliente(oFiltro)
        Me.cmbPlantaCliente.DataSource = oDt
        cmbPlantaCliente.ValueMember = "CPLNCL"
        cmbPlantaCliente.DisplayMember = "TDRCPL"
        If oDt.Rows.Count = 1 Then
            Me.cmbPlantaCliente.Enabled = False
        End If
        Select Case TipoDocumento  'JM   agrege Electronico
            Case clsComun.TipoDocumento.Factura
                lblTipoDoc.Text = "FACTURA"
            Case clsComun.TipoDocumento.NotaCreditoElectronico, clsComun.TipoDocumento.NotaCreditoElectronico
                lblTipoDoc.Text = "NOTA DE CREDITO"
            Case clsComun.TipoDocumento.NotaDebito, clsComun.TipoDocumento.NotaDebitoElectronico
                lblTipoDoc.Text = "NOTA DE DEBITO"
        End Select
    End Sub


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
            Select Case TipoDocumento   'JM   agrege Electronico
                Case clsComun.TipoDocumento.Factura
                    MessageBox.Show("No existen Facturas para crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case clsComun.TipoDocumento.NotaCredito, clsComun.TipoDocumento.NotaCreditoElectronico
                    MessageBox.Show("No existen Nota de Cr�ditos para crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case clsComun.TipoDocumento.NotaDebito, clsComun.TipoDocumento.NotaDebitoElectronico
                    MessageBox.Show("No existen Nota de D�bito para crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        End If
    End Sub


    Private Sub Mostrar_Factura(Optional ByVal intCant As Integer = 1)
        Dim TipoDoc As String = ""
        Select Case TipoDocumento  'JM   agrege Electronico
            Case clsComun.TipoDocumento.Factura
                TipoDoc = "Factura"
            Case clsComun.TipoDocumento.NotaCredito, clsComun.TipoDocumento.NotaCreditoElectronico
                TipoDoc = "Nota Cr�dito"
            Case clsComun.TipoDocumento.NotaDebito, clsComun.TipoDocumento.NotaDebitoElectronico
                TipoDoc = "Nota D�bito"
        End Select

        'Dim octrlFact As ctrlFactura
        Dim octrlFact As ctrlReFactura
        Dim X As Integer = 0
        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True
        Next X
        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = TipoDoc & " " & lint_Contador.ToString
            
            
            octrlFact = New ctrlReFactura("RU", oDtDetFactura, lint_Contador + 1, phashIGV.Item(lint_Contador + 1), mListaoFact.Item(0).TIPOFACTURA) 'pdblIGV
            octrlFact.pMaxLonDescripcionServicio = 30
            octrlFact.NumFactura = "N�          "
            If mListaoFact(0).PSCDVSN = "S" Then   'strCodDiv
                octrlFact.Referencia1 = Obtener_Referencia_Factura_SIL()
            End If
            Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
        Next
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

            oFiltro.Parametro1 = mListaoFact(intLista).NOPRCN
            oFiltro.Parametro2 = mListaoFact(intLista).CTPODC
            oFiltro.Parametro3 = mListaoFact(intLista).NDCCTC
            oDt = oFacturaNeg.Lista_Unidad_Consistencia_SIL_Refactura(oFiltro)
            If oDt.Rows.Count = 1 Then
                If oDt.Rows(0).Item("CUNDMD").ToString.Trim = "OS" Then
                    oDt = oFacturaNeg.Lista_Referencia_Factura_SIL_Refactura(oFiltro)
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
            oFiltro.Parametro3 = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
            oFiltro.Parametro4 = mListaoFact(intCant).NOPRCN
            oFiltro.Parametro5 = mListaoFact(intCant).CTPODC
            ListaoFiltro.Add(oFiltro)
        Next

        nRetorno = oFacturaNeg.Cantidad_Facturas_Refactura(ListaoFiltro)
        Return nRetorno
    End Function

    Private Sub Generar_Cabecera(ByVal pintCant As Double)
        Dim oFiltro As New Filtro

        oFiltro.Parametro1 = mListaoFact(0).NSECFC
        oFiltro.Parametro2 = pintCant
        oFiltro.Parametro3 = mListaoFact(0).CCLNFC
        oFiltro.Parametro4 = mListaoFact(0).PSCDVSN
        oFiltro.Parametro5 = mListaoFact(0).PSCCMPN
        oFiltro.Parametro6 = dblTipoCambio
        oFiltro.Parametro7 = cmbPlantaFacturar.SelectedValue
        oFiltro.Parametro8 = strMoneda
        oFiltro.Parametro9 = Me.txtRegionVenta.Text
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
        oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura_Refactura(mListaoFact, oFiltro, phashIGV, phtOperacioFacturar, mListaoFact.Item(0).TIPOFACTURA) 'pdblIGV
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub

    

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
                HelpClass.MsgBox("ERROR : Ocurri� un Problema de Conexi�n", MessageBoxIcon.Information)
                Me.btnFacturar.Enabled = False
                cmbGiro.Enabled = False
                dtpFechaFac.Enabled = False
            Case "B", "C", "D"
                HelpClass.MsgBox("ADVERTENCIA : " & "Cliente " & strResultado, MessageBoxIcon.Information)
                Me.btnFacturar.Enabled = False
                cmbGiro.Enabled = False
                dtpFechaFac.Enabled = False
            Case Else
                'ValidarCliente() 'ECM-HUNDRED-SOPORTE[180716]

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

        Dim oFiltro As New Hashtable
        Dim strCliente As String

        oFiltro("CCLNT") = mListaoFact(0).CCLNFC 'dblCliente

        oDtNew = oFacturaNeg.Lista_Datos_Cliente(oFiltro)
        strCliente = "Sres.:".PadRight(130, " ") & "C�digo:    " & oDtNew.Rows(0).Item("CCLNT").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TCMPCL").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TDRCOR").ToString.Trim & "    " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & IIf(oDtNew.Rows(0).Item("NRUC").ToString.Trim = "0", "", oDtNew.Rows(0).Item("NRUC").ToString.Trim) & " ".PadRight(90, " ") & "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim

        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(Me.dtpFechaFac.Value, "dd/MM/yyyy")
        strCliente = strCliente & vbCrLf & "Tip.Doc.Origen:  " & mListaoFact(0).CTPODC & " Num.Doc.Origen:  " & mListaoFact(0).NDCCTC & " Fec.Doc.Origen:  " & Ransa.Utilitario.HelpClass.CNumero8Digitos_a_FechaDefault(mListaoFact(0).FDCCTC)
        Me.txtCliente.Text = strCliente
    End Sub

    


    Private Sub Actualizar_Punto_Venta()
        Me.cmbPtoVenta.DataSource = oFacturaNeg.oDtDocumentos


            cmbPtoVenta.DisplayMember = "NPTOVT"
            cmbPtoVenta.ValueMember = "NPTOVT"
            If Me.cmbPtoVenta.Items.Count <= 0 Then
                Me.btnFacturar.Enabled = False
            Else
                Me.btnFacturar.Enabled = True
            End If
         
    End Sub



    Private Sub CargarPlantaFacturar()
        Me.Cursor = Cursors.WaitCursor
        If bolBuscar Then

            Dim oFiltro As New Hashtable
            oFiltro("CCMPN") = mListaoFact(0).PSCCMPN
            oFiltro("CDVSN") = mListaoFact(0).PSCDVSN

          

            Me.cmbPlantaFacturar.DataSource = oFacturaNeg.Lista_Planta_Facturar(oFiltro)
            cmbPlantaFacturar.DisplayMember = "TPLNTA"
            cmbPlantaFacturar.ValueMember = "CPLNDV"
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ActualizarTempDocumentoHistorial(ByVal pintFact As Int32)
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

    


    Private Sub Grabar_Factura(ByVal pintFact As Integer)
        Dim strNumFact As String = ""
        Dim objFiltro As New Filtro
        Try
            Cursor = Cursors.WaitCursor
            Dim oDs As DataSet

            Dim dtObsFact As New DataTable
            Dim dtObsFactDet As New DataTable
            Dim RefCabecera As String = ""
            Dim RefDetalle As String = ""

            Dim oFactObs As New FacturaElectronicaDet


            oDs = phtOperacioFacturar.Item(pintFact)
            oDtCabFactura.Rows(0).Item("CTPDCO") = mListaoFact(0).CTPODC
            oDtCabFactura.Rows(0).Item("NDCMOR") = mListaoFact(0).NDCCTC
            oDtCabFactura.Rows(0).Item("FDCMOR") = mListaoFact(0).FDCCTC


            RefCabecera = ("" & CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).Referencia1).ToString.Trim
            RefDetalle = ("" & CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).Referencia2).ToString.Trim


            dtObsFact = oFacturaNeg.Formar_Referencia_Factura(1, RefCabecera)
            dtObsFactDet = oFacturaNeg.Formar_Referencia_Factura(2, RefDetalle)



            oFacturaNeg.Grabar_Factura_Refactura(pintFact, oDtCabFactura, oDs.Tables(1), strNumFact)
            'oFacturaNeg.Grabar_Referencia_Factura(pintFact, 1, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).Referencia1, strNumFact)
            'oFacturaNeg.Grabar_Referencia_Factura(pintFact, 2, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).Referencia2, strNumFact)

            If strNumFact <> "" Then
                oFactObs.NDCCTC = strNumFact
                oFacturaNeg.Grabar_ReferenciaMasivaJS_Factura(oFactObs, dtObsFact, dtObsFactDet)
            End If
         


            ''ACTUALIZAR CABECERA Y DETALLE HISTORIAL
            ''*************************************************************
            ActualizarTempDocumentoHistorial(pintFact)
            '*************************************************************
            Dim obeFacturaHistorialDet As FacturaHistorialDet
            Dim NOPRCN As Decimal = 0
            For Fila As Int32 = 0 To oDs.Tables(0).Rows.Count - 1
                NOPRCN = oDs.Tables(0).Rows(Fila).Item("NOPRCN")
                If oDs.Tables(0).Rows(Fila)("FACTURA") = pintFact Then
                    obeFacturaHistorialDet = New FacturaHistorialDet
                    obeFacturaHistorialDet.PNNOPRCN = oDs.Tables(0).Rows(Fila).Item("NOPRCN")
                    obeFacturaHistorialDet.PNNRTFSV = oDs.Tables(0).Rows(Fila).Item("NRTFSV")
                    obeFacturaHistorialDet.PNCTPODC = oDtCabFactura.Rows(0).Item("CTPODC")
                    obeFacturaHistorialDet.PNNDCFCC = strNumFact
                    obeFacturaHistorialDet.PNNCRDCC = oDs.Tables(0).Rows(Fila).Item("NCRDCC")
                    obeFacturaHistorialDet.PNNCRROP = oDs.Tables(0).Rows(Fila).Item("NCRROP")
                    oFacturaNeg.Actualizar_Detalle_Facturado_X_Operacion_V2(obeFacturaHistorialDet)
                End If
            Next
            ''ACTUALIZAR CABECERA Y DETALLE HISTORIAL
            ''*************************************************************
            Dim dtOperacionDocHistCab As New DataTable
            Dim dtOperacionDocHistDet As New DataTable
            oFacturaNeg.Formar_Cabecera_Detalle_Historial(dtOperacionDocHistCab, dtOperacionDocHistDet, oDs.Tables(0), pintFact)
            oFacturaNeg.Grabar_Historial_Documento(dtOperacionDocHistCab, dtOperacionDocHistDet, pintFact)
            'ActulizaNombreServicio(oDs.Tables(0).Copy, strNumFact, pintFact)
            'ActulizaNombreServicioHistorial(dtOperacionDocHistDet, strNumFact, pintFact)
            oFacturaNeg.Liberar_Operacion_Servicio_Refactura(mListaoFact, dtOperacionDocHistCab.Copy, pintFact)
            '***********************************************************************


            'Agregar validacion de valor de destracci�n
            If oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim = "52" And (mListaoFact(0).CTPODC = 51 Or mListaoFact(0).CTPODC = 1) Then
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
            HelpClass.MsgBox("Error al grabar " & lblTipoDoc.Text & vbCrLf & ex.Message)
        End Try
        If strNumFact <> "" Then
            Cursor = Cursors.Default
           
            Grabar_Factura_Electronica(strNumFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim)

            'JM
            Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact)

            HelpClass.MsgBox("Se grab� correctamente " & lblTipoDoc.Text & " N� " & strNumFact)
        End If
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

            oFacturaNeg.Enviar_Documento_SAP_FE(oFiltro) 'JM
            oFiltro.Parametro1 = pstrCompania
            oFiltro.Parametro2 = pstrTipoDoc
            oFiltro.Parametro3 = pstrNumFact
            oDt = oFacturaNeg.Comprobar_Envio_Documento_SAP(oFiltro)
            If oDt.Rows.Count > 0 Then
                strNumSAP = oDt.Rows(0).Item("NDCMSP").ToString.Trim
                Cursor = Cursors.Default

            Else
                Cursor = Cursors.Default
                HelpClass.MsgBox("No se  envi� correctamente al SAP ")
            End If
        Catch ex As Exception
            HelpClass.MsgBox("Error al enviar documento al SAP " & ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Datos_Factura()
        oFacturaNeg.Limpiar_Datos_Factura()
    End Sub

   


    Public Sub Grabar_Factura_Electronica(ByVal pdblNumFacImp As Double, ByVal pstrCompania As String, ByVal pstrTipoDoc As String)
        Try
            Dim prn As New Printing.PrintDocument

            dblNumFacImp = pdblNumFacImp
            strCompFacImp = pstrCompania
            strTipoDocFacImp = pstrTipoDoc
            Grabar_Factuarcion_Electronica()
            dblNumFacImp = 0
            strCompFacImp = ""
            strTipoDocFacImp = ""
        Catch ex As Exception
            HelpClass.MsgBox("Error al imprimir la factura N� " & pdblNumFacImp & vbCrLf & ex.Message)
        End Try
    End Sub



    


    Private Sub Grabar_Factuarcion_Electronica() 'JM

        Dim objFact_Cab_FE As New FacturaElectronica
        Dim objFact_Det_FE As FacturaElectronicaDet
        Dim Negocio_FE As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim oDs As DataSet
        Dim oFiltro As New Filtro

        Dim intCont As Integer
        Dim oDr() As DataRow
        Dim dblTotal As Double = 0
        Dim bolIGV As Boolean = False
        Dim strMonto As String = ""
        Dim strMoneda As String = ""
        Dim dblSubTotalSoles As Double = 0
        Dim dblTotalSoles As Double = 0
        Dim oDtDetalleFac As New DataTable
        Dim _NCRDCC As Integer = 0

        oFiltro.Parametro1 = strCompFacImp
        oFiltro.Parametro2 = strTipoDocFacImp
        oFiltro.Parametro3 = dblNumFacImp

        oDs = oFacturaNeg.Lista_Datos_ReFactura_Electronica(oFiltro)

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

        'DATOS DE LA CABECERA ----------------------------
        objFact_Cab_FE.CCMPN = mListaoFact.Item(0).PSCCMPN 'codigo compa�ia 
        objFact_Cab_FE.CTPODC = strTipoDocFacImp 'Tipo Documento
        objFact_Cab_FE.NDCCTC = CInt(dblNumFacImp) 'Nro. documento
        objFact_Cab_FE.NINDRN = oDs.Tables(1).Rows(0).Item("NINDRN").ToString.Trim ' Nro. �ndice Renovaci�n
        objFact_Cab_FE.FDCCTC = CType(oDs.Tables(0).Rows(0).Item("FECHA").ToString.Trim, Date).ToString("yyyyMMdd") ' Fecha Doc.
        objFact_Cab_FE.CTPDCO = CDec(oDs.Tables(0).Rows(0).Item("CTPDCO").ToString.Trim) 'Cod Tipo Documento Origen
        objFact_Cab_FE.NDCMOR = CDec(oDs.Tables(0).Rows(0).Item("NDCMOR").ToString.Trim) 'Num Documento Origen
        objFact_Cab_FE.FDCMOR = CType(oDs.Tables(0).Rows(0).Item("FDCMOR").ToString.Trim, Date).ToString("yyyyMMdd")
        objFact_Cab_FE.CDMODN = TipoNota 'Cod. Motivo nota  
        objFact_Cab_FE.CRGVTA = txtRegionVenta.Text 'C�digo Regi�n de Venta
        objFact_Cab_FE.CTPCTR = cmbPtoVenta.SelectedValue 'Punto de venta
        objFact_Cab_FE.CCLNT = oDs.Tables(0).Rows(0).Item("CCLNT").ToString.Trim  ' C�digo  cliente

        objFact_Cab_FE.CCLNOP = mListaoFact.Item(0).PNCCLNT

        objFact_Cab_FE.CDDRSP = oDs.Tables(0).Rows(0).Item("CDDRSP").ToString.Trim 'C�digo Cliente SAP 
        objFact_Cab_FE.CGRONG = cmbGiro.SelectedValue 'C�digo Tipo de deposito
        objFact_Cab_FE.CZNFCC = oDs.Tables(0).Rows(0).Item("CZNFCC").ToString.Trim  ' Zona Cobranza
        objFact_Cab_FE.CMNDA = mListaoFact.Item(0).CMNDA1 'Codigo  Moneda
        objFact_Cab_FE.NFORFA = 0 'Estado de forma de impresion  
        '--------------------------------------------------
        Dim TEXTO As String = ""
        oDr = oDs.Tables(2).Select("CTPDCC = 1")

        For intCont = 0 To oDr.Length - 1
            TEXTO = oDr(intCont).Item("TOBCTC").ToString.Trim
            
        Next intCont

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
                    .CCMPN = mListaoFact.Item(0).PSCCMPN  'codigo compa�ia 
                    .NDCCTC = CInt(dblNumFacImp) 'Nro. documento
                    .CTPODC = strTipoDocFacImp 'codigo tipo documento  ver 
                    .CSRVNV = oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim 'codigo rubro
                    .NCRDCC = _NCRDCC 'C�digo Int Det Documento
                    .NINDRN = CInt(oDs.Tables(1).Rows(intCont).Item("NINDRN")) 'Nro. �ndice Renovaci�n

                    If mListaoFact.Item(0).TIPOFACTURA = 2 Then

                        'If Me.chkDescripcionManual.Checked Then
                        '    .NOMSER = oDs.Tables(1).Rows(intCont).Item("NOMSRV").ToString.Trim  'Descripcion del rubro 
                        'Else
                        '    .NOMSER = oDtNew.Rows(0).Item("NOMSER").ToString.Trim 'Descripcion del rubro
                        '    .TOBCTC = oDtNew.Rows(0).Item("TOBS").ToString.Trim ' observacion
                        'End If

                        .NOMSER = oDtNew.Rows(0).Item("NOMSER").ToString.Trim 'Descripcion del rubro
                        .TOBCTC = oDtNew.Rows(0).Item("TOBS").ToString.Trim ' observacion


                        .QAPCTC = CDec(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim) 'Cantidad 
                        .CUNCNA = oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim ' Unidad Medida
                        .ITRCTC = CDec(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim) 'Tarifa



                    Else
                        'If Me.chkDescripcionManual.Checked Then
                        '    .NOMSER = oDs.Tables(1).Rows(intCont).Item("NOMSRV").ToString.Trim
                        'Else
                        '    .NOMSER = oDtNew.Rows(0).Item("TCMTRF").ToString.Trim
                        'End If
                        .NOMSER = oDtNew.Rows(0).Item("TCMTRF").ToString.Trim
                        .QAPCTC = 1 'Cantidad 
                        .CUNCNA = "UNI" ' Unidad Medida
                    End If

                    If oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                        strMoneda = "USD"
                    Else
                        strMoneda = "S/."
                    End If
                    If strMoneda = "USD" Then
                        .IVLDCS = Math.Round(CDec(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim), 2) 'Dolares
                        If mListaoFact.Item(0).TIPOFACTURA = 1 Then
                            .ITRCTC = .IVLDCS
                        End If

                        dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), 2)
                    Else
                        .IVLDCS = Math.Round(CDec(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim), 2) 'soles
                        If mListaoFact.Item(0).TIPOFACTURA = 1 Then
                            .ITRCTC = .IVLDCS
                        End If


                        dblTotal = dblTotal + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), 2)
                    End If

                    dblSubTotalSoles = dblSubTotalSoles + Math.Round(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), 2)
                End With
                Negocio_FE.Grabar_Detalle_Factura_Electronica(objFact_Det_FE)
            Else
                bolIGV = True

            End If

        Next intCont




        objFact_Cab_FE.IVLDCS = Math.Round(dblTotal, 2)  'Sub Total

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

        dblTotalSoles = dblSubTotalSoles + Math.Round(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), 2)

         
        oDr = oDs.Tables(2).Select("CTPDCC = 2 OR CTPDCC = 52") 'jm

        For intCont = 0 To oDr.Length - 1
            Text = oDr(intCont).Item("TOBCTC").ToString.Trim


        Next intCont

        If strMoneda = "USD" Then
            objFact_Cab_FE.ITTFCS = Math.Round(dblTotal, 2) 'Importe Total Dolares

        Else
            objFact_Cab_FE.ITTFCS = Math.Round(dblTotal, 2) 'Importe Total Soles

        End If

        If strTipoDocFacImp = "52" And (objFact_Cab_FE.CTPDCO = 51 Or objFact_Cab_FE.CTPDCO = 1) Then
            Dim pnMonto As Decimal = 0
            Dim pnPorcentaje As Decimal = 0
            pnMonto = oDs.Tables(1).Rows(0).Item("IAFCDT")
            pnPorcentaje = oDs.Tables(1).Rows(0).Item("IPRCDT")
            If (dblTotalSoles) >= pnMonto And pnPorcentaje > 0 Then
                objFact_Cab_FE.NDSPGD = oDs.Tables(1).Rows(0).Item("IPRCDT") 'valor spot
            End If
        End If

        'GRABAR FACTURA  CABECERA
        Negocio_FE.Grabar_Cabecera_Factura_ELectronica(objFact_Cab_FE)
    End Sub


#End Region

#Region "Eventos de Control"

    Private Sub frmVistaRefacturaElectronico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _TipoDocumento = clsComun.TipoDocumento.Neutro Then
            MessageBox.Show("Envie tipo Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

        Dim pCRGVTA As String = ""
        Dim dtorgVenta As New DataTable
        dtorgVenta = oFacturaNeg.Lista_OrgVenta_Cliente(mListaoFact(0).PSCCMPN, mListaoFact(0).CCLNFC)
        If dtorgVenta.Rows.Count > 0 Then
            pCRGVTA = ("" & dtorgVenta.Rows(0)("CRGVTA")).ToString.Trim
        End If
        If pCRGVTA.Length = 0 Then
            MessageBox.Show("Cliente sin Org Venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mListaoFact(0).CRGVTA = pCRGVTA


        oFacturaNeg.ListaoFact = mListaoFact

        oFacturaNeg.dtServiciosTodosOp = _dtServiciosTodosOp
        'Cambiado por Azorrillap 2011-03-01
        HabilitarFechaFactura()
        '=================================
        TipoDeCambio()
        CargarDatos()

        Actualizar_Punto_Venta()
        Datos_Generales_Factura()

        Obtener_Datos_Adicionales_Factura() 'CSR-HUNDRED

        Generar_Factura()

        Validar()
       



    End Sub

    'CSR-HUNDRED-INICIO
    Private Sub Obtener_Datos_Adicionales_Factura()
        Dim oDtNew As DataTable

        Dim oFiltro As New Hashtable
        Dim strCompania As String


        oFiltro("CCMPN") = mListaoFact(0).PSCCMPN


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


    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Datos_Generales_Factura()
        Generar_Factura()
        Me.Cursor = Cursors.Default
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
        oFacturaNeg.AccionRefactura = 2
        oFacturaNeg.TipoCambio = dblTipoCambio
        Datos_Generales_Factura()
        Generar_Factura()
        'Imprime la Factura
        Try
            ImprimirFactura()
        Catch ex As Exception
            MessageBox.Show("Error al guardar el cliente de la operaci�n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ImprimirFactura()
        Dim strEstado As String = ""
       
        Select Case MessageBox.Show("Desea : " & Chr(13) & _
                                "(   Si   )-->(Guardar)" & Chr(13) & _
                                "(   No   )-->(Cancelar Proceso)", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

            Case Windows.Forms.DialogResult.Yes

                Grabar = True
            Case Windows.Forms.DialogResult.No
                Grabar = False
                Exit Sub
        End Select
        For intContador As Integer = 1 To Me.tabFactura.TabCount
            Grabar_Factura(intContador)
            Me.lblNumFact.Tag = intContador
        Next
        Me.lblNumFact.Tag = New Object

        Me.Close()
        'End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'Private Sub chkDescripcionManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For intCont As Integer = 0 To Me.tabFactura.Controls.Count - 1
    '        CType(Me.tabFactura.TabPages(intCont).Controls(0), ctrlReFactura).ModificarDescripcionFactura = Not Me.chkDescripcionManual.Checked
    '    Next
    'End Sub

    'Private Sub ActulizaNombreServicio(ByVal dtServFactura As DataTable, ByVal strNumFac As String, ByVal intControls As Integer)
    '    If Me.chkDescripcionManual.Checked Then
    '        Dim oDtServicios As New DataTable
    '        Dim oDtAux As New DataTable
    '        Dim pobjFiltro As New Filtro
    '        Dim oFactura As New SOLMIN_CTZ.NEGOCIO.clsFactura
    '        Dim oDtDatos As New DataTable
    '        Dim NOPRCN As Decimal = 0
    '        oDtDatos = CType(Me.tabFactura.TabPages(intControls - 1).Controls(0), ctrlReFactura).DevuelveDatos
    '        oDtServicios = dtServFactura.Copy
    '        For Each dr As DataRow In oDtDatos.Rows
    '            For Each drServicio As DataRow In oDtServicios.Rows
    '                pobjFiltro = New Filtro
    '                If mListaoFact.Item(0).TIPOFACTURA = 2 Then
    '                    If strNumFac = drServicio("NDCCTC") AndAlso dr("NCRDCC") = drServicio("NCRDCC") Then
    '                        pobjFiltro.Parametro1 = drServicio("NOPRCN")
    '                        pobjFiltro.Parametro2 = drServicio("NRTFSV")
    '                        pobjFiltro.Parametro3 = drServicio("NDCCTC")
    '                        pobjFiltro.Parametro4 = drServicio("NCRDCC")
    '                        pobjFiltro.Parametro5 = dr("SERVICIO")
    '                        oFacturaNeg.Actualizar_NombreServicio(pobjFiltro)
    '                    End If
    '                Else
    '                    If strNumFac = drServicio("NDCCTC") And dr("NRRUBR") = drServicio("NRRUBR") Then
    '                        pobjFiltro.Parametro1 = drServicio("NOPRCN")
    '                        pobjFiltro.Parametro2 = drServicio("NRTFSV")
    '                        pobjFiltro.Parametro3 = drServicio("NDCCTC")
    '                        pobjFiltro.Parametro4 = drServicio("NCRDCC")
    '                        pobjFiltro.Parametro5 = dr("SERVICIO")
    '                        oFacturaNeg.Actualizar_NombreServicio(pobjFiltro)
    '                    End If
    '                End If
    '            Next
    '        Next
    '    End If
    'End Sub

    'Private Sub ActulizaNombreServicioHistorial(ByVal dtOperacionDocHistDet As DataTable, ByVal strNumFac As String, ByVal pintFact As Integer)
    '    If Me.chkDescripcionManual.Checked Then
    '        Dim NCRRFC As Decimal = 0
    '        Dim oDtServicios As New DataTable
    '        Dim oDtAux As New DataTable
    '        Dim pobjFiltro As New Filtro
    '        Dim oFactura As New SOLMIN_CTZ.NEGOCIO.clsFactura
    '        Dim oDtDatos As New DataTable
    '        oDtServicios = dtOperacionDocHistDet.Copy

    '        Dim drCorrelativo() As DataRow

    '        oDtDatos = CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlReFactura).DevuelveDatos
    '        For Each dr As DataRow In oDtDatos.Rows
    '            For Each drServicio As DataRow In oDtServicios.Rows
    '                pobjFiltro = New Filtro
    '                If mListaoFact.Item(0).TIPOFACTURA = 2 Then
    '                    If strNumFac = drServicio("NDCCTC") AndAlso dr("NCRDCC") = drServicio("NCRDCC") Then
    '                        drCorrelativo = dtOperacionDocHistDet.Select("NOPRCN='" & drServicio("NOPRCN") & "' AND NDCCTC='" & drServicio("NDCCTC") & "' AND FACTURA='" & pintFact & "'")
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
    '                        drCorrelativo = dtOperacionDocHistDet.Select("NOPRCN='" & drServicio("NOPRCN") & "' AND NDCCTC='" & drServicio("NDCCTC") & "'")
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

    Private Sub ValidarClienteFE()

        Try

            Dim objHash As New Hashtable

            Dim objFiltro As New Hashtable
            Dim oDtPlanta As DataTable

       

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
                    HelpClass.MsgBox("ERROR : Ocurri� un Problema de Conexi�n", MessageBoxIcon.Information)
                    Me.btnFacturar.Enabled = False
                    cmbGiro.Enabled = False
                    dtpFechaFac.Enabled = False
                Case "0"
                    HelpClass.MsgBox("ADVERTENCIA : " & "Cliente deshabilitado para la Facturaci�n electr�nica ", MessageBoxIcon.Information)
                    Me.btnFacturar.Enabled = False
                    cmbGiro.Enabled = False
                    dtpFechaFac.Enabled = False
                Case "2"
                    HelpClass.MsgBox("ADVERTENCIA : " & "Cliente, Negocio y la Zona de facturaci�n no est�n configurados en el SAP ", MessageBoxIcon.Information)
                    Me.btnFacturar.Enabled = False
                    cmbGiro.Enabled = False
                    dtpFechaFac.Enabled = False
            End Select

        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

End Class

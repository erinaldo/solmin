Imports Db2Manager.RansaData.iSeries.DataObjects 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Text
Public Class frmGenararFacturaElectronica
  
    Public ret_TipoDocumento As Decimal = 0
    Public ret_NumeroDocumento As Decimal = 0 'CSR-HUNDRED-ESTIMACION-INGRESO
    Public esRecuperoCarga As Boolean = False

    Public InicioCierrAutomaticoPostFactOK As Boolean = False
    Private esFacturaOK As Boolean = True
 
    '-----FIX SUMMIT-------
    Public pNROPL As Decimal = 0
    Public EsXPreDocumento As Boolean = False
    Public pPreDocumentoList As String = ""
    Private pListado As String = ""
    Private pTipoListado As String = ""
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pIdMoneda As Decimal = 0
    Public pCCLNFC As Decimal = 0

    Private pCRGVTA As String = ""

    Public pTIPOFACTURA As Decimal = 0
    Public pCCLNOP As Decimal = 0
    Public pDialog As Boolean = False
    Sub New(Listado As String, TipoListado As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
       
        pListado = Listado
        pTipoListado = TipoListado
        oFacturaNeg = New SOLMIN_CTZ.NEGOCIO.clsFactura
      
    End Sub

    'csr-hotfix/031116_Visualizacion_Formato_Factura

#Region "Declaracion de Variables"

    Private strMoneda As String
    Private dblTipoCambio As Double
    Private oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura

    Private oDtCabFactura As DataTable
    Private oDtDetFactura As DataTable
 
    Private phashIGV As Hashtable
    Private dtpFechaFactura As Date
    Public Grabar As Boolean = False
    


#End Region

#Region "Procedimientos y Funciones"

   
 

    Private Sub Llenar_Combos()

        Dim oDt As DataTable
        Dim oFiltro As New Hashtable

       
        oFiltro("CCMPN") = pCCMPN
        oFiltro("CDVSN") = pCDVSN
        oDt = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
        Me.cmbGiro.DataSource = oDt
        cmbGiro.ValueMember = "CGRONG"

        cmbGiro.DisplayMember = "TCMGRN"
        
        If oDt.Rows.Count = 1 Then
            Me.cmbGiro.Enabled = False
        End If
       

       
        oFiltro = New Hashtable
        
        oFiltro("CCMPN") = pCCMPN
        oFiltro("CDVSN") = pCDVSN
        Me.cmbPlantaFacturar.DataSource = oFacturaNeg.Lista_Planta_Facturar(oFiltro)
        cmbPlantaFacturar.DisplayMember = "TPLNTA"
        cmbPlantaFacturar.ValueMember = "CPLNDV"
       
 
        oFiltro = New Hashtable
        oFiltro("CCLNT") = pCCLNFC

        oDt = oFacturaNeg.Lista_Planta_Cliente(oFiltro)
        Me.cmbPlantaCliente.DataSource = oDt
        cmbPlantaCliente.ValueMember = "CPLNCL"
        cmbPlantaCliente.DisplayMember = "TDRCPL"
        If oDt.Rows.Count = 1 Then
            Me.cmbPlantaCliente.Enabled = False
        End If
    End Sub


 
    Private Sub Generar_Factura()
        Dim intCant As Integer

 
        Dim fechaServ As Decimal = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
        Dim ParamFac As New Hashtable

        ParamFac("CCLNT") = pCCLNOP
        ParamFac("LISTADO") = pListado
        ParamFac("TIPO_LIST") = pTipoListado
        ParamFac("FECHA_FACT") = fechaServ
        ParamFac("NRO_PL") = pNROPL
        ParamFac("PREDOC_LIST") = pPreDocumentoList
        ParamFac("ES_RECUPERO") = esRecuperoCarga
        

        Dim dtServicioFactura As New DataTable

        If EsXPreDocumento = False Then
            intCant = oFacturaNeg.Cantidad_Facturas_General(ParamFac, dtServicioFactura)
        End If
        If EsXPreDocumento = True Then
            intCant = oFacturaNeg.Cantidad_Facturas_General_PreDocumentos(ParamFac, dtServicioFactura)
        End If


        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant, dtServicioFactura)
            Mostrar_Factura(intCant)
            Me.btnFacturar.Enabled = True
        Else
            Me.btnFacturar.Enabled = False
            HelpClass.MsgBox("No existen Facturas para crear")
        End If
    End Sub

    


    Private Sub Mostrar_Factura(Optional ByVal intCant As Integer = 1)
        Dim octrlFact As ctrlFactura
        Dim pCTPDCI As String = ""
        Dim porDetraccion As Decimal = 0
        Select Case oFacturaNeg.oTipoDocumento
            Case 51, 52
                pCTPDCI = "RU"
            Case 57
                pCTPDCI = "LE"
            Case 6
                pCTPDCI = "PT"
        End Select
        Dim X As Integer = 0
        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True

        Next X

        For lint_Contador As Integer = 0 To intCant - 1

            Dim OrdenCompraCliente As String = ""

            If oDtCabFactura.Rows.Count > 0 Then

                porDetraccion = Convert.ToDecimal(oDtCabFactura.Rows(lint_Contador).Item("NDSPGD").ToString)
                OrdenCompraCliente = ("" & oDtCabFactura.Rows(lint_Contador).Item("OCOMPRA")).ToString.Trim

            End If


            Me.tabFactura.TabPages(lint_Contador).Text = "DOC " & lint_Contador.ToString

            If oFacturaNeg.oTipoDocumento = 51 Or oFacturaNeg.oTipoDocumento = 52 Then
                octrlFact = New ctrlFactura(pCTPDCI, oDtDetFactura, lint_Contador + 1, phashIGV.Item(lint_Contador + 1), pTIPOFACTURA, , porDetraccion, OrdenCompraCliente) 'pdblIGV
            End If
            If oFacturaNeg.oTipoDocumento = 57 Or oFacturaNeg.oTipoDocumento = 6 Then
                octrlFact = New ctrlFactura(pCTPDCI, oDtDetFactura, lint_Contador + 1, phashIGV.Item(lint_Contador + 1), pTIPOFACTURA, 1, porDetraccion, OrdenCompraCliente) 'Electronico ) 'pdblIGV
            End If

            octrlFact.DirServicio = "Dirección servicio : " & oDtCabFactura.Rows(lint_Contador)("DIRSEV").ToString.Trim 'csr-hotfix/031116_Visualizacion_Formato_Factura
            octrlFact.NumFactura = "N°          "
            If pCDVSN = "S" Then
                octrlFact.Referencia1 = Obtener_Referencia_Factura_SIL()
            End If

            If esRecuperoCarga = True Then
                Dim CabFact As String = ""
                Dim Cabdet As String = ""
                Obtener_Referencia_RecuperoCarga(CabFact, Cabdet)
                octrlFact.Referencia1 = CabFact
                octrlFact.Referencia2 = Cabdet
            End If             
          
            Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
            Me.tabFactura.TabPages(lint_Contador).Tag = lint_Contador + 1
        Next
    End Sub

     
    Private Sub Obtener_Referencia_RecuperoCarga(ByRef CabFact As String, ByRef Cabdet As String)
        Dim oFiltro As New Hashtable
        Dim oDt As New DataTable
        oFiltro = New Hashtable
        oFiltro("CCLNT") = pCCLNFC
        oFiltro("TIPO") = pTipoListado
        oFiltro("LISTADO") = pListado
        oDt = oFacturaNeg.Lista_Referencia_RecuperoSeguroCarga(oFiltro)

        Dim dtObs As New DataTable
        Dim dr As DataRow
        dtObs.Columns.Add("TIPO")
        dtObs.Columns.Add("OBS")

        Dim ref As String = ""
        Dim lineaRefFact As String = ""
        Dim filasRefCab As Integer = 0
        Dim filasRefDet As Integer = 0
        Dim tipoObs As Integer = 0

        Dim tipoRecupero As String = ""
        Dim prefijo = ""
        If oDt.Rows.Count > 0 Then
            tipoRecupero = oDt.Rows(0)("TIPOREC")

            If tipoRecupero = "A" Then
                prefijo = "Según Liq:"
            End If
            If tipoRecupero = "M" Then
                prefijo = "Según Fact:"
            End If

            oDt.Rows(0)("REF_FACT") = prefijo & oDt.Rows(0)("REF_FACT")
        End If

        Dim fila As Integer = 0
        Dim textoSig As String = ""
        For Each item As DataRow In oDt.Rows

            filasRefCab = dtObs.Select("TIPO='1'").Length
            filasRefDet = dtObs.Select("TIPO='2'").Length
            ref = ("" & item("REF_FACT")).ToString.Trim & "/"
            textoSig = lineaRefFact & ref

            If textoSig.Length <= 70 Then
                lineaRefFact = lineaRefFact & ref
            End If

            If textoSig.Length > 70 Or (fila = oDt.Rows.Count - 1) Then
                tipoObs = 1
                If filasRefCab >= 4 Then
                    tipoObs = 2
                End If
                If filasRefCab <= 4 And filasRefDet <= 8 Then
                    dr = dtObs.NewRow
                    dr("TIPO") = tipoObs
                    dr("OBS") = lineaRefFact
                    dtObs.Rows.Add(dr)
                    lineaRefFact = ""
                End If
            End If
            fila = fila + 1
        Next

        Dim drObs() As DataRow
        drObs = dtObs.Select("TIPO='1'")
        For Each item As DataRow In drObs
            If CabFact = "" Then
                CabFact = item("OBS")
            Else
                CabFact = CabFact & item("OBS") & vbCrLf
            End If
        Next
        CabFact = CabFact.Trim
        drObs = dtObs.Select("TIPO='2'")
        For Each item As DataRow In drObs
            If Cabdet = "" Then
                Cabdet = item("OBS")
            Else
                Cabdet = Cabdet & item("OBS") & vbCrLf
            End If

        Next
        Cabdet = Cabdet.Trim
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

        Dim oFiltro As New Hashtable
        Dim intCont As Integer
        Dim oDt As DataTable

        oFiltro = New Hashtable
        oFiltro("CCLNT") = pCCLNFC
        oFiltro("TIPO") = pTipoListado
        oFiltro("LISTADO") = pListado

        oDt = oFacturaNeg.Lista_Referencia_Factura_SIL(oFiltro)
 
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

        

        strObs = "GENERACION AUTOMATICA"

        If strObs.Trim <> "" Then
            strReferencia = strReferencia & vbCrLf & strObs
        End If
        
        Return strReferencia
    End Function

    

    


    Private Sub Generar_Cabecera(ByVal pintCant As Double)

        Dim oFiltro As New Hashtable

      

        oFiltro("CCMPN") = pCCMPN
        oFiltro("CDVSN") = pCDVSN
        oFiltro("CCLNFC") = pCCLNFC
        oFiltro("MONEDA") = strMoneda
        oFiltro("TCAMBIO") = dblTipoCambio
        oFiltro("CRGVTA") = Me.txtRegionVenta.Text
        oFiltro("CPLNFC") = cmbPlantaFacturar.SelectedValue
        oFiltro("CANTFACT") = pintCant
        oFiltro("FECFAC") = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
        oFiltro("CCLNOP") = pCCLNOP


 
        oFacturaNeg.GiroNegocio = Me.cmbGiro.SelectedValue

         
        oFacturaNeg.PuntoVenta = Me.cmbPtoVenta.SelectedValue
        oFacturaNeg.PlantaCliente = Me.cmbPlantaCliente.SelectedValue

        oDtCabFactura = oFacturaNeg.Lista_Cabecera_Factura_General(oFiltro)
        Me.dtgCabeceraFactura.DataSource = oDtCabFactura
    End Sub

    Private phtOperacioFacturar As Hashtable

    Private Sub Generar_Detalles(ByVal pintCant As Integer, dtServicos As DataTable)
        Dim fechaFact As Decimal = HelpClass.CtypeDate(Me.dtpFechaFac.Value)



        phashIGV = New Hashtable
        Dim pChkAprobador As String = IIf(chkAprobador.Checked, "X", "")
        Dim pAprobador As String = ""
        If Not UcCmbAprobador.Resultado Is Nothing Then
            pAprobador = CType(UcCmbAprobador.Resultado, FacturaHistorialDet).PSUSRCCO
        Else
            pAprobador = ""
        End If


        Dim obeFact As New beFactParam



        obeFact.CantFact = pintCant
        obeFact.EsRecupero = esRecuperoCarga
        obeFact.pintTipo = pTIPOFACTURA
        obeFact.ChkAprobador = pChkAprobador
        obeFact.Aprobador = pAprobador
        obeFact.EsxPreDocumento = EsXPreDocumento
        obeFact.dtServicos = dtServicos


        oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura_General(obeFact, phashIGV, phtOperacioFacturar) 'pdblIGV 'csr-hotfix/031116_Visualizacion_Formato_Factura
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub


    Private Sub Datos_Generales_Factura()
        Dim oDtNew As DataTable

        Dim oFiltro As New Hashtable
        Dim strCliente As String
        Dim Direc As String = ""


        oFiltro("CCLNT") = pCCLNFC

        oDtNew = oFacturaNeg.Lista_Datos_Cliente(oFiltro)
        strCliente = "Sres.:".PadRight(130, " ") & "Código:    " & oDtNew.Rows(0).Item("CCLNT").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TCMPCL").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TDRCOR").ToString.Trim & "    " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & oDtNew.Rows(0).Item("NRUC").ToString.Trim & " ".PadRight(90, " ") '& "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim
        'Modificado por AZORRILLAP 2011-03-01
        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(Me.dtpFechaFac.Value, "dd/MM/yyyy")
        Me.txtCliente.Text = strCliente

    End Sub

    
    Private Sub Grabar_Factura(ByVal pintFact As Integer)
        Dim strNumFact As String = ""
        Dim objFiltro As New Filtro
        Dim strOCompra As String = "" 'OMVB REQ11072019
        Dim lstrIGV As Decimal = 0
        Dim msgerror As String = ""
        Dim msjeGeneracionFac As String = ""


        Dim CodCompania As String = ""
        Dim TipoDoc As Decimal = 0
        Dim IndRenov As Decimal = 0

        Try
            Cursor = Cursors.WaitCursor
            Dim oDs As DataSet
            oDs = phtOperacioFacturar.Item(pintFact)

            Dim dtVistaFacImpresion As New DataTable
            dtVistaFacImpresion = oFacturaNeg.oHasResumenVista(pintFact)

            lstrIGV = phashIGV(pintFact)

            Dim RefCabecera As String = ""
            Dim RefDetalle As String = ""

            'OMVB REQ11072019 ORDEN DE COMPRA
            strOCompra = CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).txtOCompra.Text.Trim
            'oDtCabFactura.Rows(0)("OCompra") = strOCompra
            RefCabecera = ("" & CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia1).ToString.Trim
            RefDetalle = ("" & CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia2).ToString.Trim
            If strOCompra <> "" Then
                RefCabecera = "OC:" & strOCompra & " " & RefCabecera
            End If
            'OMVB REQ11072019 ORDEN DE COMPRA
            Dim dtObsFact As New DataTable
            Dim dtObsFactDet As New DataTable


            Dim drFact() As DataRow
            drFact = oDtCabFactura.Select("NDCCTC='" & pintFact & "'")
            If drFact.Length > 0 Then
                CodCompania = drFact(0)("CCMPN").ToString.Trim
                TipoDoc = drFact(0)("CTPODC")
                IndRenov = drFact(0)("NINDRN")
            End If
            Dim oFactObs As New FacturaElectronicaDet
            oFactObs.CCMPN = CodCompania
            oFactObs.CTPODC = TipoDoc         
            oFactObs.NINDRN = IndRenov

 

            dtObsFact = oFacturaNeg.Formar_Referencia_Factura(1, RefCabecera)
            dtObsFactDet = oFacturaNeg.Formar_Referencia_Factura(2, RefDetalle)

            oFacturaNeg.Grabar_Factura_General(pintFact, oDtCabFactura, oDs.Tables(0), oDs.Tables(1), strNumFact, dtVistaFacImpresion, lstrIGV, strOCompra, EsXPreDocumento)
          

            If strNumFact = "" Then
                esFacturaOK = False
            End If

            If strNumFact <> "" Then
                ret_TipoDocumento = TipoDoc
                ret_NumeroDocumento = strNumFact
            End If
           

            If strNumFact <> "" Then
                oFactObs.NDCCTC = strNumFact
                oFacturaNeg.Grabar_ReferenciaMasivaJS_Factura(oFactObs, dtObsFact, dtObsFactDet)
            End If
           
            If strNumFact <> "" Then
                tabFactura.TabPages(pintFact - 1).Text = lblTipoDocumento.Text.Trim & " N°" & strNumFact
                CType(tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).NumFactura = "N° " & strNumFact
                lblNumFact.Text = "N° " & strNumFact
            End If


            If strNumFact <> "" Then
                Dim dtServicioHistorial As New DataTable
                dtServicioHistorial = oDs.Tables(0).Copy
                Dim dtSerHistFact As New DataTable
                dtSerHistFact = dtServicioHistorial.Select("FACTURA='" & pintFact & "'").CopyToDataTable()
                oFacturaNeg.Grabar_Historial_DocumentoMasivo(dtSerHistFact)
            End If
          


        Catch ex As Exception
            strNumFact = ""
            esFacturaOK = False
            MessageBox.Show("Error al grabar el documento " & Chr(10) & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try

            If strNumFact = "" Then
                Exit Sub
            End If



            msjeGeneracionFac = "Se grabó documento N° " & strNumFact
            If oFacturaNeg.oTipoDocumento = 6 Then
                Dim ventaInterna As New clsVentaInternaBL
                If oDtCabFactura.Rows.Count > 0 Then
                    Dim ccmpn As String = oDtCabFactura.Rows(0).Item("CCMPN")
                    Dim ctpodc As Double = CDbl(oDtCabFactura.Rows(0).Item("CTPODC"))
                    Dim ndcctc As Double = CDbl(strNumFact)
                    Dim aprobador As String = CStr(CType(UcCmbAprobador.Resultado, FacturaHistorialDet).PSUSRCCO)
                    Dim culusa As String = ConfigurationWizard.UserName
                    ventaInterna.Registrar_SAP(ccmpn, ctpodc, ndcctc, aprobador, culusa)
                End If
                'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

                'CSR-HUNDRED-SOLMIN-PARTE-TRANSFERENCIA 10/05/16 - INICIO 
                Dim frm As New frmVistarptParteTransf()
                frm.PSCCMPN = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                frm.PNCTPODC = oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim
                frm.PNNDCCTC = strNumFact
                frm.ShowDialog()

            Else

                msgerror = Enviar_Factura_SAP(CodCompania, TipoDoc, strNumFact)
                If msgerror.Length > 0 Then
                    msjeGeneracionFac = msjeGeneracionFac & Chr(10) & msgerror
                    msgerror = ""
                    esFacturaOK = False
                End If


                If esRecuperoCarga = False Then
                    msgerror = RevertirEstimacionDocumento(CodCompania, TipoDoc, strNumFact)
                    If msgerror.Length > 0 Then
                        msjeGeneracionFac = msjeGeneracionFac & Chr(10) & msgerror
                        msgerror = ""
                    End If
                End If
            
            End If




            If esFacturaOK = True And InicioCierrAutomaticoPostFactOK = True Then
                Dim ofrmmsg As New frmmsgBox
                ofrmmsg.lblmsg.Text = msjeGeneracionFac
                ofrmmsg.CerrarAutomatico = True
                ofrmmsg.ShowDialog()
                Me.Close()

            Else
                MessageBox.Show(msjeGeneracionFac, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            

        Catch ex As Exception
            Cursor = Cursors.Default

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


     

    Private Function RevertirEstimacionDocumento(CodCompania As String, TipoDoc As Decimal, numFact As Decimal) As String

        Dim oDt As DataTable
        Dim msgerror As String = ""
        Try

            Dim oFiltro As New Hashtable
          
            oFiltro("PSCCMPN") = CodCompania
            oFiltro("PNCTPODC") = TipoDoc
            oFiltro("PNNDCMFC") = numFact
            oFacturaNeg.fintRevertirProvisionXFacturaAdmin(oFiltro, EsXPreDocumento)


            oFiltro = New Hashtable
         
            oFiltro("CCMPN") = CodCompania
            oFiltro("CTPODC") = TipoDoc
            oFiltro("NDCFCC") = numFact
            oFiltro("NSECFC") = 0
            oDt = oFacturaNeg.Estimacion_Ingreso_Revertir(oFiltro)

            Dim ambienteSistema As String = ConfigurationWizard.AmbienteSistema()

            'AmbienteSistema

            If oDt.Rows.Count > 0 Then

                Dim IdEstimacion As Double, AnioContaSap As Double, FechaDocCtaCte As Double
                Dim NroDocEstimacionSap As String, CodSociedadSap As String, NumDocElectronico As String

                Dim dt_url_servicio As New DataTable
                Dim oda_url_servicio As New SOLMIN_CTZ.NEGOCIO.clsUrlServicio
                dt_url_servicio = oda_url_servicio.Listar_Url_Servicio("SDESTSAPSALM", "", "", 0)
                Dim url_ws_servicio As String = ""
                If dt_url_servicio.Rows.Count > 0 Then
                    url_ws_servicio = ("" & dt_url_servicio.Rows(0)("URL")).ToString.Trim
                End If


                For index As Integer = 0 To oDt.Rows.Count - 1
                    IdEstimacion = oDt.Rows(index).Item("IDESTM")
                    NroDocEstimacionSap = oDt.Rows(index).Item("NDESAP").ToString.Trim
                    CodSociedadSap = oDt.Rows(index).Item("CSCDSP").ToString.Trim
                    AnioContaSap = oDt.Rows(index).Item("ACNTSP")
                    NumDocElectronico = oDt.Rows(index).Item("NDCCTE").ToString.Trim
                    FechaDocCtaCte = oDt.Rows(index).Item("FDCFCC")
                    'INI-ECM-ActualizacionTarifario[RF001]-160516
                    Dim wssalmon As New Ransa.Controls.ServicioOperacion.ws_reversion_Ingreso.ws_salmon
                    wssalmon.Url = url_ws_servicio
                    wssalmon.ws_reversion_ingreso(IdEstimacion, CodSociedadSap, NroDocEstimacionSap, AnioContaSap, NumDocElectronico, FechaDocCtaCte)
                    'FIN-ECM-ActualizacionTarifario[RF001]-160516
                Next

            End If

        Catch ex As Exception
            msgerror = "REVERSION PROVISION : " & ex.Message
        End Try
        Return msgerror
    End Function

    Private Function Enviar_Factura_SAP(ByVal pstrCompania As String, ByVal pstrTipoDoc As String, ByVal pstrNumFact As String) As String
        Dim oFiltro As New Filtro
        Dim oDt As DataTable
        Dim strNumSAP As String = ""
        Dim msg As String = ""
        Try
            oFiltro.Parametro1 = pstrCompania.PadLeft(2, "0")
            oFiltro.Parametro2 = pstrTipoDoc.PadLeft(3, "0")
            oFiltro.Parametro3 = pstrNumFact.PadLeft(10, "0")
            oFacturaNeg.Enviar_Documento_SAP_FE(oFiltro)
            oFiltro.Parametro1 = pstrCompania
            oFiltro.Parametro2 = pstrTipoDoc
            oFiltro.Parametro3 = pstrNumFact
            oDt = oFacturaNeg.Comprobar_Envio_Documento_SAP(oFiltro)
            If oDt.Rows.Count > 0 Then
                strNumSAP = oDt.Rows(0).Item("NDCMSP").ToString.Trim

            Else
                msg = "No se  envió correctamente al SAP "
              
            End If
        Catch ex As Exception
            msg = "Error al enviar documento al SAP " & ex.Message

        End Try
        Return msg
    End Function

     
    Private Sub Limpiar_Datos_Factura()
        oFacturaNeg.Limpiar_Datos_Factura()
    End Sub



#End Region

#Region "Eventos de Control"


    Private Function ValidarSeleccionControl() As String
        Dim msgVal As String = ""
        If cmbPtoVenta.Items.Count = 0 Then          
            msgVal = "Punto de Venta no existe"
        End If
        If cmbGiro.Items.Count = 0 Then         
            msgVal = msgVal & Chr(13) & "Giro Negocio no existe"
        End If
        If cmbPlantaCliente.Items.Count = 0 Then           
            msgVal = msgVal & Chr(13) & "Planta Cliente no existe"
        End If
        If cmbPlantaFacturar.Items.Count = 0 Then           
            msgVal = msgVal & Chr(13) & "Planta Facturar no existe"
        End If
        If txtRegionVenta.Text.Length = 0 Then         
            msgVal = msgVal & Chr(13) & "Negocio no existe"
        End If
        Return msgVal
    End Function
    Private Sub frmVistaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      
        strMoneda = pIdMoneda
        Try
            dtpFechaFactura = oFacturaNeg.FechaActualServidor()
            dtpFechaFac.Value = dtpFechaFactura
            dtpFechaFac.Enabled = False
            Dim dtorgVenta As New DataTable
            dtorgVenta = oFacturaNeg.Lista_OrgVenta_Cliente(pCCMPN, pCCLNFC)
            If dtorgVenta.Rows.Count > 0 Then
                pCRGVTA = ("" & dtorgVenta.Rows(0)("CRGVTA")).ToString.Trim
            End If
            If pCRGVTA.Length = 0 Then
                MessageBox.Show("Cliente sin Org Venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            txtRegionVenta.Text = pCRGVTA

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

              
                oFiltro("CCMPN") = pCCMPN
                oFiltro("CDVSN") = pCDVSN
                oFiltro("CCLNT") = pCCLNFC
                oFacturaNeg.Lista_Documentos_Facturacion_Electronico(oFiltro)
                If oFacturaNeg.oDtDocumentos.Rows.Count > 0 Then
                    oFacturaNeg.oTipoDocumento = oFacturaNeg.oDtDocumentos.Rows(0)("CTPODC")
                    oFacturaNeg.oFlagSoloConsulta = ("" & oFacturaNeg.oDtDocumentos.Rows(0)("FLAG_CONSULTA")).ToString.Trim
                End If


                Llenar_Combos()
                cmbPtoVenta.DataSource = oFacturaNeg.oDtDocumentos
                cmbPtoVenta.DisplayMember = "TOBSAD"
                cmbPtoVenta.ValueMember = "NPTOVT"


                Dim msgVal As String = ""
                msgVal = ValidarSeleccionControl()
                If msgVal.Length > 0 Then
                    btnFacturar.Enabled = False
                    MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                

                Select Case oFacturaNeg.oTipoDocumento
                    Case 51
                        Me.lblTipoDocumento.Text = "FACTURA"
                    Case 57
                        Me.lblTipoDocumento.Text = "BOLETA"
                    Case 6
                        Me.lblTipoDocumento.Text = "PARTE TRANSFERENCIA"
                        Label4.Text = ""
                        'btnGenerar.Visible = False
                End Select

                chkAprobador.Checked = False
                chkAprobador.Enabled = False
                If oFacturaNeg.oTipoDocumento = 6 Then
                   
                    chkAprobador.Checked = True
                    chkAprobador.Enabled = True

          
                    cargarAprovador()

                End If

                Obtener_Datos_Adicionales_Factura() 'CSR-HUNDRED

                Datos_Generales_Factura()
                Generar_Factura()


                Dim validacioCliente As Boolean = False
                Dim objHash As New Hashtable
                objHash.Add("CCMPN", pCCMPN)
                objHash.Add("CDVSN", pCDVSN)
                objHash.Add("CRGVTA", txtRegionVenta.Text.Trim.PadLeft(3, "0"))
                objHash.Add("CCLNT", pCCLNFC.ToString.PadLeft(6, "0"))

                Dim strEstado As String = ""
                Dim strResultado As String = oFacturaNeg.fstrValidarClienteSAP(objHash, strEstado)
                Select Case strEstado
                    Case ""
                        HelpClass.MsgBox("ERROR : Ocurrió un Problema de Conexión", MessageBoxIcon.Information)

                        Me.btnFacturar.Enabled = False  'False
                       
                    Case "B", "C", "D"
                        HelpClass.MsgBox("ADVERTENCIA : " & "Cliente " & strResultado, MessageBoxIcon.Information)
                        Me.btnFacturar.Enabled = False
                        Exit Sub
                        
                End Select

                If oFacturaNeg.oTipoDocumento <> 6 Then
                   
                    Dim msgError As String = ""
                  
                    msgError = oFacturaNeg.ValidarClienteSAP(pCCMPN, txtRegionVenta.Text.Trim.PadLeft(3, "0"), pCCLNFC.ToString.PadLeft(6, "0"))
                    If msgError.Length > 0 Then
                        btnFacturar.Enabled = True
                        MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
 

                End If


                If cmbPtoVenta.Items.Count <= 0 Then
                    btnFacturar.Enabled = False
                Else
                    btnFacturar.Enabled = True
                End If

                If oFacturaNeg.oFlagSoloConsulta = "X" Then
                    btnFacturar.Enabled = False
                End If



            Else
                lblError.Visible = True
                btnFacturar.Enabled = False
                txtTipoCambio.Text = ""
            End If


            If InicioCierrAutomaticoPostFactOK = True And btnFacturar.Enabled = True Then

                timerAceptar.Enabled = True
                timerAceptar.Interval = 1000
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 

    '------------------------------------------

    Private Sub tabFactura_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFactura.SelectedIndexChanged
        lblNumFact.Text = tabFactura.SelectedTab.Text.Trim
    End Sub

    
#End Region

    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        Try         
            Dim msgVal As String = ""
            msgVal = ValidarSeleccionControl()
            If msgVal.Length > 0 Then
                btnFacturar.Enabled = False
                MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If oFacturaNeg.oTipoDocumento = 6 Then
                If UcCmbAprobador.Resultado Is Nothing Then
                    MessageBox.Show("Debe seleccionar un aprobador.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.WaitCursor        
            Generar_Factura()
            If InicioCierrAutomaticoPostFactOK = True Then
                Grabar = True
            Else
                Select Case MessageBox.Show("Desea : " & Chr(13) & _
                          "( Si )-->(Guardar )" & Chr(13) & _
                          "( No )-->(Cancelar Proceso)", "Documento Electrónico", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                    Case Windows.Forms.DialogResult.Yes
                        Grabar = True
                    Case Windows.Forms.DialogResult.No
                        Grabar = False
                        Exit Sub
                End Select

            End If


            pDialog = True
            esFacturaOK = True
            For intContador As Integer = 1 To Me.tabFactura.TabCount
                Grabar_Factura(intContador)
                Me.lblNumFact.Tag = intContador
            Next

            btnFacturar.Enabled = False
            Me.lblNumFact.Tag = New Object

             


            Me.Cursor = Cursors.Default

        Catch ex As Exception
            btnFacturar.Enabled = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub



    
    Private Sub ValidarClienteFE()

        Try

            Dim objHash As New Hashtable

            Dim objFiltro As New Hashtable
            Dim oDtPlanta As DataTable

          
            objFiltro("CCMPN") = pCCMPN  'strCodDiv
            objFiltro("CDVSN") = pCDVSN
            objFiltro("CPLNDV") = cmbPlantaFacturar.SelectedValue 'oFact.CPLNDV  'strCodPlanta

            oDtPlanta = oFacturaNeg.Lista_Datos_Planta(objFiltro)

            objHash.Add("CCMPN", pCCMPN)
            objHash.Add("CZNFCC", oDtPlanta.Rows(0).Item("CZNFCC").ToString.PadLeft(3, "0"))
            objHash.Add("CCLNT", pCCLNFC.ToString.PadLeft(6, "0"))
            objHash.Add("CRGVTA", txtRegionVenta.Text.Trim.PadLeft(3, "0"))

            Dim strEstado As String = ""
            Dim strResultado As String = oFacturaNeg.fstrValidarClienteSAPFE(objHash, strEstado)
            Select Case strResultado
                Case ""
                    HelpClass.MsgBox("ERROR : Ocurrió un Problema de Conexión", MessageBoxIcon.Information)
                    Me.btnFacturar.Enabled = False
                    cmbGiro.Enabled = False
                    dtpFechaFac.Enabled = False
                Case "0"
                    HelpClass.MsgBox("ADVERTENCIA : " & "Cliente deshabilitado para la Facturación electrónica ", MessageBoxIcon.Information)
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

    Private Sub cargarAprovador()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "USRCCO"
        oColumnas.DataPropertyName = "PSUSRCCO"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NOMBRE"
        oColumnas.DataPropertyName = "PSNOMUAP"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Dim oLFacturaHistorialDet As New List(Of FacturaHistorialDet)
        oLFacturaHistorialDet = oFacturaNeg.Lista_UsuarioAprobador_ParteTransferencia()

        UcCmbAprobador.DataSource = oLFacturaHistorialDet
        UcCmbAprobador.ListColumnas = oListColum
        UcCmbAprobador.Cargas()
        UcCmbAprobador.ValueMember = "PSUSRCCO"
        UcCmbAprobador.DispleyMember = "PSNOMUAP"

    End Sub

    Private Sub chkAprobador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAprobador.CheckedChanged
      

        If chkAprobador.Checked Then
            UcCmbAprobador.Enabled = True
        Else
            UcCmbAprobador.Enabled = False
            UcCmbAprobador.Limpiar()
        End If

    End Sub

     

    Private Sub Obtener_Datos_Adicionales_Factura()
        Dim oDtNew As DataTable

        Dim oFiltro As New Hashtable
        Dim strCompania As String

        oFiltro("CCMPN") = pCCMPN
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

   
    Private tiempoIniciarFact As Integer = 3
    Private Sub timerAceptar_Tick(sender As Object, e As EventArgs) Handles timerAceptar.Tick
        If InicioCierrAutomaticoPostFactOK = True Then
            tiempoIniciarFact = tiempoIniciarFact - 1
        End If
        If InicioCierrAutomaticoPostFactOK = True And btnFacturar.Enabled = True And tiempoIniciarFact = 0 Then
            timerAceptar.Enabled = False
            btnFacturar_Click(btnFacturar, Nothing)
        End If

    End Sub
End Class

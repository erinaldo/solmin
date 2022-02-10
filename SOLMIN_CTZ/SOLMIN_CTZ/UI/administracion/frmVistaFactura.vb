Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO

Public Class frmVistaFactura

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
    Private bolEstado As Boolean = True
    Private dtpFechaFactura As Date
    Public Grabar As Boolean = False

#End Region

#Region "Procedimientos y Funciones"

    Private Sub TipoDeCambio()
        Dim oDt As DataTable
        Dim oDtRegionVenta As DataTable
        Dim oFiltro As New Filtro
        oFiltro.Parametro1 = "100" 'tipo cambio dolares
        oFiltro.Parametro2 = Format(Me.dtpFechaFac.Value, "yyyyMMdd")
        oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
        If oDt.Rows.Count > 0 Then
            lblError.Visible = False
            btnGenerar.Enabled = ButtonEnabled.True
            dblTipoCambio = oDt.Rows(0).Item("IVNTA").ToString.Trim
            oFacturaNeg.TipoCambio = dblTipoCambio
            Me.txtTipoCambio.Text = dblTipoCambio
            oFiltro.Parametro1 = mListaoFact(0).PSCCMPN  'strCodCom
            oFiltro.Parametro2 = mListaoFact(0).PSCDVSN  'strCodDiv
            oFiltro.Parametro3 = mListaoFact(0).CCLNFC 'dblCliente
            oFacturaNeg.Llenar_Documentos(oFiltro)
            Llenar_Combos()
            txtDivision.Text = mListaoFact(0).TCMPDV   'strDivision

            oDtRegionVenta = oFacturaNeg.Lista_Region_Venta(mListaoFact(0))
            If oDtRegionVenta.Rows.Count = 0 Then
                txtRegionVenta.Text = "Anulada"
                btnGenerar.Visible = False
            Else
                'oFact.CRGVTA = oDtRegionVenta.Rows(0).Item("CRGVTA")
                txtRegionVenta.Text = oDtRegionVenta.Rows(0).Item("CRGVTA")
            End If
        Else
            lblError.Visible = True
            btnGenerar.Enabled = ButtonEnabled.False
            txtRegionVenta.Text = ""
            txtTipoCambio.Text = ""
            If bolEstado Then
                MessageBox.Show("No se puede generar la factura por no existir Tipo de cambio para la fecha  ")
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If

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
        Dim oFiltro As New Filtro
        Dim oDt As DataTable

        bolBuscar = False
        oFiltro.Parametro1 = mListaoFact(0).PSCCMPN 'strCodCom
        oFiltro.Parametro2 = mListaoFact(0).PSCDVSN 'strCodDiv
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
        CargarPlantaFacturar()
        oFiltro = New Filtro
        oFiltro.Parametro1 = mListaoFact(0).CCLNFC 'dblCliente
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

        intCant = Obtener_Cantidad_Facturas()
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
            HelpClass.MsgBox("No existen Facturas para crear")
        End If
    End Sub

    Private Sub Mostrar_Factura(Optional ByVal intCant As Integer = 1)
        'Dim octrlFact As ctrlFactura

        'Me.tabFactura.TabPages(0).Text = "FACTURA"
        'octrlFact = New ctrlFactura(oDtDetFactura, 1, pdblIGV)
        'octrlFact.NumFactura = "N°          "
        'If oFact.PSCDVSN = "S" Then   'strCodDiv
        '    octrlFact.Referencia1 = Obtener_Referencia_Factura_SIL()
        'End If
        'Me.TabPage1.Controls.Add(octrlFact)
        Dim octrlFact As ctrlFactura
        Dim X As Integer = 0
        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True
        Next X
        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = "Factura " & lint_Contador.ToString
            octrlFact = New ctrlFactura(oDtDetFactura, lint_Contador + 1, phashIGV.Item(lint_Contador + 1)) 'pdblIGV
            octrlFact.NumFactura = "N°          "
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



            oFiltro.Parametro1 = mListaoFact(intLista).NSECFC 'dblConsistencia
            oDt = oFacturaNeg.Lista_Unidad_Consistencia_SIL(oFiltro)
            If oDt.Rows.Count = 1 Then
                If oDt.Rows(0).Item("CUNDMD").ToString.Trim = "OS" Then
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
            ListaoFiltro.Add(oFiltro)
        Next
        nRetorno = oFacturaNeg.Cantidad_Facturas(ListaoFiltro)
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
        oFiltro.Parametro9 = mListaoFact(0).CRGVTA
        oFiltro.Parametro10 = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
        oFacturaNeg.PuntoVenta = Me.cmbPtoVenta.SelectedValue
        oFacturaNeg.GiroNegocio = Me.cmbGiro.SelectedValue
        oFacturaNeg.PlantaCliente = Me.cmbPlantaCliente.SelectedValue
        oDtCabFactura = oFacturaNeg.Lista_Cabecera_Factura(oFiltro)
        Me.dtgCabeceraFactura.DataSource = oDtCabFactura
    End Sub

    Private Sub Generar_Detalles(ByVal pintCant As Integer)
        Dim oFiltro As New Filtro

        oFiltro.Parametro2 = pintCant
        oFiltro.Parametro3 = HelpClass.CtypeDate(Me.dtpFechaFac.Value)
        phashIGV = New Hashtable
        oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura(mListaoFact, oFiltro, phashIGV) 'pdblIGV
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub

    Private Sub Datos_Generales_Factura()
        Dim oDtNew As DataTable
        Dim oFiltro As New Filtro
        Dim strCliente As String

        oFiltro.Parametro1 = mListaoFact(0).CCLNFC 'dblCliente
        oDtNew = oFacturaNeg.Lista_Datos_Cliente(oFiltro)
        strCliente = "Sres.:".PadRight(130, " ") & "Código:    " & oDtNew.Rows(0).Item("CCLNT").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TCMPCL").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TDRCOR").ToString.Trim & "    " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & oDtNew.Rows(0).Item("NRUC").ToString.Trim & " ".PadRight(90, " ") & "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim
        'Modificado por AZORRILLAP 2011-03-01
        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(Me.dtpFechaFac.Value, "dd/MM/yyyy")

        Me.txtCliente.Text = strCliente
    End Sub

    Private Sub Actualizar_Punto_Venta()
        Me.Cursor = Cursors.WaitCursor
        If bolBuscar Then
            Dim oFiltro As New Filtro

            oFiltro.Parametro1 = cmbGiro.SelectedValue
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

    Private Sub CargarPlantaFacturar()
        Me.Cursor = Cursors.WaitCursor
        If bolBuscar Then
            Dim oFiltro As New Filtro
            oFiltro.Parametro1 = mListaoFact(0).PSCCMPN
            oFiltro.Parametro2 = mListaoFact(0).PSCDVSN
            Me.cmbPlantaFacturar.DataSource = oFacturaNeg.Lista_Planta_Facturar(oFiltro)
            cmbPlantaFacturar.DisplayMember = "TPLNTA"
            cmbPlantaFacturar.ValueMember = "CPLNDV"
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Grabar_Factura(ByVal pintFact As Integer)
        Dim strNumFact As String = ""
        Dim objFiltro As New Filtro

        Try
            Cursor = Cursors.WaitCursor
            oFacturaNeg.Grabar_Factura(pintFact, oDtCabFactura, oDtDetFactura, strNumFact)
            oFacturaNeg.Grabar_Referencia_Factura(pintFact, 1, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia1)
            oFacturaNeg.Grabar_Referencia_Factura(pintFact, 2, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia2)

            For intCount As Integer = 0 To mListaoFact.Count - 1
                objFiltro.Parametro1 = mListaoFact(intCount).NSECFC 'dblConsistencia
                objFiltro.Parametro2 = oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim
                objFiltro.Parametro3 = strNumFact
                oFacturaNeg.Actualizar_Detalle_Facturado(objFiltro)
            Next intCount


            Me.TabPage1.Text = "Factura N°" & strNumFact
            CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).NumFactura = "N° " & strNumFact
            lblNumFact.Text = "N° " & strNumFact

        Catch ex As Exception
            Cursor = Cursors.Default
            strNumFact = ""
            HelpClass.MsgBox("Error al grabar la factura " & vbCrLf & ex.Message)
        End Try
        If strNumFact <> "" Then
            Cursor = Cursors.Default
            HelpClass.MsgBox("Se grabó correctamente la Factura N° " & strNumFact)
            If lintImprimir = 1 Then
                Imprime_Factura(strNumFact, oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim)
            End If
            Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact)
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
        'Dim drawFormat As New StringFormat

        'drawFormat.Alignment = StringAlignment.Near
        oFiltro.Parametro1 = strCompFacImp
        oFiltro.Parametro2 = strTipoDocFacImp
        oFiltro.Parametro3 = dblNumFacImp
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

        intPosLinea = 296
        For intCont = 0 To oDs.Tables(1).Rows.Count - 1
            If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
                'args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 0, intPosLinea, drawFormat)
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("TCMTRF").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 345, intPosLinea)
                'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 330, intPosLinea, drawFormat)
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 415, intPosLinea)
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
                'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea, drawFormat)
                If oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
                    strMoneda = "USD"
                Else
                    strMoneda = "S/."
                End If
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea)
                If strMoneda = "USD" Then
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim
                    'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
                Else
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim
                    'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
                End If
                dblSubTotalSoles = dblSubTotalSoles + oDs.Tables(1).Rows(intCont).Item("IVLDCS")
            Else
                bolIGV = True
                intPosLinea = intPosLinea - 13
            End If
            intPosLinea = intPosLinea + 13
        Next intCont
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Subtotal: ", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        'args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
        intPosLinea = intPosLinea + 13
        If bolIGV Then
            args.Graphics.DrawString("IGV " & oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim & " %:", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
            If strMoneda = "USD" Then
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
                dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim
            Else
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim
            End If
            intPosLinea = intPosLinea + 13
        End If
        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Total: " & strMoneda, New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00").PadLeft(15, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13

        oDr = oDs.Tables(2).Select("CTPDCC = 2")
        intPosLinea = intPosLinea + 13
        For intCont = 0 To oDr.Length - 1
            args.Graphics.DrawString(oDr(intCont).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 0, intPosLinea)
            intPosLinea = intPosLinea + 13
        Next intCont

        If strMoneda = "USD" Then
            'strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
        Else
            'strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
        End If
        args.Graphics.DrawString("Son: " & strMonto, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 660)
        args.Graphics.DrawString(strMoneda & "    " & Format(dblTotal, "###,###,###,##0.00").PadLeft(16, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 630, 720)
        args.Graphics.DrawString("VENCIDO EL PLAZO DE PAGO SE COBRARAN INT. MORAS Y GTOS. ADM", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 730)
        If dblSubTotalSoles >= 700 Then
            args.Graphics.DrawString("OP. SUJETA AL S.P.O.T. CON EL GOB.CENTRAL POR EL 0.12% - CUENTA 362956", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 743)
        End If




        'Dim oDs As DataSet
        'Dim oFiltro As New Filtro
        'Dim myFont As New Font("Arial", 8)
        'Dim intCont As Integer
        'Dim oDr() As DataRow
        'Dim intPosLinea As Integer = 0
        'Dim dblTotal As Double = 0
        'Dim bolIGV As Boolean = False
        'Dim strMonto As String = ""
        'Dim strMoneda As String = ""
        'Dim dblSubTotalSoles As Double = 0
        ''Dim drawFormat As New StringFormat

        ''drawFormat.Alignment = StringAlignment.Near
        'oFiltro.Parametro1 = strCompFacImp
        'oFiltro.Parametro2 = strTipoDocFacImp
        'oFiltro.Parametro3 = dblNumFacImp
        'oDs = oFacturaNeg.Lista_Datos_Factura(oFiltro)

        'args.Graphics.DrawString("Sres.:", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 80)
        'args.Graphics.DrawString("Código:  " & oDs.Tables(0).Rows(0).Item("CCLNT").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 370, 80)
        'args.Graphics.DrawString(oDs.Tables(0).Rows(0).Item("TCMPCL").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 93)
        'args.Graphics.DrawString(oDs.Tables(0).Rows(0).Item("TDRCOR").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 106)
        'args.Graphics.DrawString("Num.R.U.C.:  " & oDs.Tables(0).Rows(0).Item("NRUC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 119)
        'args.Graphics.DrawString("Zona Cobranza:  " & oDs.Tables(0).Rows(0).Item("CZNCBD").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 350, 119)
        'args.Graphics.DrawString("Fecha Doc.:  " & oDs.Tables(0).Rows(0).Item("FECHA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 132)

        'args.Graphics.DrawString("Referencia:", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 180)
        'args.Graphics.DrawString("No. Control : " & dblNumFacImp, New Font(myFont, FontStyle.Regular), Brushes.Black, 600, 180)

        'oDr = oDs.Tables(2).Select("CTPDCC = 1")
        'intPosLinea = 202
        'For intCont = 0 To oDr.Length - 1
        '  args.Graphics.DrawString(oDr(intCont).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
        '  intPosLinea = intPosLinea + 13
        'Next intCont

        'args.Graphics.DrawString("Cod", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 270)
        'args.Graphics.DrawString("Descripción", New Font(myFont, FontStyle.Regular), Brushes.Black, 75, 270)
        'args.Graphics.DrawString("Cantidad", New Font(myFont, FontStyle.Regular), Brushes.Black, 365, 270)
        'args.Graphics.DrawString("Importe", New Font(myFont, FontStyle.Regular), Brushes.Black, 565, 270)
        'args.Graphics.DrawString("Importe", New Font(myFont, FontStyle.Regular), Brushes.Black, 745, 270)
        'args.Graphics.DrawString("Rub", New Font(myFont, FontStyle.Regular), Brushes.Black, 15, 283)
        'args.Graphics.DrawString("Rubro", New Font(myFont, FontStyle.Regular), Brushes.Black, 75, 283)
        'args.Graphics.DrawString("Aplicada", New Font(myFont, FontStyle.Regular), Brushes.Black, 365, 283)
        'args.Graphics.DrawString("Tarifa", New Font(myFont, FontStyle.Regular), Brushes.Black, 565, 283)
        'args.Graphics.DrawString("Rubro", New Font(myFont, FontStyle.Regular), Brushes.Black, 745, 283)

        '    intPosLinea = 296
        '    For intCont = 0 To oDs.Tables(1).Rows.Count - 1
        '        If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
        '            args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, "0"), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
        '            'args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 0, intPosLinea, drawFormat)
        '            args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("TCMTRF").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
        '            args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 345, intPosLinea)
        '            'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 330, intPosLinea, drawFormat)
        '            args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 415, intPosLinea)
        '            args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
        '            'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea, drawFormat)
        '            If oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim = "DOL" Then
        '                strMoneda = "USD"
        '            Else
        '                strMoneda = "S/."
        '            End If
        '            args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea)
        '            If strMoneda = "USD" Then
        '                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '                dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim
        '                'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
        '            Else
        '                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '                dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim
        '                'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
        '            End If
        '        Else
        '            bolIGV = True
        '            intPosLinea = intPosLinea - 13
        '        End If
        '        intPosLinea = intPosLinea + 13
        '    Next intCont
        '    intPosLinea = intPosLinea + 13
        '    args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '    intPosLinea = intPosLinea + 13
        '    args.Graphics.DrawString("Subtotal: ", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        '    args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '    'args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
        '    intPosLinea = intPosLinea + 13
        '    If bolIGV Then
        '        args.Graphics.DrawString("IGV " & oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim & " %:", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        '        If strMoneda = "USD" Then
        '            args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '            'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
        '            dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim
        '        Else
        '            args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '            dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim
        '        End If
        '        intPosLinea = intPosLinea + 13
        '    End If
        '    args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea)
        '    If strMoneda = "USD" Then
        '      args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '      dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim
        '    Else
        '        args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '        dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim
        '    End If
        '    dblSubTotalSoles = dblSubTotalSoles + oDs.Tables(1).Rows(intCont).Item("IVLDCS")

        'intPosLinea = intPosLinea + 13
        'args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        'intPosLinea = intPosLinea + 13
        'args.Graphics.DrawString("Subtotal: ", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        'args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        ''args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
        'intPosLinea = intPosLinea + 13
        'If bolIGV Then
        '  args.Graphics.DrawString("IGV " & oDs.Tables(1).Rows(0).Item("PIGVA").ToString.Trim & " %:", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        '  If strMoneda = "USD" Then
        '    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '    'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
        '    dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim
        '  Else
        '    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), "###,###,###,##0.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '    dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim
        '  End If
        '  intPosLinea = intPosLinea + 13
        'End If
        'args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        'intPosLinea = intPosLinea + 13
        'args.Graphics.DrawString("Total: " & strMoneda, New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        'args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00").PadLeft(15, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        'intPosLinea = intPosLinea + 13

        'oDr = oDs.Tables(2).Select("CTPDCC = 2")
        'intPosLinea = intPosLinea + 13
        'For intCont = 0 To oDr.Length - 1
        '  args.Graphics.DrawString(oDr(intCont).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 0, intPosLinea)
        '  intPosLinea = intPosLinea + 13
        'Next intCont

        'If strMoneda = "USD" Then
        '  strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
        'Else
        '  strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
        'End If
        'args.Graphics.DrawString("Son: " & strMonto, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 660)
        'args.Graphics.DrawString(strMoneda & "    " & Format(dblTotal, "###,###,###,##0.00").PadLeft(16, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 630, 720)
        'args.Graphics.DrawString("VENCIDO EL PLAZO DE PAGO SE COBRARAN INT. MORAS Y GTOS. ADM", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 730)
        'If dblSubTotalSoles >= 700 Then
        '  args.Graphics.DrawString("OP. SUJETA AL S.P.O.T. CON EL GOB.CENTRAL POR EL 0.12% - CUENTA 362956", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 743)
        'End If
    End Sub

#End Region

#Region "Eventos de Control"

    Private Sub frmVistaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambiado por Azorrillap 2011-03-01
        HabilitarFechaFactura()
        '=================================
        TipoDeCambio()
        bolEstado = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Me.Cursor = Cursors.WaitCursor
        Datos_Generales_Factura()
        Generar_Factura()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmbGiro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGiro.SelectedIndexChanged
        Actualizar_Punto_Venta()
    End Sub

    Private Sub btnImprimirfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirfactura.Click
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
                Grabar_Factura(intContador)         'Grabar_Factura(Me.tabFactura.SelectedIndex + 1)
                Me.lblNumFact.Tag = intContador
                Me.btnImprimirfactura.Visible = False
                Me.btnGenerar.Visible = False
            Next
            Me.lblNumFact.Tag = New Object
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelarImpr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelarImpr.Click
        Me.KryptonHeaderGroup1.Enabled = True
        Me.btnImprimirfactura.Visible = False
        Me.btnCancelarImpr.Visible = False
        Me.lblNumFact.Text = ""
        Limpiar_Datos_Factura()
        Me.TabPage1.Controls.RemoveAt(0)
    End Sub

    Private Sub tabFactura_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabFactura.TabIndexChanged
        lblNumFact.Text = tabFactura.SelectedTab.Text.Trim
    End Sub

    Private Sub dtpFechaFac_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaFac.ValueChanged
        TipoDeCambio()
    End Sub

#End Region

    'Public Function NumeroEnLetras(ByVal numero As String) As String

    '    '********Declara variables de tipo cadena************
    '    Dim palabras, entero, dec, flag As String

    '    '********Declara variables de tipo entero***********
    '    Dim num, x, y As Integer

    '    flag = "N"

    '    '**********Número Negativo***********
    '    If Mid(numero, 1, 1) = "-" Then
    '        numero = Mid(numero, 2, Len(numero) - 1).ToString
    '        palabras = "menos "
    '    End If

    '    '**********Si tiene ceros a la izquierda*************
    '    For x = 1 To Len(numero)
    '        If Mid(numero, 1, 1) = "0" Then
    '            numero = Trim(Mid(numero, 2, Len(numero)).ToString)
    '            If Trim(Len(numero)) = 0 Then palabras = ""
    '        Else
    '            Exit For
    '        End If
    '    Next

    '    '*********Dividir parte entera y decimal************
    '    For y = 1 To Len(numero)
    '        If Mid(numero, y, 1) = "." Then
    '            flag = "S"
    '        Else
    '            If flag = "N" Then
    '                entero = entero + Mid(numero, y, 1)
    '            Else
    '                dec = dec + Mid(numero, y, 1)
    '            End If
    '        End If
    '    Next y

    '    If Len(dec) = 1 Then dec = dec & "0"

    '    '**********proceso de conversión***********
    '    flag = "N"

    '    If Val(numero) <= 999999999 Then
    '        For y = Len(entero) To 1 Step -1
    '            num = Len(entero) - (y - 1)
    '            Select Case y
    '                Case 3, 6, 9
    '                    '**********Asigna las palabras para las centenas***********
    '                    Select Case Mid(entero, num, 1)
    '                        Case "1"
    '                            If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
    '                                palabras = palabras & "cien "
    '                            Else
    '                                palabras = palabras & "ciento "
    '                            End If
    '                        Case "2"
    '                            palabras = palabras & "doscientos "
    '                        Case "3"
    '                            palabras = palabras & "trescientos "
    '                        Case "4"
    '                            palabras = palabras & "cuatrocientos "
    '                        Case "5"
    '                            palabras = palabras & "quinientos "
    '                        Case "6"
    '                            palabras = palabras & "seiscientos "
    '                        Case "7"
    '                            palabras = palabras & "setecientos "
    '                        Case "8"
    '                            palabras = palabras & "ochocientos "
    '                        Case "9"
    '                            palabras = palabras & "novecientos "
    '                    End Select
    '                Case 2, 5, 8
    '                    '*********Asigna las palabras para las decenas************
    '                    Select Case Mid(entero, num, 1)
    '                        Case "1"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                flag = "S"
    '                                palabras = palabras & "diez "
    '                            End If
    '                            If Mid(entero, num + 1, 1) = "1" Then
    '                                flag = "S"
    '                                palabras = palabras & "once "
    '                            End If
    '                            If Mid(entero, num + 1, 1) = "2" Then
    '                                flag = "S"
    '                                palabras = palabras & "doce "
    '                            End If
    '                            If Mid(entero, num + 1, 1) = "3" Then
    '                                flag = "S"
    '                                palabras = palabras & "trece "
    '                            End If
    '                            If Mid(entero, num + 1, 1) = "4" Then
    '                                flag = "S"
    '                                palabras = palabras & "catorce "
    '                            End If
    '                            If Mid(entero, num + 1, 1) = "5" Then
    '                                flag = "S"
    '                                palabras = palabras & "quince "
    '                            End If
    '                            If Mid(entero, num + 1, 1) > "5" Then
    '                                flag = "N"
    '                                palabras = palabras & "dieci"
    '                            End If
    '                        Case "2"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                palabras = palabras & "veinte "
    '                                flag = "S"
    '                            Else
    '                                palabras = palabras & "veinti"
    '                                flag = "N"
    '                            End If
    '                        Case "3"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                palabras = palabras & "treinta "
    '                                flag = "S"
    '                            Else
    '                                palabras = palabras & "treinta y "
    '                                flag = "N"
    '                            End If
    '                        Case "4"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                palabras = palabras & "cuarenta "
    '                                flag = "S"
    '                            Else
    '                                palabras = palabras & "cuarenta y "
    '                                flag = "N"
    '                            End If
    '                        Case "5"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                palabras = palabras & "cincuenta "
    '                                flag = "S"
    '                            Else
    '                                palabras = palabras & "cincuenta y "
    '                                flag = "N"
    '                            End If
    '                        Case "6"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                palabras = palabras & "sesenta "
    '                                flag = "S"
    '                            Else
    '                                palabras = palabras & "sesenta y "
    '                                flag = "N"
    '                            End If
    '                        Case "7"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                palabras = palabras & "setenta "
    '                                flag = "S"
    '                            Else
    '                                palabras = palabras & "setenta y "
    '                                flag = "N"
    '                            End If
    '                        Case "8"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                palabras = palabras & "ochenta "
    '                                flag = "S"
    '                            Else
    '                                palabras = palabras & "ochenta y "
    '                                flag = "N"
    '                            End If
    '                        Case "9"
    '                            If Mid(entero, num + 1, 1) = "0" Then
    '                                palabras = palabras & "noventa "
    '                                flag = "S"
    '                            Else
    '                                palabras = palabras & "noventa y "
    '                                flag = "N"
    '                            End If
    '                    End Select
    '                Case 1, 4, 7
    '                    '*********Asigna las palabras para las unidades*********
    '                    Select Case Mid(entero, num, 1)
    '                        Case "1"
    '                            If flag = "N" Then
    '                                If y = 1 Then
    '                                    palabras = palabras & "uno "
    '                                Else
    '                                    palabras = palabras & "un "
    '                                End If
    '                            End If
    '                        Case "2"
    '                            If flag = "N" Then palabras = palabras & "dos "
    '                        Case "3"
    '                            If flag = "N" Then palabras = palabras & "tres "
    '                        Case "4"
    '                            If flag = "N" Then palabras = palabras & "cuatro "
    '                        Case "5"
    '                            If flag = "N" Then palabras = palabras & "cinco "
    '                        Case "6"
    '                            If flag = "N" Then palabras = palabras & "seis "
    '                        Case "7"
    '                            If flag = "N" Then palabras = palabras & "siete "
    '                        Case "8"
    '                            If flag = "N" Then palabras = palabras & "ocho "
    '                        Case "9"
    '                            If flag = "N" Then palabras = palabras & "nueve "
    '                    End Select
    '            End Select

    '            '***********Asigna la palabra mil***************
    '            If y = 4 Then
    '                If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
    '                (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
    '                Len(entero) <= 6) Then palabras = palabras & "mil "
    '            End If

    '            '**********Asigna la palabra millón*************
    '            If y = 7 Then
    '                If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
    '                    palabras = palabras & "millón "
    '                Else
    '                    palabras = palabras & "millones "
    '                End If
    '            End If
    '        Next y

    '        '**********Une la parte entera y la parte decimal*************
    '        If dec <> "" Then
    '            Return palabras & " y " & dec & "/100 "
    '        Else
    '            Return palabras & " y 00/100 "
    '        End If
    '    Else
    '        Return ""
    '    End If

    'End Function


End Class

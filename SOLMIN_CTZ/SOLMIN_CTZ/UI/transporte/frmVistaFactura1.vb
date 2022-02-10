Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones

Public Class frmVistaFactura1
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
    Private dblNumFacImp As Int64
    Private strCompFacImp As String
    Private strTipoDocFacImp As String
    Private lintCountFactura As Integer
    Private lboolEstado As Int32 = 0
    Private lintImprimir As Int32 = 0
    Private ldtpFechaFactura As Date = Now
    Private lstrIGV As String = ""
    Private lintFATNSR As Int64 = 0

    Public WriteOnly Property pEstado() As Int32
        Set(ByVal value As Int32)
            lboolEstado = value
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
        cmbPlantaCliente.SelectedValue = CType(strCodPlanta, Double)
        Me.cmbPlantaCliente.Enabled = False
        Select Case oFacturaNeg.oTipoDocumento
            Case 1
                Me.lblTipoDocumento.Text = "FACTURA"
            Case 6
                Me.lblTipoDocumento.Text = "PARTE"
            Case 7
                Me.lblTipoDocumento.Text = "BOLETA"
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
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TCMPCL").ToString.Trim
        strCliente = strCliente & vbCrLf & oDtNew.Rows(0).Item("TDRCOR").ToString.Trim & "    " & oDtNew.Rows(0).Item("TDSTR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Num.R.U.C.:  " & oDtNew.Rows(0).Item("NRUC").ToString.Trim & " ".PadRight(90, " ") & "Zona Cobranza:  " & oDtNew.Rows(0).Item("CZNCBR").ToString.Trim
        strCliente = strCliente & vbCrLf & "Fecha Doc.:  " & Format(ldtpFechaFactura, "dd/MM/yyyy")
        Me.txtCliente.Text = strCliente
    End Sub

    Private Sub Generar_Factura()
        Dim intCant As Integer

        intCant = IIf(oFacturaNeg.oTipoDocumento.ToString.Equals("7"), 1, Obtener_Cantidad_Facturas())
        If intCant > 0 Then
            Generar_Cabecera(intCant)
            Generar_Detalles(intCant, lboolEstado)
            Mostrar_Factura(intCant)
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
        Else
            Me.btnCancelarImpr.Visible = False
            Me.btnImprimirfactura.Visible = False
            HelpClass.MsgBox("No existen Facturas para crear")
        End If
    End Sub

    Private Sub Mostrar_Factura(ByVal intCant As Integer)
        Dim octrlFact As ctrlFactura1
        Dim X As Integer = 0
        For X = Me.tabFactura.TabCount To intCant - 1
            Me.tabFactura.TabPages.Add("TabPage" & (X + 1), "")
            Me.tabFactura.TabPages.Item(X).UseVisualStyleBackColor = True
        Next X
        For lint_Contador As Integer = 0 To intCant - 1
            Me.tabFactura.TabPages(lint_Contador).Text = Me.lblTipoDocumento.Text
            octrlFact = New ctrlFactura1(oDtDetFactura, lint_Contador + 1, strMoneda, lstrIGV)
            octrlFact.NumFactura = "N°          "
            octrlFact.Referencia1 = "RUTA: " & oFacturaNeg.Obtener_Referencia_Ruta(lstrConsistenciaOperacion)
            Me.tabFactura.TabPages(lint_Contador).Controls.Add(octrlFact)
        Next

    End Sub

    Private Function Obtener_Cantidad_Facturas() As Integer
        Dim oFiltro As New Hashtable

        oFiltro.Add("PNNOPRCN", lstrConsistenciaOperacion)
        oFiltro.Add("PSCCMPN", strCodCom)
        oFiltro.Add("PSCMNDA", strMoneda)
        oFiltro.Add("PNFECFAC", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PNFATNSR", lintFATNSR)
        Return oFacturaNeg.Cantidad_Facturas(oFiltro) ', lboolEstado)
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
        oDtDetFactura = oFacturaNeg.Lista_Detalle_Factura(oFiltro, lstrIGV)
        Me.dtgDetalleFactura.DataSource = oDtDetFactura
    End Sub

    Private Sub Grabar_Factura(ByVal pintFact As Integer)
        Dim strNumFact As Int64 = 0
        Dim objFiltro As New Hashtable 'Filtro
        Dim intValor As Int32 = 0
        Try
            Cursor = Cursors.WaitCursor
            oFacturaNeg.Grabar_Factura(pintFact, oDtCabFactura, oDtDetFactura, strNumFact)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 1, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia1)
            oFacturaNeg.Grabar_Referencia_Factura(strNumFact, 2, oDtCabFactura, CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).Referencia2)
            intValor = Registrar_Orden_Interna_Factura(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact, CType(oDtCabFactura.Rows(0).Item("FDCCTC").ToString.Trim, Int64))
            'Me.TabPage1.Text = "Factura N°" & strNumFact
            Me.tabFactura.TabPages(pintFact - 1).Text = "Factura N°" & strNumFact
            CType(Me.tabFactura.TabPages(pintFact - 1).Controls(0), ctrlFactura).NumFactura = "N° " & strNumFact
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
            Enviar_Factura_SAP(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, strNumFact.ToString)
            If intValor = 1 Then
                Cerrar_Orden_Interna(oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim, CType(oDtCabFactura.Rows(0).Item("CTPODC").ToString.Trim, Int32), strNumFact)
            End If
            If MsgBox("Desea Imprimir Sustento?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
                Dim obj_Logica As New Factura_Transporte_BLL
                Dim objPrintForm As New PrintForm
                Dim objDsSustento As New DataSet
                Dim objDtSustento As New DataTable
                Dim objetoRepSustento As New rptSustento_Factura
                Dim objParametroSustento As New Hashtable
                Try
                    If strNumFact.ToString.Trim.Length = 0 Then Exit Sub
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
                    objetoRepSustento.SetDataSource(objDsSustento)

                    CType(objetoRepSustento.ReportDefinition.ReportObjects("lblUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConfigurationWizard.UserName
                    CType(objetoRepSustento.ReportDefinition.ReportObjects("lblCompania"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = oDtCabFactura.Rows(0).Item("CCMPN").ToString.Trim
                    CType(objetoRepSustento.ReportDefinition.ReportObjects("lblDivision"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strDivision
                    CType(objetoRepSustento.ReportDefinition.ReportObjects("lblPlanta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = strCodPlanta
                    CType(objetoRepSustento.ReportDefinition.ReportObjects("lblFactura"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "FACTURA N° " & strNumFact.ToString
                    objPrintForm.ShowForm(objetoRepSustento, Me)

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
                Grabar_Factura(intContador) 'Me.tabFactura.SelectedIndex + 1)
                Me.lblNumFact.Tag = intContador
                Me.btnImprimirfactura.Visible = False
                Me.btnGenerar.Visible = False
            Next
            Me.lblNumFact.Tag = New Object
        End If
    End Sub

    'Private Sub btnCancelarImpr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelarImpr.Click
    '  Me.KryptonHeaderGroup1.Enabled = True
    '  Me.btnImprimirfactura.Visible = False
    '  Me.btnCancelarImpr.Visible = False
    '  Me.lblNumFact.Text = ""
    '  Limpiar_Datos_Factura()
    '  Me.TabPage1.Controls.RemoveAt(0)
    'End Sub

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
        'Dim strObs() As String
        'Dim drawFormat As New StringFormat
        'drawFormat.Alignment = StringAlignment.Near
        oFiltro.Add("PSCCMPN", strCompFacImp)
        oFiltro.Add("PNCTPODC", strTipoDocFacImp)
        oFiltro.Add("PNNDCCTC", dblNumFacImp)
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

        'If Me.lboolEstado = 0 Then
        intPosLinea = 309
        For intCont = 0 To oDs.Tables(1).Rows.Count - 1
            If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
                'args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 0, intPosLinea, drawFormat)
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("TCMTRF").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 345, intPosLinea)
                'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 330, intPosLinea, drawFormat)
                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 415, intPosLinea)
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
                'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea, drawFormat)
                args.Graphics.DrawString(strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea) 'oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim
                If strMoneda_Local = "USD" Then
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                    dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim
                    'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
                Else
                    args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
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

        'Else
        '    intPosLinea = 309
        '    'oDr = oDs.Tables(2).Select("CTPDCC = 2")
        '    'For intCont = 0 To oDr.Length - 1
        '    'args.Graphics.DrawString(oDr(intCont).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
        '    'strDescripcionDetalle = oDr(intCont).Item("TOBCTC").ToString.Trim & "-" & strDescripcionDetalle
        '    'intPosLinea = intPosLinea + 13
        '    'Next intCont
        '    '-------------------ACD-----------
        '    For intCont = 0 To oDs.Tables(1).Rows.Count - 1
        '        If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
        '            args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim.PadLeft(3, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 15, intPosLinea)
        '            If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim = 1 Then
        '                bolFlete = True
        '                oDr = oDs.Tables(2).Select("CTPDCC = 2")
        '                For intConti As Integer = 0 To oDr.Length - 1
        '                    If oDr(intConti).Item("TOBCTC").ToString.Trim.Length > 45 Then
        '                        If oDr(intConti).Item("TOBCTC").ToString.Trim <> "" Then
        '                            args.Graphics.DrawString(oDr(intConti).Item("TOBCTC").ToString.Trim.Substring(0, 45), New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea + intConti * 13)
        '                        End If
        '                    Else
        '                        args.Graphics.DrawString(oDr(intConti).Item("TOBCTC").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea + intConti * 13)
        '                    End If
        '                Next intConti
        '            Else
        '                args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("TCMTRF").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 75, intPosLinea)
        '            End If
        '            args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("QAPCTC").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 345, intPosLinea)
        '            args.Graphics.DrawString(oDs.Tables(1).Rows(intCont).Item("CUNCNA").ToString.Trim, New Font(myFont, FontStyle.Regular), Brushes.Black, 415, intPosLinea)
        '            args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("ITRCTC").ToString.Trim, Double), "###,###,###,###.00000").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 530, intPosLinea)
        '            args.Graphics.DrawString(strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 620, intPosLinea) 'oDs.Tables(1).Rows(intCont).Item("CUTCTC").ToString.Trim
        '            If strMoneda_Local = "USD" Then
        '                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '                dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim
        '            Else
        '                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        '                dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim
        '            End If
        '        Else
        '            bolIGV = True
        '            intPosLinea = intPosLinea - 13
        '        End If
        '        If bolFlete = True Then
        '            intPosLinea = intPosLinea + 13 * oDr.Length - 1
        '            bolFlete = False
        '        Else
        '            intPosLinea = intPosLinea + 13
        '        End If
        '    Next intCont
        '    '-------------------FIN ACD--------
        '    dblTotal = 0 'Reiniciamos el Valor total
        '    For intCont = 0 To oDs.Tables(1).Rows.Count - 1
        '        If oDs.Tables(1).Rows(intCont).Item("CRBCTC").ToString.Trim <> "999" Then
        '            If strMoneda_Local = "USD" Then
        '                dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCD").ToString.Trim
        '            Else
        '                dblTotal = dblTotal + oDs.Tables(1).Rows(intCont).Item("IVLDCS").ToString.Trim
        '            End If
        '        Else
        '            bolIGV = True
        '            intPosLinea = intPosLinea - 13
        '        End If
        '        'intPosLinea = intPosLinea + 13
        '    Next intCont
        'End If

        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Subtotal: ", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        'args.Graphics.DrawString(Format(dblTotal, "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
        intPosLinea = intPosLinea + 13
        If bolIGV Then
            args.Graphics.DrawString("IGV " & lstrIGV & " %:", New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
            If strMoneda_Local = "USD" Then
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                'args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD").ToString.Trim, Double), "###,###,###,##0.00"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea, drawFormat)
                dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCD")
            Else
                args.Graphics.DrawString(Format(CType(oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS").ToString.Trim, Double), "###,###,###,###.00").PadLeft(18, " "), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
                dblTotal = dblTotal + oDs.Tables(1).Rows(oDs.Tables(1).Rows.Count - 1).Item("IVLDCS")
            End If
            intPosLinea = intPosLinea + 13
        End If
        args.Graphics.DrawString("--------------------------", New Font(myFont, FontStyle.Bold), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13
        args.Graphics.DrawString("Total: " & strMoneda_Local, New Font(myFont, FontStyle.Regular), Brushes.Black, 650, intPosLinea)
        args.Graphics.DrawString(Format(dblTotal, "###,###,###,###.00").PadLeft(15, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 710, intPosLinea)
        intPosLinea = intPosLinea + 13

        If strMoneda_Local = "USD" Then
            'strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & " Dolares Americanos"
        Else
            'strMonto = NumeroEnLetras(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
            strMonto = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(dblTotal, "###########0.00")).ToUpper & " Nuevos Soles"
        End If
        Dim strValorReferencial As String = Format(oDtCabFactura.Rows(lintCountFactura).Item("VLRFDT"), "###,###,###,###.00")
        args.Graphics.DrawString("Son: " & strMonto, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 660)
        args.Graphics.DrawString(strMoneda_Local & "    " & Format(dblTotal, "###,###,###,###.00").PadLeft(16, "*"), New Font(myFont, FontStyle.Regular), Brushes.Black, 630, 720)
        'If Me.lboolEstado = 0 Then
        args.Graphics.DrawString("Reg. MTC 150491-CNG VAL. REF DETRACCION S/." & strValorReferencial, New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 730)
        'End If
        If dblSubTotalSoles >= 700 Then
            args.Graphics.DrawString("OP. SUJETA AL S.P.O.T. CON EL GOB.CENTRAL POR EL  " & oDs.Tables(0).Rows(0).Item("NDSPGD") & " % " & " -  CUENTA " & IIf(strCodCom.Trim.Equals("EZ"), "362956", "").ToString, New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 743)
        End If
        If Me.lboolEstado = 0 Then
            args.Graphics.DrawString("VENCIDO EL PLAZO DE PAGO SE COBRARAN INT. MORAS Y GTOS. ADM", New Font(myFont, FontStyle.Regular), Brushes.Black, 140, 756)
        End If
        'Dim strCadena As String = args.Graphics.Save
        'args.Graphics.SetClip(args.Graphics) '756
        lintCountFactura += 1
    End Sub

    'Public Function NumeroEnLetras(ByVal numero As String) As String

    '    '********Declara variables de tipo cadena************
    '    Dim palabras, entero, dec, flag As String
    '    palabras = ""
    '    entero = ""
    '    dec = ""
    '    flag = ""
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

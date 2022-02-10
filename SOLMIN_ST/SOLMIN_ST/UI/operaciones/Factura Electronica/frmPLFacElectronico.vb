Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones

Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.Controls.ServicioOperacion


Public Class frmPLFacElectronico

#Region "Atributos"
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private mCCLNT As String = ""
    Private mCPLNDV As Int32 = 0
    Private mConsistenciaPlanta As Boolean = False
    Private dgwPreFacturacionChk As Boolean = False
    Private dgwLiquidacionChk As Boolean = False
    Private cOrgVenta As String = ""
    Private dOrgVenta As String = ""
    Private Aprobador As String = "" ''CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    '-----------------------------------------------------
    Public PNNROPL As Decimal = 0
    '--------------------------------------------------------

    Enum TipoCliente
        Interno = 0
        Externo = 1
    End Enum
#End Region

    
    Private odtCliente As New DataTable
#Region "Eventos"

    Private Sub frmPreLiquidacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            dtgPreDocumentos.AutoGenerateColumns = False
            dgwLiquidacion.AutoGenerateColumns = False
       
            Me.Cargar_Compania()
            Me.Validar_Acceso_Opciones_Usuario()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            If (Me.txtClienteFiltro.pCodigo = 0) Then
                MessageBox.Show("Ingrese Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            '-------------------------------------------------
 
            Me.Listar_Liquidacion()


            '-------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub InicializarFormulario()

        Me.dgwLiquidacion.DataSource = Nothing
        Me.txtClienteFiltro.CCMPN = Me.cboCompania.SelectedValue
    End Sub

    Private Sub dgwLiquidacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwLiquidacion.CellContentClick
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objetoParametro As New Hashtable
        Try

            If dgwLiquidacion.Columns(e.ColumnIndex).Name = "btnDetalleLiquidacion" Then
                Me.Cursor = Cursors.WaitCursor
                If Me.dgwLiquidacion.CurrentCellAddress.Y < 0 Then Exit Sub

                Dim objfrmConsultaPreFactura As New frmConsultaPreFactura()

                With objfrmConsultaPreFactura
                    .mNPRLQD = Me.dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value()
                    .mCompania = Me.cboCompania.SelectedValue
                    .pCDVSN = Me.cboDivision.SelectedValue
                    '--------------------------------------------------------------------
                    .pCCLNT = txtClienteFiltro.pCodigo
                    .pCCLNFC = txtClienteFiltro.pCodigo
                   

                    .ShowDialog()
                    Me.Listar_Liquidacion()
                End With
                Me.Cursor = Cursors.Default
            ElseIf dgwLiquidacion.Columns(e.ColumnIndex).Name = "NOPRCN" Then

                Dim objfrmOperacion As New frmOperacionesXPreFactura
                With objfrmOperacion
                    '--------------------------------------------------------------------
                    .PNCCLNT = txtClienteFiltro.pCodigo

                    '--------------------------------------------------------------------
                    .PNNPRLQD = Me.dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value()
                    .PSCCMPN = Me.cboCompania.SelectedValue
                    .PSCDVSN = Me.cboDivision.SelectedValue
                End With
                objfrmOperacion.ShowDialog()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

   

   
    

    Private Sub btnFacturaPreLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturaPreLiquidacion.Click
        Try



            If dtgPreDocumentos.Rows.Count > 0 Then
                MessageBox.Show("No puede Facturar PL con Pre-Documentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dgwLiquidacion.RowCount = 0 Then Exit Sub

            If odtCliente.Rows.Count = 0 Then
                MessageBox.Show("Datos del cliente no eoncontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            Dim objEntidad As New Factura_Transporte
            Dim obj_Logica As New PreLiquidacion_BLL
            Dim facturaTransporteBL As New Factura_Transporte_BLL
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim Cadena As String = ""
            Dim lstr_Consistencia As String = ""
            Dim dt As DataTable
            Dim dblDocumentoOrigen As Double = 0
            Dim dblFechaDocumentoOrigen As Double = 0
            Dim dblTipoDocumentoOrigen As Double = 0
            Dim obj_LogicaFactura As New Factura_Transporte_BLL
            Dim objDatoCPLNDV As Decimal
            Dim tipoClienteDocumento As TipoCliente = TipoCliente.Externo
            Me.dgwLiquidacion.EndEdit()
            'If Consistencia_Organizacion_Venta(Me.dgwLiquidacion) = False Then
            '    HelpClass.MsgBox("La Organizaci�n de Venta de las Pre-Liquidaciones seleccionadas no son las mismas.", MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            'Me.dgwLiquidacion.EndEdit()
            Dim CodPrimerOrgVenta As String = ""
            Dim CodOrgVenta As String = ""
            Dim EstadoPL As String = ""
            Dim primer_reg_sel As Integer = 0
            For intIndice As Integer = 0 To dgwLiquidacion.RowCount - 1
                If dgwLiquidacion.Item("chk2", intIndice).Value = True Then
                    objEntidad = New Factura_Transporte
                    objEntidad.NPRLQD = dgwLiquidacion.Item("NPRLQD", intIndice).Value
                    objEntidad.CCMPN = Me.cboCompania.SelectedValue
                    objEntidad.CDVSN = Me.cboDivision.SelectedValue
                    objEntidad.CPLNCL = 0

                    lstr_Consistencia = lstr_Consistencia & "," & objEntidad.NPRLQD


                    If primer_reg_sel = 0 Then
                        CodPrimerOrgVenta = ("" & dgwLiquidacion.Item("CRGVTA_L", intIndice).Value).ToString.Trim
                    End If
                    CodOrgVenta = ("" & dgwLiquidacion.Item("CRGVTA_L", intIndice).Value).ToString.Trim
                    If CodOrgVenta <> CodPrimerOrgVenta Then
                        MessageBox.Show("Sector de las Pre-Liquidaciones seleccionadas no son las mismas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    EstadoPL = ("" & dgwLiquidacion.Item("ESTADO_PL", intIndice).Value).ToString.Trim
                    If EstadoPL = "B" Then
                        MessageBox.Show("PL Bloqueado para facturaci�n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    objGenericCollection.Add(objEntidad)
                    primer_reg_sel = primer_reg_sel + 1
                End If
            Next

            If lstr_Consistencia.Length = 0 Then
                MessageBox.Show("No ha seleccionado alguna PL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            


            Dim ListadoPL As String = lstr_Consistencia.Substring(1)
            Dim ValorizacionOK As Boolean = True
            Dim msgValPFPL As String = facturaTransporteBL.ValidarValorizacion_PF_PL(Me.cboCompania.SelectedValue, "PL", ListadoPL)  ' "lstr_Consistencia"
            If msgValPFPL.Length > 0 Then
                MessageBox.Show(msgValPFPL, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ValorizacionOK = False
            End If



            Dim objProcesoFacturaTransporte As New Factura_Transporte_BLL
            Dim objDtFacturaTransporte As New DataTable

            If objGenericCollection.Count = 0 Then Exit Sub
            objDtFacturaTransporte = objProcesoFacturaTransporte.DatosOperacionPlanta(Me.cboCompania.SelectedValue, 0, objGenericCollection(0).NPRLQD)
            If objDtFacturaTransporte.Rows.Count > 0 Then

                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
                objDatoCPLNDV = CType(objDtFacturaTransporte.Rows(0)("CPLNFC"), Decimal)
                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN
            End If

            '--------------------------------------------------------------------
           
            '--------------------------------------------------------------------
            'Dim clienteDataTable As DataTable = facturaTransporteBL.ValidarClienteInterno(Me.cboCompania.SelectedValue, Me.gwdDatos.Item("CCLNT", lint_Contador).Value)

            Dim clienteDataTable As DataTable = facturaTransporteBL.ValidarClienteInterno(Me.cboCompania.SelectedValue, odtCliente.Rows(0)("CCLNT"))


            '--------------------------------------------------------------------
            lstr_Consistencia = lstr_Consistencia.Substring(1)
            Cadena = obj_Logica.Lista_Operacion_Liquidacion(objGenericCollection)

            If Cadena.Length = 0 Then
                MessageBox.Show("Operaciones no encontradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            If (clienteDataTable.Rows.Count > 0) Then
                tipoClienteDocumento = TipoCliente.Interno

                Dim mensajeError As String = facturaTransporteBL.ValidarOperacionesParteTransferencia(cboCompania.SelectedValue, Cadena.TrimEnd(","))  ' "lstr_Consistencia"

                If Len(mensajeError) > 0 Then
                    MsgBox(mensajeError, MsgBoxStyle.Exclamation, "Advertencia")
                    Exit Sub
                End If
            End If
            'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN


            Dim frm_OpcionFactura As New frmOpcionFactura
            If (tipoClienteDocumento = TipoCliente.Interno) Then
                frm_OpcionFactura.EsPT = True
            End If

            With frm_OpcionFactura
                frm_OpcionFactura.Compania = Me.cboCompania.SelectedValue
                frm_OpcionFactura.Division = Me.cboDivision.SelectedValue
                frm_OpcionFactura.Estado = 1
                '--------------------------------------------------------------------
                frm_OpcionFactura.txtCliente.Text = odtCliente.Rows(0)("CCLNT") & " <-> " & odtCliente.Rows(0)("TCMPCL")
                'frm_OpcionFactura.txtNIT.Text = odtCliente.Rows(0)("NRUC")
                'frm_OpcionFactura.txtDireccion.Text = odtCliente.Rows(0)("TDRCOR")
               

                'frm_OpcionFactura.txtCliente.Text = Me.gwdDatos.Item("CCLNT", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCL", lint_Contador).Value
                'frm_OpcionFactura.txtNIT.Text = Me.gwdDatos.Item("NRUCRM", lint_Contador).Value
                'frm_OpcionFactura.txtDireccion.Text = Me.gwdDatos.Item("TDRCRM", lint_Contador).Value
                '--------------------------------------------------------------------
                frm_OpcionFactura.lblOperacion.Text = "N� Liquidaci�n"
                frm_OpcionFactura.txtOperacion.Text = lstr_Consistencia.Trim
                frm_OpcionFactura.txtOrganizacionVenta.Text = CodPrimerOrgVenta ' dOrgVenta.Trim
                frm_OpcionFactura.Planta = objDatoCPLNDV
                If frm_OpcionFactura.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                'Dim FechaFactura As Date = .dtpFechaFactura.Value.Date
                'Dim FechaAtencion As Double = 0
                'If frm_OpcionFactura.chkFechaServicio.Checked = True Then
                '    FechaAtencion = (CType(HelpClass.CFecha_a_Numero8Digitos(.dtpFechaServicio.Value), Int64))
                'End If
                Dim strZonaFacturacion As Int32 = 0
                If frm_OpcionFactura.cboZonaFacturacion.NoHayCodigo = False Then
                    strZonaFacturacion = frm_OpcionFactura.cboZonaFacturacion.Codigo
                End If

                Select Case tipoClienteDocumento
                    Case TipoCliente.Externo

                        Dim param As New Hashtable
                        param.Add("PSNOPRCN", Cadena.TrimEnd(","))
                        param.Add("PSCCMPN", Me.cboCompania.SelectedValue)
                        dt = obj_LogicaFactura.Listar_Facturas_X_Operaciones_Liberadas(param)
                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Count = 1 Then
                                dblDocumentoOrigen = dt.Rows(0).Item("NDCMOR")
                                dblFechaDocumentoOrigen = dt.Rows(0).Item("FDCMOR")
                                dblTipoDocumentoOrigen = dt.Rows(0).Item("CTPDCO")
                            Else
                                Dim ofrm As New frmFacturasXOperacionesLiberadas
                                ofrm.setDataSource(dt)
                                ofrm.ShowDialog()
                                dblDocumentoOrigen = ofrm.DocumentoOrigen
                                dblFechaDocumentoOrigen = ofrm.FechaDocumentoOrigen
                                dblTipoDocumentoOrigen = ofrm.TipoDocumentoOrigen
                            End If

                        End If
                End Select

                Select Case tipoClienteDocumento
                    Case TipoCliente.Externo
                        '--------------------------------------------------------------------

                        ' Dim objfrmVistaFactura As New frmVistaFacturaElectronico(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, Me.gwdDatos.Item("CCLNT", lint_Contador).Value, frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion, ValorizacionOK)

                        Dim objfrmVistaFactura As New frmVistaFacturaElectronico(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, odtCliente.Rows(0)("CCLNT"), frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, ValorizacionOK)

                        '--------------------------------------------------------------------
                        objfrmVistaFactura.EsXPreLiquidacion = True

                        Select Case frm_OpcionFactura.Tag
                            Case 0
                                objfrmVistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Normal
                            Case 1
                                objfrmVistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Resumido
                            Case 2
                                objfrmVistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Detallado
                                'Case 3
                                '    objfrmVistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Lote
                        End Select
                        objfrmVistaFactura.NumDocOrigen = dblDocumentoOrigen
                        objfrmVistaFactura.FechaDocOrigen = dblFechaDocumentoOrigen
                        objfrmVistaFactura.TipoDocOrigen = dblTipoDocumentoOrigen
                        If objfrmVistaFactura.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        '-----------------------------------------
                        ' Me.Listar_PreLiquidacion()
                        'If Me.gwdDatos.RowCount = 0 Then Exit Sub
                        '-------------------------------------------
                        Me.Listar_Liquidacion()

                    Case TipoCliente.Interno

                        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
                        If (frm_OpcionFactura.ucAprobador.Resultado) Is Nothing Then
                            Aprobador = ""
                        Else
                            Aprobador = CType(frm_OpcionFactura.ucAprobador.Resultado, Aprobadores).USRCCO
                        End If

                        '--------------------------------------------------------------------------

                        ' Dim objfrmVistaPT As New frmVistaParteTransferencia(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, Me.gwdDatos.Item("CCLNT", lint_Contador).Value, frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion, Trim(Aprobador))
                        Dim objfrmVistaPT As New frmVistaParteTransferencia(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, odtCliente.Rows(0)("CCLNT"), frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, Trim(Aprobador))

                        '--------------------------------------------------------------------------

                        'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN 

                        Select Case frm_OpcionFactura.Tag
                            Case 0
                                objfrmVistaPT.TipoVistaImpresion = clsComun.VistaImpresion.Normal
                            Case 1
                                objfrmVistaPT.TipoVistaImpresion = clsComun.VistaImpresion.Resumido
                            Case 2
                                objfrmVistaPT.TipoVistaImpresion = clsComun.VistaImpresion.Detallado

                        End Select
                        objfrmVistaPT.EsXPreLiquidacion = True
                        objfrmVistaPT.NumDocOrigen = dblDocumentoOrigen
                        objfrmVistaPT.FechaDocOrigen = dblFechaDocumentoOrigen
                        objfrmVistaPT.TipoDocOrigen = dblTipoDocumentoOrigen

                        If objfrmVistaPT.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        '-----------------------------------------
                      
                        '-----------------------------------------
                        Me.Listar_Liquidacion()
                End Select
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnAnularPreliquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularPreliquidacion.Click

        Try

            If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
            If dtgPreDocumentos.Rows.Count > 0 Then
                MessageBox.Show("No puede anular PL con Pre-Documentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If MessageBox.Show("�Desea anular la Pre-Liquidaci�n?", "Confirmaci�n", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            Dim obj_Logica As New PreLiquidacion_BLL
            Dim objEntidad As New Factura_Transporte
            Dim ListaParametros As New List(Of String)
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim lintResultado As Integer = 0
            dgwLiquidacion.EndEdit()
            For intIndice As Integer = 0 To dgwLiquidacion.RowCount - 1
                If dgwLiquidacion.Item("chk2", intIndice).Value = True Then
                    objEntidad = New Factura_Transporte
                    objEntidad.NPRLQD = dgwLiquidacion.Item("NPRLQD", intIndice).Value
                    objEntidad.CCMPN = Me.cboCompania.SelectedValue
                    objEntidad.CDVSN = Me.cboDivision.SelectedValue

                    objEntidad.CPLNCL = 0
                    objEntidad.CULUSA = MainModule.USUARIO
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objGenericCollection.Add(objEntidad)
                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub

            obj_Logica.Anular_Pre_Liquidacion(objGenericCollection)
            HelpClass.MsgBox("Se anul� la Pre - Liquidaci�n Satisfactoriamente")
            Me.Listar_Liquidacion()
            

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim iContinua As Boolean = True
            Dim lint_Contador As Integer = 0
            Dim lint_NPRLQD As Int64 = 0

            If Me.dgwLiquidacion.RowCount = 0 Then
                iContinua = False
            End If
            dgwLiquidacion.EndEdit()
            If iContinua = True Then
                For intIndice As Integer = 0 To dgwLiquidacion.RowCount - 1
                    If dgwLiquidacion.Item("chk2", intIndice).Value = True Then
                        lint_NPRLQD = dgwLiquidacion.Item("NPRLQD", intIndice).Value
                        lint_Contador += 1
                    End If
                Next
            End If
            Select Case lint_Contador
                Case 0
                    Dim frmOpReparto As New frmOptRepReparto()
                    With frmOpReparto
                        .CCMPN = Me.cboCompania.SelectedValue
                        .CDVSN = Me.cboDivision.SelectedValue

                        .CPLNDV = 0
                        .Compania = Me.cboCompania.Text
                        .Division = Me.cboDivision.Text

                        .Planta = "TODOS"
                        .Estado = 2
                        .Titulo = "Pre Liquidaci�n"
                        .Tipo = "Pre Liquidaci�n"
                        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                    End With
                    Exit Sub
                Case 1
                    Me.Imprimir_PreLiquidacion(lint_NPRLQD)
                Case Else
                    HelpClass.MsgBox("Seleccionar solo una Pre - Liquidaci�n", MessageBoxIcon.Information)
                    Exit Sub
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub cboCompania_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectionChangeCommitted
        Try
            If bolBuscar Then
                Cargar_Division()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectionChangeCommitted
        LimpiarDatos()
    End Sub

    Private Sub dgwLiquidacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwLiquidacion.CellDoubleClick
        Try
            If e.RowIndex = -1 And e.ColumnIndex = 0 Then
                If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
                Dim lintEstado As Boolean = Me.dgwLiquidacion.Item(0, 0).Value
                For lint_Contador As Integer = 0 To Me.dgwLiquidacion.RowCount - 1
                    Me.dgwLiquidacion.Item(0, lint_Contador).Value = Not lintEstado
                    Me.dgwLiquidacion.EndEdit()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
     
    End Sub

    Private Sub btnValorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValorizar.Click
        If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub

        If odtCliente.Rows.Count = 0 Then
            MessageBox.Show("Datos del cliente no eoncontrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Obtener_Estado() = True Then
            Dim listCabecera_Movimiento As New Hashtable
            Dim objParametros As New Hashtable
            'DESPACHOS

            With objParametros
                .Add("CCMPN", Me.cboCompania.SelectedValue)
                .Add("CDVSN", "R")
                .Add("NPRLQD", Me.Obtener_PreLiquidacion)
            End With

            Dim objNegocio As New PreLiquidacion_BLL
            Dim loDespachoMovimientos_BE As New Data.DataTable
            loDespachoMovimientos_BE = objNegocio.ListarMovimiento_PreLiquidacion(objParametros)

            loDespachoMovimientos_BE.DefaultView.Sort = "TCMPCL,PLANTA,CREFFW,NSEQIN"
            loDespachoMovimientos_BE = loDespachoMovimientos_BE.DefaultView.ToTable()

            'Crea Una Rutina k limpia los Datos Solo para el Exportar.

            With listCabecera_Movimiento
                .Add("TITULO", "REPORTE VALORIZADO")
                .Add("COMPA�IA : ", Me.cboCompania.ComboBox.Text)
                .Add("DIVISION : ", Me.cboDivision.ComboBox.Text)
                .Add("CLIENTE : ", odtCliente.Rows(0)("TCMPCL"))
                '.Add("CLIENTE  : ", Me.gwdDatos.Item("TCMPCL", Me.gwdDatos.CurrentCellAddress.Y).Value)
                .Add("PRE LIQUIDACI�N : ", objParametros("NPRLQD"))
            End With

            Dim ds As New Data.DataSet
            ds.Tables.Add(loDespachoMovimientos_BE.Copy)

            ' Dim obrIngresoMovimientos_BLL As New SOLMIN_WEB.NEGOCIO.IngresoMovimientos_BLL
            Ransa.Utilitario.HelpClass_NPOI.ExportExcelDespacho("Despacho", listCabecera_Movimiento, objNegocio.CrearResumenes_Despacho(ds.Tables(0)), Me.Obtener_Grilla)

        Else

            Dim frmOpReparto As New frmOptRepReparto()
            With frmOpReparto
                .CCMPN = Me.cboCompania.SelectedValue
                .CDVSN = Me.cboDivision.SelectedValue

                .CPLNDV = 0
                .Compania = Me.cboCompania.Text
                .Division = Me.cboDivision.Text
                '.Planta = Me.cboPlanta.Text
                .Planta = "TODOS"
                .Estado = 3
                .Titulo = "Reporte Valorizado - Pre Liquidaci�n"
                .Tipo = "Pre Liquidaci�n"
                .Cliente = odtCliente.Rows(0)("TCMPCL")

                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            End With
            Exit Sub
        End If

    End Sub

#End Region

#Region "M�todos"

    Private Function Obtener_Grilla() As DataGridView
        Dim objDgView As New DataGridView
        objDgView.Columns.Add("TCMPCL", "Cliente")
        objDgView.Columns.Add("PLANTA", "Planta")
        objDgView.Columns.Add("CREFFW", "Bulto")
        objDgView.Columns.Add("NSEQIN", "NSEQIN")
        objDgView.Columns.Add("DESCWB", "Descripci�n")
        objDgView.Columns.Add("QBLTSR", "Cant. Despachada")
        objDgView.Columns.Add("TUNDIT", "Unidad Medida")
        objDgView.Columns.Add("QPEPQT", "Peso Despachado")
        objDgView.Columns.Add("TUNPSO", "Unidad Peso")
        objDgView.Columns.Add("QVLBTO", "Volumen Bulto")
        objDgView.Columns.Add("TUNVOL", "Unidad Volumen")
        objDgView.Columns.Add("TPRVCL", "Proveedor")
        objDgView.Columns.Add("NORCML", "Orden de Compra")
        objDgView.Columns.Add("TCMAEM", "�rea Solicitante")
        objDgView.Columns.Add("TIPO", "Tipo Movimiento")
        objDgView.Columns.Add("TRFRNA", "C�digo Lote")
        objDgView.Columns.Add("TLUGEN", "Lugar Entrega")
        objDgView.Columns.Add("FREFFW", "F. Recep. CL")
        objDgView.Columns.Add("FSLFFW", "F. Salida C.L")
        objDgView.Columns.Add("DIASCL", "D�as C.L")
        objDgView.Columns.Add("FINGAL", "F. Recep. Almac�n (O.L)")
        objDgView.Columns.Add("FSLDAL", "F. Salida Almac�n (O.L)")
        objDgView.Columns.Add("DIAS", "D�as Almac�n (O.L)")
        objDgView.Columns.Add("NGUIRM", "Gu�a Remisi�n")
        objDgView.Columns.Add("GRMEDENVIO", "Medio Envio G/R")
        objDgView.Columns.Add("GRTCMTRT", "Transportista")
        objDgView.Columns.Add("GRNPLCCM", "Placa")
        objDgView.Columns.Add("GRNPLACP", "Acoplado")
        objDgView.Columns.Add("FLGCNL", "Estado Entrega")
        objDgView.Columns.Add("FCNFCL", "Fecha Confirmaci�n")
        objDgView.Columns.Add("HCNFCL", "Hora Confirmaci�n")
        objDgView.Columns.Add("SENTIDO", "Sentido de Carga")
        objDgView.Columns.Add("CZNALM", "Almacen/Zona")
        objDgView.Columns.Add("1_MEDENVIO", "1_Medio Envio")
        objDgView.Columns.Add("1_GUIATRANS", "1_Gu�a Transp.")
        objDgView.Columns.Add("1_FGUIRM", "1_Fecha Gu�a Transp.")
        objDgView.Columns.Add("1_TUNDVH", "1_Tipo Unidad")
        objDgView.Columns.Add("1_RUTA", "1_Ruta")
        objDgView.Columns.Add("1_TCMTRT", "1_Transportista")
        objDgView.Columns.Add("1_NPLCTR", "1_Placa")
        objDgView.Columns.Add("1_NPLCAC", "1_Acoplado")
        objDgView.Columns.Add("1_CUENTA", "1_Cuenta")
        objDgView.Columns.Add("1_FCHFTR", "1_Fecha de Llegada")
        objDgView.Columns.Add("3_MEDENVIO", "3_Medio Envio")
        objDgView.Columns.Add("3_GUIATRANS", "3_Gu�a Transp.")
        objDgView.Columns.Add("3_FGUIRM", "3_Fecha Gu�a Transp.")
        objDgView.Columns.Add("3_TUNDVH", "3_Tipo Unidad")
        objDgView.Columns.Add("3_RUTA", "3_Ruta")
        objDgView.Columns.Add("3_TCMTRT", "3_Transportista")
        objDgView.Columns.Add("3_NPLCTR", "3_Avi�n")
        objDgView.Columns.Add("3_NPLCAC", "3_Acoplado")
        objDgView.Columns.Add("3_CUENTA", "3_Cuenta")
        objDgView.Columns.Add("3_FCHFTR", "3_Fecha de Llegada")
        objDgView.Columns.Add("2_MEDENVIO", "2_Medio Envio")
        objDgView.Columns.Add("2_GUIATRANS", "2_Gu�a Transp.")
        objDgView.Columns.Add("2_FGUIRM", "2_Fecha Gu�a Transp.")
        objDgView.Columns.Add("2_TUNDVH", "2_Tipo Unidad")
        objDgView.Columns.Add("2_RUTA", "2_Ruta")
        objDgView.Columns.Add("2_TCMTRT", "2_Transportista")
        objDgView.Columns.Add("2_NPLCTR", "2_Empujador")
        objDgView.Columns.Add("2_NPLCAC", "2_Artefacto")
        objDgView.Columns.Add("2_CUENTA", "2_Cuenta")
        objDgView.Columns.Add("2_FCHFTR", "2_Fecha de Llegada")
        objDgView.Columns.Add("TCTAFE", "Cuenta AFE")
        Return objDgView
    End Function

    Private Function Obtener_PreLiquidacion() As String
        Dim strListaPL As String = ""
        Me.dgwLiquidacion.EndEdit()
        For intIndice As Integer = 0 To dgwLiquidacion.RowCount - 1
            If dgwLiquidacion.Item("chk2", intIndice).Value = True Then
                strListaPL = strListaPL & "," & dgwLiquidacion.Item("NPRLQD", intIndice).Value
            End If
        Next
        strListaPL = strListaPL.Trim.Substring(1)
        Return strListaPL
    End Function

    Private Function Obtener_Estado() As Boolean
        Dim boolEstado As Boolean = False
        Me.dgwLiquidacion.EndEdit()
        For intIndice As Integer = 0 To dgwLiquidacion.RowCount - 1
            If dgwLiquidacion.Item("chk2", intIndice).Value = True Then
                boolEstado = True
            End If
        Next
        Return boolEstado
    End Function

    Private Sub Cargar_Compania()
        Try
            objCompaniaBLL.Crea_Lista()
            bolBuscar = False
            Me.cboCompania.DataSource = objCompaniaBLL.Lista
            Me.cboCompania.ValueMember = "CCMPN"
            Me.cboCompania.DisplayMember = "TCMPCM"
            bolBuscar = True
            cboCompania.SelectedIndex = 0
          
            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            cboCompania_SelectionChangeCommitted(Nothing, Nothing)
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Division()
        Try
            If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing) Then
                bolBuscar = False
                objDivision.Crea_Lista()
                Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
                Me.cboDivision.ValueMember = "CDVSN"
                bolBuscar = True
                Me.cboDivision.DisplayMember = "TCMPDV"
                Me.cboDivision.SelectedValue = "T"
                If Me.cboDivision.SelectedIndex = -1 Then
                    Me.cboDivision.SelectedIndex = 0
                End If
                'cboDivision_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub
    '-------------------------------------------------------------------
   
    Private Sub Listar_Liquidacion()

       


        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objetoParametro As New Hashtable
        '-------------------------------------------------------------------
        objetoParametro.Add("PNCCLNT", txtClienteFiltro.pCodigo)
        objetoParametro.Add("PNCCLNFC", txtClienteFiltro.pCodigo)
      
        '-------------------------------------------------------------------
        objetoParametro.Add("PSCCMPN", cboCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", cboDivision.SelectedValue)
        objetoParametro.Add("PNCPLNDV", 0)
     
        odtCliente = obj_Logica.ListaDatosCliente(Me.cboCompania.SelectedValue, Me.txtClienteFiltro.pCodigo)
        Dim oListPl As New List(Of Factura_Transporte)
        oListPl = obj_Logica.Listar_Liquidacion(objetoParametro)
        Dim TotSoles As Decimal = 0
        Dim TotDol As Decimal = 0
        For Each item As Factura_Transporte In oListPl
            TotSoles = TotSoles + item.IMPOCOS
            TotDol = TotDol + item.IMPOCOD
        Next
        lblDolares.Text = "Soles : " & TotSoles
        lblSoles.Text = "D�lares : " & TotDol

        dtgPreDocumentos.DataSource = Nothing
        Me.dgwLiquidacion.DataSource = oListPl

    End Sub

    Private Sub Imprimir_PreLiquidacion(ByVal lintNPRLQD As Int64)
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objPrintForm As New PrintForm
        Dim objDs As New DataSet
        Dim objetoRep As New rptPreLiquidacion
        Dim objetoRep_Lote As New rptPreLiquidacion_X_Lote
        Dim ListaParametros As New List(Of String)
        Dim oTransporte As New Factura_Transporte
        Dim oDtb As New DataTable
        Dim oDtResLote As New DataTable
        oTransporte.CCMPN = Me.cboCompania.SelectedValue
        oTransporte.NPRLQD = lintNPRLQD
        '===Buscamos el tipo de reporte correspondiente al cliente (se busca el cliente de la preliquidacion)
        oDtb = obj_Logica.ObtenerTipoReportePreLiquidacion(oTransporte)

        Select Case oDtb.Rows(0).Item(0)
            Case 0
                ListaParametros.Add(lintNPRLQD)
                ListaParametros.Add(Me.cboCompania.SelectedValue)
                ListaParametros.Add(Me.cboDivision.SelectedValue)
                'ListaParametros.Add(Me.cboPlanta.SelectedValue)
                ListaParametros.Add(0)
                ListaParametros.Add(HelpClass.TodayNumeric)

                objDs = obj_Logica.Imprimir_Reporte_Pre_Liquidacion(ListaParametros)
                If objDs.Tables.Count = 0 Then Exit Sub
                objDs.Tables(0).TableName = "RZTR06"
                HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", MainModule.USUARIO)
                HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", Me.cboCompania.Text)
                HelpClass.CrystalReportTextObject(objetoRep, "lblDivision", Me.cboDivision.Text)
                HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", "TODOS")

                HelpClass.CrystalReportTextObject(objetoRep, "lblNroPreliquidacion", "N� " & lintNPRLQD.ToString)
                objetoRep.SetDataSource(objDs)
                objPrintForm.ShowForm(objetoRep, Me)
            Case 1
                ListaParametros.Add(lintNPRLQD)
                ListaParametros.Add(Me.cboCompania.SelectedValue)
                ListaParametros.Add(Me.cboDivision.SelectedValue)

                ListaParametros.Add(0)
                ListaParametros.Add(HelpClass.TodayNumeric)

                oTransporte.CDVSN = cboDivision.SelectedValue
                oDtResLote = obj_Logica.Obtener_Reporte_Resumen_X_Lote(oTransporte)

                objDs = obj_Logica.Imprimir_Reporte_Pre_Liquidacion(ListaParametros)
                oDtResLote.TableName = "ResLote"
                objDs.Tables.Add(oDtResLote.Copy)
                If objDs.Tables.Count = 0 Then Exit Sub
                objDs.Tables(0).TableName = "RZTR06"
                objDs.Tables(1).TableName = "RES_X_LOTE"
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblUsuario", MainModule.USUARIO)
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblCompania", Me.cboCompania.Text)
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblDivision", Me.cboDivision.Text)

                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblPlanta", "TODOS")
                HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblNroPreliquidacion", "N� " & lintNPRLQD.ToString)
                objetoRep_Lote.SetDataSource(objDs)
                objPrintForm.ShowForm(objetoRep_Lote, Me)
        End Select
    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral
        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)
        'If objEntidad.STSOP1 = "" Then
        '    Me.btnFacturaPreLiquidacion.Visible = False
        '    'Me.Separator3.Visible = False
        'End If
        'If objEntidad.STSOP2 = "" Then
        '    Me.btnAnularPreliquidacion.Visible = False
        '    'Me.Separator3.Visible = False
        'End If
        'If objEntidad.STSOP3 = "" Then
        '    Me.btnValorizar.Visible = False
        '    'Me.Separator5.Visible = False
        'End If

        'If objEntidad.STSCHG = "" Then
        '    btnPreDoc.Enabled = False
        'End If

        'Validar_Acceso_Tab()
    End Sub

    

    Private Function Consistencia_Organizacion_Venta(ByVal Sender As Object) As Boolean
        Dim lstr_Estado As Boolean = True
        Dim intIndice As Int32 = 0
        cOrgVenta = ""
        Sender.EndEdit()
     
        For intContador As Integer = 0 To Sender.RowCount - 1
            If Sender.Item("chk2", intContador).Value = True Then
                If intIndice = 0 Then
                    
                    cOrgVenta = Sender.Item("CRGVTA_L", intContador).Value
                    dOrgVenta = Sender.Item("TCRVTA_L", intContador).Value
                    lstr_Estado = True
                    intIndice += 1
                Else
                   
                    If Sender.Item("CRGVTA_L", intContador).Value.ToString.Trim <> cOrgVenta.Trim Then
                        lstr_Estado = False
                    End If
                End If
            End If
        Next
        Return lstr_Estado
    End Function

    Private Sub LimpiarDatos()
        'txtClienteFiltro.pClear()
        'gwdDatos.DataSource = Nothing
        dgwLiquidacion.DataSource = Nothing
    End Sub

    Private Function ObtenerTipoCambio() As Double
        Dim oDt As DataTable
        Dim oFiltro As New Hashtable
        Dim ldtpFechaFactura As Date = Now
        Dim dblTipoCambio As Double = 0
        Dim oFacturaNeg As New Factura_Transporte_BLL
        oFiltro.Add("PNCMNDA1", "100")
        oFiltro.Add("PNFCMBO", Format(ldtpFechaFactura, "yyyyMMdd"))
        oFiltro.Add("PSCCMPN", Me.cboCompania.SelectedValue)

        oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
        If oDt.Rows.Count > 0 Then
            dblTipoCambio = oDt.Rows(0).Item("IVNTA").ToString.Trim
        End If
        Return dblTipoCambio
    End Function

#End Region

    Private Sub btnFacturacionLibre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturacionLibre.Click
        Try
            If dgwLiquidacion.RowCount = 0 Then Exit Sub
            Dim objetoParametro As New Hashtable
            Dim objEntidad As New Factura_Transporte
            Dim obj_Logica As New PreLiquidacion_BLL
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim Cadena As String = ""
            Dim lstr_Consistencia As String = ""

            Dim dblDocumentoOrigen As Double = 0
            Dim dblFechaDocumentoOrigen As Double = 0
            Dim dblTipoDocumentoOrigen As Double = 0
            Dim obj_LogicaFactura As New Factura_Transporte_BLL
            Me.dgwLiquidacion.EndEdit()
            If Consistencia_Organizacion_Venta(Me.dgwLiquidacion) = False Then
                HelpClass.MsgBox("Los sectores de las Pre-Liquidaciones seleccionadas no son las mismas.", MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.dgwLiquidacion.EndEdit()
            For intIndice As Integer = 0 To dgwLiquidacion.RowCount - 1
                If dgwLiquidacion.Item("chk2", intIndice).Value = True Then
                    objEntidad = New Factura_Transporte
                    objEntidad.NPRLQD = dgwLiquidacion.Item("NPRLQD", intIndice).Value
                    objEntidad.CCMPN = Me.cboCompania.SelectedValue
                    objEntidad.CDVSN = Me.cboDivision.SelectedValue
                    objEntidad.CPLNCL = 0

                    lstr_Consistencia = lstr_Consistencia & "," & objEntidad.NPRLQD
                    objGenericCollection.Add(objEntidad)
                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub

            lstr_Consistencia = lstr_Consistencia.Substring(1)
            Cadena = obj_Logica.Lista_Operacion_Liquidacion(objGenericCollection)
            If Cadena.Length <> 0 Then
                Cadena = Cadena.Substring(0, Cadena.Length - 1)
            End If
            objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            objetoParametro.Add("PSNOPRCN", Cadena)

            Dim SumaSoles As Double = 0
            Dim SumaDolares As Double = 0
            Dim oDtImportes As DataTable
            Dim Tipo_Cambio As Double = ObtenerTipoCambio()
            If Tipo_Cambio > 0 Then
                If Cadena <> "" Then
                    oDtImportes = obj_LogicaFactura.Listar_Importes_Servicio_Operaciones(objetoParametro)
                    If oDtImportes IsNot Nothing And oDtImportes.Rows.Count > 0 Then
                        For Each objDataRow As DataRow In oDtImportes.Rows
                            If objDataRow("CMNDGU") = 1 Then
                                SumaSoles += objDataRow("ISRVGU")
                                Dim ImporteDolares As Double = objDataRow("ISRVGU") / Tipo_Cambio
                                SumaDolares += ImporteDolares
                            ElseIf objDataRow("CMNDGU") = 100 Then
                                Dim ImporteSoles As Double = objDataRow("ISRVGU") * Tipo_Cambio
                                SumaSoles += ImporteSoles
                                SumaDolares += objDataRow("ISRVGU")
                            End If
                        Next

                        Dim frm_OpcionFacturacionLibre As New frmOpcionFacturacionLibre

                    
                        With frm_OpcionFacturacionLibre
                            .Compania = Me.cboCompania.SelectedValue
                            .Division = Me.cboDivision.SelectedValue
                            .Estado = 1
                            .OperacionPreLiq = Cadena

                            '-------------------------------------------------------------------
                            .txtCliente.Text = odtCliente.Rows(0)("CCLNT") & " <-> " & odtCliente.Rows(0)("TCMPCL")
                            '.txtNIT.Text = odtCliente.Rows(0)("NRUC")
                            '.txtDireccion.Text = odtCliente.Rows(0)("TDRCOR")

                            '.txtCliente.Text = Me.gwdDatos.Item("CCLNT", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCL", lint_Contador).Value
                            '.txtNIT.Text = Me.gwdDatos.Item("NRUCRM", lint_Contador).Value
                            '.txtDireccion.Text = Me.gwdDatos.Item("TDRCRM", lint_Contador).Value

                            '-------------------------------------------------------------------
                            .lblOperacion.Text = "N� Pre Liquidaci�n"
                            .txtOperacion.Text = lstr_Consistencia.Trim
                            .txtOrganizacionVenta.Text = dOrgVenta.Trim
                            SumaSoles = Math.Round(SumaSoles, 2)
                            SumaDolares = Math.Round(SumaDolares, 2)
                            Dim ImporteSoles As String = IIf(SumaSoles = 0, "", String.Format("{0:N2}", SumaSoles))
                            Dim ImporteDolares As String = IIf(SumaDolares = 0, "", String.Format("{0:N2}", SumaDolares))
                            .ImporteSoles = ImporteSoles
                            .ImporteDolares = ImporteDolares
                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                            Me.Listar_Liquidacion()
                        End With
                    End If
                End If
            Else
                HelpClass.MsgBox("No existe Tipo de Cambio para Hoy", MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '-------------------------------------------------------------------
   
    '-------------------------------------------------------------------
    Private Sub btnEditPL_Click(sender As Object, e As EventArgs) Handles btnEditPL.Click
        Try
            If dgwLiquidacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmEditPLDOC As New frmEditPLDOCvb
            ofrmEditPLDOC.pCCMPN = Me.cboCompania.SelectedValue
            ofrmEditPLDOC.pCDVSN = Me.cboDivision.SelectedValue
            ofrmEditPLDOC.pNPRLQD = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            If ofrmEditPLDOC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Listar_Liquidacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub btnPreDoc_Click(sender As Object, e As EventArgs) Handles btnPreDoc.Click
        Try

            Dim ofrmGenerarPreDoc As New Ransa.Controls.ServicioOperacion.frmGenerarPreDoc
          
            Dim dt As New DataTable
            If dgwLiquidacion.CurrentRow Is Nothing Then
                Exit Sub
            End If
            
 
            ofrmGenerarPreDoc.pNRLQD = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            ofrmGenerarPreDoc.pCCMPN = cboCompania.SelectedValue
            ofrmGenerarPreDoc.pCCNLT = txtClienteFiltro.pCodigo
         
            ofrmGenerarPreDoc.pTIPOPL = "T"

            ofrmGenerarPreDoc.ShowDialog()
            If ofrmGenerarPreDoc.pDialog = True Then
                Listar_Liquidacion()
            End If
        
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


   

    Private Sub dtgPreDocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPreDocumentos.CellContentClick
        Try
            If dtgPreDocumentos.Columns(e.ColumnIndex).Name = "OPERACION" Then

                Dim objfrmOperacion As New frmOperacionesXPreDoc

                objfrmOperacion.PSCCMPN = cboCompania.SelectedValue
                objfrmOperacion.PNNRCTRL = Me.dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
                objfrmOperacion.PSTPCTRL = Me.dtgPreDocumentos.CurrentRow.Cells("TPCTRL").Value
                objfrmOperacion.PNNCRRPD = Me.dtgPreDocumentos.CurrentRow.Cells("NCRRPD").Value

                objfrmOperacion.ShowDialog()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
     
    End Sub


    Private Sub dgwLiquidacion_SelectionChanged(sender As Object, e As EventArgs) Handles dgwLiquidacion.SelectionChanged
        Try
            txtValorReferencial.Text = ""
            If dgwLiquidacion.CurrentRow Is Nothing Then Exit Sub
            If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub

            'Me.Listar_Liquidacion()
            Dim dtResult As New DataTable

            Dim obrFiltroPreDoc As New clsPreDocum_BLL

            Dim oPreDocFiltro As PreDocum_BE

            oPreDocFiltro = New PreDocum_BE
            'If oPreDocFiltro IsNot Nothing Then
            oPreDocFiltro.PSCCMPN = cboCompania.SelectedValue
            oPreDocFiltro.PNNRCTRL = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            oPreDocFiltro.PSTIPOPL = "T"
            If oPreDocFiltro IsNot Nothing Then
                dtResult = obrFiltroPreDoc.ListarPLDocumentosCh(oPreDocFiltro)
                dtgPreDocumentos.DataSource = dtResult

                Dim ValorRef As Decimal = 0
                For Each item As DataGridViewRow In dtgPreDocumentos.Rows
                    ValorRef = ValorRef + item.Cells("VLRFDT").Value
                Next
                txtValorReferencial.Text = ValorRef

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnFacturaPreDoc_Click(sender As Object, e As EventArgs) Handles btnFacturaPreDoc.Click
        Try

            If dgwLiquidacion.RowCount = 0 Then
                MessageBox.Show("No existen registro a facturar ", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If dtgPreDocumentos.Rows.Count = 0 Then
                MessageBox.Show("No existen Pre-Documentos a facturar ", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim objEntidad As New Factura_Transporte
            Dim obj_Logica As New PreLiquidacion_BLL
            Dim facturaTransporteBL As New Factura_Transporte_BLL
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim Cadena As String = ""
            Dim lstr_Consistencia As String = ""
            Dim dt As DataTable
            Dim dblDocumentoOrigen As Double = 0
            Dim dblFechaDocumentoOrigen As Double = 0
            Dim dblTipoDocumentoOrigen As Double = 0
            Dim obj_LogicaFactura As New Factura_Transporte_BLL
            Dim objDatoCPLNDV As Decimal
            Dim tipoClienteDocumento As TipoCliente = TipoCliente.Externo
            Dim strPreDoc As String = ""
            Me.dgwLiquidacion.EndEdit()
           
            Dim CodEstadoPL As String = ("" & dgwLiquidacion.CurrentRow.Cells("ESTADO_PL").Value).ToString.Trim
            If CodEstadoPL = "B" Then
                MessageBox.Show("No se puede facturar una liquidaci�n en Pre-Documento ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If




            objEntidad = New Factura_Transporte
            objEntidad.NPRLQD = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
            objEntidad.CCMPN = Me.cboCompania.SelectedValue
            objEntidad.CDVSN = Me.cboDivision.SelectedValue
            objEntidad.CPLNCL = 0
            lstr_Consistencia = lstr_Consistencia & "," & objEntidad.NPRLQD
            objGenericCollection.Add(objEntidad)

            'Next

            If lstr_Consistencia.Length = 0 Then
                MessageBox.Show("No ha seleccionado alguna PL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim ListadoPL As String = lstr_Consistencia.Substring(1)
            Dim ValorizacionOK As Boolean = True
            Dim msgValPFPL As String = facturaTransporteBL.ValidarValorizacion_PF_PL(Me.cboCompania.SelectedValue, "PL", ListadoPL)  ' "lstr_Consistencia"
            If msgValPFPL.Length > 0 Then
                MessageBox.Show(msgValPFPL, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ValorizacionOK = False
            End If



            Dim objProcesoFacturaTransporte As New Factura_Transporte_BLL
            Dim objDtFacturaTransporte As New DataTable

            If objGenericCollection.Count = 0 Then Exit Sub
            objDtFacturaTransporte = objProcesoFacturaTransporte.DatosOperacionPlanta(Me.cboCompania.SelectedValue, 0, objGenericCollection(0).NPRLQD)
            If objDtFacturaTransporte.Rows.Count > 0 Then

                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
                objDatoCPLNDV = CType(objDtFacturaTransporte.Rows(0)("CPLNFC"), Decimal)
                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN
            End If


            Dim clienteDataTable As DataTable = facturaTransporteBL.ValidarClienteInterno(Me.cboCompania.SelectedValue, odtCliente.Rows(0)("CCLNT"))
            '---------------------------------
            strPreDoc = Lista_NCRRPD()

            '--------------------------------------------------------------------
            lstr_Consistencia = lstr_Consistencia.Substring(1)
            Cadena = obj_Logica.Lista_Operacion_Liquidacion(objGenericCollection)

            'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            If (clienteDataTable.Rows.Count > 0) Then
                tipoClienteDocumento = TipoCliente.Interno

                Dim mensajeError As String = facturaTransporteBL.ValidarOperacionesParteTransferencia(cboCompania.SelectedValue, Cadena.TrimEnd(","))  ' "lstr_Consistencia"

                If Len(mensajeError) > 0 Then
                    MsgBox(mensajeError, MsgBoxStyle.Exclamation, "Advertencia")
                    Exit Sub
                End If
            End If
            'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN


            Dim frm_OpcionFactura As New frmOpcionFactura
            If (tipoClienteDocumento = TipoCliente.Interno) Then
                frm_OpcionFactura.EsPT = True
            End If

            Dim idMoneda As Decimal = dtgPreDocumentos.CurrentRow.Cells("ID_MONEDA").Value


            With frm_OpcionFactura
                frm_OpcionFactura.Compania = Me.cboCompania.SelectedValue
                frm_OpcionFactura.Division = Me.cboDivision.SelectedValue
                frm_OpcionFactura.Estado = 1
                '--------------------------------------------------------------------
                frm_OpcionFactura.txtCliente.Text = odtCliente.Rows(0)("CCLNT") & " <-> " & odtCliente.Rows(0)("TCMPCL")
                'frm_OpcionFactura.txtNIT.Text = odtCliente.Rows(0)("NRUC")
                'frm_OpcionFactura.txtDireccion.Text = odtCliente.Rows(0)("TDRCOR")


                '--------------------------------------------------------------------
                frm_OpcionFactura.lblOperacion.Text = "N� Liquidaci�n"
                frm_OpcionFactura.txtOperacion.Text = lstr_Consistencia.Trim
                frm_OpcionFactura.txtOrganizacionVenta.Text = dOrgVenta.Trim
                frm_OpcionFactura.Planta = objDatoCPLNDV

                If idMoneda = 1 Then
                    frm_OpcionFactura.rbtnSoles.Checked = True
                    frm_OpcionFactura.rbtnDolares.Enabled = False
                    frm_OpcionFactura.rbtnSoles.Enabled = False
                End If
                If idMoneda = 100 Then
                    frm_OpcionFactura.rbtnDolares.Checked = True
                    frm_OpcionFactura.rbtnDolares.Enabled = False
                    frm_OpcionFactura.rbtnSoles.Enabled = False
                End If

                If frm_OpcionFactura.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                'Dim FechaFactura As Date = .dtpFechaFactura.Value.Date
                'Dim FechaAtencion As Double = 0
                'If frm_OpcionFactura.chkFechaServicio.Checked = True Then
                '    FechaAtencion = (CType(HelpClass.CFecha_a_Numero8Digitos(.dtpFechaServicio.Value), Int64))
                'End If
                Dim strZonaFacturacion As Int32 = 0
                If frm_OpcionFactura.cboZonaFacturacion.NoHayCodigo = False Then
                    strZonaFacturacion = frm_OpcionFactura.cboZonaFacturacion.Codigo
                End If

                Select Case tipoClienteDocumento
                    Case TipoCliente.Externo

                        Dim param As New Hashtable
                        param.Add("PSNOPRCN", Cadena.TrimEnd(","))
                        param.Add("PSCCMPN", Me.cboCompania.SelectedValue)
                        dt = obj_LogicaFactura.Listar_Facturas_X_Operaciones_Liberadas(param)
                        If dt.Rows.Count > 0 Then
                            If dt.Rows.Count = 1 Then
                                dblDocumentoOrigen = dt.Rows(0).Item("NDCMOR")
                                dblFechaDocumentoOrigen = dt.Rows(0).Item("FDCMOR")
                                dblTipoDocumentoOrigen = dt.Rows(0).Item("CTPDCO")
                            Else
                                Dim ofrm As New frmFacturasXOperacionesLiberadas
                                ofrm.setDataSource(dt)
                                ofrm.ShowDialog()
                                dblDocumentoOrigen = ofrm.DocumentoOrigen
                                dblFechaDocumentoOrigen = ofrm.FechaDocumentoOrigen
                                dblTipoDocumentoOrigen = ofrm.TipoDocumentoOrigen
                            End If

                        End If
                End Select

                Select Case tipoClienteDocumento
                    Case TipoCliente.Externo
                        '--------------------------------------------------------------------
                        'Dim objfrmVistaFactura As New frmVistaFacturaElectronico(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, odtCliente.Rows(0)("CCLNT"), frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion, ValorizacionOK)
                        Dim objfrmVistaFactura As New frmVistaFacturaElectronico(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, odtCliente.Rows(0)("CCLNT"), frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, ValorizacionOK)
                        objfrmVistaFactura.PNNROPL = dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value
                        objfrmVistaFactura.EsxPreDocumento = True
                        objfrmVistaFactura.EsXPreLiquidacion = True
                        objfrmVistaFactura.PreDocumento = strPreDoc
                        '--------------------------------------------------------------------
                        Select Case frm_OpcionFactura.Tag
                            Case 0
                                objfrmVistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Normal
                            Case 1
                                objfrmVistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Resumido
                            Case 2
                                objfrmVistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Detallado
                                'Case 3
                                '    objfrmVistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Lote
                        End Select
                        objfrmVistaFactura.NumDocOrigen = dblDocumentoOrigen
                        objfrmVistaFactura.FechaDocOrigen = dblFechaDocumentoOrigen
                        objfrmVistaFactura.TipoDocOrigen = dblTipoDocumentoOrigen
                        If objfrmVistaFactura.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

                        Me.Listar_Liquidacion()

                        
                End Select
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Function Lista_NCRRPD() As String
        Dim strCadDocumentos As String = ""

        For Each row As DataGridViewRow In dtgPreDocumentos.Rows
            strCadDocumentos += row.Cells("NCRRPD").Value.ToString & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub btnVerPreDoc_Click(sender As Object, e As EventArgs) Handles btnVerPreDoc.Click
        Try

            Dim ofrmNroPL As New Ransa.Controls.ServicioOperacion.frmNroPL
            Dim ofrmGenerarPreDoc As New Ransa.Controls.ServicioOperacion.frmGenerarPreDoc

            If txtClienteFiltro.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If ofrmNroPL.ShowDialog = Windows.Forms.DialogResult.OK Then
                ofrmGenerarPreDoc.pNRLQD = ofrmNroPL.NRO_PL
                ofrmGenerarPreDoc.pCCMPN = cboCompania.SelectedValue
                ofrmGenerarPreDoc.pCCNLT = txtClienteFiltro.pCodigo
                ofrmGenerarPreDoc.pTIPOPL = "T"
                ofrmGenerarPreDoc.pSoloLectura = True
                ofrmGenerarPreDoc.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
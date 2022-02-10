Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO

Public Class frmFactTransporteElectronico

#Region "Atributos"
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private bolBuscar As Boolean
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private mCCLNT As String = ""
    Private mCPLNDV As Int32 = 0
    Private mConsistenciaPlanta As Boolean = False
    'Private cOrgVenta As String = ""
    'Private dOrgVenta As String = ""
    Private Aprobador As String = "" 'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Enum TipoCliente
        Interno = 0
        Externo = 1
    End Enum
#End Region

#Region "Eventos"
    Private Sub frmFacturacionTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Me.gwdDatos.Rows.Clear()
            'Me.dgwGuiaRemision.Rows.Clear()
            'Me.txtOrdenServicio.Text = ""
            ''Me.txtCliente.Text = ""
            'Me.txtClienteFiltro.pClear()
            'Me.txtClienteFiltro.CCMPN = Me.cboCompania.SelectedValue


            Dim dtFechaActual As Date
            Me.Cargar_Compania()
            Me.Alinear_Columnas_Grilla()
            Me.Validar_Acceso_Opciones_Usuario()
            Dim oFacturaNeg As New NEGOCIO.Operaciones.Factura_Transporte_BLL
            dtFechaActual = oFacturaNeg.Obtener_Fecha_Servidor()
            Me.dtpFechaConsistencia.Value = dtFechaActual
            Select Case dtFechaActual.Day
                Case 1, 2
                    Me.lblFechaConsistencia.Visible = True
                    Me.dtpFechaConsistencia.Visible = True
                    'Me.Separator4.Visible = True
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenServicio.Click
        Try
            Dim objFormConsultaOrdenServicio As New frmConsultaOrdenServicio
            With objFormConsultaOrdenServicio
                .CCMPN = Me.cboCompania.SelectedValue
                .CDVSN = Me.cboDivision.SelectedValue
                .CPLNDV = 0
                .TipoFiltro = IIf(Me.chkOS.Checked = True, 0, 1)
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                'Me.txtCliente.Text = .P_CCLNT
                Me.txtOrdenServicio.Text = IIf(Me.chkOS.Checked = True, .P_NORSRT, .P_NCTZCN)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private EstadoSelec As Boolean = False

    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            Select Case e.ColumnIndex
                Case 0
                    If e.RowIndex = -1 Then
                        For intCount As Integer = 0 To Me.gwdDatos.RowCount - 1
                            If Me.Validar_Cliente(intCount) = 2 Then
                                Me.gwdDatos.Item("SELEC_C", intCount).Value = False
                            Else
                                If Not EstadoSelec Then
                                    If Me.gwdDatos.Item("SELEC_C", intCount).Value = False Then
                                        Me.Lista_GR_x_Operacion(intCount)
                                        Me.gwdDatos.Item("SELEC_C", intCount).Value = True
                                    End If
                                Else
                                    Me.Eliminar_Guias_X_Operacion(Me.gwdDatos.Item("NOPRCN_C", intCount).Value)
                                    Me.gwdDatos.Item("SELEC_C", intCount).Value = False
                                End If
                            End If
                        Next
                        EstadoSelec = Not EstadoSelec
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick, gwdDatos.CellContentDoubleClick
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            Select Case e.ColumnIndex
                Case 0
                    If Me.Validar_Cliente(e.RowIndex) = 2 Then
                        Me.gwdDatos.Item("SELEC_C", e.RowIndex).Value = False
                        Exit Sub
                    End If
                    Me.gwdDatos.EndEdit()
                    If Me.gwdDatos.Item("SELEC_C", e.RowIndex).Value = True Then
                        Me.Lista_GR_x_Operacion(e.RowIndex)
                    Else
                        Me.Eliminar_Guias_X_Operacion(Me.gwdDatos.Item("NOPRCN_C", e.RowIndex).Value)
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'Private Sub txtOrdenServicio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrdenServicio.KeyPress
    '    Try
    '        If e.KeyChar = "." Then
    '            e.Handled = True
    '            Exit Sub
    '        End If
    '        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    'Private Sub txtOrdenServicio_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrdenServicio.KeyUp
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Dim obj_Logica As New Factura_Transporte_BLL
    '            Dim objetoParametro As New Hashtable
    '            objetoParametro.Add("PNNORSRT", Me.txtOrdenServicio.Text.Trim)
    '            'Me.txtCliente.Text = obj_Logica.Obtener_Cliente_x_Orden_Servicio(objetoParametro)
    '            Me.btnBuscar_Click(Nothing, Nothing)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Me.Lista_Operacion_x_OS()
            If Me.chkMM.Checked = True Then
                If Me.gwdDatos.RowCount > 0 Then
                    For intCount As Integer = 0 To Me.gwdDatos.RowCount - 1
                        Me.gwdDatos.Item("SELEC_C", intCount).Value = True
                        Me.Lista_GR_x_Operacion(intCount)
                    Next

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub dgwGuiaRemision_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGuiaRemision.CellContentClick
    '    Try
    '        If Me.gwdDatos.RowCount < 0 OrElse e.RowIndex < 0 Then Exit Sub
    '        Select Case e.ColumnIndex
    '            Case 1
    '                Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem = New frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem( _
    '                         Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue, _
    '                         dgwGuiaRemision.CurrentRow.Cells("NOPRCN_D").Value, _
    '                         dgwGuiaRemision.CurrentRow.Cells("NGUITR_D").Value, "L", 0)
    '                With fMostrarInfAdic
    '                    .ToolStrip1.Visible = False
    '                    .tcListadoGuiasCargadas.Controls.Remove(.tpGuiasRemisionHijas)
    '                    .ShowDialog()
    '                End With
    '        End Select
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click
        Try
            Dim CantOperaciones As Int32 = 0
            Dim lstr_Cadena As String = Me.Consistencia_Operacion(CantOperaciones)
            If lstr_Cadena.Length = 0 Then  ' ================ SOLO PARA CONSISTENCIAS CUANDO YA FUE FACTURADO ========================
                Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()
                Dim frmOpReparto As New frmOptRepReparto
                With frmOpReparto
                    .CCMPN = Me.cboCompania.SelectedValue
                    .CDVSN = Me.cboDivision.SelectedValue
                    .CPLNDV = PlantaSeleccionada
                    '.CPLNDV = Me.cboPlanta.SelectedValue
                    .Titulo = "Re - Impresión de Consistencia"
                    .Tipo = "Consistencia"
                    .Estado = 1
                    .Fecha = Me.dtpFechaConsistencia.Value
                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                End With
                Exit Sub
            End If
            If mConsistenciaPlanta Then
                HelpClass.MsgBox("Planta no existe", MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.Imprimir_Consistencia(lstr_Cadena)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Function ObtenerPlantaSeleccionada() As Decimal
        Dim Planta As Decimal = -1
        For i As Integer = 1 To Me.cmbPlanta.CheckedItems.Count - 1
            Planta = Me.cmbPlanta.CheckedItems(i).Value
            Exit For
        Next
        Return Planta
    End Function

    Private Sub btnFacturacionLibre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturacionLibre.Click
        Try
            Dim obj_Logica As New Factura_Transporte_BLL
            Dim objetoParametro As New Hashtable

            Dim lstr_Consistencia As String = Me.Consistencia_Operacion()
            If Me.Consistencia_Cliente = 0 Then Exit Sub
            'If Consistencia_Organizacion_Venta() = False Then
            '    HelpClass.MsgBox("La Organización de Venta de las Operaciones seleccionadas no son iguales", MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()

            objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            objetoParametro.Add("PSNOPRCN", lstr_Consistencia.Trim)

            Dim SumaSoles As Double = 0
            Dim SumaDolares As Double = 0
            Dim oDtImportes As DataTable
            Dim Tipo_Cambio As Double = ObtenerTipoCambio()
            If Tipo_Cambio > 0 Then
                oDtImportes = obj_Logica.Listar_Importes_Servicio_Operaciones(objetoParametro)
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
                End If
            Else
                HelpClass.MsgBox("No existe Tipo de Cambio para Hoy", MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim frm_OpcionFacturacionLibre As New frmOpcionFacturacionLibre
            With frm_OpcionFacturacionLibre
                .Compania = Me.cboCompania.SelectedValue
                .Division = Me.cboDivision.SelectedValue
                For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                    If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                        .txtCliente.Text = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value
                        '.txtNIT.Text = Me.gwdDatos.Item("NRUCCN_C", lint_Contador).Value
                        '.txtDireccion.Text = Me.gwdDatos.Item("TDRCNS_C", lint_Contador).Value
                        .txtOperacion.Text = lstr_Consistencia.Trim
                        SumaSoles = Math.Round(SumaSoles, 2)
                        SumaDolares = Math.Round(SumaDolares, 2)
                        Dim ImporteSoles As String = IIf(SumaSoles = 0, "", String.Format("{0:N2}", SumaSoles)) 'Convert.ToString(SumaSoles)
                        Dim ImporteDolares As String = IIf(SumaDolares = 0, "", String.Format("{0:N2}", SumaDolares)) 'Convert.ToString(SumaDolares)
                        .ImporteSoles = ImporteSoles
                        .ImporteDolares = ImporteDolares
                        '.txtOrganizacionVenta.Text = dOrgVenta
                        Exit For
                    End If
                Next
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Me.Lista_Operacion_x_OS()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactura.Click
        Try
            Dim obj_Logica As New Factura_Transporte_BLL
            'Dim objetoParametro As New Hashtable
            'Dim lint_Numerador As Int64 = 0

            Dim cOrgVenta As String = ""

            Dim lstr_Consistencia As String = Me.Consistencia_Operacion()
            Dim objDatoCPLNDV As Decimal
            'Dim lstr_primera_operacion As String = String.Copy(Me.Consistencia_Operacion(msgValidacionFactura)).Split(",")(0)
            Dim lstr_primera_operacion As String = String.Copy(lstr_Consistencia).Split(",")(0)


           


            Dim objProcesoFacturaTransporte As New Factura_Transporte_BLL
            Dim objDtFacturaTransporte As New DataTable
          

            Dim dt As DataTable
            Dim dblDocumentoOrigen As Double = 0
            Dim dblFechaDocumentoOrigen As Double = 0
            Dim dblTipoDocumentoOrigen As Double = 0
            Dim tipoClienteDocumento As TipoCliente = TipoCliente.Externo

            If Me.Consistencia_Cliente = 0 Then Exit Sub
            If mConsistenciaPlanta Then
                HelpClass.MsgBox("Planta no existe", MessageBoxIcon.Information)
                Exit Sub
            End If
            If Consistencia_Organizacion_Venta(cOrgVenta) = False Then
                'HelpClass.MsgBox("La Organización de Venta de las Operaciones seleccionadas no son iguales", MessageBoxIcon.Information)
                HelpClass.MsgBox("Sector no son iguales", MessageBoxIcon.Information)

                Exit Sub
            End If
            'validacion
            objDtFacturaTransporte = objProcesoFacturaTransporte.DatosOperacionPlanta(Me.cboCompania.SelectedValue, lstr_primera_operacion, 0)
            If objDtFacturaTransporte.Rows.Count > 0 Then
                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-INICIO
                objDatoCPLNDV = CType(objDtFacturaTransporte.Rows(0)("CPLNFC"), Decimal)
                'CSR-HUNDRED-CORRECTIVO-VENTA INTERNA-FIN

            End If

           
            Dim clienteFac As Decimal = 0
            For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                    clienteFac = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value
                    Exit For
                End If
            Next
            Dim clienteDataTable As DataTable = obj_Logica.ValidarClienteInterno(Me.cboCompania.SelectedValue, clienteFac)
            If (clienteDataTable.Rows.Count > 0) Then
                tipoClienteDocumento = TipoCliente.Interno

                Dim mensajeError As String = obj_Logica.ValidarOperacionesParteTransferencia(cboCompania.SelectedValue, lstr_Consistencia)

                If Len(mensajeError) > 0 Then
                    MsgBox(mensajeError, MsgBoxStyle.Exclamation, "Advertencia")
                    Exit Sub
                End If
            End If

            Dim frm_OpcionFactura As New frmOpcionFactura
            If (tipoClienteDocumento = TipoCliente.Interno) Then
                frm_OpcionFactura.EsPT = True
            End If




            frm_OpcionFactura.Compania = Me.cboCompania.SelectedValue
            frm_OpcionFactura.Division = Me.cboDivision.SelectedValue
            For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                    frm_OpcionFactura.txtCliente.Text = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value
                    'frm_OpcionFactura.txtNIT.Text = Me.gwdDatos.Item("NRUCCN_C", lint_Contador).Value
                    'frm_OpcionFactura.txtDireccion.Text = Me.gwdDatos.Item("TDRCNS_C", lint_Contador).Value
                    frm_OpcionFactura.txtOperacion.Text = lstr_Consistencia.Trim
                    frm_OpcionFactura.txtPreFactura.Text = ""
                    'frm_OpcionFactura.txtOrganizacionVenta.Text = dOrgVenta
                    frm_OpcionFactura.Planta = objDatoCPLNDV
                    Exit For
                End If
            Next

            'frm_OpcionFactura.txtPreFactura.Tag = ""
            'frm_OpcionFactura.rbtnFactura.Checked = True
            'frm_OpcionFactura.rbtnPreFactura.Checked = False
            'frm_OpcionFactura.rbtnPreFactura.Enabled = False

            Dim NroPreFactura As Decimal = 0
            If frm_OpcionFactura.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            If frm_OpcionFactura.rbtnPreFactura.Checked Then

                Dim objetoParametroPreF As New Hashtable
                objetoParametroPreF.Add("PNNOPRCN", lstr_Consistencia.Trim)
                objetoParametroPreF.Add("PSCCMPN", Me.cboCompania.SelectedValue)
                objetoParametroPreF.Add("PSCDVSN", Me.cboDivision.SelectedValue)
                objetoParametroPreF.Add("PNCPLNDV", frm_OpcionFactura.Planta)
                objetoParametroPreF.Add("PNFULTAC", HelpClass.TodayNumeric)
                objetoParametroPreF.Add("PNHULTAC", HelpClass.NowNumeric)
                objetoParametroPreF.Add("PSCULUSA", MainModule.USUARIO)
                objetoParametroPreF.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
                NroPreFactura = obj_Logica.Pre_Facturar_Operacion(objetoParametroPreF)
                'obj_Logica.Pre_Facturar_Operacion(objetoParametroPreF)
                frm_OpcionFactura.txtPreFactura.Text = NroPreFactura.ToString.Trim
                MessageBox.Show("Se generó la Pre-Factura " & NroPreFactura.ToString.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Lista_Operacion_x_OS()
            Else

                'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
                If (frm_OpcionFactura.ucAprobador.Resultado) Is Nothing Then
                    Aprobador = ""
                Else
                    Aprobador = CType(frm_OpcionFactura.ucAprobador.Resultado, Aprobadores).USRCCO
                End If
                'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

                'Dim FechaFactura As Date = frm_OpcionFactura.dtpFechaFactura.Value.Date

                'Dim FechaAtencion As Int64 = 0
                Dim FechaAtencion As Int64 = Today.ToString("yyyyMMdd")
                'If frm_OpcionFactura.dtpFechaServicio.Enabled = True Then
                '    FechaAtencion = (CType(HelpClass.CFecha_a_Numero8Digitos(frm_OpcionFactura.dtpFechaServicio.Value), Int64))
                'End If
                Dim strZonaFacturacion As Int32 = 0
                If frm_OpcionFactura.cboZonaFacturacion.NoHayCodigo = False Then
                    strZonaFacturacion = frm_OpcionFactura.cboZonaFacturacion.Codigo

                End If
                Select Case tipoClienteDocumento
                    Case TipoCliente.Externo
                        Dim param As New Hashtable
                        param.Add("PSNOPRCN", lstr_Consistencia.Trim)
                        param.Add("PSCCMPN", Me.cboCompania.SelectedValue)
                        dt = obj_Logica.Listar_Facturas_X_Operaciones_Liberadas(param)
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

                        Dim ListadoPL As String = lstr_Consistencia
                        Dim ValorizacionOK As Boolean = True
                        Dim msgValPFPL As String = obj_Logica.ValidarValorizacion_PF_PL(Me.cboCompania.SelectedValue, "OP", ListadoPL)  ' "lstr_Consistencia"
                        If msgValPFPL.Length > 0 Then
                            MessageBox.Show(msgValPFPL, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            ValorizacionOK = False
                        End If

                        Dim frm_VistaFactura As frmVistaFacturaElectronico
                        'frm_VistaFactura = New frmVistaFacturaElectronico(lstr_Consistencia, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion, ValorizacionOK)
                        frm_VistaFactura = New frmVistaFacturaElectronico(lstr_Consistencia, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, ValorizacionOK)

                        Select Case frm_OpcionFactura.Tag
                            Case 0
                                frm_VistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Normal
                            Case 1
                                frm_VistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Resumido
                            Case 2
                                frm_VistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Detallado
                            Case 3
                                frm_VistaFactura.TipoVistaImpresion = clsComun.VistaImpresion.Lote
                        End Select
                        frm_VistaFactura.EsXPreLiquidacion = False
                        frm_VistaFactura.NumDocOrigen = dblDocumentoOrigen
                        frm_VistaFactura.FechaDocOrigen = dblFechaDocumentoOrigen
                        frm_VistaFactura.TipoDocOrigen = dblTipoDocumentoOrigen
                        If frm_VistaFactura.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        Me.Lista_Operacion_x_OS()
                    Case TipoCliente.Interno
                        Dim frm_VistaPT As frmVistaParteTransferencia

                        'frm_VistaPT = New frmVistaParteTransferencia(lstr_Consistencia, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion, Aprobador)
                        frm_VistaPT = New frmVistaParteTransferencia(lstr_Consistencia, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), frm_OpcionFactura.Planta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, Aprobador)

                        Select Case frm_OpcionFactura.Tag
                            Case 0
                                frm_VistaPT.TipoVistaImpresion = clsComun.VistaImpresion.Normal
                            Case 1
                                frm_VistaPT.TipoVistaImpresion = clsComun.VistaImpresion.Resumido
                            Case 2
                                frm_VistaPT.TipoVistaImpresion = clsComun.VistaImpresion.Detallado
                        End Select
                        frm_VistaPT.EsXPreLiquidacion = False
                        frm_VistaPT.NumDocOrigen = dblDocumentoOrigen
                        frm_VistaPT.FechaDocOrigen = dblFechaDocumentoOrigen
                        frm_VistaPT.TipoDocOrigen = dblTipoDocumentoOrigen

                        If frm_VistaPT.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                        Me.Lista_Operacion_x_OS()
                End Select
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnClienteFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClienteFacturar.Click

        Try
            Dim msgValidacionFactura As String = ""
            If Me.Consistencia_Operacion().Trim.Equals("") Then Exit Sub


            Dim clienteOP As Decimal = 0
            For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
                    clienteOP = Me.gwdDatos.Item("CCLNT_C", lint_Contador).Value
                    Exit For
                End If
            Next

            Dim frm_ClienteFacturar As New frmClienteFacturar
            With frm_ClienteFacturar
                .P_CCLNT = clienteOP
                .P_CCMPN = cboCompania.SelectedValue.ToString().Trim()
                .P_CCLNFC = Me.Consistencia_Cliente
                '.P_CPLNDV = mCPLNDV
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim obj_Logica As New Factura_Transporte_BLL
                Dim objetoParametro As New Hashtable
                objetoParametro.Add("PNNOPRCN", Me.Consistencia_Operacion().Trim)
                objetoParametro.Add("PNCCLNFC", .P_CCLNFC)
                'objetoParametro.Add("PNCPLNCL", .P_CPLNDV)
                objetoParametro.Add("PSCULUSA", MainModule.USUARIO)
                objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
                objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)
                objetoParametro.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
                objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
                'If obj_Logica.Actualizar_Cliente_Facturar(objetoParametro) = 0 Then
                '    HelpClass.ErrorMsgBox()
                '    Exit Sub
                'End If
                obj_Logica.Actualizar_Cliente_Facturar(objetoParametro)
                HelpClass.MsgBox("Actualización Satisfactoria", MessageBoxIcon.Information)
                'Me.Text = .P_CCLNT & .P_CPLNDV
                For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                    If Me.gwdDatos.Item("SELEC_C", lint_Contador).Value = True Then
                        Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value = .P_CCLNFC
                        Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value = .P_TCMPCF
                        'Me.gwdDatos.Item("CPLNCL_C", lint_Contador).Value = .P_CPLNDV
                        'Me.gwdDatos.Item("TPLNTA_C", lint_Contador).Value = .P_TPLNTA
                    End If
                Next

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
    '    Try
    '        If bolBuscar Then
    '            Cargar_Division()
    '            ' InicializarFormulario()
    '        End If
    '        'Catch ex As Exception
    '        'Finally
    '        '    Me.Cursor = Cursors.Default
    '        'End Try
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub InicializarFormulario()
    '    Me.gwdDatos.Rows.Clear()
    '    Me.dgwGuiaRemision.Rows.Clear()
    '    Me.txtOrdenServicio.Text = ""
    '    'Me.txtCliente.Text = ""
    '    Me.txtClienteFiltro.pClear()
    '    Me.txtClienteFiltro.CCMPN = Me.cboCompania.SelectedValue
    'End Sub

    'Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
    '    Try
    '        If bolBuscar Then
    '            'Me.Cargar_Planta()
    '            Me.cargarComboPlanta()
    '            'InicializarFormulario()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub

    'Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
    '    If bolBuscar = True Then
    '        InicializarFormulario()
    '    End If
    'End Sub

   

    Private Sub btnSustentoFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSustentoFactura.Click

        Try
            Dim frmOpReparto As New frmOptRepReparto
            With frmOpReparto
                .CCMPN = Me.cboCompania.SelectedValue
                .CDVSN = Me.cboDivision.SelectedValue
                .CPLNDV = 0 'Me.cboPlanta.SelectedValue
                .Compania = Me.cboCompania.Text
                .Division = Me.cboDivision.Text
                .Size = New Size(300, 120)
                '.Planta = Me.cboPlanta.Text
                .Planta = "TODOS"
                .Estado = 1
                .Titulo = "Sustento"
                .Tipo = "Sustento"
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub kchkOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOS.CheckedChanged
        Select Case Me.chkOS.Checked
            Case True
                Me.chkMM.Checked = False
                txtOrdenServicio.Enabled = True
                btnOrdenServicio.Enabled = True
                txtClienteFiltro.Enabled = False
            Case False
                txtOrdenServicio.Enabled = False
                btnOrdenServicio.Enabled = False
                txtClienteFiltro.Enabled = True
        End Select
    End Sub

    Private Sub chkMM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMM.CheckedChanged
        Select Case Me.chkMM.Checked
            Case True
                Me.chkOS.Checked = False
                txtOrdenServicio.Enabled = True
                btnOrdenServicio.Enabled = False
                txtClienteFiltro.Enabled = False
            Case False
                txtOrdenServicio.Enabled = False
                btnOrdenServicio.Enabled = False
                txtClienteFiltro.Enabled = True
        End Select
    End Sub

#End Region

#Region "Métodos"

    Private Sub Cargar_Compania()
        'Try
        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        Me.cboCompania.DataSource = objCompaniaBLL.Lista
        Me.cboCompania.ValueMember = "CCMPN"
        Me.cboCompania.DisplayMember = "TCMPCM"
        bolBuscar = True
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        'cboCompania_SelectedIndexChanged(Nothing, Nothing)
        cboCompania_SelectionChangeCommitted(Nothing, Nothing)

        'Catch ex As Exception
        '    HelpClass.MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Cargar_Division()
        'Try
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
            cboDivision_SelectionChangeCommitted(Nothing, Nothing)
        End If

        'Catch ex As Exception
        '    HelpClass.MsgBox(ex.Message)
        'End Try
    End Sub

    'Private Sub Cargar_Planta()
    '  Try
    '    If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
    '      bolBuscar = False
    '      objPlanta.Crea_Lista()
    '      Me.cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
    '      Me.cboPlanta.ValueMember = "CPLNDV"
    '      bolBuscar = True
    '      Me.cboPlanta.DisplayMember = "TPLNTA"
    '      Me.cboPlanta.SelectedIndex = 0
    '      cboPlanta_SelectedIndexChanged(Nothing, Nothing)
    '    End If
    '  Catch ex As Exception
    '    HelpClass.MsgBox(ex.Message)
    '  End Try
    'End Sub

    Private Sub Alinear_Columnas_Grilla()
        Me.gwdDatos.AutoGenerateColumns = False
        Me.dgwGuiaRemision.AutoGenerateColumns = False
        For lint_Contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_Contador As Integer = 0 To Me.dgwGuiaRemision.ColumnCount - 1
            Me.dgwGuiaRemision.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub Lista_Operacion_x_OS()

        Dim msgValidacion As String = ""
        Dim obj_Logica As New Factura_Transporte_BLL
        Dim objEntidad As New OperacionTransporte
        Dim CodigoCliente As Decimal = 0
        Dim objetoParametro As New Hashtable
        Dim dwvrow As DataGridViewRow
        Dim strCodPlanta As String = ""
        Dim PNNORSRT As Int64 = 0

        Dim PNNMOPMM As Int64 = 0
        Dim PNCCLNT As Int64 = 0

        If (Me.chkOS.Checked = True) Then

            If Not Me.txtOrdenServicio.Text.Trim.Equals("") Then
                PNNORSRT = txtOrdenServicio.Text.Trim
            Else
                HelpClass.MsgBox("Ingrese la Orden de Servicio ", MessageBoxIcon.Information)
                Exit Sub
            End If

        ElseIf (Me.chkMM.Checked = True) Then
            If Not Me.txtOrdenServicio.Text.Trim.Equals("") Then
                'PNNCTZCN = txtOrdenServicio.Text.Trim
                PNNMOPMM = txtOrdenServicio.Text.Trim
            Else
                HelpClass.MsgBox("Ingrese la Operación Multimodal ", MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            If txtClienteFiltro.pCodigo = 0 Then
                HelpClass.MsgBox("Ingrese el Cliente ", MessageBoxIcon.Information)
                Exit Sub
            Else
                PNCCLNT = txtClienteFiltro.pCodigo
            End If
        End If


        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        'For i As Integer = 0 To Me.cmbPlanta.CheckedItems.Count - 1
        ' strCodPlanta += Me.cmbPlanta.CheckedItems(i).Value & ","
        ' Next
        ' If strCodPlanta.Trim.Length > 0 Then
        ' strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        ' Else
        ' HelpClass.MsgBox("Seleccione algunas plantas.", MessageBoxIcon.Information)
        ' Exit Sub
        ' End If

        If cmbPlanta.Items.Count = 1 Then
            MessageBox.Show("* Sin plantas a seleccionar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        strCodPlanta = DevuelvePlantaSeleccionadas(cmbPlanta)
        If strCodPlanta.Trim.Length = 0 Then
            HelpClass.MsgBox("Seleccione algunas plantas.", MessageBoxIcon.Information)
            Exit Sub
        End If
        '

        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        objetoParametro.Add("PNNMOPMM", PNNMOPMM)
        objetoParametro.Add("PNNORSRT", PNNORSRT)
        objetoParametro.Add("PSSESTOP", "C")
        objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
        objetoParametro.Add("PSCPLNDV", strCodPlanta)
        objetoParametro.Add("PNCCLNT", PNCCLNT)

        objetoParametro.Add("PNNROVLR", Val(txtnrovaloriz.Text.Trim))
        objetoParametro.Add("PSDOCVLR", txtdocvaloriz.Text.Trim)

        Me.gwdDatos.Rows.Clear()
        Me.dgwGuiaRemision.Rows.Clear()
        Dim fila As Integer
        For Each objEntidad In obj_Logica.Listar_Operacion_x_Orden_Servicio(objetoParametro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.gwdDatos)
            Me.gwdDatos.Rows.Add(dwvrow)
            fila = gwdDatos.Rows.Count - 1

            gwdDatos.Rows(fila).Cells("SELEC_C").Value = False
            gwdDatos.Rows(fila).Cells("NOPRCN_C").Value = objEntidad.NOPRCN
            ''<AHM_VINTERNA>
            gwdDatos.Rows(fila).Cells("NORSRT_C").Value = objEntidad.NORSRT
            gwdDatos.Rows(fila).Cells("CCLNT_C").Value = objEntidad.CCLNT
            gwdDatos.Rows(fila).Cells("TCMPCL_C").Value = objEntidad.TCMPCL.Trim
            gwdDatos.Rows(fila).Cells("CCLNFC_C").Value = objEntidad.CCLNFC
            gwdDatos.Rows(fila).Cells("CPLNCL_C").Value = objEntidad.CPLNCL
            gwdDatos.Rows(fila).Cells("TCMPCF_C").Value = objEntidad.TCMPCF
            gwdDatos.Rows(fila).Cells("TPLNTA_C").Value = objEntidad.TPLNTA
            'gwdDatos.Rows(fila).Cells("CTPOSR_C").Value = objEntidad.CTPOSR
            'gwdDatos.Rows(fila).Cells("TCMTPS_C").Value = objEntidad.TCMTPS
            'gwdDatos.Rows(fila).Cells("TCMSBS_C").Value = objEntidad.TCMSBS
            'gwdDatos.Rows(fila).Cells("CMRCDR_C").Value = objEntidad.CMRCDR
            'gwdDatos.Rows(fila).Cells("TCMRCD_C").Value = objEntidad.TCMRCD.Trim
            'gwdDatos.Rows(fila).Cells("TCNTCS").Value = objEntidad.TCNTCS
            'gwdDatos.Rows(fila).Cells("CECO_OPE").Value = objEntidad.CECO_OPE
            gwdDatos.Rows(fila).Cells("TCRVTA_C").Value = objEntidad.TCRVTA
            REM ECM-HUNDRED-INICIO
            'gwdDatos.Rows(fila).Cells("CDSCSP").Value = objEntidad.CDSCSP
            'gwdDatos.Rows(fila).Cells("CDSCSP_TDSCSP").Value = objEntidad.CDSCSP_TDSCSP
            REM ECM-HUNDRED-FIN
            gwdDatos.Rows(fila).Cells("SESTOP_C").Value = objEntidad.SESTOP
            'gwdDatos.Rows(fila).Cells("TDRCNS_C").Value = objEntidad.TDRCNS
            'gwdDatos.Rows(fila).Cells("NRUCCN_C").Value = objEntidad.NRUCCN
            gwdDatos.Rows(fila).Cells("SORGMV_C").Value = IIf(objEntidad.SORGMV.Equals(""), "NO", "SI")
            gwdDatos.Rows(fila).Cells("CRGVTA_C").Value = objEntidad.CRGVTA
            gwdDatos.Rows(fila).Cells("CPLNDV_C").Value = objEntidad.CPLNDV
            ''</>

            'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            gwdDatos.Rows(fila).Cells("PLANTA").Value = objEntidad.PLANTA
            gwdDatos.Rows(fila).Cells("PLANTA_FACT").Value = objEntidad.PLANTA_FACT


            'gwdDatos.Rows(fila).Cells("CEBEO").Value = objEntidad.CEBEO
            'gwdDatos.Rows(fila).Cells("CECOD").Value = objEntidad.CECOD


            gwdDatos.Rows(fila).Cells("DOCVLR").Value = objEntidad.DOCVLR
            gwdDatos.Rows(fila).Cells("SEGVLR").Value = objEntidad.SEGVLR
            gwdDatos.Rows(fila).Cells("SEGVLR_DESC").Value = objEntidad.SEGVLR_DESC
            gwdDatos.Rows(fila).Cells("NROVLR").Value = objEntidad.NROVLR

            gwdDatos.Rows(fila).Cells("CEBE_C").Value = objEntidad.CEBE
            gwdDatos.Rows(fila).Cells("CECO_C").Value = objEntidad.CECO
            'gwdDatos.Rows(fila).Cells("OP_FACTURABLE").Value = objEntidad.OP_FACTURABLE

            'CSR-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

        Next
    End Sub

    Private Sub Lista_GR_x_Operacion(ByVal Indice As Integer)
        Dim obj_Logica As New Factura_Transporte_BLL
        Dim objEntidad As New Factura_Transporte
        Dim objetoParametro As New Hashtable
        Dim lintEstado As Int32 = 0
        Dim lintGuiaRemi As Int64 = 0
        Dim dwvrow As DataGridViewRow

        objetoParametro.Add("PNNOPRCN", Me.gwdDatos.Item("NOPRCN_C", Indice).Value)
        objetoParametro.Add("PSSESTOP", "C")
        objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
        objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
        objetoParametro.Add("PNCPLNDV", 0)
        'objetoParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))

        For Each objEntidad In obj_Logica.Listar_Guia_Remision_x_Operacion(objetoParametro)
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dgwGuiaRemision)
            dwvrow.Cells(0).Value = objEntidad.NOPRCN
            If (objEntidad.NGUITR = lintGuiaRemi) Then
                dwvrow.Cells(1).Value = ""
            Else
                dwvrow.Cells(1).Value = objEntidad.NGUITR
                lintGuiaRemi = objEntidad.NGUITR
            End If
            dwvrow.Cells(2).Value = objEntidad.FGUITR_S
            dwvrow.Cells(3).Value = objEntidad.NMNFCR
            dwvrow.Cells(4).Value = objEntidad.CTRSPT
            dwvrow.Cells(5).Value = objEntidad.TCMTRT
            dwvrow.Cells(6).Value = objEntidad.NPLVHT
            dwvrow.Cells(7).Value = objEntidad.CBRCNT
            dwvrow.Cells(8).Value = objEntidad.TDSTRT
            dwvrow.Cells(9).Value = objEntidad.QCNDTG
            dwvrow.Cells(10).Value = objEntidad.CMNDGU
            dwvrow.Cells(11).Value = objEntidad.TOTSER
            dwvrow.Cells(12).Value = objEntidad.PBRTOR
            dwvrow.Cells(13).Value = objEntidad.QBLORG
            dwvrow.Cells(14).Value = objEntidad.QKLMRC

            Me.dgwGuiaRemision.Rows.Add(dwvrow)
            lintEstado = 1
        Next
        Me.gwdDatos.EndEdit()
        If lintEstado = 0 Then
            Me.gwdDatos.Item("SELEC_C", Me.gwdDatos.CurrentCellAddress.Y).Value = False
            Me.gwdDatos.EndEdit()
        End If
    End Sub

    Private Sub Imprimir_Consistencia(ByVal lstr_Cadena As String)
        Dim obj_Logica As New Factura_Transporte_BLL
        Dim objPrintForm As New PrintForm
        Dim objDs As New DataSet
        Dim objDt As New DataTable
        Dim objetoRep As New rptConsistencia_Factura
        Dim objParametro As New Hashtable
        'Try
        objParametro.Add("PSNOPRCN", lstr_Cadena)
        objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue.ToString)
        objParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue.ToString)
        objParametro.Add("PNFECHA", HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaConsistencia.Value))
        objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Consistencia_Factura_x_Orden_Servicio(objParametro))
        objDt.TableName = "RZCT01"

        If objDt.Rows.Count = 0 Then
            HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
            Exit Sub
        End If
        objDs.Tables.Add(objDt.Copy)
        objetoRep.SetDataSource(objDs)

        CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
        CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cboCompania.Text
        CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cboDivision.Text
        CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = "TODOS"
        'CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cboPlanta.Text

        objPrintForm.ShowForm(objetoRep, Me)

        'Catch : End Try

    End Sub

    Private Function Consistencia_Operacion() As String
        Dim lstr_Cadena As String = ""
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Return lstr_Cadena
            Exit Function
        End If
        mConsistenciaPlanta = False
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1

            If Me.gwdDatos.Item(0, lint_Contador).Value Then
                lstr_Cadena = lstr_Cadena + Me.gwdDatos.Item("NOPRCN_C", lint_Contador).Value.ToString.Trim + ","
                If Me.gwdDatos.Item("TPLNTA_C", lint_Contador).Value.ToString.Trim.Equals("") Then mConsistenciaPlanta = True

            End If
        Next
        If lstr_Cadena.Length <> 0 Then
            lstr_Cadena = lstr_Cadena.Substring(0, lstr_Cadena.Length - 1)
        End If
        Return lstr_Cadena
    End Function
    'Private Function Validacion_Valorizacion() As String
    '    Dim msgValidacionFactura As String = ""
    '    If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
    '        Return msgValidacionFactura
    '        Exit Function
    '    End If

    '    Dim strFacturable As String = ""
    '    Dim TodosFacturable As Boolean = True
    '    For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1

    '        If Me.gwdDatos.Item(0, lint_Contador).Value Then
    '            If lint_Contador = 0 Then
    '                strFacturable = gwdDatos.Item("OP_FACTURABLE", lint_Contador).Value.ToString.Trim
    '                If strFacturable = "NO" Then
    '                    msgValidacionFactura = "Valorización aún no aprobadas."
    '                    Exit For
    '                End If
    '            Else
    '                If strFacturable <> gwdDatos.Item("OP_FACTURABLE", lint_Contador).Value.ToString.Trim Then
    '                    TodosFacturable = False
    '                    msgValidacionFactura = "No se puede unir operaciones valorizadas y no valorizadas."
    '                    Exit For
    '                End If
    '            End If
    '        End If
    '    Next
    '    Return msgValidacionFactura
    'End Function

    Private Function Consistencia_Organizacion_Venta(ByRef pOrgVenta As String) As Boolean
        Dim lstr_Estado As Boolean = True
        Dim intIndice As Int32 = 0
        Dim OrgVentaop As String = ""
        'cOrgVenta = ""
        Me.gwdDatos.EndEdit()
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos.Item("SELEC_C", lint_Contador).Value = True Then
                If intIndice = 0 Then
                    'cOrgVenta = Me.gwdDatos.Item("CRGVTA_C", lint_Contador).Value
                    OrgVentaop = Me.gwdDatos.Item("CRGVTA_C", lint_Contador).Value
                    'dOrgVenta = Me.gwdDatos.Item("TCRVTA_C", lint_Contador).Value
                    lstr_Estado = True
                    intIndice += 1
                Else
                    If Me.gwdDatos.Item("CRGVTA_C", lint_Contador).Value <> OrgVentaop Then
                        lstr_Estado = False
                    End If
                End If
            End If
        Next
        Return lstr_Estado
    End Function

    Private Function Consistencia_Cliente() As Int64
        Dim lstr_CCLNT As Int64 = 0
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos.Item(0, lint_Contador).Value Then
                lstr_CCLNT = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value
                mCPLNDV = Me.gwdDatos.Item("CPLNCL_C", lint_Contador).Value
                Exit For
            End If
        Next
        Return lstr_CCLNT
    End Function

    Private Function Validar_Cliente(ByVal lint_Indice As Integer) As Integer
        Dim lint_Resultado As Integer = 0
        Dim strFacturable As String = ""
        Me.gwdDatos.EndEdit()
        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
            If Me.gwdDatos.Item("SELEC_C", lint_Contador).Value = True Then
                If Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value <> Me.gwdDatos.Item("CCLNFC_C", lint_Indice).Value OrElse _
                   Me.gwdDatos.Item("SORGMV_C", lint_Contador).Value <> Me.gwdDatos.Item("SORGMV_C", lint_Indice).Value Then
                    lint_Resultado = 2
                    Return lint_Resultado
                End If
            End If
        Next
        Return lint_Resultado
    End Function

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSOP1 = "" Then
            Me.btnClienteFacturar.Visible = False
        End If
        If objEntidad.STSOP2 = "" Then
            Me.btnConsistencia.Visible = False
        End If
        If objEntidad.STSOP3 = "" Then
            Me.btnFactura.Visible = False
            'Me.Separator2.Visible = False
        End If
    End Sub

    Private Sub Eliminar_Guias_X_Operacion(ByVal lintOperacion As Int64)
        If Me.dgwGuiaRemision.RowCount = 0 Then Exit Sub
        Dim lint_contador As Int32 = 0
        While lint_contador <= Me.dgwGuiaRemision.RowCount - 1
            If Me.dgwGuiaRemision.Item("NOPRCN_D", lint_contador).Value = lintOperacion Then
                Me.dgwGuiaRemision.Rows.RemoveAt(lint_contador)
                lint_contador -= 1
            End If
            lint_contador += 1
        End While
    End Sub

    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        'Try
        Me.cmbPlanta.Text = ""
        If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
            bolBuscar = False
            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)

            Dim OPlanta As New ClaseGeneral
            OPlanta.CPLNDV = 0
            OPlanta.TPLNTA = "TODOS"
            objLisEntidad2.Insert(0, OPlanta)

            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next
            cmbPlanta.DisplayMember = "TPLNTA"
            cmbPlanta.ValueMember = "CPLNDV"
            Me.cmbPlanta.DataSource = objLisEntidad
            For i As Integer = 0 To cmbPlanta.Items.Count - 1
                If cmbPlanta.Items.Item(i).Value = "0" Then
                    Me.cmbPlanta.SetItemChecked(i, True)
                End If
            Next
            If Me.cmbPlanta.Text = "" Then
                Me.cmbPlanta.SetItemChecked(0, True)
            End If

            'If objLisEntidad.Count > 0 Then
            '  _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
            'Else
            '  _lstrTipoCuenta = ""
            'End If
            bolBuscar = True
        End If
        'Catch ex As Exception
        'End Try
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
    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
    Private Function DevuelvePlantaSeleccionadas(MiCombo As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox) As String
        Dim strCodPlanta As String
        strCodPlanta = ""
        For i As Integer = 0 To MiCombo.CheckedItems.Count - 1
            strCodPlanta += MiCombo.CheckedItems(i).Value & ","
        Next
        Dim v As Integer
        v = InStr(1, strCodPlanta, "0,")
        If v = 1 Then
            strCodPlanta = "0,"

        End If
        If strCodPlanta = "0," Then
            strCodPlanta = ""
            For i As Integer = 1 To MiCombo.Items.Count - 1
                strCodPlanta += MiCombo.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        Return strCodPlanta

    End Function
    'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS


#End Region

    Private Sub btnPreFactura_Click(sender As Object, e As EventArgs) Handles btnPreFactura.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim obj_Logica As New Factura_Transporte_BLL
            Dim NroPreFactura As Decimal = 0
            Dim objetoParametroPreF As New Hashtable
            Dim pNoprcn As Decimal = gwdDatos.CurrentRow.Cells("NOPRCN_C").Value
            Dim pCodPlanta As Decimal = gwdDatos.CurrentRow.Cells("CPLNCL_C").Value

            objetoParametroPreF.Add("PNNOPRCN", pnoprcn)
            objetoParametroPreF.Add("PSCCMPN", Me.cboCompania.SelectedValue)
            objetoParametroPreF.Add("PSCDVSN", Me.cboDivision.SelectedValue)
            objetoParametroPreF.Add("PNCPLNDV", pCodPlanta)
            objetoParametroPreF.Add("PNFULTAC", HelpClass.TodayNumeric)
            objetoParametroPreF.Add("PNHULTAC", HelpClass.NowNumeric)
            objetoParametroPreF.Add("PSCULUSA", MainModule.USUARIO)
            objetoParametroPreF.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            NroPreFactura = obj_Logica.Pre_Facturar_Operacion(objetoParametroPreF)
            MessageBox.Show("Se generó la Pre-Factura " & NroPreFactura.ToString.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Lista_Operacion_x_OS()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboCompania_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCompania.SelectionChangeCommitted
        Try
            Cargar_Division()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDivision.SelectionChangeCommitted
        Try
            Me.cargarComboPlanta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

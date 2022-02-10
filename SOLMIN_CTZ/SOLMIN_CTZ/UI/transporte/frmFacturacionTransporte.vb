
'Imports SOLMIN_CTZ.NEGOCIO.Operaciones
'Imports SOLMIN_CTZ.ENTIDADES.Operaciones
'Imports CrystalDecisions.CrystalReports.Engine
'Imports SOLMIN_CTZ.ENTIDADES.Mantenimientos
'Imports Ransa.Utilitario
'Imports SOLMIN_CTZ.NEGOCIO
'Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports System.Configuration


'Public Class frmFacturacionTransporte

'#Region "Atributos"
'    Private gEnum_Mantenimiento As MANTENIMIENTO
'    Private bolBuscar As Boolean
'    Private objCompaniaBLL As New SOLMIN_CTZ.NEGOCIO.Compania_BLL
'    Private objPlanta As New SOLMIN_CTZ.NEGOCIO.Planta_BLL
'    Private objDivision As New SOLMIN_CTZ.NEGOCIO.Division_BLL
'    Private mCCLNT As String = ""
'    Private mCPLNDV As Int32 = 0
'    Private mConsistenciaPlanta As Boolean = False
'    Private cOrgVenta As String = ""
'    Private dOrgVenta As String = ""
'#End Region

'#Region "Eventos"
'    Private Sub frmFacturacionTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Try

'            Dim dtFechaActual As Date
'            Me.Cargar_Compania()
'            Me.Alinear_Columnas_Grilla()
'            Me.Validar_Acceso_Opciones_Usuario()
'            Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.Operaciones.Factura_Transporte_BLL
'            dtFechaActual = oFacturaNeg.Obtener_Fecha_Servidor()
'            Me.dtpFechaConsistencia.Value = dtFechaActual
'            Select Case dtFechaActual.Day
'                Case 1, 2
'                    Me.lblFechaConsistencia.Visible = True
'                    Me.dtpFechaConsistencia.Visible = True
'                    Me.Separator4.Visible = True
'            End Select
'            'Dim ckBox = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
'            'Dim rect As Rectangle = Me.gwdDatos.GetCellDisplayRectangle(0, -1, True)
'            'rect.Y = 3
'            'rect.X = rect.Location.X + (rect.Width / 4)
'            'ckBox.Name = "ckColum"
'            'ckBox.Text = ""
'            'ckBox.Location = rect.Location
'            'Me.gwdDatos.Controls.Add(ckBox)
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'    End Sub

'    Private Sub btnOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenServicio.Click
'        Try
'            Dim objFormConsultaOrdenServicio As New frmConsultaOrdenServicio
'            With objFormConsultaOrdenServicio
'                .CCMPN = Me.cboCompania.SelectedValue
'                .CDVSN = Me.cboDivision.SelectedValue
'                '.CPLNDV = Me.cboPlanta.SelectedValue
'                .CPLNDV = 0
'                .TipoFiltro = IIf(Me.chkOS.Checked = True, 0, 1)
'                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
'                Me.txtCliente.Text = .P_CCLNT
'                Me.txtOrdenServicio.Text = IIf(Me.chkOS.Checked = True, .P_NORSRT, .P_NCTZCN)
'            End With
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'    End Sub

'    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
'        Me.Close()
'    End Sub


'    Private EstadoSelec As Boolean = False

'    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
'        If Me.gwdDatos.RowCount = 0 Then Exit Sub
'        Select Case e.ColumnIndex
'            Case 0
'                If e.RowIndex = -1 Then
'                    For intCount As Integer = 0 To Me.gwdDatos.RowCount - 1
'                        If Me.Validar_Cliente(intCount) = 2 Then
'                            Me.gwdDatos.Item("SELEC_C", intCount).Value = False
'                        Else
'                            If Not EstadoSelec Then
'                                If Me.gwdDatos.Item("SELEC_C", intCount).Value = False Then
'                                    Me.Lista_GR_x_Operacion(intCount)
'                                    Me.gwdDatos.Item("SELEC_C", intCount).Value = True
'                                End If
'                            Else
'                                Me.Eliminar_Guias_X_Operacion(Me.gwdDatos.Item("NOPRCN_C", intCount).Value)
'                                Me.gwdDatos.Item("SELEC_C", intCount).Value = False
'                            End If
'                        End If
'                    Next
'                    EstadoSelec = Not EstadoSelec
'                End If
'        End Select
'    End Sub

'    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick, gwdDatos.CellContentDoubleClick
'        Try
'            If Me.gwdDatos.RowCount = 0 Then Exit Sub
'            Select Case e.ColumnIndex
'                Case 0
'                    If Me.Validar_Cliente(e.RowIndex) = 2 Then
'                        Me.gwdDatos.Item("SELEC_C", e.RowIndex).Value = False
'                        Exit Sub
'                    End If
'                    Me.gwdDatos.EndEdit()
'                    If Me.gwdDatos.Item("SELEC_C", e.RowIndex).Value = True Then
'                        Me.Lista_GR_x_Operacion(e.RowIndex)
'                    Else
'                        Me.Eliminar_Guias_X_Operacion(Me.gwdDatos.Item("NOPRCN_C", e.RowIndex).Value)
'                    End If

'            End Select
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'    End Sub

'    Private Sub txtOrdenServicio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrdenServicio.KeyPress
'        Try
'            If e.KeyChar = "." Then
'                e.Handled = True
'                Exit Sub
'            End If
'            If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'    End Sub

'    Private Sub txtOrdenServicio_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrdenServicio.KeyUp
'        Try
'            If e.KeyCode = Keys.Enter Then
'                Dim obj_Logica As New Factura_Transporte_BLL
'                Dim objetoParametro As New Hashtable
'                objetoParametro.Add("PNNORSRT", Me.txtOrdenServicio.Text.Trim)
'                Me.txtCliente.Text = obj_Logica.Obtener_Cliente_x_Orden_Servicio(objetoParametro)
'                Me.btnBuscar_Click(Nothing, Nothing)
'            End If
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'    End Sub


'    Private Sub dgwGuiaRemision_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGuiaRemision.CellContentClick
'        Try
'            If Me.gwdDatos.RowCount < 0 OrElse e.RowIndex < 0 Then Exit Sub
'            Select Case e.ColumnIndex
'                Case 1
'                    Dim fMostrarInfAdic As frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem = New frmLiquidacionFlete_DlgMostrarInfAdicGuiaRem( _
'                             Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue, _
'                             dgwGuiaRemision.CurrentRow.Cells("NOPRCN_D").Value, _
'                             dgwGuiaRemision.CurrentRow.Cells("NGUITR_D").Value, "L", 0)
'                    With fMostrarInfAdic
'                        .ToolStrip1.Visible = False
'                        .tcListadoGuiasCargadas.Controls.Remove(.tpGuiasRemisionHijas)
'                        .ShowDialog()
'                    End With

'            End Select
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'    End Sub

'    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click
'        Try

'            Dim lstr_Cadena As String = Me.Consistencia_Operacion
'            If lstr_Cadena.Length = 0 Then  ' ================ SOLO PARA CONSISTENCIAS CUANDO YA FUE FACTURADO ========================
'                Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()
'                Dim frmOpReparto As New frmOptRepReparto
'                With frmOpReparto
'                    .CCMPN = Me.cboCompania.SelectedValue
'                    .CDVSN = Me.cboDivision.SelectedValue
'                    .CPLNDV = PlantaSeleccionada
'                    '.CPLNDV = Me.cboPlanta.SelectedValue
'                    .Titulo = "Re - Impresión de Consistencia"
'                    .Tipo = "Consistencia"
'                    .Estado = 1
'                    .Fecha = Me.dtpFechaConsistencia.Value
'                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
'                End With
'                Exit Sub
'            End If
'            If mConsistenciaPlanta Then
'                HelpClass.MsgBox("Planta no existe", MessageBoxIcon.Information)
'                Exit Sub
'            End If
'            Me.Imprimir_Consistencia(lstr_Cadena)
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try


'    End Sub

'    Private Function ObtenerPlantaSeleccionada() As Decimal
'        Dim Planta As Decimal = -1
'        For i As Integer = 0 To Me.cmbPlanta.CheckedItems.Count - 1
'            Planta = Me.cmbPlanta.CheckedItems(i).Value
'            Exit For
'        Next
'        Return Planta
'    End Function

'    Private Sub btnFacturacionLibre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturacionLibre.Click
'        Try
'            Dim obj_Logica As New Factura_Transporte_BLL
'            Dim objetoParametro As New Hashtable
'            Dim lstr_Consistencia As String = Me.Consistencia_Operacion
'            If Me.Consistencia_Cliente = 0 Then Exit Sub
'            If Consistencia_Organizacion_Venta() = False Then
'                HelpClass.MsgBox("La Organización de Venta de las Operaciones seleccionadas no son iguales", MessageBoxIcon.Information)
'                Exit Sub
'            End If
'            Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()

'            objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
'            objetoParametro.Add("PSNOPRCN", lstr_Consistencia.Trim)

'            Dim SumaSoles As Double = 0
'            Dim SumaDolares As Double = 0
'            Dim oDtImportes As DataTable
'            Dim Tipo_Cambio As Double = ObtenerTipoCambio()
'            If Tipo_Cambio > 0 Then
'                oDtImportes = obj_Logica.Listar_Importes_Servicio_Operaciones(objetoParametro)
'                If oDtImportes IsNot Nothing And oDtImportes.Rows.Count > 0 Then
'                    For Each objDataRow As DataRow In oDtImportes.Rows
'                        If objDataRow("CMNDGU") = 1 Then
'                            SumaSoles += objDataRow("ISRVGU")
'                            Dim ImporteDolares As Double = objDataRow("ISRVGU") / Tipo_Cambio
'                            SumaDolares += ImporteDolares
'                        ElseIf objDataRow("CMNDGU") = 100 Then
'                            Dim ImporteSoles As Double = objDataRow("ISRVGU") * Tipo_Cambio
'                            SumaSoles += ImporteSoles
'                            SumaDolares += objDataRow("ISRVGU")
'                        End If
'                    Next
'                End If
'            Else
'                HelpClass.MsgBox("No existe Tipo de Cambio para Hoy", MessageBoxIcon.Information)
'                Exit Sub
'            End If

'            Dim frm_OpcionFacturacionLibre As New frmOpcionFacturacionLibre
'            With frm_OpcionFacturacionLibre
'                .Compania = Me.cboCompania.SelectedValue
'                .Division = Me.cboDivision.SelectedValue
'                For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
'                    If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
'                        .txtCliente.Text = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value
'                        .txtNIT.Text = Me.gwdDatos.Item("NRUCCN_C", lint_Contador).Value
'                        .txtDireccion.Text = Me.gwdDatos.Item("TDRCNS_C", lint_Contador).Value
'                        .txtOperacion.Text = lstr_Consistencia.Trim
'                        SumaSoles = Math.Round(SumaSoles, 2)
'                        SumaDolares = Math.Round(SumaDolares, 2)
'                        Dim ImporteSoles As String = IIf(SumaSoles = 0, "", String.Format("{0:N2}", SumaSoles)) 'Convert.ToString(SumaSoles)
'                        Dim ImporteDolares As String = IIf(SumaDolares = 0, "", String.Format("{0:N2}", SumaDolares)) 'Convert.ToString(SumaDolares)
'                        .ImporteSoles = ImporteSoles
'                        .ImporteDolares = ImporteDolares
'                        .txtOrganizacionVenta.Text = dOrgVenta
'                        Exit For
'                    End If
'                Next
'                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
'                Me.Lista_Operacion_x_OS()
'            End With

'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Sub btnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactura.Click
'        Try

'            Dim obj_Logica As New Factura_Transporte_BLL
'            Dim objetoParametro As New Hashtable
'            Dim lint_Numerador As Int64 = 0
'            Dim lstr_Consistencia As String = Me.Consistencia_Operacion
'            Dim dt As DataTable
'            Dim dblDocumentoOrigen As Double = 0
'            Dim dblFechaDocumentoOrigen As Double = 0
'            Dim dblTipoDocumentoOrigen As Double = 0
'            If Me.Consistencia_Cliente = 0 Then Exit Sub
'            If mConsistenciaPlanta Then
'                HelpClass.MsgBox("Planta no existe", MessageBoxIcon.Information)
'                Exit Sub
'            End If
'            If Consistencia_Organizacion_Venta() = False Then
'                HelpClass.MsgBox("La Organización de Venta de las Operaciones seleccionadas no son iguales", MessageBoxIcon.Information)
'                Exit Sub
'            End If
'            Dim PlantaSeleccionada As Decimal = ObtenerPlantaSeleccionada()
'            objetoParametro.Add("PNCCLNT", Me.Consistencia_Cliente)
'            objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
'            objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
'            objetoParametro.Add("PNCPLNDV", PlantaSeleccionada)
'            'objetoParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
'            objetoParametro.Add("PON_NRODOCU", 0)
'            lint_Numerador = obj_Logica.Verificar_Cliente_Especial(objetoParametro)
'            If lint_Numerador = 0 Then
'                HelpClass.ErrorMsgBox()
'                Exit Sub
'            Else 'If lint_Numerador = -1 Then
'                Dim frm_OpcionFactura As New frmOpcionFactura
'                With frm_OpcionFactura
'                    .Compania = Me.cboCompania.SelectedValue
'                    .Division = Me.cboDivision.SelectedValue
'                    For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
'                        If Me.gwdDatos("SELEC_C", lint_Contador).Value = True Then
'                            .txtCliente.Text = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value
'                            .txtNIT.Text = Me.gwdDatos.Item("NRUCCN_C", lint_Contador).Value
'                            .txtDireccion.Text = Me.gwdDatos.Item("TDRCNS_C", lint_Contador).Value
'                            .txtOperacion.Text = lstr_Consistencia.Trim
'                            .txtPreFactura.Text = IIf(lint_Numerador.ToString.Equals("-1"), "", lint_Numerador)
'                            .txtOrganizacionVenta.Text = dOrgVenta
'                            Exit For
'                        End If
'                    Next
'                    .txtPreFactura.Tag = IIf(lint_Numerador.ToString.Equals("-1"), "", lint_Numerador)
'                    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
'                    If .rbtnPreFactura.Checked Then
'                        objetoParametro.Add("PNNOPRCN", lstr_Consistencia.Trim)
'                        objetoParametro.Add("PSCULUSA", ConfigurationWizard.UserName)
'                        objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
'                        objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)
'                        objetoParametro.Add("PSNTRMNL", HelpClass.NombreMaquina)
'                        obj_Logica.Pre_Facturar_Operacion(objetoParametro)
'                        Me.Lista_Operacion_x_OS()
'                    Else
'                        Dim FechaFactura As Date = .dtpFechaFactura.Value.Date
'                        Dim FechaAtencion As Int64 = 0
'                        If .dtpFechaServicio.Enabled = True Then
'                            FechaAtencion = (CType(Ransa.Utilitario.HelpClass.CFecha_a_Numero8Digitos(.dtpFechaServicio.Value), Int64))
'                        End If
'                        Dim strZonaFacturacion As Int32 = 0
'                        If .cboZonaFacturacion.NoHayCodigo = False Then
'                            strZonaFacturacion = .cboZonaFacturacion.Codigo

'                        End If
'                        Dim param As New Hashtable
'                        param.Add("PSNOPRCN", lstr_Consistencia.Trim)
'                        param.Add("PSCCMPN", Me.cboCompania.SelectedValue)
'                        dt = obj_Logica.Listar_Facturas_X_Operaciones_Liberadas(param)
'                        If dt.Rows.Count > 0 Then
'                            If dt.Rows.Count = 1 Then
'                                dblDocumentoOrigen = dt.Rows(0).Item("NDCMOR")
'                                dblFechaDocumentoOrigen = dt.Rows(0).Item("FDCMOR")
'                                dblTipoDocumentoOrigen = dt.Rows(0).Item("CTPDCO")
'                            Else
'                                Dim ofrm As New frmFacturasXOperacionesLiberadas
'                                ofrm.setDataSource(dt)
'                                ofrm.ShowDialog()
'                                dblDocumentoOrigen = ofrm.DocumentoOrigen
'                                dblFechaDocumentoOrigen = ofrm.FechaDocumentoOrigen
'                                dblTipoDocumentoOrigen = ofrm.TipoDocumentoOrigen
'                            End If

'                        End If


'                        Dim frm_VistaFactura As frmVistaFactura_ST
'                        frm_VistaFactura = New frmVistaFactura_ST(lstr_Consistencia, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), PlantaSeleccionada, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion)
'                        'frm_VistaFactura = New frmVistaFactura(lstr_Consistencia, Me.cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, CType(Me.Consistencia_Cliente, Int64), Me.cboPlanta.SelectedValue, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion)
'                        With frm_VistaFactura
'                            .Tag = frm_OpcionFactura.Tag
'                            .DocumentoOrigen = dblDocumentoOrigen
'                            .FechaDocumentoOrigen = dblFechaDocumentoOrigen
'                            .TipoDocumentoOrigen = dblTipoDocumentoOrigen
'                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
'                            Me.Lista_Operacion_x_OS()
'                        End With
'                    End If

'                End With
'            End If
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'    End Sub

'    Private Sub btnClienteFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClienteFacturar.Click

'        Try
'            If Me.Consistencia_Operacion.Trim.Equals("") Then Exit Sub
'            Dim frm_ClienteFacturar As New frmClienteFacturar
'            With frm_ClienteFacturar
'                .P_CCMPN = cboCompania.SelectedValue.ToString().Trim()
'                .P_CCLNFC = Me.Consistencia_Cliente
'                .P_CPLNDV = mCPLNDV
'                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
'                Dim obj_Logica As New Factura_Transporte_BLL
'                Dim objetoParametro As New Hashtable
'                objetoParametro.Add("PNNOPRCN", Me.Consistencia_Operacion.Trim)
'                objetoParametro.Add("PNCCLNFC", .P_CCLNFC)
'                objetoParametro.Add("PNCPLNCL", .P_CPLNDV)
'                objetoParametro.Add("PSCULUSA", ConfigurationWizard.UserName)
'                objetoParametro.Add("PNFULTAC", HelpClass.TodayNumeric)
'                objetoParametro.Add("PNHULTAC", HelpClass.NowNumeric)
'                objetoParametro.Add("PSNTRMNL", HelpClass.NombreMaquina)
'                objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
'                If obj_Logica.Actualizar_Cliente_Facturar(objetoParametro) = 0 Then
'                    HelpClass.ErrorMsgBox()
'                    Exit Sub
'                End If
'                HelpClass.MsgBox("Actualización Satisfactoria", MessageBoxIcon.Information)
'                'Me.Text = .P_CCLNT & .P_CPLNDV
'                For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
'                    If Me.gwdDatos.Item("SELEC_C", lint_Contador).Value = True Then
'                        Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value = .P_CCLNFC
'                        Me.gwdDatos.Item("TCMPCF_C", lint_Contador).Value = .P_TCMPCF
'                        Me.gwdDatos.Item("CPLNCL_C", lint_Contador).Value = .P_CPLNDV
'                        Me.gwdDatos.Item("TPLNTA_C", lint_Contador).Value = .P_TPLNTA
'                    End If
'                Next

'            End With
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'    End Sub

'    Private Sub cboCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompania.SelectedIndexChanged
'        Try
'            If bolBuscar Then
'                Cargar_Division()
'                ' InicializarFormulario()
'            End If
'        Catch ex As Exception
'        Finally
'            Me.Cursor = Cursors.Default
'        End Try
'    End Sub

'    Private Sub InicializarFormulario()
'        Me.gwdDatos.Rows.Clear()
'        Me.dgwGuiaRemision.Rows.Clear()
'        Me.txtOrdenServicio.Text = ""
'        Me.txtCliente.Text = ""
'        Me.txtClienteFiltro.pClear()
'        Me.txtClienteFiltro.CCMPN = Me.cboCompania.SelectedValue
'    End Sub

'    Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
'        Try
'            If bolBuscar Then
'                'Me.Cargar_Planta()
'                Me.cargarComboPlanta()
'                InicializarFormulario()
'            End If
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            Me.Cursor = Cursors.Default
'        End Try

'    End Sub

'    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
'        If bolBuscar = True Then
'            InicializarFormulario()
'        End If
'    End Sub

'    'Private Sub cboPlanta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlanta.SelectedIndexChanged
'    '  Try
'    '    If (bolBuscar = True) Then
'    '      InicializarFormulario()
'    '    End If
'    '  Catch : End Try

'    'End Sub

'    Private Sub btnSustentoFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSustentoFactura.Click

'        Try
'            Dim frmOpReparto As New frmOptRepReparto
'            With frmOpReparto
'                .CCMPN = Me.cboCompania.SelectedValue
'                .CDVSN = Me.cboDivision.SelectedValue
'                .CPLNDV = 0 'Me.cboPlanta.SelectedValue
'                .Compania = Me.cboCompania.Text
'                .Division = Me.cboDivision.Text
'                .Size = New Size(300, 120)
'                '.Planta = Me.cboPlanta.Text
'                .Planta = "TODOS"
'                .Estado = 1
'                .Titulo = "Sustento"
'                .Tipo = "Sustento"
'                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
'            End With
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'    End Sub

'    Private Sub kchkOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOS.CheckedChanged
'        Select Case Me.chkOS.Checked
'            Case True
'                Me.chkMM.Checked = False
'                txtOrdenServicio.Enabled = True
'                btnOrdenServicio.Enabled = True
'                txtClienteFiltro.Enabled = False
'            Case False
'                txtOrdenServicio.Enabled = False
'                btnOrdenServicio.Enabled = False
'                txtClienteFiltro.Enabled = True
'        End Select
'    End Sub

'    Private Sub chkMM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMM.CheckedChanged
'        Select Case Me.chkMM.Checked
'            Case True
'                Me.chkOS.Checked = False
'                txtOrdenServicio.Enabled = True
'                btnOrdenServicio.Enabled = False
'                txtClienteFiltro.Enabled = False
'            Case False
'                txtOrdenServicio.Enabled = False
'                btnOrdenServicio.Enabled = False
'                txtClienteFiltro.Enabled = True
'        End Select
'    End Sub

'#End Region

'#Region "Métodos"

'    Private Sub Cargar_Compania()
'        Try
'            objCompaniaBLL.Crea_Lista()
'            bolBuscar = False
'            Me.cboCompania.DataSource = objCompaniaBLL.Lista
'            Me.cboCompania.ValueMember = "CCMPN"
'            Me.cboCompania.DisplayMember = "TCMPCM"

'            bolBuscar = True
'            'cboCompania.SelectedIndex = 0
'            'Me.cboCompania.SelectedValue = "EZ"
'            'If cboCompania.SelectedIndex = -1 Then
'            '    cboCompania.SelectedIndex = 0
'            'End If

'            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
'            cboCompania_SelectedIndexChanged(Nothing, Nothing)


'        Catch ex As Exception
'            HelpClass.MsgBox(ex.Message)
'        End Try
'    End Sub

'    Private Sub Cargar_Division()
'        Try
'            If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing) Then
'                bolBuscar = False
'                objDivision.Crea_Lista()
'                Me.cboDivision.DataSource = objDivision.Lista_Division(Me.cboCompania.SelectedValue.ToString.Trim)
'                Me.cboDivision.ValueMember = "CDVSN"
'                bolBuscar = True
'                Me.cboDivision.DisplayMember = "TCMPDV"
'                Me.cboDivision.SelectedValue = "T"
'                If Me.cboDivision.SelectedIndex = -1 Then
'                    Me.cboDivision.SelectedIndex = 0
'                End If
'                cboDivision_SelectedIndexChanged(Nothing, Nothing)
'            End If

'        Catch ex As Exception
'            HelpClass.MsgBox(ex.Message)
'        End Try
'    End Sub

'    'Private Sub Cargar_Planta()
'    '  Try
'    '    If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
'    '      bolBuscar = False
'    '      objPlanta.Crea_Lista()
'    '      Me.cboPlanta.DataSource = objPlanta.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
'    '      Me.cboPlanta.ValueMember = "CPLNDV"
'    '      bolBuscar = True
'    '      Me.cboPlanta.DisplayMember = "TPLNTA"
'    '      Me.cboPlanta.SelectedIndex = 0
'    '      cboPlanta_SelectedIndexChanged(Nothing, Nothing)
'    '    End If
'    '  Catch ex As Exception
'    '    HelpClass.MsgBox(ex.Message)
'    '  End Try
'    'End Sub

'    Private Sub Alinear_Columnas_Grilla()
'        Me.gwdDatos.AutoGenerateColumns = False
'        Me.dgwGuiaRemision.AutoGenerateColumns = False
'        For lint_Contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
'            Me.gwdDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'        Next
'        For lint_Contador As Integer = 0 To Me.dgwGuiaRemision.ColumnCount - 1
'            Me.dgwGuiaRemision.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
'        Next
'    End Sub

'    Private Sub Lista_Operacion_x_OS()

'        Dim msgValidacion As String = ""
'        Dim obj_Logica As New Factura_Transporte_BLL
'        Dim objEntidad As New OperacionTransporte
'        Dim CodigoCliente As Decimal = 0
'        Dim objetoParametro As New Hashtable
'        Dim dwvrow As DataGridViewRow
'        Dim strCodPlanta As String = ""
'        Dim PNNORSRT As Int64 = 0
'        'Dim PNNCTZCN As Int64 = 0
'        Dim PNNMOPMM As Int64 = 0
'        Dim PNCCLNT As Int64 = 0

'        If (Me.chkOS.Checked = True) Then

'            If Not Me.txtOrdenServicio.Text.Trim.Equals("") Then
'                PNNORSRT = txtOrdenServicio.Text.Trim
'            Else
'                HelpClass.MsgBox("Ingrese la Orden de Servicio ", MessageBoxIcon.Information)
'                Exit Sub
'            End If

'        ElseIf (Me.chkMM.Checked = True) Then
'            If Not Me.txtOrdenServicio.Text.Trim.Equals("") Then
'                'PNNCTZCN = txtOrdenServicio.Text.Trim
'                PNNMOPMM = txtOrdenServicio.Text.Trim
'            Else
'                HelpClass.MsgBox("Ingrese la Operación Multimodal ", MessageBoxIcon.Information)
'                Exit Sub
'            End If
'        Else
'            If txtClienteFiltro.pCodigo = 0 Then
'                HelpClass.MsgBox("Ingrese el Cliente ", MessageBoxIcon.Information)
'                Exit Sub
'            Else
'                PNCCLNT = txtClienteFiltro.pCodigo
'            End If
'        End If
'        For i As Integer = 0 To Me.cmbPlanta.CheckedItems.Count - 1
'            strCodPlanta += Me.cmbPlanta.CheckedItems(i).Value & ","
'        Next
'        If strCodPlanta.Trim.Length > 0 Then
'            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
'        Else
'            HelpClass.MsgBox("Seleccione algunas plantas.", MessageBoxIcon.Information)
'            Exit Sub
'        End If


'        'objetoParametro.Add("PNNORSRT", Me.txtOrdenServicio.Text.Trim)
'        'objetoParametro.Add("PSSESTOP", "C")
'        'objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
'        'objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
'        'objetoParametro.Add("PSCPLNDV", strCodPlanta)

'        'objetoParametro.Add("PNNCTZCN", PNNCTZCN)
'        objetoParametro.Add("PNNMOPMM", PNNMOPMM)
'        objetoParametro.Add("PNNORSRT", PNNORSRT)
'        objetoParametro.Add("PSSESTOP", "C")
'        objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
'        objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
'        objetoParametro.Add("PSCPLNDV", strCodPlanta)
'        objetoParametro.Add("PNCCLNT", PNCCLNT)

'        Me.gwdDatos.Rows.Clear()
'        Me.dgwGuiaRemision.Rows.Clear()
'        For Each objEntidad In obj_Logica.Listar_Operacion_x_Orden_Servicio(objetoParametro)
'            dwvrow = New DataGridViewRow
'            dwvrow.CreateCells(Me.gwdDatos)
'            dwvrow.Cells(0).Value = False
'            dwvrow.Cells(1).Value = objEntidad.NOPRCN
'            dwvrow.Cells(2).Value = objEntidad.NORSRT
'            dwvrow.Cells(3).Value = objEntidad.CCLNT
'            dwvrow.Cells(4).Value = objEntidad.TCMPCL
'            dwvrow.Cells(5).Value = objEntidad.CCLNFC
'            dwvrow.Cells(6).Value = objEntidad.CPLNCL
'            dwvrow.Cells(7).Value = objEntidad.TCMPCF
'            dwvrow.Cells(8).Value = objEntidad.TPLNTA
'            dwvrow.Cells(9).Value = objEntidad.CTPOSR
'            dwvrow.Cells(10).Value = objEntidad.TCMTPS
'            dwvrow.Cells(11).Value = objEntidad.TCMSBS
'            dwvrow.Cells(12).Value = objEntidad.CMRCDR
'            dwvrow.Cells(13).Value = objEntidad.TCMRCD
'            dwvrow.Cells(14).Value = objEntidad.TCNTCS
'            dwvrow.Cells(15).Value = objEntidad.TCRVTA
'            dwvrow.Cells(16).Value = objEntidad.SESTOP
'            dwvrow.Cells(17).Value = objEntidad.TDRCNS
'            dwvrow.Cells(18).Value = objEntidad.NRUCCN
'            dwvrow.Cells(19).Value = IIf(objEntidad.SORGMV.Equals(""), "NO", "SI")
'            dwvrow.Cells(20).Value = objEntidad.CRGVTA
'            dwvrow.Cells(21).Value = objEntidad.CPLNDV

'            Me.gwdDatos.Rows.Add(dwvrow)
'        Next
'    End Sub

'    Private Sub Lista_GR_x_Operacion(ByVal Indice As Integer)
'        Dim obj_Logica As New Factura_Transporte_BLL
'        Dim objEntidad As New Factura_Transporte
'        Dim objetoParametro As New Hashtable
'        Dim lintEstado As Int32 = 0
'        Dim lintGuiaRemi As Int64 = 0
'        Dim dwvrow As DataGridViewRow

'        objetoParametro.Add("PNNOPRCN", Me.gwdDatos.Item("NOPRCN_C", Indice).Value)
'        objetoParametro.Add("PSSESTOP", "C")
'        objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
'        objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
'        objetoParametro.Add("PNCPLNDV", 0)
'        'objetoParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))

'        For Each objEntidad In obj_Logica.Listar_Guia_Remision_x_Operacion(objetoParametro)
'            dwvrow = New DataGridViewRow
'            dwvrow.CreateCells(Me.dgwGuiaRemision)
'            dwvrow.Cells(0).Value = objEntidad.NOPRCN
'            If (objEntidad.NGUITR = lintGuiaRemi) Then
'                dwvrow.Cells(1).Value = ""
'            Else
'                dwvrow.Cells(1).Value = objEntidad.NGUITR
'                lintGuiaRemi = objEntidad.NGUITR
'            End If
'            dwvrow.Cells(2).Value = objEntidad.FGUITR_S
'            dwvrow.Cells(3).Value = objEntidad.NMNFCR
'            dwvrow.Cells(4).Value = objEntidad.CTRSPT
'            dwvrow.Cells(5).Value = objEntidad.TCMTRT
'            dwvrow.Cells(6).Value = objEntidad.NPLVHT
'            dwvrow.Cells(7).Value = objEntidad.CBRCNT
'            dwvrow.Cells(8).Value = objEntidad.TDSTRT
'            dwvrow.Cells(9).Value = objEntidad.QCNDTG
'            dwvrow.Cells(10).Value = objEntidad.CMNDGU
'            dwvrow.Cells(11).Value = objEntidad.TOTSER
'            dwvrow.Cells(12).Value = objEntidad.PBRTOR
'            dwvrow.Cells(13).Value = objEntidad.QBLORG
'            dwvrow.Cells(14).Value = objEntidad.QKLMRC

'            Me.dgwGuiaRemision.Rows.Add(dwvrow)
'            lintEstado = 1
'        Next
'        Me.gwdDatos.EndEdit()
'        If lintEstado = 0 Then
'            Me.gwdDatos.Item("SELEC_C", Me.gwdDatos.CurrentCellAddress.Y).Value = False
'            Me.gwdDatos.EndEdit()
'        End If
'    End Sub

'    Private Sub Imprimir_Consistencia(ByVal lstr_Cadena As String)
'        Dim obj_Logica As New Factura_Transporte_BLL
'        Dim objPrintForm As New PrintForm
'        Dim objDs As New DataSet
'        Dim objDt As New DataTable
'        Dim objetoRep As New rptConsistencia_Factura
'        Dim objParametro As New Hashtable
'        Try
'            objParametro.Add("PSNOPRCN", lstr_Cadena)
'            objParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue.ToString)
'            objParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue.ToString)
'            objParametro.Add("PNFECHA", Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaConsistencia.Value))
'            objDt = HelpClass.GetDataSetNative(obj_Logica.Listar_Consistencia_Factura_x_Orden_Servicio(objParametro))
'            objDt.TableName = "RZCT01"

'            If objDt.Rows.Count = 0 Then
'                HelpClass.MsgBox("No tiene registros", MessageBoxIcon.Information)
'                Exit Sub
'            End If
'            objDs.Tables.Add(objDt.Copy)
'            objetoRep.SetDataSource(objDs)

'            CType(objetoRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = ConfigurationWizard.UserName
'            CType(objetoRep.ReportDefinition.ReportObjects("lblCompania"), TextObject).Text = Me.cboCompania.Text
'            CType(objetoRep.ReportDefinition.ReportObjects("lblDivision"), TextObject).Text = Me.cboDivision.Text
'            CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = "TODOS"
'            'CType(objetoRep.ReportDefinition.ReportObjects("lblPlanta"), TextObject).Text = Me.cboPlanta.Text

'            objPrintForm.ShowForm(objetoRep, Me)

'        Catch : End Try

'    End Sub

'    Private Function Consistencia_Operacion() As String
'        Dim lstr_Cadena As String = ""
'        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then
'            Return lstr_Cadena
'            Exit Function
'        End If
'        mConsistenciaPlanta = False
'        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
'            If Me.gwdDatos.Item(0, lint_Contador).Value Then
'                lstr_Cadena = lstr_Cadena + Me.gwdDatos.Item("NOPRCN_C", lint_Contador).Value.ToString.Trim + ","
'                If Me.gwdDatos.Item("TPLNTA_C", lint_Contador).Value.ToString.Trim.Equals("") Then mConsistenciaPlanta = True
'            End If
'        Next
'        If lstr_Cadena.Length <> 0 Then
'            lstr_Cadena = lstr_Cadena.Substring(0, lstr_Cadena.Length - 1)
'        End If
'        Return lstr_Cadena
'    End Function

'    Private Function Consistencia_Organizacion_Venta() As Boolean
'        Dim lstr_Estado As Boolean = True
'        Dim intIndice As Int32 = 0
'        cOrgVenta = ""
'        Me.gwdDatos.EndEdit()
'        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
'            If Me.gwdDatos.Item("SELEC_C", lint_Contador).Value = True Then
'                If intIndice = 0 Then
'                    cOrgVenta = Me.gwdDatos.Item("CRGVTA_C", lint_Contador).Value
'                    dOrgVenta = Me.gwdDatos.Item("TCRVTA_C", lint_Contador).Value
'                    lstr_Estado = True
'                    intIndice += 1
'                Else
'                    If Me.gwdDatos.Item("CRGVTA_C", lint_Contador).Value <> cOrgVenta Then
'                        lstr_Estado = False
'                    End If
'                End If
'            End If
'        Next
'        Return lstr_Estado
'    End Function

'    Private Function Consistencia_Cliente() As Int64
'        Dim lstr_CCLNT As Int64 = 0
'        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
'            If Me.gwdDatos.Item(0, lint_Contador).Value Then
'                lstr_CCLNT = Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value
'                mCPLNDV = Me.gwdDatos.Item("CPLNCL_C", lint_Contador).Value
'                Exit For
'            End If
'        Next
'        Return lstr_CCLNT
'    End Function

'    Private Function Validar_Cliente(ByVal lint_Indice As Integer) As Integer
'        Dim lint_Resultado As Integer = 0
'        Me.gwdDatos.EndEdit()
'        For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
'            If Me.gwdDatos.Item("SELEC_C", lint_Contador).Value = True Then
'                If Me.gwdDatos.Item("CCLNFC_C", lint_Contador).Value <> Me.gwdDatos.Item("CCLNFC_C", lint_Indice).Value OrElse _
'                   Me.gwdDatos.Item("SORGMV_C", lint_Contador).Value <> Me.gwdDatos.Item("SORGMV_C", lint_Indice).Value Then
'                    lint_Resultado = 2
'                    Return lint_Resultado
'                End If
'            End If
'        Next
'        Return lint_Resultado
'    End Function

'    Private Sub Validar_Acceso_Opciones_Usuario()
'        Dim objParametro As New Hashtable
'        Dim objLogica As New Acceso_Opciones_Usuario_BLL
'        Dim objEntidad As New ClaseGeneral

'        objParametro.Add("MMCAPL", ConfigurationManager.AppSettings("System_prefix"))
'        objParametro.Add("MMCUSR", ConfigurationWizard.UserName)
'        objParametro.Add("MMNPVB", Me.Name.Trim)
'        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

'        If objEntidad.STSOP1 = "" Then
'            Me.btnClienteFacturar.Visible = False
'        End If
'        If objEntidad.STSOP2 = "" Then
'            Me.btnConsistencia.Visible = False
'        End If
'        If objEntidad.STSOP3 = "" Then
'            Me.btnFactura.Visible = False
'            Me.Separator2.Visible = False
'        End If
'    End Sub

'    Private Sub Eliminar_Guias_X_Operacion(ByVal lintOperacion As Int64)
'        If Me.dgwGuiaRemision.RowCount = 0 Then Exit Sub
'        Dim lint_contador As Int32 = 0
'        While lint_contador <= Me.dgwGuiaRemision.RowCount - 1
'            If Me.dgwGuiaRemision.Item("NOPRCN_D", lint_contador).Value = lintOperacion Then
'                Me.dgwGuiaRemision.Rows.RemoveAt(lint_contador)
'                lint_contador -= 1
'            End If
'            lint_contador += 1
'        End While
'    End Sub

'    Private Sub cargarComboPlanta()
'        Dim objLisEntidad As New List(Of SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral)
'        Dim objLisEntidad2 As New List(Of SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral)
'        Dim objLogica As New SOLMIN_CTZ.NEGOCIO.Planta_BLL
'        Try
'            Me.cmbPlanta.Text = ""
'            If (bolBuscar = True And Me.cboCompania.SelectedValue IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
'                bolBuscar = False
'                objLogica.Crea_Lista()
'                objLisEntidad2 = objLogica.Lista_Planta(Me.cboCompania.SelectedValue, Me.cboDivision.SelectedValue)
'                Dim objEntidad As New SOLMIN_CTZ.Entidades.mantenimientos.ClaseGeneral
'                For Each objEntidad In objLisEntidad2
'                    objLisEntidad.Add(objEntidad)
'                Next
'                cmbPlanta.DisplayMember = "TPLNTA"
'                cmbPlanta.ValueMember = "CPLNDV"
'                Me.cmbPlanta.DataSource = objLisEntidad
'                For i As Integer = 0 To cmbPlanta.Items.Count - 1
'                    If cmbPlanta.Items.Item(i).Value = "1" Then
'                        Me.cmbPlanta.SetItemChecked(i, True)
'                    End If
'                Next
'                If Me.cmbPlanta.Text = "" Then
'                    Me.cmbPlanta.SetItemChecked(0, True)
'                End If

'                'If objLisEntidad.Count > 0 Then
'                '  _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
'                'Else
'                '  _lstrTipoCuenta = ""
'                'End If
'                bolBuscar = True
'            End If
'        Catch ex As Exception
'        End Try
'    End Sub

'    Private Function ObtenerTipoCambio() As Double
'        Dim oDt As DataTable
'        Dim oFiltro As New Hashtable
'        Dim ldtpFechaFactura As Date = Now
'        Dim dblTipoCambio As Double = 0
'        Dim oFacturaNeg As New Factura_Transporte_BLL
'        oFiltro.Add("PNCMNDA1", "100")
'        oFiltro.Add("PNFCMBO", Format(ldtpFechaFactura, "yyyyMMdd"))
'        oFiltro.Add("PSCCMPN", Me.cboCompania.SelectedValue)

'        oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
'        If oDt.Rows.Count > 0 Then
'            dblTipoCambio = oDt.Rows(0).Item("IVNTA").ToString.Trim
'        End If
'        Return dblTipoCambio
'    End Function

'#End Region

'    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar1.Click
'        Try
'            Me.Lista_Operacion_x_OS()
'            If Me.chkMM.Checked = True Then
'                If Me.gwdDatos.RowCount > 0 Then
'                    For intCount As Integer = 0 To Me.gwdDatos.RowCount - 1
'                        Me.gwdDatos.Item("SELEC_C", intCount).Value = True
'                        Me.Lista_GR_x_Operacion(intCount)
'                    Next

'                End If
'            End If
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try

'    End Sub
'End Class

Public Class frmFacturacionTransporte
    Private Sub frmFacturacionTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcFacturacionTransporte1.pSystem_Prefix = HelpClass.getSetting("System_prefix")
        UcFacturacionTransporte1.pUsuario = Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.UserName
        UcFacturacionTransporte1.pNameFormulario = Me.Name
        UcFacturacionTransporte1.pInicializar()
    End Sub
End Class


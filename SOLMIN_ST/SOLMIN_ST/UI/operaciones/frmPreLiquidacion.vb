Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_ST.ENTIDADES.Mantenimientos


Public Class frmPreLiquidacion

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
#End Region

#Region "Eventos"

  Private Sub frmPreLiquidacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      Me.Cargar_Compania()
      Me.Alinear_Columnas_Grilla()
      Me.Validar_Acceso_Opciones_Usuario()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Try
  End Sub

  Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
    Try
      If e.RowIndex < 0 Then Exit Sub
      If Me.gwdDatos.RowCount = 0 Then Exit Sub
      'Dim CCLNT As Integer = Convert.ToInt32(Me.gwdDatos.Item("CCLNT", e.RowIndex).Value)
      'Me.Listar_Liquidacion(CCLNT)
      Me.Listar_Liquidacion()
      'Validar_Acceso_Tab()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Try
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      If (Me.txtClienteFiltro.pCodigo = 0) Then
        MessageBox.Show("Ingrese Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      Me.Listar_PreLiquidacion()
      Me.gwdDatos.CurrentCell = Nothing

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Try
  End Sub

  Private Sub InicializarFormulario()
    Me.gwdDatos.DataSource = Nothing
    Me.dgwLiquidacion.DataSource = Nothing
    Me.txtClienteFiltro.CCMPN = Me.cboCompania.SelectedValue
  End Sub

  'Private Sub dgwLiquidacion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwLiquidacion.CellClick
  '  Try
  '    If Me.dgwLiquidacion.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
  '    dgwLiquidacion.EndEdit()
  '    Select Case dgwLiquidacion.Columns(e.ColumnIndex).Name
  '      Case ""
  '        Me.dgwLiquidacion.Item(e.ColumnIndex, e.RowIndex).Value = IIf(dgwLiquidacionChk, "N", "S")
  '        dgwLiquidacionChk = IIf(dgwLiquidacionChk, False, True)
  '      Case ""

  '    End Select
  '    If dgwLiquidacion.Columns(e.ColumnIndex).Name = "chk2" Then

  '    End If
  '  Catch ex As Exception
  '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
  '  End Try

  'End Sub

    Private Sub dgwLiquidacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwLiquidacion.CellContentClick
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objetoParametro As New Hashtable
        Try

            If dgwLiquidacion.Columns(e.ColumnIndex).Name = "btnDetalleLiquidacion" Then
                Me.Cursor = Cursors.WaitCursor
                If Me.dgwLiquidacion.CurrentCellAddress.Y < 0 Then Exit Sub
                If Existe_Ventana(frmConsultaPreFactura.Name) Then Exit Sub
                Dim objfrmConsultaPreFactura As New frmConsultaPreFactura()
                With objfrmConsultaPreFactura
                    .mNPRLQD = Me.dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value()
                    .mCompania = Me.cboCompania.SelectedValue

                    .ShowDialog()
                    Me.Listar_Liquidacion()
                End With
                Me.Cursor = Cursors.Default
            ElseIf dgwLiquidacion.Columns(e.ColumnIndex).Name = "NOPRCN" Then
                Try
                    Dim objfrmOperacion As New frmOperacionesXPreFactura
                    With objfrmOperacion
                        .PNCCLNT = Me.gwdDatos.Item("CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value
                        .PNNPRLQD = Me.dgwLiquidacion.CurrentRow.Cells("NPRLQD").Value()
                        .PSCCMPN = Me.cboCompania.SelectedValue
                        .PSCDVSN = Me.cboDivision.SelectedValue
                    End With
                    objfrmOperacion.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            ' Me.dgwLiquidacion.DataSource = obj_Logica.Listar_Liquidacion(objetoParametro)
            '  Me.Listar_PreLiquidacion()
        Catch ex As Exception

        End Try

    End Sub

    Private Function Existe_Ventana(ByVal pstrForm As String) As Boolean
        Dim intCont As Integer

        For intCont = 0 To Me.ParentForm.MdiChildren.Length - 1
            If Me.ParentForm.MdiChildren(intCont).Name.Trim = pstrForm.Trim Then
                Me.ParentForm.MdiChildren(intCont).WindowState = FormWindowState.Maximized
                Me.ParentForm.MdiChildren(intCont).Show()
                Return True
            End If
        Next intCont
        Return False
    End Function

  'Private Sub dgwLiquidacion_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwLiquidacion.ColumnHeaderMouseClick, dgwLiquidacion.ColumnHeaderMouseDoubleClick
  '    Try
  '        If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
  '        dgwLiquidacion.EndEdit()
  '        If dgwLiquidacion.Columns(e.ColumnIndex).Name = "chk2" Then
  '            For Each row As DataGridViewRow In dgwLiquidacion.Rows
  '                row.Cells("chk2").Value = IIf(dgwLiquidacionChk, "N", "S")
  '            Next
  '            dgwLiquidacionChk = IIf(dgwLiquidacionChk, False, True)
  '        End If
  '    Catch ex As Exception
  '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
  '    End Try

  'End Sub

  Private Sub btnFacturaPreLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturaPreLiquidacion.Click
    Try

      If dgwLiquidacion.RowCount = 0 Then Exit Sub
      Dim objEntidad As New Factura_Transporte
      Dim obj_Logica As New PreLiquidacion_BLL
      Dim objGenericCollection As New List(Of Factura_Transporte)
      Dim Cadena As String = ""
            Dim lstr_Consistencia As String = ""
            Dim dt As DataTable
            Dim dblDocumentoOrigen As Double = 0
            Dim dblFechaDocumentoOrigen As Double = 0
            Dim dblTipoDocumentoOrigen As Double = 0
            Dim obj_LogicaFactura As New Factura_Transporte_BLL
      Me.dgwLiquidacion.EndEdit()
      If Consistencia_Organizacion_Venta(Me.dgwLiquidacion) = False Then
        HelpClass.MsgBox("La Organización de Venta de las Pre-Liquidaciones seleccionadas no son las mismas.", MessageBoxIcon.Information)
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
          'objEntidad.CPLNCL = Me.cboPlanta.SelectedValue
          lstr_Consistencia = lstr_Consistencia & "," & objEntidad.NPRLQD
          objGenericCollection.Add(objEntidad)
        End If
      Next
      If objGenericCollection.Count = 0 Then Exit Sub
      Cadena = obj_Logica.Lista_Operacion_Liquidacion(objGenericCollection)
      lstr_Consistencia = lstr_Consistencia.Substring(1)
      Dim frm_OpcionFactura As New frmOpcionFactura
      Dim lint_Contador As Int32 = Me.gwdDatos.CurrentCellAddress.Y
      With frm_OpcionFactura
        .Compania = Me.cboCompania.SelectedValue
        .Division = Me.cboDivision.SelectedValue
        .Estado = 1
        .txtCliente.Text = Me.gwdDatos.Item("CCLNT", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCL", lint_Contador).Value
                '.txtNIT.Text = Me.gwdDatos.Item("NRUCRM", lint_Contador).Value
                '.txtDireccion.Text = Me.gwdDatos.Item("TDRCRM", lint_Contador).Value
        .lblOperacion.Text = "N° Liquidación"
        .txtOperacion.Text = lstr_Consistencia.Trim
        .txtOrganizacionVenta.Text = dOrgVenta.Trim
        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                'Dim FechaFactura As Date = .dtpFechaFactura.Value.Date
                'Dim FechaAtencion As Double = 0
                'If .chkFechaServicio.Checked = True Then
                '  FechaAtencion = (CType(HelpClass.CFecha_a_Numero8Digitos(.dtpFechaServicio.Value), Int64))
                'End If
        Dim strZonaFacturacion As Int32 = 0
        Dim decPlanta As Decimal = 0
        If .cboZonaFacturacion.NoHayCodigo = False Then
          strZonaFacturacion = .cboZonaFacturacion.Codigo
        End If
        decPlanta = .Planta
        'Dim objfrmVistaFactura As New frmVistaFactura(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, Me.gwdDatos.Item("CCLNT", lint_Contador).Value, Me.cboPlanta.SelectedValue, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion)
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
                'Dim objfrmVistaFactura As New frmVistaFactura(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, Me.gwdDatos.Item("CCLNT", lint_Contador).Value, decPlanta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta, FechaFactura, FechaAtencion)
                Dim objfrmVistaFactura As New frmVistaFactura(Cadena.TrimEnd(","), cboDivision.Text, Me.cboDivision.SelectedValue, Me.cboCompania.SelectedValue, Me.gwdDatos.Item("CCLNT", lint_Contador).Value, decPlanta, IIf(frm_OpcionFactura.rbtnDolares.Checked, "DOL", "SOL"), strZonaFacturacion, cOrgVenta)
        With objfrmVistaFactura
          .pEstado = 1
                    .Tag = frm_OpcionFactura.Tag
                    .DocumentoOrigen = dblDocumentoOrigen
                    .FechaDocumentoOrigen = dblFechaDocumentoOrigen
                    .TipoDocumentoOrigen = dblTipoDocumentoOrigen
          If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
          Me.Listar_PreLiquidacion()
          If Me.gwdDatos.RowCount = 0 Then Exit Sub
          Me.Listar_Liquidacion()
          'Me.Listar_Liquidacion(CType(Me.gwdDatos.SelectedRows(0).Cells("CCLNT").Value, Integer))
        End With
      End With

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Try
  End Sub

  Private Sub btnAnularPreliquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularPreliquidacion.Click

        Try

            If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
            If MessageBox.Show("¿Desea anular la Pre-Liquidación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then
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
                    'objEntidad.CPLNCL = Me.cboPlanta.SelectedValue
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
            HelpClass.MsgBox("Se anuló la Pre - Liquidación Satisfactoriamente")
            Me.Listar_Liquidacion()

            'lintResultado = obj_Logica.Anular_Pre_Liquidacion(objGenericCollection)
            'If lintResultado = 1 Then
            '    HelpClass.MsgBox("Se anuló la Pre - Liquidación Satisfactoriamente")
            '    Me.Listar_Liquidacion()
            '    'Me.Listar_Liquidacion(CType(Me.gwdDatos.SelectedRows(0).Cells("CCLNT").Value, Integer))
            'Else
            '    HelpClass.MsgBox("Ocurrió un Error, no se anuló la Pre - Liquidación", MessageBoxIcon.Error)
            'End If

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
            '.CPLNDV = Me.cboPlanta.SelectedValue
            .CPLNDV = 0
            .Compania = Me.cboCompania.Text
            .Division = Me.cboDivision.Text
            '.Planta = Me.cboPlanta.Text
            .Planta = "TODOS"
            .Estado = 2
            .Titulo = "Pre Liquidación"
            .Tipo = "Pre Liquidación"
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
          End With
          Exit Sub
        Case 1
          Me.Imprimir_PreLiquidacion(lint_NPRLQD)
        Case Else
          HelpClass.MsgBox("Seleccionar solo una Pre - Liquidación", MessageBoxIcon.Information)
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
    If e.RowIndex = -1 And e.ColumnIndex = 0 Then
      If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
      Dim lintEstado As Boolean = Me.dgwLiquidacion.Item(0, 0).Value
      For lint_Contador As Integer = 0 To Me.dgwLiquidacion.RowCount - 1
        Me.dgwLiquidacion.Item(0, lint_Contador).Value = Not lintEstado
        Me.dgwLiquidacion.EndEdit()
      Next
    End If
  End Sub

  Private Sub btnValorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValorizar.Click
    If Me.dgwLiquidacion.RowCount = 0 Then Exit Sub
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
        .Add("COMPAÑIA : ", Me.cboCompania.ComboBox.Text)
        .Add("DIVISION : ", Me.cboDivision.ComboBox.Text)
        .Add("CLIENTE  : ", Me.gwdDatos.Item("TCMPCL", Me.gwdDatos.CurrentCellAddress.Y).Value)
        .Add("PRE LIQUIDACIÓN : ", objParametros("NPRLQD"))
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
        '.CPLNDV = Me.cboPlanta.SelectedValue
        .CPLNDV = 0
        .Compania = Me.cboCompania.Text
        .Division = Me.cboDivision.Text
        '.Planta = Me.cboPlanta.Text
        .Planta = "TODOS"
        .Estado = 3
        .Titulo = "Reporte Valorizado - Pre Liquidación"
        .Tipo = "Pre Liquidación"
        .Cliente = Me.gwdDatos.Item("TCMPCL", Me.gwdDatos.CurrentCellAddress.Y).Value
        If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
      End With
      Exit Sub
    End If

  End Sub

#End Region

#Region "Métodos"

  Private Function Obtener_Grilla() As DataGridView
    Dim objDgView As New DataGridView
    objDgView.Columns.Add("TCMPCL", "Cliente")
    objDgView.Columns.Add("PLANTA", "Planta")
    objDgView.Columns.Add("CREFFW", "Bulto")
    objDgView.Columns.Add("NSEQIN", "NSEQIN")
    objDgView.Columns.Add("DESCWB", "Descripción")
    objDgView.Columns.Add("QBLTSR", "Cant. Despachada")
    objDgView.Columns.Add("TUNDIT", "Unidad Medida")
    objDgView.Columns.Add("QPEPQT", "Peso Despachado")
    objDgView.Columns.Add("TUNPSO", "Unidad Peso")
    objDgView.Columns.Add("QVLBTO", "Volumen Bulto")
    objDgView.Columns.Add("TUNVOL", "Unidad Volumen")
    objDgView.Columns.Add("TPRVCL", "Proveedor")
    objDgView.Columns.Add("NORCML", "Orden de Compra")
    objDgView.Columns.Add("TCMAEM", "Área Solicitante")
    objDgView.Columns.Add("TIPO", "Tipo Movimiento")
    objDgView.Columns.Add("TRFRNA", "Código Lote")
    objDgView.Columns.Add("TLUGEN", "Lugar Entrega")
    objDgView.Columns.Add("FREFFW", "F. Recep. CL")
    objDgView.Columns.Add("FSLFFW", "F. Salida C.L")
    objDgView.Columns.Add("DIASCL", "Días C.L")
    objDgView.Columns.Add("FINGAL", "F. Recep. Almacén (O.L)")
    objDgView.Columns.Add("FSLDAL", "F. Salida Almacén (O.L)")
    objDgView.Columns.Add("DIAS", "Días Almacén (O.L)")
    objDgView.Columns.Add("NGUIRM", "Guía Remisión")
    objDgView.Columns.Add("GRMEDENVIO", "Medio Envio G/R")
    objDgView.Columns.Add("GRTCMTRT", "Transportista")
    objDgView.Columns.Add("GRNPLCCM", "Placa")
    objDgView.Columns.Add("GRNPLACP", "Acoplado")
    objDgView.Columns.Add("FLGCNL", "Estado Entrega")
    objDgView.Columns.Add("FCNFCL", "Fecha Confirmación")
    objDgView.Columns.Add("HCNFCL", "Hora Confirmación")
    objDgView.Columns.Add("SENTIDO", "Sentido de Carga")
    objDgView.Columns.Add("CZNALM", "Almacen/Zona")
    objDgView.Columns.Add("1_MEDENVIO", "1_Medio Envio")
    objDgView.Columns.Add("1_GUIATRANS", "1_Guía Transp.")
    objDgView.Columns.Add("1_FGUIRM", "1_Fecha Guía Transp.")
    objDgView.Columns.Add("1_TUNDVH", "1_Tipo Unidad")
    objDgView.Columns.Add("1_RUTA", "1_Ruta")
    objDgView.Columns.Add("1_TCMTRT", "1_Transportista")
    objDgView.Columns.Add("1_NPLCTR", "1_Placa")
    objDgView.Columns.Add("1_NPLCAC", "1_Acoplado")
    objDgView.Columns.Add("1_CUENTA", "1_Cuenta")
    objDgView.Columns.Add("1_FCHFTR", "1_Fecha de Llegada")
    objDgView.Columns.Add("3_MEDENVIO", "3_Medio Envio")
    objDgView.Columns.Add("3_GUIATRANS", "3_Guía Transp.")
    objDgView.Columns.Add("3_FGUIRM", "3_Fecha Guía Transp.")
    objDgView.Columns.Add("3_TUNDVH", "3_Tipo Unidad")
    objDgView.Columns.Add("3_RUTA", "3_Ruta")
    objDgView.Columns.Add("3_TCMTRT", "3_Transportista")
    objDgView.Columns.Add("3_NPLCTR", "3_Avión")
    objDgView.Columns.Add("3_NPLCAC", "3_Acoplado")
    objDgView.Columns.Add("3_CUENTA", "3_Cuenta")
    objDgView.Columns.Add("3_FCHFTR", "3_Fecha de Llegada")
    objDgView.Columns.Add("2_MEDENVIO", "2_Medio Envio")
    objDgView.Columns.Add("2_GUIATRANS", "2_Guía Transp.")
    objDgView.Columns.Add("2_FGUIRM", "2_Fecha Guía Transp.")
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
            'cboCompania.SelectedValue = "EZ"
            'If cboCompania.SelectedIndex = -1 Then
            '    cboCompania.SelectedIndex = 0
            'End If
            'cboCompania_SelectedIndexChanged(Nothing, Nothing)
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

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    Me.dgwLiquidacion.AutoGenerateColumns = False
    For lint_Contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
    For lint_Contador As Integer = 0 To Me.dgwLiquidacion.ColumnCount - 1
      Me.dgwLiquidacion.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Listar_PreLiquidacion()
    Dim obj_Logica As New PreLiquidacion_BLL
    Dim objetoParametro As New Hashtable
    objetoParametro.Add("PNCCLNT", Me.txtClienteFiltro.pCodigo)
    objetoParametro.Add("PNFECINI", 0)
    objetoParametro.Add("PNFECFIN", 0)
    objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
    objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
    objetoParametro.Add("PNCPLNDV", 0)
    Me.gwdDatos.DataSource = Nothing
    Me.dgwLiquidacion.DataSource = Nothing
    Me.gwdDatos.DataSource = obj_Logica.Listar_PreLiquidacion_Factura(objetoParametro)
    'Validar_Acceso_Tab()

  End Sub

  Private Sub Listar_Liquidacion()
    Dim obj_Logica As New PreLiquidacion_BLL
    Dim objetoParametro As New Hashtable
    objetoParametro.Add("PNCCLNT", Me.gwdDatos.Item("CCLNT", Me.gwdDatos.CurrentCellAddress.Y).Value)
    objetoParametro.Add("PNCCLNFC", Me.gwdDatos.Item("CCLNFC", Me.gwdDatos.CurrentCellAddress.Y).Value)
    objetoParametro.Add("PSCCMPN", Me.cboCompania.SelectedValue)
    objetoParametro.Add("PSCDVSN", Me.cboDivision.SelectedValue)
    'objetoParametro.Add("PNCPLNDV", CType(Me.cboPlanta.SelectedValue, Double))
    objetoParametro.Add("PNCPLNDV", 0)
    objetoParametro.Add("PNFECINI", 0)
    objetoParametro.Add("PNFECFIN", 0)
    Me.dgwLiquidacion.DataSource = obj_Logica.Listar_Liquidacion(objetoParametro) 'dt
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
        'HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", Me.cboPlanta.Text)
        HelpClass.CrystalReportTextObject(objetoRep, "lblNroPreliquidacion", "N° " & lintNPRLQD.ToString)
        objetoRep.SetDataSource(objDs)
        objPrintForm.ShowForm(objetoRep, Me)
      Case 1
        ListaParametros.Add(lintNPRLQD)
        ListaParametros.Add(Me.cboCompania.SelectedValue)
        ListaParametros.Add(Me.cboDivision.SelectedValue)
        'ListaParametros.Add(Me.cboPlanta.SelectedValue)
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
        'HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblPlanta", Me.cboPlanta.Text)
        HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblPlanta", "TODOS")
        HelpClass.CrystalReportTextObject(objetoRep_Lote, "lblNroPreliquidacion", "N° " & lintNPRLQD.ToString)
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
    If objEntidad.STSOP1 = "" Then
      Me.btnFacturaPreLiquidacion.Visible = False
      Me.Separator3.Visible = False
    End If
    If objEntidad.STSOP2 = "" Then
      Me.btnAnularPreliquidacion.Visible = False
      Me.Separator3.Visible = False
    End If
    If objEntidad.STSOP3 = "" Then
      Me.btnValorizar.Visible = False
      Me.Separator5.Visible = False
    End If

    'Validar_Acceso_Tab()
  End Sub

  'Private Sub Validar_Acceso_Tab()
  '  Me.btnFacturaPreLiquidacion.Enabled = Convert.ToBoolean(Me.TabListaLiquidacion.SelectedIndex)
  '  Me.btnAnularPreliquidacion.Enabled = Convert.ToBoolean(Me.TabListaLiquidacion.SelectedIndex)
  '  Me.btnImprimir.Enabled = Convert.ToBoolean(Me.TabListaLiquidacion.SelectedIndex)  
  'End Sub

  Private Function Consistencia_Organizacion_Venta(ByVal Sender As Object) As Boolean
    Dim lstr_Estado As Boolean = True
    Dim intIndice As Int32 = 0
    cOrgVenta = ""
    Sender.EndEdit()
    'For lint_Contador As Integer = 0 To Sender.RowCount - 1
    '  If Sender.Item(0, lint_Contador).Value = "S" Then
    For intContador As Integer = 0 To Sender.RowCount - 1
      If Sender.Item("chk2", intContador).Value = True Then
        If intIndice = 0 Then
          cOrgVenta = Sender.Item(6, intContador).Value
          dOrgVenta = Sender.Item(5, intContador).Value
          lstr_Estado = True
          intIndice += 1
        Else
          If Sender.Item(6, intContador).Value.ToString.Trim <> cOrgVenta.Trim Then
            lstr_Estado = False
          End If
        End If
      End If
    Next
    Return lstr_Estado
  End Function

  Private Sub LimpiarDatos()
    txtClienteFiltro.pClear()
    gwdDatos.DataSource = Nothing
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
            'Dim dt As DataTable
            Dim dblDocumentoOrigen As Double = 0
            Dim dblFechaDocumentoOrigen As Double = 0
            Dim dblTipoDocumentoOrigen As Double = 0
            Dim obj_LogicaFactura As New Factura_Transporte_BLL
            Me.dgwLiquidacion.EndEdit()
            If Consistencia_Organizacion_Venta(Me.dgwLiquidacion) = False Then
                HelpClass.MsgBox("La Organización de Venta de las Pre-Liquidaciones seleccionadas no son las mismas.", MessageBoxIcon.Information)
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
                    'objEntidad.CPLNCL = Me.cboPlanta.SelectedValue
                    lstr_Consistencia = lstr_Consistencia & "," & objEntidad.NPRLQD
                    objGenericCollection.Add(objEntidad)
                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub
            'Obtener las Operaciones de la Pre Liquidación
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
                        Dim lint_Contador As Int32 = Me.gwdDatos.CurrentCellAddress.Y
                        With frm_OpcionFacturacionLibre
                            .Compania = Me.cboCompania.SelectedValue
                            .Division = Me.cboDivision.SelectedValue
                            .Estado = 1
                            .OperacionPreLiq = Cadena
                            .txtCliente.Text = Me.gwdDatos.Item("CCLNT", lint_Contador).Value & " <-> " & Me.gwdDatos.Item("TCMPCL", lint_Contador).Value
                            '.txtNIT.Text = Me.gwdDatos.Item("NRUCRM", lint_Contador).Value
                            '.txtDireccion.Text = Me.gwdDatos.Item("TDRCRM", lint_Contador).Value
                            .lblOperacion.Text = "N° Pre Liquidación"
                            .txtOperacion.Text = lstr_Consistencia.Trim
                            .txtOrganizacionVenta.Text = dOrgVenta.Trim
                            SumaSoles = Math.Round(SumaSoles, 2)
                            SumaDolares = Math.Round(SumaDolares, 2)
                            Dim ImporteSoles As String = IIf(SumaSoles = 0, "", String.Format("{0:N2}", SumaSoles)) 'Convert.ToString(SumaSoles) 
                            Dim ImporteDolares As String = IIf(SumaDolares = 0, "", String.Format("{0:N2}", SumaDolares)) 'Convert.ToString(SumaDolares)
                            .ImporteSoles = ImporteSoles
                            .ImporteDolares = ImporteDolares
                            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
                            Me.Listar_PreLiquidacion()
                            If Me.gwdDatos.RowCount = 0 Then Exit Sub
                            Me.Listar_Liquidacion()
                        End With
                    End If
                End If
            Else
                HelpClass.MsgBox("No existe Tipo de Cambio para Hoy", MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
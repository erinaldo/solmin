Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES

Public Class frmNuevoPedidoEfectivo

  Public Sub New(ByVal objEntidad As Hashtable)
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    lobjEntidad = objEntidad
  End Sub

#Region "Variables"
  Private lobjEntidad As New Hashtable
#End Region

#Region "Eventos"
    Private Sub frmNuevoPedidoEfectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Datos_Extra()
            CargarCombos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Try

      Guardar_Pedido_Efectivo()
    Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperacion.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
    If e.KeyChar = Chr(13) Then
      Placa_X_Operacion()
    End If
  End Sub

  Private Sub txtImporte_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.Leave
    If IsNumeric(txtImporte.Text) Then
      txtImporte.Text = Format(CType(txtImporte.Text, Double), "###,###,##0.00")
    Else
      txtImporte.Text = "0"
    End If
  End Sub

  Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaOrdenServicio.Click

        Try
            Dim objBuscarOperacion As New frmBuscarOperacion
            With objBuscarOperacion
                .CCMPN = lobjEntidad("COMPANIA")
                .CDVSN = lobjEntidad("DIVISION")
                .CPLNDV = lobjEntidad("PLANTA")
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    txtOperacion.Text = .NOPRCN_1
                    Placa_X_Operacion()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
  End Sub

    Private Sub txtOperacion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperacion.Leave
        Try
            Placa_X_Operacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region "Metodos y Funciones"

  Private Sub Cargar_Datos_Extra()
    Dim Objeto_Logica As New NEGOCIO.PedidoEfectivo_BLL
    Dim objLogicalMoneda As New Moneda_BLL
    Dim objEntidad As New Moneda

    Me.txtPedido.Text = Objeto_Logica.Generar_Codigo(lobjEntidad("COMPANIA"), lobjEntidad("PLANTA"))
    objEntidad.FULTAC = HelpClass.CtypeDate(Now)
    objEntidad.CMNDA1 = 100
  End Sub

  Private Sub Guardar_Pedido_Efectivo()
    Dim objEntidad As New ENTIDADES.PedidoEfectivo
    Dim objLogic As New NEGOCIO.PedidoEfectivo_BLL
    Dim objLogical As New SolicitudPedidoEfectivo_BLL


    Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)

    If Me.txtOperacion.Text = "" Then
      strError = strError & "* Número de Operación" & Chr(13)
    Else
      If Not objLogical.Validar_Numero_Operacion(Me.txtOperacion.Text) Then
        Me.txtOperacion.Text = 0
        strError = strError & "* Número de Operación  valida" & Chr(13)
      End If
    End If
    If Me.ctbObrero.Codigo.Trim.Length = 0 Then
      strError = strError & "* Código del Obrero" & Chr(13)
    End If
    If Me.txtImporte.Text.Trim.Length = 0 OrElse CType(Me.txtImporte.Text.Trim, Double) = "0" Then
      strError = strError & "* Importe mayor a Cero" & Chr(13)
    End If
    If cmbPlaca.Text = vbNullString Then
      strError = strError & "* Número de Placa" & Chr(13)
    End If
    If Me.txtMotivo.Text.Trim = vbNullString Then
      strError = strError & "* Motivo" & Chr(13)
    End If
    'NUMERO DE DIGITOS DEBE DE SER MAYOR A 17 PARA QUE SE PUEDA EMITIR ERRO, YA QUE EL TITULO TIENE 17 CARACTERES
    If strError.Trim.Length > 17 Then
      HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
      Exit Sub
    End If

    'Validacion adicionada-----------------------------------------
    Dim dataTable As New DataTable
    dataTable = Me.Tag
        Dim CodSAPObrero As String = ("" & ctbObrero.Codigo).Trim
    Dim bollIguales As Boolean = False
        For Each objDataRow As DataRow In dataTable.Rows
            'If (ctbObrero.Codigo.ToString.Trim = ("" & objDataRow.Item("CODSAP")).ToString()) Then
            '    bollIguales = True
            'End If
            If (CodSAPObrero = ("" & objDataRow.Item("CODSAP")).ToString()) Then
                bollIguales = True
            End If
            If (CodSAPObrero = ("" & objDataRow.Item("CODSAP2")).ToString()) Then
                bollIguales = True
            End If
        Next
    If (bollIguales = False) Then
      MessageBox.Show("No se puede realizar la operación." & Chr(13) & "El Obrero y Conductor deben ser iguales")
      Exit Sub
    End If
    '--------------------------------------------------------------


    Me.Cursor = Cursors.WaitCursor
    objEntidad.NCSOTR = 0
    objEntidad.NCRRSR = 0
    objEntidad.CCMPN = Me.lobjEntidad("COMPANIA")
    objEntidad.CDVSN = Me.lobjEntidad("DIVISION")
    objEntidad.CPLNDV = Me.lobjEntidad("PLANTA")
    objEntidad.TPSLPE = "P"
    objEntidad.FCJSPE = HelpClass.CtypeDate(Now)
    objEntidad.ISLPES = Me.txtImporte.Text
    If txtMotivo.Text.Length >= 30 Then
      objEntidad.MOTIVO = txtMotivo.Text.Substring(0, 30)
    Else
      objEntidad.MOTIVO = txtMotivo.Text
    End If
    objEntidad.NPLCUN = cmbPlaca.SelectedValue
    objEntidad.NORDSR = Me.txtOperacion.Text.Trim
    objEntidad.CODDES = ctbObrero.Codigo
    objEntidad.SESTRG = "A"
    objEntidad.DATCRT = HelpClass.TodayNumeric
    objEntidad.HRACRT = HelpClass.NowNumeric
    objEntidad.USRCRT = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidad.CBRCNT = Me.lobjEntidad("CBRCNT")
    objEntidad.NOPRCN = Me.txtOperacion.Text.Trim
    objEntidad.MTVGRO = CType(cmbPlaca.SelectedItem, SolicitudEfectivoSAP).CBRCNT + " - " + CType(cmbPlaca.SelectedItem, SolicitudEfectivoSAP).CONDUCTOR1

    objEntidad = objLogic.Guardar_Pedido_Efectivo(objEntidad)
    If objEntidad.NMSLPE <> 0 Then
      HelpClass.MsgBox("El registro se guardó satisfactoriamente")
      'Me.Imprimir_Reporte_Pedido_Efectivo
      Me.DialogResult = Windows.Forms.DialogResult.OK
    Else
      HelpClass.MsgBox("Error al Guardar")
    End If
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub Imprimir_Reporte_Pedido_Efectivo(ByVal intNMSLPE As Int64)
    Dim objParametro As New Hashtable
    Dim oDt As DataTable
    Dim oDs As New DataSet

    Me.Cursor = Cursors.WaitCursor
    Dim objPrintForm As New PrintForm

    'If .Cells("NRFSAP").Value <> 0 Then
    Dim objReporte As New rptSolicitudEfectivo
    Dim objLogical As New NEGOCIO.Gastos_Ruta_BLL
    objParametro.Add("NCSLPE", intNMSLPE)
    oDt = HelpClass.GetDataSetNative(objLogical.Reporte_Pedido_Efectivo(objParametro))
    oDt.TableName = "GastosRuta"
    oDs.Tables.Add(oDt.Copy)
    objReporte.SetDataSource(oDs)
    objPrintForm.ShowForm(objReporte, Me)
    'IMPRIMIR DIRECTO SIN MOSTRAR EL VISOR REPORTVIEWER
    'objPrintForm.ReportViewer.ReportSource = objReporte
    'objPrintForm.ReportViewer.PrintReport()
    'End If

    Me.Cursor = Cursors.Default
  End Sub

  Private Function Validad_Numero_Operacion() As Double
    Dim objLogical As New SolicitudPedidoEfectivo_BLL
    If Me.txtOperacion.Text = "" Then
      HelpClass.MsgBox("Ingrese Número de Operación")
      Return False
      Exit Function
    End If
    If Not objLogical.Validar_Numero_Operacion(Me.txtOperacion.Text) Then
      Me.txtOperacion.Text = 0
      HelpClass.MsgBox("Número de Operación no valido")
      Return False
    Else
      Return True
    End If
  End Function

  Private Sub CargarCombos()
    Dim obj_Logica_Vehiculo As New TransportistaTracto_BLL
    Dim obj_Entidad_Vehiculo As New TransportistaTracto
    Dim objLogicalObrero As New SolicitudPedidoEfectivo_BLL
        'Try
        With Me.ctbObrero
            .DataSource = HelpClass.GetDataSetNative(objLogicalObrero.Lista_Obrero)
            .KeyField = "COBRR"
            .ValueField = "TNMBOB"
            .DataBind()
        End With
        'Catch : End Try

  End Sub

  Private Sub Placa_X_Operacion()
    Dim objEntidad As New Hashtable
    Dim objLisEntidad As New List(Of SolicitudEfectivoSAP)
    Dim objLogical As New SolicitudPedidoEfectivo_BLL()      
    objEntidad.Add("NOPRCN", txtOperacion.Text)
    objLisEntidad = objLogical.Obtener_Placa_X_Operacion(objEntidad)
    With cmbPlaca
      .DataSource = objLisEntidad
      .DisplayMember = "COMENTARIO"
      .ValueMember = "NPLCUN"
    End With
    Me.Tag = HelpClass.GetDataSetNative(objLisEntidad)
  End Sub
#End Region

  Private Sub txtOperacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperacion.TextChanged

  End Sub

  Private Sub ctbObrero_Texto_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ctbObrero.Texto_KeyEnter
        Try
            Dim objEntidad As New Chofer
            Dim objNegocio As New Chofer_BLL

            objEntidad.CODSAP = ctbObrero.Codigo
            objEntidad.CCMPN = Me.lobjEntidad("COMPANIA")
            objEntidad = objNegocio.Obtener_brevete(objEntidad)
            Me.lobjEntidad("CBRCNT") = objEntidad.CBRCNT

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
  End Sub
End Class

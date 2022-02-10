Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class frmSeguimientoAdminOperacion

  Private intValorCon As Int32 = 0

    Private Sub frmSeguimientoAdminOperacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If gintEstadoDocOperacion = 1 Then
                gintEstadoDocOperacion = 0
                Call btnProcesarReporte_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


  Private Sub frmSeguimientoAdminOperacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      Me.Alinear_Columnas_Grilla()
      Me.Cargar_Compania()
      Me.Carga_MedioTransporte()
      Me.Cargar_Estado()
      Me.CargarEstadoOperacion()
      ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

  Private Sub Alinear_Columnas_Grilla()
    Me.gwdDatos.AutoGenerateColumns = False
    Me.gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub Cargar_Compania()
    cmbCompania.Usuario = MainModule.USUARIO
        'cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

  End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                Me.InicializarFormulario()
                Me.cmbCompania.CCMPN_ANTERIOR = Me.cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
        Try
            If Me.cmbDivision.CDVSN_ANTERIOR <> Me.cmbDivision.Division Then
                Cargar_Planta()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  Private Sub Carga_MedioTransporte()
    Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
    Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(Me.cmbCompania.CCMPN_CodigoCompania)
    Dim oDr As DataRow
    oDr = objTabla.NewRow
    oDr.Item("CMEDTR") = 0
    oDr.Item("TNMMDT") = "TODOS"
    objTabla.Rows.Add(oDr)
    objTabla.Select("", "")

    Dim dv As DataView
    dv = New DataView(objTabla, "", "CMEDTR ASC", DataViewRowState.CurrentRows)

    Me.cboMedioTransporteFiltro.DataSource = dv
    Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
    Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"

  End Sub

  Private Sub Cargar_Estado()
    Dim dt As New DataTable
    dt = ObtenerEstadosDocumento()
    Me.cboEstadoChk.DisplayMember = "ESTADO_NOPRCN"
    Me.cboEstadoChk.ValueMember = "VALUE"
    Me.cboEstadoChk.DataSource = dt

    For i As Integer = 0 To cboEstadoChk.Items.Count - 1
      If cboEstadoChk.Items.Item(i).Value = "1" Then
        cboEstadoChk.SetItemChecked(i, True)
      End If
    Next

  End Sub

  Private Function ObtenerEstadosDocumento() As DataTable
    Dim oDt As New DataTable
    oDt.TableName = "dtResumenEstado"
    Dim oDr As DataRow
    oDt.Columns.Add("VALUE", Type.GetType("System.String"))
    oDt.Columns.Add("ESTADO_NOPRCN", Type.GetType("System.String"))
    oDt.Columns.Add("NROUNI", Type.GetType("System.Int32"))
    oDt.Columns.Add("VALUES_STRING", Type.GetType("System.String"))

    oDr = oDt.NewRow
    oDr.Item(0) = "1"
    oDr.Item(1) = "TODOS"
    oDr.Item(2) = 0
    oDr.Item(3) = "T"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "2"
    oDr.Item(1) = "GENERADO"
    oDr.Item(2) = 0
    oDr.Item(3) = "G"
    oDt.Rows.Add(oDr)


    oDr = oDt.NewRow
    oDr.Item(0) = "3"
    oDr.Item(1) = "OPERACIONES"
    oDr.Item(2) = 0
    oDr.Item(3) = "O"
    oDt.Rows.Add(oDr)



    oDr = oDt.NewRow
    oDr.Item(0) = "5"
    oDr.Item(1) = "ADMINISTRACION"
    oDr.Item(2) = 0
    oDr.Item(3) = "A"
    ' oDr.Item(2) = "FA"
    oDt.Rows.Add(oDr)

    Return oDt

  End Function

  Private Sub CargarEstadoOperacion()
    Dim oDt As New DataTable

    Dim oDr As DataRow
    oDt.TableName = "dtResumenEstado"

    oDt.Columns.Add("VALUE", Type.GetType("System.String"))
    oDt.Columns.Add("ESTADO", Type.GetType("System.String"))
    oDt.Columns.Add("NROUNI", Type.GetType("System.Int32"))
    oDt.Columns.Add("VALUES_STRING", Type.GetType("System.String"))

    oDr = oDt.NewRow
    oDr.Item(1) = "TODOS"
    oDr.Item(2) = 0
    oDr.Item(0) = "1"
    oDr.Item(3) = "T"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(1) = "PENDIENTE"
    oDr.Item(2) = 0
    oDr.Item(0) = "2"
    oDr.Item(3) = "P"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(1) = "ASIGNADO"
    oDr.Item(2) = 0
    oDr.Item(0) = "3"
    oDr.Item(3) = "A"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(1) = "PRE - FACTURADO"
    oDr.Item(2) = 0
    oDr.Item(0) = "4"
    oDr.Item(3) = "F"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(1) = "FACTURADO"
    oDr.Item(2) = 0
    oDr.Item(0) = "5"
    oDr.Item(3) = "F"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(1) = "CERRADO"
    oDr.Item(2) = 0
    oDr.Item(0) = "6"
    oDr.Item(3) = "C"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(1) = "ANULADO"
    oDr.Item(2) = 0
    oDr.Item(0) = "7"
    oDr.Item(3) = "*"
    oDt.Rows.Add(oDr)


    Me.cboEstadoOperChk.DisplayMember = "ESTADO"
    Me.cboEstadoOperChk.ValueMember = "VALUES_STRING"
    Me.cboEstadoOperChk.DataSource = oDt

    For i As Integer = 0 To cboEstadoOperChk.Items.Count - 1
      If cboEstadoOperChk.Items.Item(i).Value = "1" Then
        cboEstadoOperChk.SetItemChecked(i, True)
      End If
    Next


  End Sub

  Private Function ObtenerEstadoOperacion() As String
    Dim strEstadoOper As String = String.Empty
    Dim oDt As New DataTable
    intValorCon = 0
    oDt = cboEstadoOperChk.DataSource

    For i As Integer = 0 To cboEstadoOperChk.CheckedItems.Count - 1
      If (cboEstadoOperChk.CheckedItems(i).Value <> "1") Then
        For j As Integer = 0 To oDt.Rows.Count - 1
          If (oDt.Rows(j).Item("VALUE") = cboEstadoOperChk.CheckedItems(i).Value) Then

            Select Case cboEstadoOperChk.CheckedItems(i).Value
              Case 4
                intValorCon = 1
              Case 5
                intValorCon = IIf(intValorCon = 0, 2, 0)

            End Select

            strEstadoOper += oDt.Rows(j).Item("VALUES_STRING") & ","
          End If
        Next
      Else

        strEstadoOper = "T,"
        Exit For

      End If
    Next
    If strEstadoOper.Trim.Length > 0 Then
      strEstadoOper = strEstadoOper.Trim.Substring(0, strEstadoOper.Trim.Length - 1)
    End If
    Return strEstadoOper
  End Function

  Private Sub Cargar_Planta()
    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Dim objLogica As New NEGOCIO.Planta_BLL
    cboPlanta.Text = ""
        'Try
        'If (bolBuscar = True And cmbCompania.CCMPN_CodigoCompania IsNot Nothing And Me.cboDivision.SelectedValue IsNot Nothing) Then
        '    bolBuscar = False
        If (cmbCompania.CCMPN_CodigoCompania IsNot Nothing And cmbDivision.Division IsNot Nothing) Then
            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral
            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next


            objEntidad = New ENTIDADES.mantenimientos.ClaseGeneral
            objEntidad.CPLNDV = 0
            objEntidad.TPLNTA = "Todos"
            objLisEntidad.Insert(0, objEntidad)


            cboPlanta.DisplayMember = "TPLNTA"
            cboPlanta.ValueMember = "CPLNDV"
            Me.cboPlanta.DataSource = objLisEntidad

            If objLisEntidad.Count > 0 Then
                cboPlanta.SetItemChecked(0, True)
            End If


            'For i As Integer = 0 To cboPlanta.Items.Count - 1
            '    If cboPlanta.Items.Item(i).Value = "1" Then
            '        cboPlanta.SetItemChecked(i, True)
            '    End If
            'Next
            'If cboPlanta.Text = "" Then
            '    cboPlanta.SetItemChecked(0, True)
            'End If
            'If objLisEntidad.Count > 0 Then
            '  _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
            'Else
            '  _lstrTipoCuenta = ""
            'End If
            'bolBuscar = True
        End If
        'Catch ex As Exception
        'End Try
  End Sub

  Private Sub InicializarFormulario()
    gwdDatos.DataSource = Nothing
    ctlCliente.pClear()
    ctlCliente.CCMPN = cmbCompania.CCMPN_CodigoCompania
  End Sub

  Private Sub txtGuiaTransporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiaTransporte.KeyPress, txtNroOperacion.KeyPress
        'If e.KeyChar = "." Then
        '  e.Handled = True
        '  Exit Sub
        'End If
        'If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
        e.KeyChar = e.KeyChar.ToString.ToUpper
  End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Try
            Me.gwdDatos.DataSource = Nothing
            Dim PlantaSel As String = DevuelvePlantaSeleccionadas()
            If cboPlanta.CheckedItems.Count = 0 Or PlantaSel = "" Then
                MessageBox.Show("Seleccione planta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            ht = New Hashtable
            PrepararProceesWorked()
            bgwProceso.RunWorkerAsync()
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            ClearMemory()
        End Try
        Me.Cursor = Cursors.Default
    End Sub

  Private ht As New Hashtable

    Private Sub PrepararProceesWorked()
        'Try
        'Dim objcoleccion As New Collection
        Dim strCodPlanta As String = ""
        Dim strCodEstado As String = ""

        Dim oDt As New DataTable
        Me.Cursor = Cursors.WaitCursor
        Me.pbxProceso.Visible = True
        Me.lblProceso.Visible = True
        Me.lblProceso.Text = "Procesando..."
        oDt = ObtenerEstadosDocumento()
        ht.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
        ht.Add("CDVSN", cmbDivision.Division)
        'For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
        '  strCodPlanta += cboPlanta.CheckedItems(i).Value & ","
        'Next
        'If strCodPlanta.Trim.Length > 0 Then
        '  strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        'End If
        Dim PlantaSel As String = ""
        PlantaSel = DevuelvePlantaSeleccionadas()
        ht.Add("CPLNDV", PlantaSel)
        'ht.Add("CPLNDV", strCodPlanta)
        ht.Add("CCLNT", Convert.ToInt32(Me.ctlCliente.pCodigo))

        'ht.Add("FINCOP_IN", Format(dtpFechaInicio.Value, "yyyyMMdd"))
        'ht.Add("FINCOP_FI", Format(dtpFechaFin.Value, "yyyyMMdd"))

       


        For i As Integer = 0 To cboEstadoChk.CheckedItems.Count - 1
            If (cboEstadoChk.CheckedItems(i).Value <> "1") Then
                For j As Integer = 0 To oDt.Rows.Count - 1
                    If (oDt.Rows(j).Item("VALUE") = cboEstadoChk.CheckedItems(i).Value) Then
                        If cboEstadoChk.CheckedItems(i).Value = "2" Then

                            strCodEstado += oDt.Rows(j).Item("VALUES_STRING") & "," & "-,"
                        Else
                            strCodEstado += oDt.Rows(j).Item("VALUES_STRING") & ","
                        End If

                    End If
                Next
            Else
                strCodEstado = "T,"
                Exit For
            End If
        Next
        If strCodEstado.Trim.Length > 0 Then
            strCodEstado = strCodEstado.Trim.Substring(0, strCodEstado.Trim.Length - 1)
        End If

        ht.Add("ESTADO", strCodEstado)


        If Val(txtNroOperacion.Text.Trim) > 0 Or txtGuiaTransporte.Text.Trim.Length > 0 Then
            ht("NOPRCN") = Val(Me.txtNroOperacion.Text.Trim)
            ht("NGUITR") = Me.txtGuiaTransporte.Text.Trim.ToUpper

            ht("FINCOP_IN") = 0
            ht("FINCOP_FI") = 0

        Else
            ht("NOPRCN") = 0
            ht("NGUITR") = ""

            ht("FINCOP_IN") = Format(dtpFechaInicio.Value, "yyyyMMdd")
            ht("FINCOP_FI") = Format(dtpFechaFin.Value, "yyyyMMdd")

        End If

 
        'If Me.txtNroOperacion.Text.Trim.Equals("") Then
        '    ht.Add("NOPRCN", 0)

        '    ht("FINCOP_IN") = Format(dtpFechaInicio.Value, "yyyyMMdd")
        '    ht("FINCOP_FI") = Format(dtpFechaFin.Value, "yyyyMMdd")

        'Else
        '    ht.Add("NOPRCN", Convert.ToInt64(Me.txtNroOperacion.Text.Trim))

        '    ht("FINCOP_IN") = 0
        '    ht("FINCOP_FI") = 0

        'End If


        'If Me.txtGuiaTransporte.Text.Trim.Equals("") Then
        '    'ht.Add("NGUITR", 0)
        '    ht.Add("NGUITR", "")

        '    ht("FINCOP_IN") = Format(dtpFechaInicio.Value, "yyyyMMdd")
        '    ht("FINCOP_FI") = Format(dtpFechaFin.Value, "yyyyMMdd")

        'Else
        '    'ht.Add("NGUITR", Convert.ToInt64(Me.txtGuiaTransporte.Text.Trim))
        '    ht.Add("NGUITR", Me.txtGuiaTransporte.Text.Trim.ToUpper)


        '    ht("FINCOP_IN") = 0
        '    ht("FINCOP_FI") = 0

        'End If


        ht.Add("CMEDTR", Me.cboMedioTransporteFiltro.SelectedValue)

        ht.Add("CULUSA", "")
        ht.Add("ESTADO_OPER", ObtenerEstadoOperacion())
        ht.Add("VARCON", intValorCon)




    End Sub

  Private Sub bgwProceso_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProceso.DoWork
    Try
      Dim objLogicaReportes As New ReportesVariados_BLL
      e.Result = objLogicaReportes.Lista_Operaciones_Seguimiento_Administrativo(ht)
    Catch ex As Exception
      HelpClass.MsgBox(ex.Message, MessageBoxIcon.Information)
    End Try

  End Sub

  Private Sub bgwProceso_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProceso.RunWorkerCompleted
    Try
      Dim dtreporte As New DataTable
      dtreporte = CType(e.Result, DataTable)
      If dtreporte Is Nothing Then Exit Try

      If dtreporte.Rows.Count > 0 Then dtreporte.TableName = "dtmovOperaciones"
      Me.gwdDatos.DataSource = dtreporte
    Catch ex As Exception
      ClearMemory()
    End Try
    Me.lblProceso.Text = "Finalizado..."
    Me.pbxProceso.Visible = False
    Me.lblProceso.Visible = False
  End Sub

    Private Sub btnAsignarArea_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAsignarArea.Click
        Try
            'Dim objDataTable As New DataTable
            'Dim strCadenaOperacion As String = Me.Lista_Operaciones_Realizar_Pase(objDataTable)
            'If strCadenaOperacion.Trim = "" Then
            '    HelpClass.MsgBox("Seleccionar Operaciones para realizar pase", MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            'Dim frmRealizarPase As New frmAsignarArea
            'With frmRealizarPase
            '    .CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            '    .NOPRCN = strCadenaOperacion
            '    .Tag = Me.cmbCompania.CCMPN_Descripcion.Trim
            '    .Table = objDataTable
            '    If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            '    Me.btnProcesarReporte_Click(Nothing, Nothing)
            'End With

            Dim ofrm As New frmGestionDocumentos
            Dim strCodPlanta As String = String.Empty
            With ofrm
                .MdiParent = Me.Parent.Parent
                .Compania = cmbCompania.CCMPN_CodigoCompania
                .CompaniaDescripcion = cmbCompania.CCMPN_Descripcion
                .Division = cmbDivision.Division
                For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
                    strCodPlanta += cboPlanta.CheckedItems(i).Value & ","
                Next
                If strCodPlanta.Trim.Length > 0 Then
                    strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
                End If
                .CodPlanta = strCodPlanta
                .WindowState = FormWindowState.Normal
                .Show()
                'If .ShowDialog = Windows.Forms.DialogResult.Yes Then
                '  Call btnProcesarReporte_Click(Nothing, Nothing)
                'End If
            End With

            'If ofrm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            '  Call btnProcesarReporte_Click(Nothing, Nothing)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    'Private Function ObtenerPlanta() As String
    '  Dim strCodPlanta As String = String.Empty
    '  For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
    '    strCodPlanta += cboPlanta.CheckedItems(i).Value & ","
    '  Next
    '  If strCodPlanta.Trim.Length > 0 Then
    '    strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
    '  End If
    '  Return strCodPlanta
    'End Function

  Private Function Lista_Operaciones_Realizar_Pase(ByRef objDataTable As DataTable) As String
    Dim strCadenaOperacion As String = ""
    Dim objDataRow As DataRow
    objDataTable.Columns.Add("NOPRCN")
    objDataTable.Columns.Add("FINCOP")
    objDataTable.Columns.Add("TCMPCL")
    objDataTable.Columns.Add("NGUITR")
    Me.gwdDatos.CommitEdit(DataGridViewDataErrorContexts.Commit)
    For lintCount As Integer = 0 To Me.gwdDatos.RowCount - 1
      objDataRow = objDataTable.NewRow
      If Me.gwdDatos.Item(0, lintCount).Value = True Then
        strCadenaOperacion += Me.gwdDatos.Item("NOPRCN", lintCount).Value.ToString.Trim & ","
        objDataRow("NOPRCN") = Me.gwdDatos.Item("NOPRCN", lintCount).Value
        objDataRow("FINCOP") = Me.gwdDatos.Item("FINCOP", lintCount).Value
        objDataRow("TCMPCL") = Me.gwdDatos.Item("TCMPCL", lintCount).Value
        objDataRow("NGUITR") = Me.gwdDatos.Item("NGUITR", lintCount).Value
        objDataTable.Rows.Add(objDataRow)
      End If
    Next
    If strCadenaOperacion.Trim <> "" Then
      strCadenaOperacion = strCadenaOperacion.Trim.Substring(0, strCadenaOperacion.Trim.Length - 1)
    End If

    Return strCadenaOperacion
  End Function

    Private Sub gwdDatos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
        Try
            If e.RowIndex = -1 And e.ColumnIndex = 0 Then
                If Me.gwdDatos.RowCount = 0 Then Exit Sub
                Dim lintEstado As Boolean = Me.gwdDatos.Item(0, 0).Value
                For lint_Contador As Integer = 0 To Me.gwdDatos.RowCount - 1
                    Me.gwdDatos.Item(0, lint_Contador).Value = Not lintEstado
                    Me.gwdDatos.EndEdit()
                Next
            End If

            If gwdDatos.Columns(e.ColumnIndex).Name = "imgSeg" Then
                Dim ofrm As New frmEstadoDocumento
                If gwdDatos.CurrentRow.Cells("SESTTP").Value Is String.Empty Then Exit Sub

                ofrm.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN").Value
                ofrm.lblCliente.Text = gwdDatos.CurrentRow.Cells("TCMPCL").Value
                ofrm.lblNumero.Text = gwdDatos.CurrentRow.Cells("NOPRCN").Value

                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try
            'ExportarExcel()
            If Me.gwdDatos.RowCount = 0 Then Exit Sub

            Dim dtg As New DataGridView
            dtg = gwdDatos

            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)


            strlTitulo = "Seguimiento de Administración por Operación"

            strlFiltros.Add("Compañia : \n" & cmbCompania.CCMPN_Descripcion)
            strlFiltros.Add("División : \n" & cmbDivision.DivisionDescripcion)
            strlFiltros.Add("Planta : \n" & cboPlanta.Text)
            strlFiltros.Add("Cliente :\n" & IIf(ctlCliente.pCodigo = 0, "TODOS", ctlCliente.pCodigo & " - " & ctlCliente.pRazonSocial))
            strlFiltros.Add("Medio de transporte : \n" & cboMedioTransporteFiltro.SelectedText)
            strlFiltros.Add("Estado : \n" & cboEstadoChk.Text)
            strlFiltros.Add("Operación : \n" & txtNroOperacion.Text)
            strlFiltros.Add("Guía Tranporte : \n" & txtGuiaTransporte.Text)
            strlFiltros.Add("Fecha : \n" & dtpFechaInicio.Value.ToShortDateString & " al " & dtpFechaFin.Value.ToShortDateString)

            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtg, strlTitulo, strlFiltros)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub ExportarExcel()

    '  If Me.gwdDatos.RowCount = 0 Then Exit Sub

    '  Dim dtg As New DataGridView
    '  dtg = gwdDatos

    '  Dim strlTitulo As String
    '  Dim strlFiltros As New List(Of String)


    '  strlTitulo = "Seguimiento de Administración por Operación"

    '  strlFiltros.Add("Compañia : \n" & cmbCompania.CCMPN_Descripcion)
    '  strlFiltros.Add("División : \n" & cmbDivision.DivisionDescripcion)
    '  strlFiltros.Add("Planta : \n" & cboPlanta.Text)
    '  strlFiltros.Add("Cliente :\n" & IIf(ctlCliente.pCodigo = 0, "TODOS", ctlCliente.pCodigo & " - " & ctlCliente.pRazonSocial))
    '  strlFiltros.Add("Medio de transporte : \n" & cboMedioTransporteFiltro.SelectedText)
    '  strlFiltros.Add("Estado : \n" & cboEstadoChk.Text)
    '  strlFiltros.Add("Operación : \n" & txtNroOperacion.Text)
    '  strlFiltros.Add("Guía Tranporte : \n" & txtGuiaTransporte.Text)
    '  strlFiltros.Add("Fecha : \n" & dtpFechaInicio.Value.ToShortDateString & " al " & dtpFechaFin.Value.ToShortDateString)

    '  Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtg, strlTitulo, strlFiltros)

    'End Sub

  Private Sub gwdDatos_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellMouseEnter

    Dim markingUnderMouse As Bitmap = Nothing
    Try
      markingUnderMouse = CType(gwdDatos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Bitmap)
    Catch : End Try

    If markingUnderMouse Is Nothing Then gwdDatos.Cursor = Cursors.Default Else gwdDatos.Cursor = Cursors.Hand

    End Sub

    Private Function DevuelvePlantaSeleccionadas() As String
        Dim CodPlanta As String = ""
        Dim strCodPlanta As String = ""
        Dim PlantaTodos As Boolean = False
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            CodPlanta = cboPlanta.CheckedItems(i).Value.ToString.Trim
            If CodPlanta = "0" Then
                PlantaTodos = True
                Exit For
            End If
            strCodPlanta = strCodPlanta & CodPlanta & ","
        Next
        If PlantaTodos = True Then
            strCodPlanta = ""
            For i As Integer = 1 To cboPlanta.Items.Count - 1
                strCodPlanta = strCodPlanta & cboPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        Return strCodPlanta
    End Function

End Class

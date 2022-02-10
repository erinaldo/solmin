Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmFiltroOperacion

  Public compania As String
  Public Division As String
  Public oDtOperaciones As DataTable
  Private ht As New Hashtable
  Private Marcar As Image
  Private Desmarcar As Image

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar_.Click
        Try
            DialogResult = Windows.Forms.DialogResult.Yes
            Dim dr As DataRow
            oDtOperaciones = dtgDocumentos.DataSource.Clone
            dtgDocumentos.CommitEdit(DataGridViewDataErrorContexts.Commit)
            For i As Integer = 0 To dtgDocumentos.Rows.Count - 1
                If CType(dtgDocumentos.Rows(i).Cells("chkSel").Value, Boolean) Then
                    dr = oDtOperaciones.NewRow
                    dr("NOPRCN") = dtgDocumentos.Rows(i).Cells("NOPRCN").Value
                    dr("FINCOP") = dtgDocumentos.Rows(i).Cells("FINCOP").Value
                    dr("TCMPCL") = dtgDocumentos.Rows(i).Cells("TCMPCL").Value
                    dr("NGUITR") = dtgDocumentos.Rows(i).Cells("NGUITR").Value

                    dr("NGUITS") = dtgDocumentos.Rows(i).Cells("NGUITS").Value

                    dr("SESTTP") = dtgDocumentos.Rows(i).Cells("SESTTP").Value

                    dr("NMRGIM_O") = dtgDocumentos.Rows(i).Cells("NMRGIM_O").Value
                    dr("NMRGIM_S") = dtgDocumentos.Rows(i).Cells("NMRGIM_S").Value
                    dr("NMRGIM_IMG") = dtgDocumentos.Rows(i).Cells("NMRGIM_IMG").Value
                    dr("NCSOTR") = dtgDocumentos.Rows(i).Cells("NCSOTR").Value

                    oDtOperaciones.Rows.Add(dr)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub frmFiltroOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Marcar = btnMarcarItems.BackgroundImage
            Desmarcar = btnMarcarItems.Image

            Me.Carga_MedioTransporte()
            Me.Cargar_Estado()
            ctlCliente.CCMPN = compania
            Cargar_Planta()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub Carga_MedioTransporte()
    Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
    Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(compania)
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
    dt = ObtenerEstadosOperacion()
    Me.cboEstadoChk.DisplayMember = "ESTADO_NOPRCN"
    Me.cboEstadoChk.ValueMember = "VALUE"
    Me.cboEstadoChk.DataSource = dt

    For i As Integer = 0 To cboEstadoChk.Items.Count - 1
      If cboEstadoChk.Items.Item(i).Value = "1" Then
        cboEstadoChk.SetItemChecked(i, True)
      End If
    Next

  End Sub

  Private Function ObtenerEstadosOperacion() As DataTable
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
    'oDr.Item(2) = "TO"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "2"
    oDr.Item(1) = "GENERADO"
    oDr.Item(2) = 0
    oDr.Item(3) = "G"
    'oDr.Item(2) = "PE"
    oDt.Rows.Add(oDr)


    oDr = oDt.NewRow
    oDr.Item(0) = "3"
    oDr.Item(1) = "OPERACIONES"
    oDr.Item(2) = 0
    oDr.Item(3) = "O"
    'oDr.Item(2) = "PE"
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


  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_.Click
        Try
            Dim strCodPlanta As String = ""
            strCodPlanta = DevuelvePlantaSeleccionadas()

            If cboPlanta.CheckedItems.Count = 0 Or strCodPlanta = "" Then
                MessageBox.Show("Seleccione planta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ht = New Hashtable
            Dim objLogicaReportes As New ReportesVariados_BLL
            ObtenerFiltros()
            dtgDocumentos.AutoGenerateColumns = False
            dtgDocumentos.DataSource = objLogicaReportes.Lista_Operaciones_Seguimiento_Administrativo(ht)
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message, MessageBoxIcon.Information)
        End Try
  End Sub

  Private Sub ObtenerFiltros()

    Dim strCodPlanta As String = ""
    Dim strCodEstado As String = ""
    Dim intValorCon As Int32 = 0
    Dim oDt As New DataTable
        'Dim PlantaSel As String = ""

    oDt = ObtenerEstadosOperacion()
    ht.Add("CCMPN", compania)
    ht.Add("CDVSN", Division)

        '    For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
        '        strCodPlanta += cboPlanta.CheckedItems(i).Value & ","
        '    Next
        'If strCodPlanta.Trim.Length > 0 Then
        '  strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        '    End If
        strCodPlanta = DevuelvePlantaSeleccionadas()

    ht.Add("CPLNDV", strCodPlanta)
    ht.Add("CCLNT", Convert.ToInt32(Me.ctlCliente.pCodigo))
    ht.Add("FINCOP_IN", Format(dtpFechaInicio.Value, "yyyyMMdd"))
    ht.Add("FINCOP_FI", Format(dtpFechaFin.Value, "yyyyMMdd"))
    For i As Integer = 0 To cboEstadoChk.CheckedItems.Count - 1
      If (cboEstadoChk.CheckedItems(i).Value <> "1") Then
        For j As Integer = 0 To oDt.Rows.Count - 1
          If (oDt.Rows(j).Item("VALUE") = cboEstadoChk.CheckedItems(i).Value) Then
            Select Case cboEstadoChk.CheckedItems(i).Value
              Case 4
                intValorCon = 1
              Case 5
                intValorCon = 2
            End Select
            strCodEstado += oDt.Rows(j).Item("VALUES_STRING") & ","
          End If
        Next
      Else
        If (cboEstadoChk.CheckedItems.Count = 1) Then
          strCodEstado = "T,"
        End If
      End If
    Next
    If strCodEstado.Trim.Length > 0 Then
      strCodEstado = strCodEstado.Trim.Substring(0, strCodEstado.Trim.Length - 1)
    End If

    ht.Add("ESTADO", strCodEstado)
    If Me.txtNroOperacion.Text.Trim.Equals("") Then
      ht.Add("NOPRCN", 0)
    Else
      ht.Add("NOPRCN", Convert.ToInt64(Me.txtNroOperacion.Text.Trim))
    End If
    If Me.txtGuiaTransporte.Text.Trim.Equals("") Then
            'ht.Add("NGUITR", 0)
            ht.Add("NGUITR", "")
    Else
            'ht.Add("NGUITR", Convert.ToInt64(Me.txtGuiaTransporte.Text.Trim))
            ht.Add("NGUITR", txtGuiaTransporte.Text.Trim.ToUpper)
    End If
    ht.Add("CMEDTR", Me.cboMedioTransporteFiltro.SelectedValue)
    ht.Add("CULUSA", ConfigurationWizard.UserName)

    ht.Add("ESTADO_OPER", "T")
    ht.Add("VARCON", 0)


  End Sub

  Private Sub Cargar_Planta()
    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    Dim objLogica As New NEGOCIO.Planta_BLL
    cboPlanta.Text = ""
        'Try

        If (compania IsNot Nothing And Division IsNot Nothing) Then
            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(compania, Division)
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

        End If
        'Catch ex As Exception
        '    End Try
  End Sub

  Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            dtgDocumentos.Columns("chkSel").ReadOnly = True
            If dtgDocumentos.RowCount > 0 Then
                If Existe_Check() Then
                    Poner_Check_Todo_OC(False)
                    btnMarcarItems.Image = Desmarcar
                Else

                    Poner_Check_Todo_OC(True)
                    btnMarcarItems.Image = Marcar

                End If
            End If

            Me.dtgDocumentos.EndEdit()
            dtgDocumentos.Columns("chkSel").ReadOnly = False
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   

  End Sub

  Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)

    Dim intCont As Integer
    For intCont = 0 To dtgDocumentos.RowCount - 1
      dtgDocumentos.Rows(intCont).Cells("chkSel").Value = blnEstado
    Next intCont

  End Sub

  Private Function Existe_Check() As Boolean
    Dim intCont As Integer
    For intCont = 0 To dtgDocumentos.Rows.Count - 1
      If dtgDocumentos.Rows(intCont).Cells("chkSel").Value = True Then
        Return True
      End If
    Next
    Return False
    End Function

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

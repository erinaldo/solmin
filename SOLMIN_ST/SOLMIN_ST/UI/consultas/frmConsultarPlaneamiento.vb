Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmConsultarPlaneamiento

    Private Sub frmConsultarPlaneamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Cargar_Combos()
      cboEstado.SelectedItem = "A"
      gwdDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    Catch : End Try

  End Sub

    Private Sub Cargar_Combos()
        cargarCompania()
        cargarDivision()
        cargarPlanta()
    End Sub

    Private Sub cargarCompania()
        Dim objLogica As New NEGOCIO.Compania_BLL
        objLogica.Crea_Lista()
        cboCia.DataSource = objLogica.Lista
        cboCia.ValueMember = "CCMPN"
        cboCia.DisplayMember = "TCMPCM"
    cboCia.SelectedIndex = 0
    End Sub

    Private Sub cargarDivision()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim objLogica As New NEGOCIO.Division_BLL
            objLogica.Crea_Lista()
            cboDivision.DataSource = objLogica.Lista_Division(cboCia.SelectedValue.ToString.Trim)
            cboDivision.ValueMember = "CDVSN"
            cboDivision.DisplayMember = "TCMPDV"
      cboDivision.SelectedIndex = 0
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cargarPlanta()
        Try
            Dim objLogica As New NEGOCIO.Planta_BLL
            objLogica.Crea_Lista()
            cboPlanta.DataSource = objLogica.Lista_Planta(cboCia.SelectedValue.ToString.Trim, cboDivision.SelectedValue.ToString.Trim)
            cboPlanta.ValueMember = "CPLNDV"
            cboPlanta.DisplayMember = "TPLNTA"
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cboCia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCia.SelectedIndexChanged
        cargarDivision()
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
        cargarPlanta()
    End Sub

    Private Sub btnProcesarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarReporte.Click
        Dim dstreporte As New DataSet
        dstreporte = Me.Datos_Reporte_Planeamiento()
        If dstreporte Is Nothing Then
            Exit Sub
        End If
        If dstreporte.Tables.Count > 0 Then
            gwdDatos.DataSource = dstreporte.Tables(0)
        End If
    End Sub

    Private Sub Generar_Reporte_Crystal()
        Dim dstreporte As New DataSet
        dstreporte = Me.Datos_Reporte_Planeamiento()
        If dstreporte Is Nothing Then
            Exit Sub
        End If
        Try
            Dim objPrintForm = New PrintForm
            Dim objReporte As New rptPlanamiento
            HelpClass.CrystalReportTextObject(objReporte, "lblCliente", Me.txtCliente.pRazonSocial)
            HelpClass.CrystalReportTextObject(objReporte, "lblCompania", Me.cboCia.Text.Trim)
            HelpClass.CrystalReportTextObject(objReporte, "lblDivision", Me.cboDivision.Text.Trim)
            HelpClass.CrystalReportTextObject(objReporte, "lblPlanta", Me.cboPlanta.Text.Trim)
            objReporte.SetDataSource(dstreporte)
            objPrintForm.ShowForm(objReporte, Me)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            ClearMemory()
        End Try
    End Sub

    Private Function Datos_Reporte_Planeamiento() As DataSet
        Dim objEntidad As New Planeamiento
        Dim objPlaneamiento As New Planeamiento_BLL
        Dim dstReporte As New DataSet
        Dim validacion As String = ""

        If Me.txtNroPlaneamiento.Text.Equals("") = True Then

            If Me.txtCliente.pCodigo.Equals("") = True Then
                validacion += "Debe de seleccionar un cliente " & Chr(13)
            End If
          
        Else
            If IsNumeric(Me.txtNroPlaneamiento.Text) = False Then
                validacion += "Debe de ingresar el número de planeamiento"
            End If
        End If

        If validacion.Equals("") = False Then
            HelpClass.MsgBox(validacion)
            Return Nothing
        End If

        If Me.txtNroPlaneamiento.Text.Equals("") = True Then
            objEntidad.CCMPN = Me.cboCia.SelectedValue
            objEntidad.CDVSN = Me.cboDivision.SelectedValue
            objEntidad.CPLNDV = Me.cboPlanta.SelectedValue
            objEntidad.CCLNT = CInt(Me.txtCliente.pCodigo)
            objEntidad.SESPLN = IIf(Me.cboEstado.SelectedIndex = 0, "A", "P")
        Else
            objEntidad.NPLNMT = Me.txtNroPlaneamiento.Text
        End If

        If Me.txtNroPlaneamiento.Text.Equals("") Then
            dstReporte = objPlaneamiento.Listado_Planeamiento(objEntidad, HelpClass.CtypeDate(Me.dtpFechaInicioPlaneamiento.Text), HelpClass.CtypeDate(Me.dtpFechaFinPlaneamiento.Text))
        Else
            dstReporte = objPlaneamiento.Listado_Planeamiento_Filtro(objEntidad)
        End If

        Return dstReporte

    End Function

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Generar_Reporte_Crystal()
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim objListDtg As New List(Of DataGridView)
        objListDtg.Add(Me.gwdDatos)
        HelpClass.ExportarExcel_HTML(objListDtg)
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        If gwdDatos.Rows.Count > 0 Then
            For i As Integer = 0 To gwdDatos.Columns.Count - 1
                Select Case gwdDatos.Columns(i).Name
                    Case "NPLNMT"
                        gwdDatos.Columns(i).HeaderText = "NUMERO_PLANEAMIENTO"
                    Case "CCLNT"
                        gwdDatos.Columns(i).HeaderText = "CLIENTE"
                    Case "FINCPL"
                        gwdDatos.Columns(i).HeaderText = "FECHA_INICIO_PLANEAMIENTO"
                    Case "TDSCPL"
                        gwdDatos.Columns(i).HeaderText = "DESCRIPCION_PLANEAMIENTO"
                    Case "CCMPN"
                        gwdDatos.Columns(i).HeaderText = "CIA"
                    Case "CDVSN"
                        gwdDatos.Columns(i).HeaderText = "DIVISION"
                    Case "CPLNDV"
                        gwdDatos.Columns(i).HeaderText = "PLANTA"
                End Select
            Next
        End If
    End Sub

End Class
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Public Class frmOrdenesParaGastosAdministrativos
    Private obs As New BindingSource
    Private bolBuscar As Boolean = False
    Private Sub ProcesarReporte()
        Dim dstreporte As New DataSet
        gwdDatos.DataSource = Nothing
        dstreporte = Me.Lista_Ordenes_Servicio()
        If (dstreporte IsNot Nothing) Then
            obs.DataSource = dstreporte.Tables(0)
            gwdDatos.DataSource = obs
            If (gwdDatos.Rows.Count > 0) Then
                Me.gwdDatos.Rows(0).Selected = False
            End If
        End If
    End Sub
    Private Function Lista_Ordenes_Servicio() As DataSet
        Dim dstReporte As New DataSet
        Try
            Dim objEntidad As New ReporteListadoTarifas
            Dim objReporte As New Reportes_BLL
            objEntidad.CCMPN = Me.cboCia.SelectedValue
            objEntidad.CDVSN = Me.cboDivision.SelectedValue
            objEntidad.CPLNDV = CType(Me.cboPlanta.SelectedValue.ToString.Trim, Integer)

            If Me.ctlCliente.pCodigo.Equals("") = True Then
                objEntidad.CCLNT = 0
            Else
                objEntidad.CCLNT = CInt(Me.ctlCliente.pCodigo)
            End If

            'estado servicio
            If Me.cboEstado.SelectedIndex = 0 Then
                objEntidad.SESTOS = "P"
            ElseIf Me.cboEstado.SelectedIndex = 1 Then
                objEntidad.SESTOS = "C"
            Else
                objEntidad.SESTOS = ""
            End If

            'Unidad Vehicular
            dstReporte = objReporte.Listado_Ordenes_ServicioxCliente(objEntidad)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
            dstReporte = Nothing
        End Try
        Return dstReporte
    End Function

    Private Sub frmOrdenesParaGastosAdministrativos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Alinear_Columnas_Grilla()
      Cargar_Combos()
      cboEstado.SelectedItem = "Pendiente"

      gwdDatos.AutoGenerateColumns = False
      gwdatosOperaciones.AutoGenerateColumns = False

      lblProceso.Visible = False
      pbxProceso.Visible = False
      ctlCliente.pCargar(213)
      ctlCliente.Enabled = False
    Catch : End Try
  End Sub
    Private Sub Cargar_Combos()
        cargarComboCompania()
        cargarComboDivision()
        cargarComboPlanta()
        cargarComboEstado()
    End Sub
    Private Sub cargarComboEstado()
        Dim oDt As New DataTable
        Dim oDr As DataRow
        oDt.Columns.Add("COD")
        oDt.Columns.Add("DES")

        oDr = oDt.NewRow

        oDr.Item(0) = "0"
        oDr.Item(1) = "Pendiente"

        oDt.Rows.Add(oDr)
        oDr = oDt.NewRow
        oDr.Item(0) = "1"
        oDr.Item(1) = "Cerrado"
        oDt.Rows.Add(oDr)


        Me.cboEstado.DataSource = oDt
        Me.cboEstado.ValueMember = "COD"
        Me.cboEstado.DisplayMember = "DES"



    End Sub
    Private Sub cargarComboCompania()
        Dim objLogica As New NEGOCIO.Compania_BLL
        bolBuscar = False
        objLogica.Crea_Lista()
        cboCia.DataSource = objLogica.Lista
        cboCia.ValueMember = "CCMPN"
        cboCia.DisplayMember = "TCMPCM"
        bolBuscar = True

        'cboCia.SelectedIndex = 0
        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cboCia, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub

    Private Sub cargarComboDivision()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim objLogica As New NEGOCIO.Division_BLL
            bolBuscar = False
            objLogica.Crea_Lista()
            cboDivision.DataSource = objLogica.Lista_Division(cboCia.SelectedValue.ToString.Trim)
            cboDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cboDivision.DisplayMember = "TCMPDV"
            Me.cboDivision.SelectedValue = "T"
            If Me.cboDivision.SelectedIndex = -1 Then
                Me.cboDivision.SelectedIndex = 0
            End If
            cboDivision_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cargarComboPlanta()
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
        If bolBuscar = True Then
            cargarComboDivision()
        End If
    End Sub

    Private Sub cboDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDivision.SelectedIndexChanged
        If bolBuscar = True Then
            cargarComboPlanta()
        End If
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        For lint_contador As Integer = 0 To Me.gwdatosOperaciones.ColumnCount - 1
            Me.gwdatosOperaciones.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub gwdatosOperaciones_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdatosOperaciones.CellDoubleClick
        Dim ofrmPLaneamientoxOperacion As New frmGastosAdminDetOperaciones()
        Dim strTRFMRC As String = ""
        Dim oPlaneamientoBE As New Planeamiento()
        Dim numPlaneamiento As String = ""
        Dim lint_indiceOperacion As Integer = Me.gwdatosOperaciones.CurrentCellAddress.Y
        Try
            If Me.gwdatosOperaciones.RowCount = 0 Then Exit Sub
            If e.RowIndex < 0 Then Exit Sub
            If e.ColumnIndex = 5 Then
                strTRFMRC = Me.gwdatosOperaciones.Item("TRFMRC", lint_indiceOperacion).Value.ToString().Trim()
                oPlaneamientoBE.NPLNMT = Me.gwdatosOperaciones.Item("NPLNMT", lint_indiceOperacion).Value.ToString().Trim()
                oPlaneamientoBE.NORSRT = Me.gwdatosOperaciones.Item("NORSRT_DETALLE", lint_indiceOperacion).Value.ToString().Trim()
                oPlaneamientoBE.NOPRCN = Me.gwdatosOperaciones.Item("NOPRCN", lint_indiceOperacion).Value.ToString().Trim()
                oPlaneamientoBE.CCMPN = cboCia.SelectedValue.ToString()
                oPlaneamientoBE.CDVSN = cboDivision.SelectedValue.ToString()
                oPlaneamientoBE.CPLNDV = Convert.ToDouble(cboPlanta.SelectedValue)
                ofrmPLaneamientoxOperacion.ShowForm(oPlaneamientoBE, strTRFMRC, Me)


            End If
        Catch : End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Me.Cursor = Cursors.WaitCursor
        If (gwdDatos.Rows.Count > 0) Then
            gwdDatos.DataSource = Nothing
        End If
        If (gwdatosOperaciones.Rows.Count > 0) Then
            gwdatosOperaciones.DataSource = Nothing
        End If

        Try
            ProcesarReporte()
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
        Me.Cursor = Cursors.Default




    End Sub


    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

        Dim lint_indiceGDatos = Me.gwdDatos.CurrentCellAddress.Y
        If (gwdatosOperaciones.Rows.Count > 0) Then
            gwdatosOperaciones.DataSource = Nothing
        End If
        Try
            Dim objReporte As New Reportes_BLL
            Dim numOS = ""
            If Me.gwdDatos.CurrentRow.Index < 0 OrElse lint_indiceGDatos < 0 Then
                Exit Sub
            End If
            numOS = Me.gwdDatos.Item("NORSRT", lint_indiceGDatos).Value.ToString().Trim()
            gwdatosOperaciones.DataSource = objReporte.Lista_Detalle_Operaciones_X_OS(numOS.ToString().Trim()).Tables(0)
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try
    End Sub
End Class

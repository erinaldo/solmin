Imports System.Windows.Forms
Imports System.Drawing
Imports Ransa.Utilitario

Public Class ucAprobarOrdenServicio

    Private _pUsuario As String = ""
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _pSystem_Prefix As String = ""
    Public Property pSystem_Prefix() As String
        Get
            Return _pSystem_Prefix
        End Get
        Set(ByVal value As String)
            _pSystem_Prefix = value
        End Set
    End Property

    Private _pNameFormulario As String = ""
    Public Property pNameFormulario() As String
        Get
            Return _pNameFormulario
        End Get
        Set(ByVal value As String)
            _pNameFormulario = value
        End Set
    End Property

    'pNameFormulario

    Private pTipo_Cambio As Decimal = 0D

    'Private Sub ckbRangoFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbRangoFechas.CheckedChanged

    '    Try
    '        ' txtCotizacion.Enabled = Not ckbRangoFechas.Checked
    '        txtOS.Enabled = Not ckbRangoFechas.Checked
    '        dtpFechaInicio.Enabled = ckbRangoFechas.Checked
    '        dtpFechaFin.Enabled = ckbRangoFechas.Checked

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub Cargar_Compania()
        cboCompania.Usuario = _pUsuario
        cboCompania.pActualizar()
        cboCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Sub pInicializar()
        Cargar_Compania()
        Cargar_Tipo_Cambio()
        Validar_Usuario_Autoridado()
    End Sub
    Private objEntidadAcceso As mantenimientos.ClaseGeneral
    Private Sub Validar_Usuario_Autoridado()
        Dim objParametro As New Hashtable
        Dim objLogica As New Acceso_Opciones_Usuario_BLL
        objEntidadAcceso = New mantenimientos.ClaseGeneral
        'objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCAPL", _pSystem_Prefix)
        objParametro.Add("MMCUSR", _pUsuario)
        objParametro.Add("MMNPVB", _pNameFormulario)
        'objParametro.Add("CCMPN", Me.cmbCompania.SelectedValue)
        objEntidadAcceso = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)
        If objEntidadAcceso.STSOP1 = "" Then
            btnAprobar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        End If
    End Sub



    Sub Cargar_Tipo_Cambio()

        Dim objNegocios As New ServicioMercaderia_BLL
        Dim obj As New Hashtable
        obj.Add("PSCCMPN", cboCompania.CCMPN_CodigoCompania)
        obj.Add("PNCMNDA1", 100)

        Dim DT As New DataTable
        DT = objNegocios.Lista_Tipo_Cambio_Actual(obj)
        If DT.Rows.Count > 0 Then
            pTipo_Cambio = CDec(DT.Rows(0)("IVNTA"))
        End If
        PanelFiltros.ValuesSecondary.Heading = "ÓRDENES DE SERVICIOS POR APROBAR  | Tipo de Cambio : " & pTipo_Cambio

    End Sub

    Private Sub cboCompania_SelectionChangeCommitted(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cboCompania.SelectionChangeCommitted
        Try

            cboDivision.Usuario = _pUsuario
            cboDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cboDivision.DivisionDefault = "T"
            cboDivision.pActualizar()

            Dim division As New Ransa.Controls.UbicacionPlanta.Division.beDivision
            division.CCMPN_CodigoCompania = obeCompania.CCMPN_CodigoCompania
            division.CDVSN_CodigoDivision = cboDivision.Division
            'cboDivision_SelectionChangeCommitted(division)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub cboDivision_SelectionChangeCommitted(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cboDivision.SelectionChangeCommitted
    '    Try

    '        Me.cboPlanta.Usuario = _pUsuario
    '        Me.cboPlanta.CodigoCompania = obeDivision.CCMPN_CodigoCompania
    '        Me.cboPlanta.CodigoDivision = obeDivision.CDVSN_CodigoDivision
    '        Me.cboPlanta.PlantaDefault = 1
    '        If Me.cboDivision.CDVSN_ANTERIOR <> Me.cboDivision.Division Then
    '            Me.cboPlanta.pActualizar()
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Lista_Cotizacione_Por_Aprobar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Lista_Cotizacione_Por_Aprobar()

        Me.dtgDetalleCotizacion.AutoGenerateColumns = False

        Dim objEntidad As New Hashtable
        Dim objNegocio As New DetalleCotizacion_BLL

        'If txtCliente.pCodigo = 0D Then
        '    MessageBox.Show(" Seleccione  cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        objEntidad.Add("PSCCMPN", cboCompania.CCMPN_CodigoCompania)
        objEntidad.Add("PSCDVSN", cboDivision.Division)
        'objEntidad.Add("PNCPLNDV", cboPlanta.Planta)
        objEntidad.Add("PNCPLNDV", 0)
        objEntidad.Add("PNCCLNT", txtCliente.pCodigo)
        objEntidad.Add("PNNCTZCN", 0)
        'objEntidad.Add("PNNCTZCN", CDec(Val(txtCotizacion.Text)))
        objEntidad.Add("PNNORSRT", CDec(Val(txtOS.Text)))
        'If Me.ckbRangoFechas.Checked Then
        '    objEntidad.Add("PNFCHCRT_INI", CDec(HelpClassST.CDate_a_Numero8Digitos(Me.dtpFechaInicio.Value)))
        '    objEntidad.Add("PNFCHCRT_FIN", CDec(HelpClassST.CDate_a_Numero8Digitos(Me.dtpFechaFin.Value)))
        'Else
        '    objEntidad.Add("PNFCHCRT_INI", 0)
        '    objEntidad.Add("PNFCHCRT_FIN", 0)
        'End If
        objEntidad.Add("PNFCHCRT_INI", 0)
        objEntidad.Add("PNFCHCRT_FIN", 0)
        Me.dtgDetalleCotizacion.DataSource = objNegocio.ListaCotizacionPorAprobar(objEntidad)
        If dtgDetalleCotizacion.Rows.Count <= 0 Then
            dtgServicioMercaderia.DataSource = Nothing
        End If
      

    End Sub

    Private Sub txtOS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOS.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    End Sub

    'Private Sub txtCotizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    'End Sub

    Private Sub dtgDetalleCotizacion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgDetalleCotizacion.SelectionChanged
        Try
            If Me.dtgDetalleCotizacion.CurrentCellAddress.Y = -1 Then Exit Sub

            Dim bs As New BindingSource
            Dim objNegocios As New ServicioMercaderia_BLL
            Dim objEntidad As New Hashtable
            objEntidad.Add("NCTZCN", Me.dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN").Value)
            objEntidad.Add("NCRRCT", Me.dtgDetalleCotizacion.CurrentRow.Cells("NCRRCT").Value)
            objEntidad.Add("CCMPN", cboCompania.CCMPN_CodigoCompania)
            dtgServicioMercaderia.AutoGenerateColumns = False
            dtgServicioMercaderia.DataSource = objNegocios.ListaServicioMercaderia_Aprobacion(objEntidad, Me.dtgDetalleCotizacion.CurrentRow.Cells("MARGEN").Value)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgServicioMercaderia_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgServicioMercaderia.DataBindingComplete
        Try

            Dim myfont As Font
            myfont = New Font(dtgServicioMercaderia.Font, FontStyle.Bold)

            For index As Integer = 0 To dtgServicioMercaderia.Rows.Count - 1
                If dtgServicioMercaderia.Item("MARCA", index).Value = "X" Then
                    dtgServicioMercaderia.Item("NCRRSR", index).Style.Font = myfont
                    dtgServicioMercaderia.Item("NCRRSR", index).Style.ForeColor = Color.Red
                    dtgServicioMercaderia.Item("MARGENPOR", index).Style.Font = myfont
                    dtgServicioMercaderia.Item("MARGENPOR", index).Style.ForeColor = Color.Red
                    dtgServicioMercaderia.Item("DIFSOLES", index).Style.Font = myfont
                    dtgServicioMercaderia.Item("DIFSOLES", index).Style.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click

        Try
            Dim obeOrdenServicio As New Operaciones.OrdenServicioTransporte
            Dim objOrdenServicio As New Operaciones.OrdenServicio_BLL
            If dtgDetalleCotizacion.CurrentRow Is Nothing Then
                MessageBox.Show("No existe información", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            If pTipo_Cambio = 0 Then
                MessageBox.Show("No existe tipo cambio a la fecha", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim Nro_O_S As Decimal = 0
            Nro_O_S = dtgDetalleCotizacion.CurrentRow.Cells("NORSRT").Value

            If MessageBox.Show("Está seguro de aprobar la O/S N°: " & Nro_O_S, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                obeOrdenServicio = New Operaciones.OrdenServicioTransporte
                obeOrdenServicio.CCMPN = ("" & dtgDetalleCotizacion.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                'obeOrdenServicio.NCTZCN = dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN").Value
                obeOrdenServicio.NORSRT = dtgDetalleCotizacion.CurrentRow.Cells("NORSRT").Value
                obeOrdenServicio.SESTOS = "P" ' ESTADO POR CONFIRMAR(EN BLANCO)
                obeOrdenServicio.CULUSA = _pUsuario
                obeOrdenServicio.NTRMNL = ""
                obeOrdenServicio.TOBS = "APROBADO"
                objOrdenServicio.ActualizarEstadoOrdenServicio(obeOrdenServicio)

                MessageBox.Show("La O/S " & Nro_O_S & " fue aprobada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Lista_Cotizacione_Por_Aprobar()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click


        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC

            If Me.dtgDetalleCotizacion.Rows.Count = 0 Then Exit Sub

            Dim ListaExcel As List(Of Detalle_Cotizacion) = Me.dtgDetalleCotizacion.DataSource

            Dim dtExcel As New DataTable
            Dim dr As DataRow

            dtExcel.Columns.Add("NORSRT").Caption = NPOI_SC.FormatDato("O/S", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CCNCST").Caption = NPOI_SC.FormatDato("Ce. Co. Propio", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("CCNCS1").Caption = NPOI_SC.FormatDato("Ce. Co. Tercero", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("ESTADOOS").Caption = NPOI_SC.FormatDato("Estado O/S", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("MARGEN").Caption = NPOI_SC.FormatDato("Margen Min Permitido (%)", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("NCTZCN").Caption = NPOI_SC.FormatDato("N° Cotización", NPOI_SC.keyDatoTexto)
            'dtExcel.Columns.Add("NCRRCT").Caption = NPOI_SC.FormatDato("N° Correlativo", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("TUNDVH").Caption = NPOI_SC.FormatDato("Unidad Vehicular", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("MERCAD").Caption = NPOI_SC.FormatDato("Producto", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("QMRCDR").Caption = NPOI_SC.FormatDato("Cantidad", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("UNIMED").Caption = NPOI_SC.FormatDato("Unidad de medida", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("PMRCDR").Caption = NPOI_SC.FormatDato("Peso", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FFACTURA").Caption = NPOI_SC.FormatDato("Param. Facturación", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("FPAGO").Caption = NPOI_SC.FormatDato("Param. Pago", NPOI_SC.keyDatoTexto)
            dtExcel.Columns.Add("SEGURO").Caption = NPOI_SC.FormatDato("Seguro", NPOI_SC.keyDatoTexto)

            For Each inc As Detalle_Cotizacion In ListaExcel
                dr = dtExcel.NewRow
                dr("NORSRT") = inc.NORSRT
                dr("CCNCST") = inc.CCNCST
                dr("CCNCS1") = inc.CCNCS1
                dr("ESTADOOS") = inc.ESTADOOS
                dr("MARGEN") = inc.MARGEN
                'dr("NCTZCN") = inc.NCTZCN
                'dr("NCRRCT") = inc.NCRRCT
                dr("TUNDVH") = inc.TUNDVH
                dr("MERCAD") = inc.MERCAD
                dr("QMRCDR") = inc.QMRCDR
                dr("UNIMED") = inc.UNIMED
                dr("PMRCDR") = inc.PMRCDR
                dr("FFACTURA") = inc.FFACTURA
                dr("FPAGO") = inc.FPAGO
                dr("SEGURO") = inc.SEGURO

                dtExcel.Rows.Add(dr)
            Next

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExcel.Copy)

            Dim ListaTitulos As New List(Of String)
            ListaTitulos.Add("ORDENES DE SERVICIO POR APROBAR")

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cboCompania.CCMPN_Descripcion)
            F.Add(1, "División:|" & cboDivision.DivisionDescripcion)
            'F.Add(2, "Planta:| " & cboPlanta.DescripcionPlanta)
            F.Add(3, "Cliente:| " & txtCliente.pRazonSocial)
            oLisFiltro.Add(F)

            Dim ListColumnNFilas As New List(Of String)
            ListColumnNFilas.Add("NORSRT")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, ListColumnNFilas, oLisFiltro, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnRechazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRechazar.Click
        Try
            Dim obeOrdenServicio As New Operaciones.OrdenServicioTransporte
            Dim objOrdenServicio As New Operaciones.OrdenServicio_BLL
            If dtgDetalleCotizacion.CurrentRow Is Nothing Then
                MessageBox.Show("No existe información", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            'If pTipo_Cambio = 0 Then
            '    MessageBox.Show("No existe tipo cambio a la fecha", "Aviso", MessageBoxButtons.OK)
            '    Exit Sub
            'End If
            Dim Nro_O_S As Decimal = 0
            Nro_O_S = dtgDetalleCotizacion.CurrentRow.Cells("NORSRT").Value

            If MessageBox.Show("Está seguro de rechazar la O/S N°: " & Nro_O_S, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                obeOrdenServicio = New Operaciones.OrdenServicioTransporte
                obeOrdenServicio.CCMPN = ("" & dtgDetalleCotizacion.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                'obeOrdenServicio.NCTZCN = dtgDetalleCotizacion.CurrentRow.Cells("NCTZCN").Value
                obeOrdenServicio.NORSRT = dtgDetalleCotizacion.CurrentRow.Cells("NORSRT").Value
                obeOrdenServicio.SESTOS = "C"
                obeOrdenServicio.CULUSA = _pUsuario
                obeOrdenServicio.NTRMNL = ""
                obeOrdenServicio.TOBS = "RECHAZADO"
                objOrdenServicio.ActualizarEstadoOrdenServicio(obeOrdenServicio)

                MessageBox.Show("La O/S " & Nro_O_S & " fue rechazada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Lista_Cotizacione_Por_Aprobar()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

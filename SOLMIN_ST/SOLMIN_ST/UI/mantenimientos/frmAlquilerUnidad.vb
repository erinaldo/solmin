Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimiento
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Moneda
Imports Ransa.Utilitario
Public Class frmAlquilerUnidad

#Region " Atributos "
    Private bolEstado As Boolean = False

    Private objAlquilerUnidadBLL As New AlquilerUnidad_BLL
    Private objProveedorBLL As New Proveedor_BLL
    Private objOperacionesXAlquilerBLL As New OperacionesXAlquiler_BLL
    Private strProveedorAlq As String
#End Region

#Region " Eventos "
    Enum Mantenimiento_opcion
        Neutral
        Nuevo
        Modificar
    End Enum
    Private opcMantenimiento As Mantenimiento_opcion = Mantenimiento_opcion.Neutral
    Private Sub HabilitarBotonMantenimiento(ByVal opc As Mantenimiento_opcion)

        Dim TabSelect As String = TabAlquiler.SelectedTab.Name

        Select Case TabSelect
            Case "tabDatosAlquiler"
                Select Case opc
                    Case Mantenimiento_opcion.Neutral
                        btnNuevoAlquiler.Enabled = True
                        btnModificar.Enabled = True
                        btnModificar.Visible = True
                        btnGuardarAlquiler.Enabled = False
                        btnCancelarAlquiler.Enabled = False
                        btnEliminarAlquiler.Enabled = True
                        btnCerrarAlquiler.Enabled = True
                        btnEnviarSAP.Enabled = True
                        btnAprobarAlquiler.Enabled = True
                        Button1.Enabled = True
                        Estado_Controles(False)
                        'btnEliminarOperacion.Enabled = True
                    Case Mantenimiento_opcion.Modificar
                        btnNuevoAlquiler.Enabled = False
                        btnModificar.Enabled = True
                        btnModificar.Visible = False
                        btnGuardarAlquiler.Enabled = True
                        btnCancelarAlquiler.Enabled = True
                        btnEliminarAlquiler.Enabled = False
                        btnCerrarAlquiler.Enabled = False
                        btnEnviarSAP.Enabled = False
                        btnAprobarAlquiler.Enabled = False
                        Button1.Enabled = False
                        'btnEliminarOperacion.Enabled = True
                    Case Mantenimiento_opcion.Nuevo
                        btnNuevoAlquiler.Enabled = False
                        btnModificar.Enabled = True
                        btnModificar.Visible = False
                        btnGuardarAlquiler.Enabled = True
                        btnCancelarAlquiler.Enabled = True
                        btnEliminarAlquiler.Enabled = False
                        btnCerrarAlquiler.Enabled = False
                        btnEnviarSAP.Enabled = False
                        btnAprobarAlquiler.Enabled = False
                        Button1.Enabled = True
                        'btnEliminarOperacion.Enabled = True
                End Select

            Case "tabOperacion"
                btnNuevoAlquiler.Enabled = False
                btnModificar.Enabled = False
                btnModificar.Visible = False
                btnGuardarAlquiler.Enabled = False
                btnCancelarAlquiler.Enabled = False
                btnEliminarAlquiler.Enabled = False
                btnCerrarAlquiler.Enabled = True
                Button1.Enabled = False
                'btnEliminarOperacion.Enabled = True
        End Select

      
    End Sub

    Private Sub frmAlquilerUnidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            btnEliminarOperacion.Visible = False
            Validar_Acceso_Opciones_Usuario()

            Cargar_Tipo_Recurso()
            Me.Cargar_Compania()
            Cargar_Estado_Alquiler()
            Cargar_Proveedor_Filtro()
            'Habilitar_Botones(TabAlquiler.SelectedTab.Name)
            Cargar_Moneda()
            Cargar_Servicio()
            Cargar_CentroCosto()
            Estado_Controles(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name) ''Me.Name.Trim)

        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)


        If objEntidad.STSADI = "" Then
            btnNuevoAlquiler.Visible = False
        End If
        If objEntidad.STSCHG = "" Then
            btnModificar.Visible = False
            Button1.Visible = False
        End If
     
        If objEntidad.STSELI = "" Then
            btnEliminarAlquiler.Enabled = False
        End If

        If objEntidad.STSVIS = "" Then
            btnCerrarAlquiler.Visible = False
        End If

        If objEntidad.STSOP1 = "" Then
            btnAprobarAlquiler.Visible = False
        End If

        If objEntidad.STSOP2 = "" Then
            btnEnviarSAP.Visible = False
        End If

        
    End Sub


    Private Sub Cargar_Tipo_Recurso()
        Dim objProveedorBLL As New Proveedor_BLL
        Dim oDt As New DataTable
        oDt.Columns.Add("CCMPRN")
        oDt.Columns.Add("TDSDES")
        'Dim dr As DataRow
        'dr = oDt.NewRow
        'dr("CCMPRN") = "T"
        'dr("TDSDES") = "TODOS"
        'oDt.Rows.Add(dr)
        Dim dtTipoRecurso As New DataTable
        dtTipoRecurso = objProveedorBLL.Listar_Tipos(cmbCompania.CCMPN_CodigoCompania, "TIRSO")
        Dim dr As DataRow
        dr = dtTipoRecurso.NewRow
        dr("CCMPRN") = "-1"
        dr("TDSDES") = "TODOS"
        dtTipoRecurso.Rows.InsertAt(dr, 0)
        'For Each oDr As DataRow In dtTipoRecurso.Rows
        '    dr = oDt.NewRow
        '    dr("CCMPRN") = oDr("CCMPRN")
        '    dr("TDSDES") = oDr("TDSDES")
        '    oDt.Rows.Add(dr)
        'Next
        cmbTipoRecurso.DataSource = dtTipoRecurso
        cmbTipoRecurso.ValueMember = "CCMPRN"
        cmbTipoRecurso.DisplayMember = "TDSDES"
        cmbTipoRecurso.SelectedValue = "-1"
    End Sub


    Private Sub cmbCompania_SelectionChangeCommitted(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            If obeCompania.CCMPN_CodigoCompania = "EZ" Then
                cmbDivision.DivisionDefault = "T"
            End If
            cmbDivision.pActualizar()
            cmbDivision_SelectionChangeCommitted(Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            Me.cmbPlanta.Usuario = MainModule.USUARIO
            Me.cmbPlanta.CodigoCompania = cmbDivision.Compania
            Me.cmbPlanta.CodigoDivision = cmbDivision.Division
            Me.cmbPlanta.PlantaDefault = 1
            Me.cmbPlanta.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TabAlquiler_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabAlquiler.SelectedIndexChanged

        Try
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            Me.Asignar_Datos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    'Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    '    Try
    '        If (gwdDatos.Rows.Count = 0) Then
    '            MessageBox.Show("No existen datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            Exit Sub
    '        End If

    '        Dim MdataColumna As String = ""
    '        Dim NPOI As New HelpClass_NPOI_ST
    '        Dim dtResumen As New DataTable
    '        dtResumen.Columns.Add("NRALQT").Caption = NPOI.FormatDato("Nro.Alquiler", HelpClass_NPOI_ST.keyDatoNumero)
    '        dtResumen.Columns.Add("TCMTRT").Caption = NPOI.FormatDato("Proveedor", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("TDSDES").Caption = NPOI.FormatDato("Tipo Recurso", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("NPLRCS").Caption = NPOI.FormatDato("Placa", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("TCMTRF").Caption = NPOI.FormatDato("Servicio", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("FVALIN_S").Caption = NPOI.FormatDato("Fecha de Inicio", HelpClass_NPOI_ST.keyDatoFecha)
    '        dtResumen.Columns.Add("FVALFI_S").Caption = NPOI.FormatDato("Fecha Fin", HelpClass_NPOI_ST.keyDatoFecha)
    '        dtResumen.Columns.Add("TMNDA").Caption = NPOI.FormatDato("Moneda", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("IMP_TOTAL").Caption = NPOI.FormatDato("Importe Total", HelpClass_NPOI_ST.keyDatoMonto)
    '        dtResumen.Columns.Add("SESALQ_S").Caption = NPOI.FormatDato("Estado Alquiler", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("NORINS").Caption = NPOI.FormatDato("Orden Interna", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("CUSCRT").Caption = NPOI.FormatDato("Usuario Creador", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("CULUSA").Caption = NPOI.FormatDato("Usuario Actualizador", HelpClass_NPOI_ST.keyDatoTexto)

    '        dtResumen.Columns.Add("TOBS").Caption = NPOI.FormatDato("Obs. alquiler", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("TOBRES2").Caption = NPOI.FormatDato("Obs. aprobación", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("TOBRES").Caption = NPOI.FormatDato("Obs. cierre", HelpClass_NPOI_ST.keyDatoTexto)
    '        dtResumen.Columns.Add("TOBRE3").Caption = NPOI.FormatDato("Obs. envio pedido", HelpClass_NPOI_ST.keyDatoTexto)


    '        Dim dr As DataRow
    '        Dim NameColumna As String = ""
    '        For Fila As Integer = 0 To gwdDatos.Rows.Count - 1
    '            dr = dtResumen.NewRow
    '            For Each Col As DataColumn In dtResumen.Columns
    '                NameColumna = Col.ColumnName
    '                dr(NameColumna) = gwdDatos.Rows(Fila).Cells(NameColumna).Value
    '            Next
    '            dtResumen.Rows.Add(dr)
    '        Next

    '        Dim oListDtReport As New List(Of DataTable)
    '        dtResumen.TableName = "Alquiler Unidades"
    '        oListDtReport.Add(dtResumen.Copy)

    '        Dim ListTitulo As New List(Of String)
    '        Dim LisFiltros As New List(Of SortedList)
    '        'Dim itemSortedList As SortedList
    '        ListTitulo.Add("LISTA DE ALQUILER DE UNIDADES")

    '        NPOI.ExportExcelGeneralMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, Nothing)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub txtNroAlquiler_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroAlquiler.KeyPress
        Try
            If e.KeyChar = "." Then
                e.Handled = True
                Exit Sub
            End If
            If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNroLiq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar = "." Then
                e.Handled = True
                Exit Sub
            End If
            If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRecursosAsignados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecursosAsignados.Click
        Try
            If txtProveedor.Text.Trim = "" Then
                MsgBox("Debe seleccionar Proveedor.", MsgBoxStyle.Exclamation)
            Else
                Dim fRecursosAsignados As frmRecursosAsignados = New frmRecursosAsignados(cmbCompania.CCMPN_CodigoCompania, txtProveedor.Tag, txtProveedor.Text)
                With fRecursosAsignados
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        txtTipo.Text = .Tipo
                        txtTipo.Tag = .CodTipo
                        txtPlaca.Text = .Placa
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
            CType(sender, TextBox).Tag = "8-3"
            Event_KeyPress_NumeroWithDecimal(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCantidad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        If txtCantidad.Text.EndsWith(".") Then
            txtCantidad.Text = txtCantidad.Text.Replace(".", "")
        End If
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        CType(sender, TextBox).Tag = "10-5"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    Private Sub txtImporte_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.Leave
        If txtImporte.Text.EndsWith(".") Then
            txtImporte.Text = txtImporte.Text.Replace(".", "")
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If Me.gwdDatos.CurrentRow Is Nothing Then Exit Sub

            Dim objAlquiler As New AlquilerUnidad
            Dim dtAlquiler As New DataTable
            objAlquiler.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN1").Value
            objAlquiler.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value
            dtAlquiler = objAlquilerUnidadBLL.Listar_Datos_Liquidacion_Alquiler(objAlquiler)
            If dtAlquiler.Rows.Count > 0 Then
                If dtAlquiler.Rows(0)("NLQDCN") > 0 Then
                    MessageBox.Show("No se puede modificar. El alquiler está enviado a SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If Me.txtNroAlquiler1.Text.Trim <> "" And Me.txtNroAlquiler1.Text.Trim <> "0" Then
                If Obtener_Estado_Alquiler() = "C" Then
                    MessageBox.Show("No se puede modificar un Alquiler cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
           
            opcMantenimiento = Mantenimiento_opcion.Modificar
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Modificar)
            Me.Estado_Controles(True)

            If Obtener_Estado_Alquiler_Aprobado() = "X" Then
                'MessageBox.Show("No se puede modificar.El alquiler se encuentra aprobado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Exit Sub
                'gggg()
                btnProveedorAsignado.Enabled = False
                btnRecursosAsignados.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardarAlquiler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarAlquiler.Click
        Try

            Select Case opcMantenimiento
                Case Mantenimiento_opcion.Nuevo
                    If ValidarAlquilerUnidad() Then Exit Sub
                    Dim strResultado As String = Validar_Proveedor_Homologado()
                    If strResultado.Trim = "" Then

                        Dim objEntidad As New AlquilerUnidad
                        objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
                        objEntidad.CDVSN = cmbDivision.Division
                        objEntidad.CPLNDV = cmbPlanta.Planta
                        objEntidad.NRUCTR = txtProveedor.Tag
                        objEntidad.FCHASG = HelpClass.CFecha_a_Numero8Digitos(dtpFechaAsignacion.Value)
                        objEntidad.FVALIN = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
                        objEntidad.FVALFI = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value)
                        objEntidad.STPRCS = txtTipo.Tag
                        objEntidad.NPLRCS = txtPlaca.Text
                        objEntidad.CSRVNV = CType(cmbServicio.Resultado, Ransa.Controls.ServTransp.TD_Obj_ServTransp).pCSRVNV_Servicio
                        objEntidad.CCNCS1 = CType(cmbCentroCosto.Resultado, CentroCosto).CCNTCS
                        objEntidad.CMNALQ = cmbMoneda.SelectedValue.ToString.Trim
                        objEntidad.QCNALQ = txtCantidad.Text.Trim
                        objEntidad.IRVALQ = txtImporte.Text.Trim
                        objEntidad.SESALQ = "P"
                        objEntidad.CUSCRT = MainModule.USUARIO
                        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                        objEntidad.REFDO1 = KryptonTextBox4.Text.Trim
                        objEntidad.TOBS = KryptonTextBox3.Text.Trim

                        Dim olstAlquilerUnidad As New List(Of AlquilerUnidad)
                        olstAlquilerUnidad = Validar_Existe_Alquiler_Unidad(objEntidad)
                        If olstAlquilerUnidad.Count = 0 Then
                            objEntidad = objAlquilerUnidadBLL.Registrar_Alquiler_Unidad(objEntidad)
                            MessageBox.Show("Se creó el alquiler " & objEntidad.NRALQT, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            opcMantenimiento = Mantenimiento_opcion.Neutral
                            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
                            Listar_Alquiler_Unidad()
                        Else
                            MessageBox.Show("No se puede crear el alquiler.Debe cerrar alquileres pendientes" & Chr(13) & "El Alquiler Nro. " & olstAlquilerUnidad.Item(0).NRALQT & " con Placa " & olstAlquilerUnidad.Item(0).NPLRCS & " se encuentra pendiente de cierre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    Else
                        MessageBox.Show(strResultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If


                Case Mantenimiento_opcion.Modificar


                    If ValidarAlquilerUnidad() Then Exit Sub
                    Dim strResultado As String = Validar_Proveedor_Homologado()
                    If strResultado.Trim = "" Then
                      
                        Dim objEntidad As New AlquilerUnidad
                        Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
                        objEntidad.NRALQT = txtNroAlquiler1.Text.Trim
                        objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                        objEntidad.CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
                        objEntidad.CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
                        objEntidad.NRUCTR = txtProveedor.Tag
                        objEntidad.FCHASG = HelpClass.CFecha_a_Numero8Digitos(dtpFechaAsignacion.Value)
                        objEntidad.FVALIN = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
                        objEntidad.FVALFI = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value)
                        objEntidad.STPRCS = txtTipo.Tag
                        objEntidad.NPLRCS = txtPlaca.Text
                        'objEntidad.CSRVNV = CType(cmbServicio.Resultado, TD_Obj_ServTransp).pCSRVNV_Servicio
                        objEntidad.CSRVNV = CType(cmbServicio.Resultado, Ransa.Controls.ServTransp.TD_Obj_ServTransp).pCSRVNV_Servicio
                        objEntidad.CCNCS1 = CType(cmbCentroCosto.Resultado, CentroCosto).CCNTCS
                        objEntidad.CMNALQ = cmbMoneda.SelectedValue.ToString.Trim
                        objEntidad.QCNALQ = txtCantidad.Text.Trim
                        objEntidad.IRVALQ = txtImporte.Text.Trim
                        objEntidad.CULUSA = MainModule.USUARIO
                        objEntidad.FULTAC = HelpClass.TodayNumeric
                        objEntidad.HULTAC = HelpClass.NowNumeric
                        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                        objEntidad.REFDO1 = KryptonTextBox4.Text.Trim
                        objEntidad.TOBS = KryptonTextBox3.Text.Trim

                        objEntidad = objAlquilerUnidad_BLL.Modificar_Alquiler_Unidad(objEntidad)
                        opcMantenimiento = Mantenimiento_opcion.Neutral
                        HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
                        Listar_Alquiler_Unidad()

                    Else
                        MessageBox.Show(strResultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNuevoAlquiler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevoAlquiler.Click
        Try
            opcMantenimiento = Mantenimiento_opcion.Nuevo
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Nuevo)
            Estado_Controles(True)
            Cargar_Datos_Alquiler()
            Limpiar_Controles()
            Me.cmbServicio.Valor = 522
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEliminarAlquiler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminarAlquiler.Click
        Try
            If Me.gwdDatos.CurrentRow Is Nothing Then Exit Sub
            Dim objAlquiler As New AlquilerUnidad
            Dim dtalquiler As New DataTable

            objAlquiler.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN1").Value.ToString.Trim
            objAlquiler.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value.ToString.Trim

            dtalquiler = objAlquilerUnidadBLL.Listar_Datos_Liquidacion_Alquiler(objAlquiler)

            If Me.txtNroAlquiler1.Text.Trim <> "" And Me.txtNroAlquiler1.Text.Trim <> "0" Then
                If Obtener_Estado_Alquiler() = "C" Then
                    MessageBox.Show("No se puede eliminar un Alquiler cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
           
            If dtalquiler.Rows.Count > 0 Then
                If dtalquiler.Rows(0)("NLQDCN") > 0 Then
                    MessageBox.Show("No se puede eliminar. El alquiler está enviado a SAP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If


            If MessageBox.Show("Está seguro de eliminar el alquiler ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            
                Dim objEntidad As New AlquilerUnidad

                objEntidad.NRALQT = txtNroAlquiler1.Text.Trim
                objEntidad.CULUSA = MainModule.USUARIO
                objEntidad.FULTAC = HelpClass.TodayNumeric
                objEntidad.HULTAC = HelpClass.NowNumeric
                objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
                objEntidad = objAlquilerUnidadBLL.Eliminar_Alquiler_Unidad(objEntidad)

                Dim objLogica As New Solicitud_Transporte_BLL
                Dim lstrList As List(Of String) = objLogica.Anulacion_Operacion_Transporte_Alquiler(gwdDatos.CurrentRow.Cells("CCMPN").Value, txtNroAlquiler1.Text.Trim, MainModule.USUARIO, Ransa.Utilitario.HelpClass.NombreMaquina)
                If lstrList.Count > 0 Then
                    If lstrList(1) <> 1 Then
                        MessageBox.Show(lstrList(0), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
                If objEntidad.NRALQT = 0 Then
                    HelpClass.ErrorMsgBox()
                    Exit Sub
                Else
                    Limpiar_Controles()
                    Listar_Alquiler_Unidad()
                End If

                Listar_Alquiler_Unidad()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCerrarAlquiler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarAlquiler.Click
        Try
            If Me.gwdDatos.CurrentRow Is Nothing Then Exit Sub

            Dim strEstado As String = ""
            Dim msgVal As String = ""
            Dim oebAlquilerUnidad As New AlquilerUnidad
            Dim objEntidad As New AlquilerUnidad
            Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
            objEntidad.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value
            objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            oebAlquilerUnidad = objAlquilerUnidad_BLL.Obtener_Datos_Alquiler_Unidad(objEntidad)

            If oebAlquilerUnidad IsNot Nothing Then

                If oebAlquilerUnidad.SESALQ = "C" Then
                    msgVal = "No se puede cerrar. El alquiler ya se encuentra cerrado"
                End If
                If oebAlquilerUnidad.FLGAPR <> "X" Then
                    msgVal = msgVal & Chr(13) & "Se requiere aprobación del alquiler"
                End If
                If msgVal.Length > 0 Then
                    MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

            End If


            'Dim NumAlquiler As Decimal = 0
            'NumAlquiler = gwdDatos.CurrentRow.Cells("NRALQT").Value
            'Dim dtAlquiler As New DataTable
            'Dim objEntidadOPAlq As New AlquilerUnidad
            'objEntidadOPAlq.NRALQT = NumAlquiler
            'objEntidadOPAlq.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            'dtAlquiler = objAlquilerUnidadBLL.Listar_Datos_Liquidacion_Alquiler(objEntidadOPAlq)

            'If dtAlquiler.Rows.Count > 0 AndAlso dtAlquiler.Rows(0)("NLQDCN") <> 0 Then

            Dim objAlquilerUnidad As New AlquilerUnidad
            objAlquilerUnidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            objAlquilerUnidad.NRUCTR = txtProveedor.Tag
            objAlquilerUnidad.TCMTRT = txtProveedor.Text
            objAlquilerUnidad.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value
            objAlquilerUnidad.STPRCS = gwdDatos.CurrentRow.Cells("STPRCS").Value
            objAlquilerUnidad.TDSDES = gwdDatos.CurrentRow.Cells("TDSDES").Value
            objAlquilerUnidad.NPLRCS = gwdDatos.CurrentRow.Cells("NPLRCS").Value
            objAlquilerUnidad.CULUSA = MainModule.USUARIO
            objAlquilerUnidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            'cmbCompania.CCMPN_CodigoCompania, cboProveedor.pRucTransportista, cboProveedor.pRazonSocial, gwdDatos.CurrentRow.Cells("STPRCS").Value, gwdDatos.CurrentRow.Cells("TDSDES").Value, gwdDatos.CurrentRow.Cells("NPLRCS").Value)

            '------------------------------------

            Dim fOperacionesxProveedor As frmOperacionesxProveedor = New frmOperacionesxProveedor(objAlquilerUnidad)
            With fOperacionesxProveedor
                fOperacionesxProveedor.FechaInicio = dtpFechaInicio.Value.ToString("dd/MM/yyyy")
                fOperacionesxProveedor.FechaFin = dtpFechaFin.Value.ToString("dd/MM/yyyy")
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' 3 EJECUTA EL CIERRE DE ALQUILAR '
                    objAlquilerUnidad.TOBRES = fOperacionesxProveedor.TxtObservacionCierreAlquiler.Text.ToString
                    'objAlquilerUnidad.TOBRES = "Cierre"
                    If objAlquilerUnidadBLL.Cerrar_Alquiler_Unidad(objAlquilerUnidad).NRALQT > 0 Then
                        MessageBox.Show("Se cerró el Alquiler Nro. " & objAlquilerUnidad.NRALQT, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Listar_Operaciones_Alquiler()
                    End If

                End If
            End With


            'Else
            'MessageBox.Show("El alquiler no se encuentra enviado al SAP. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelarAlquiler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelarAlquiler.Click
        Try
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            Me.Asignar_Datos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub gwdDatos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            'If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            gwdOperacionesXAlquiler.DataSource = Nothing
            opcMantenimiento = Mantenimiento_opcion.Neutral
            HabilitarBotonMantenimiento(Mantenimiento_opcion.Neutral)
            Me.Asignar_Datos()
            Listar_Operaciones_Alquiler()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboProveedor_InformationChanged()
        Try
            txtTipo.Text = ""
            txtTipo.Tag = ""
            txtPlaca.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ckbFechaAsignacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbFechaAsignacion.CheckedChanged
        If ckbFechaAsignacion.Checked = True Then
            dtpFechaAsigInicio.Enabled = True
            dtpFechaAsigFin.Enabled = True
        Else
            dtpFechaAsigInicio.Enabled = False
            dtpFechaAsigFin.Enabled = False
        End If
    End Sub


#End Region

#Region " Procedimiento "
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub


    Private Sub Cargar_Datos_Alquiler()
        Estado_Controles(True)
    
    End Sub

    Private Sub Cargar_Servicio()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "pCSRVNV_Servicio"
        oColumnas.DataPropertyName = "pCSRVNV_Servicio"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "pTCMTRF_Descripcion"
        oColumnas.DataPropertyName = "pTCMTRF_Descripcion"
        oColumnas.HeaderText = "Servicio"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        'Dim obr As New Ransa.DAO.ServTransp.cServTransp
        Dim obr As New Ransa.Controls.ServTransp.cServTransp

        Dim obe As New Ransa.Controls.ServTransp.TD_Obj_ServTransp
        cmbServicio.DataSource = Nothing
        cmbServicio.DataSource = HelpClass.CreateObjectsFromDataTable(Of Ransa.Controls.ServTransp.TD_Obj_ServTransp)(obr.fdtListar(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division))
        Me.cmbServicio.ListColumnas = oListColum
        Me.cmbServicio.Cargas()
        Me.cmbServicio.Limpiar()
        Me.cmbServicio.ValueMember = "pCSRVNV_Servicio"
        Me.cmbServicio.DispleyMember = "pTCMTRF_Descripcion"

    End Sub

    Private Sub Cargar_Proveedor_Filtro()
        Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeProveedor.pCCMPN_Compania = cmbCompania.CCMPN_CodigoCompania
        'obeTransportista.pNRUCTR_RucTransportista = .pNRUCTR_RucProveedor
        cmbProveedorFiltro.pCargar(obeProveedor)
    End Sub



    Private Sub Cargar_Moneda()
       
        Dim obMonedaBLL As New Moneda_BLL
        Dim dtMoneda As New DataTable
        dtMoneda = obMonedaBLL.Listar_Monedas_Basica
        cmbMoneda.DataSource = dtMoneda
        cmbMoneda.ValueMember = "pCMNDA1_Codigo"
        cmbMoneda.DisplayMember = "pTMNDA_Detalle"
        cmbMoneda.SelectedValue = "1"
 

    End Sub

    Private Sub Cargar_Estado_Alquiler()
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("VALUE")
        dtEstado.Columns.Add("DISPLAY")

        Dim dr As DataRow

        dr = dtEstado.NewRow
        dr("DISPLAY") = "PENDIENTE"
        dr("VALUE") = "P"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "CERRADO"
        dr("VALUE") = "C"
        dtEstado.Rows.Add(dr)

        cmbEstadoAlq.DataSource = dtEstado
        cmbEstadoAlq.ValueMember = "VALUE"
        cmbEstadoAlq.DisplayMember = "DISPLAY"
        cmbEstadoAlq.SelectedValue = "P"
    End Sub

    Private Sub Estado_Controles(ByVal estado As Boolean)
        dtpFechaAsignacion.Enabled = False
        btnProveedorAsignado.Enabled = estado
        dtpFechaInicio.Enabled = estado
        dtpFechaFin.Enabled = estado
        txtTipo.Enabled = False
        txtPlaca.Enabled = False
        btnRecursosAsignados.Enabled = estado
        cmbServicio.Enabled = estado
        cmbCentroCosto.Enabled = estado
        cmbMoneda.ComboBox.Enabled = estado
        txtCantidad.Enabled = False
        txtImporte.Enabled = estado
        KryptonTextBox4.Enabled = estado
        KryptonTextBox3.Enabled = estado
    End Sub

    Private Sub Limpiar_Controles()
        txtNroAlquiler1.Text = ""
        txtProveedor.Text = ""
        txtProveedor.Tag = ""
        txtTipo.Text = ""
        txtTipo.Tag = ""
        txtPlaca.Text = ""
        cmbCentroCosto.Limpiar()
        cmbServicio.Limpiar()
        cmbMoneda.SelectedValue = "1"
        txtCantidad.Text = "1"
        txtImporte.Text = "0"
        txtOrdenInterna.Text = ""
        txtNroLiquidacion.Text = ""
        KryptonTextBox1.Text = ""
        txtReferenciaSAP.Text = ""
        txtDocumentoLiq.Text = ""
        txtServicio.Text = ""
        txtRefOperacion.Text = ""
        txtImporteLiq.Text = ""
        dtpFechaInicio.Value = Date.Now
        dtpFechaFin.Value = Date.Now
        dtpFechaAsignacion.Value = Date.Now
        KryptonTextBox4.Text = ""
        KryptonTextBox3.Text = ""
        'gwdOperacionesXAlquiler.DataSource = Nothing

        'Codigo agregado por MREATEGUIP - Ajuste Moneda
        '----- Ini -----
        txtMoneda.Text = ""
        '----- Fin -----



    End Sub

    Private Function ValidarAlquilerUnidad() As Boolean
        Dim strMensajeError As String = ""
        If txtTipo.Text.Trim = "" Then strMensajeError &= "* Ingrese Tipo de Recurso" & vbNewLine
        If txtPlaca.Text.Trim = "" Then strMensajeError &= "* Ingrese Placa" & vbNewLine
        If cmbCentroCosto.Resultado Is Nothing Then strMensajeError &= "* Seleccione Centro de Costo" & vbNewLine
        If cmbServicio.Resultado Is Nothing Then strMensajeError &= "* Seleccione Servicio" & vbNewLine
        If cmbMoneda.SelectedValue Is Nothing Then strMensajeError &= "* Seleccione Moneda" & vbNewLine
        If txtCantidad.Text.Trim = "" Then strMensajeError &= "* Ingrese Cantidad" & vbNewLine
        If txtImporte.Text.Trim = "" Or txtImporte.Text.Trim = "0" Then strMensajeError &= "* Ingrese Importe" & vbNewLine

        Dim FechaIni As Decimal = dtpFechaInicio.Value.ToString("yyyyMMdd")
        Dim FechaFin As Decimal = dtpFechaFin.Value.ToString("yyyyMMdd")
        If FechaFin < FechaIni Then strMensajeError &= "* Fecha vigencia de inicio debe ser menor a la fecha vigencia fin. " & vbNewLine
      


        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
       
    End Function

    Private Function Validar_Existe_Alquiler_Unidad(ByVal objAlquilerUnidad As AlquilerUnidad) As List(Of AlquilerUnidad)
        Dim olstAlqUnidad As New List(Of AlquilerUnidad)
        Return objAlquilerUnidadBLL.Validar_Existe_Alquiler_Unidad(objAlquilerUnidad)
    End Function



    Private Sub Listar_Alquiler_Unidad()
        gwdOperacionesXAlquiler.DataSource = Nothing
        gwdDatos.DataSource = Nothing

        Dim objEntidad As New AlquilerUnidad
        objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
        objEntidad.CDVSN = cmbDivision.Division
        objEntidad.CPLNDV = cmbPlanta.Planta
        objEntidad.SESALQ = cmbEstadoAlq.SelectedValue.ToString.Trim
        objEntidad.NRUCTR = cmbProveedorFiltro.pRucTransportista
        If txtNroAlquiler.Text.Trim = "" Then
            objEntidad.NRALQT = 0
        Else
            objEntidad.NRALQT = CType(txtNroAlquiler.Text, Double)
        End If
        objEntidad.NLQDCN = 0
        If ckbFechaAsignacion.Checked = True Then
            objEntidad.FCHASGI = HelpClass.CFecha_a_Numero8Digitos(dtpFechaAsigInicio.Value)
            objEntidad.FCHASGF = HelpClass.CFecha_a_Numero8Digitos(dtpFechaAsigFin.Value)
        Else
            objEntidad.FCHASGI = 0
            objEntidad.FCHASGF = 0
        End If

        If cmbTipoRecurso.SelectedValue = "-1" Then
            objEntidad.STPRCS = ""
        Else
            objEntidad.STPRCS = ("" & cmbTipoRecurso.SelectedValue).ToString.Trim
        End If
        objEntidad.NPLRCS = KryptonTextBox2.Text.Trim
        gwdDatos.AutoGenerateColumns = False
        Dim oList As New List(Of AlquilerUnidad)
        oList = objAlquilerUnidadBLL.Listar_Alquiler_Unidad(objEntidad)
        gwdDatos.DataSource = oList
        If gwdDatos.RowCount = 0 Then
            gwdOperacionesXAlquiler.DataSource = Nothing
            Limpiar_Controles()
        End If
    End Sub


    Private Sub Asignar_Datos()
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Limpiar_Controles()
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        txtNroAlquiler1.Text = Me.gwdDatos.Item("NRALQT", lint_Indice).Value.ToString().Trim()
        Me.txtProveedor.Tag = Me.gwdDatos.Item("NRUCTR", lint_Indice).Value.ToString().Trim()
        Me.txtProveedor.Text = Me.gwdDatos.Item("NRUCTR", lint_Indice).Value.ToString().Trim() & " - " & Me.gwdDatos.Item("TCMTRT", lint_Indice).Value.ToString().Trim()
        Me.dtpFechaAsignacion.Value = Date.Parse(gwdDatos.CurrentRow.Cells("FCHASG_S").Value.ToString.Trim)
        Me.dtpFechaInicio.Value = Date.Parse(gwdDatos.CurrentRow.Cells("FVALIN_S").Value.ToString.Trim)
        Me.dtpFechaFin.Value = Date.Parse(gwdDatos.CurrentRow.Cells("FVALFI_S").Value.ToString.Trim)
        Me.txtTipo.Tag = Me.gwdDatos.Item("STPRCS", lint_Indice).Value.ToString().Trim()
        Me.txtTipo.Text = Me.gwdDatos.Item("TDSDES", lint_Indice).Value.ToString().Trim()
        Me.txtPlaca.Text = Me.gwdDatos.Item("NPLRCS", lint_Indice).Value.ToString().Trim()
        Me.cmbServicio.Valor = Me.gwdDatos.Item("CSRVNV", lint_Indice).Value.ToString().Trim()
        Me.cmbCentroCosto.Valor = Me.gwdDatos.Item("CCNCS1", lint_Indice).Value.ToString().Trim()
        cmbMoneda.SelectedValue = Me.gwdDatos.Item("CMNALQ", lint_Indice).Value.ToString().Trim()
        txtCantidad.Text = Val(Me.gwdDatos.Item("QCNALQ", lint_Indice).Value.ToString().Trim())
        txtImporte.Text = Val(Me.gwdDatos.Item("IRVALQ", lint_Indice).Value.ToString().Trim())
        txtRefOperacion.Text = Me.gwdDatos.Item("NOPRCN1", lint_Indice).Value.ToString().Trim()

        KryptonTextBox4.Text = Me.gwdDatos.Item("REFDO1", lint_Indice).Value.ToString().Trim()
        KryptonTextBox3.Text = Me.gwdDatos.Item("TOBS", lint_Indice).Value.ToString().Trim()


        Dim objEntidad As New AlquilerUnidad
        objEntidad.NOPRCN = gwdDatos.CurrentRow.Cells("NOPRCN1").Value.ToString.Trim
        objEntidad.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value.ToString.Trim
        txtOrdenInterna.Text = gwdDatos.CurrentRow.Cells("NORINS").Value.ToString.Trim
        Dim dtAlquiler As New DataTable
        dtAlquiler = objAlquilerUnidadBLL.Listar_Datos_Liquidacion_Alquiler(objEntidad)
        If dtAlquiler.Rows.Count > 0 Then
            txtNroLiquidacion.Text = dtAlquiler.Rows(0)("NLQDCN")
            KryptonTextBox1.Text = HelpClass.FechaNum_a_Fecha(dtAlquiler.Rows(0)("FLQDCN"))
            txtReferenciaSAP.Text = dtAlquiler.Rows(0)("NRFSAP")
            txtImporteLiq.Text = Val(dtAlquiler.Rows(0)("ILQDTR"))
            txtDocumentoLiq.Text = dtAlquiler.Rows(0)("NUMOPG")
            txtServicio.Text = IIf(dtAlquiler.Rows(0)("CSRVC") = 0, "", dtAlquiler.Rows(0)("CSRVC") & " - " & dtAlquiler.Rows(0)("SERVICIO"))

            'Codigo agregado por MREATEGUIP - Ajuste Moneda
            '----- Ini -----
            If Not IsDBNull(dtAlquiler.Rows(0)("TMNDA")) Then
                txtMoneda.Text = dtAlquiler.Rows(0)("TMNDA")
            End If
            '----- Fin -----
            End If

    End Sub

    Private Function Obtener_Estado_Alquiler() As String
        Dim strEstado As String = ""
        If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Function
        Dim obeAlquilerUnidad As New AlquilerUnidad
        Dim objEntidad As New AlquilerUnidad
        Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
        objEntidad.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value
        objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
        obeAlquilerUnidad = objAlquilerUnidad_BLL.Obtener_Datos_Alquiler_Unidad(objEntidad)
        If obeAlquilerUnidad IsNot Nothing Then
            strEstado = obeAlquilerUnidad.SESALQ.Trim
        End If
        Return strEstado
    End Function

    Private Sub Cargar_CentroCosto()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim Etiquetas As New List(Of String)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCRVTA"
        oColumnas.DataPropertyName = "TCRVTA"
        oColumnas.HeaderText = "Negocio"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CCNTCS"
        oColumnas.DataPropertyName = "CCNTCS"
        oColumnas.HeaderText = "Cód. CC"
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCNTCS"
        oColumnas.DataPropertyName = "TCNTCS"
        oColumnas.HeaderText = "Centro Costo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(3, oColumnas)

        Etiquetas.Add("Cod. CC")
        Etiquetas.Add("Centro Costo")
        Dim objCentroCosto As New CentroCosto
        objCentroCosto.CCMPN = cmbCompania.CCMPN_CodigoCompania
        Dim objCentroCostoBLL As New CentroCosto_BLL
        cmbCentroCosto.DataSource = Nothing
        cmbCentroCosto.DataSource = objCentroCostoBLL.Listar_Centro_Costo_Alquiler(objCentroCosto)
        Me.cmbCentroCosto.ListColumnas = oListColum
        Me.cmbCentroCosto.Etiquetas_Form = Etiquetas
        Me.cmbCentroCosto.Cargas()
        Me.cmbCentroCosto.Limpiar()
        Me.cmbCentroCosto.ValueMember = "CCNTCS"
        Me.cmbCentroCosto.DispleyMember = "TCNTCS"
    End Sub

    Private Function Validar_Proveedor_Homologado() As String
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim objHashTable As New Hashtable
        objHashTable.Add("CCMPN", cmbCompania.CCMPN_CodigoCompania)
        objHashTable.Add("NRUCTR", txtProveedor.Tag)
        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
        Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    End Function


    Private Sub Listar_Operaciones_Alquiler()
        gwdOperacionesXAlquiler.DataSource = Nothing
        Dim objEntidad As New OperacionesXAlquiler
        objEntidad.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value
        gwdOperacionesXAlquiler.AutoGenerateColumns = False
        gwdOperacionesXAlquiler.DataSource = objOperacionesXAlquilerBLL.Listar_Operacion_X_Alquiler(objEntidad)
    End Sub

   

    'Private Sub Generar_OrdenInterna_Operacion_Liquidar()
    '    Dim sMensajeError As String = ""
    '    Dim NumAlquiler As Decimal = gwdDatos.CurrentRow.Cells("NRALQT").Value
    '    Dim objEntidad As New AlquilerUnidad
    '    objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
    '    objEntidad.NRALQT = NumAlquiler
    '    objEntidad.CUSCRT = MainModule.USUARIO
    '    objEntidad.NTRMCR = HelpClass.NombreMaquina
    '    Dim dtOpAlquiler As New DataTable
    '    If objAlquilerUnidadBLL.Validar_Configuracion_Servicio_Alquiler(objEntidad, sMensajeError) Then
    '        If MsgBox("Esta seguro de liquidar?", MsgBoxStyle.OkCancel, "Liquidar") = MsgBoxResult.Ok Then

    '            Dim OI As Decimal = 0

    '            Dim objEntidadOPAlq As New AlquilerUnidad
    '            objEntidadOPAlq.NRALQT = NumAlquiler
    '            objEntidadOPAlq.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
    '            dtOpAlquiler = objAlquilerUnidadBLL.Obtener_Operacion_Alquiler_Unidad(objEntidadOPAlq)
    '            If dtOpAlquiler.Rows.Count > 0 Then

    '                If dtOpAlquiler.Rows(0)("NORINS") = 0 Then
    '                    OI = objAlquilerUnidadBLL.Generar_Orden_Interna_Alquiler(objEntidad).NORINS
    '                Else
    '                    OI = dtOpAlquiler.Rows(0)("NORINS")
    '                End If
    '                If OI = 0 Then
    '                    MessageBox.Show("El proceso no se pudo completar.No se generó la Orden Interna", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    Exit Sub
    '                End If

    '                If dtOpAlquiler.Rows(0)("NOPRCN") = 0 Then
    '                    Dim objEntidadOP As New AlquilerUnidad
    '                    objEntidadOP.CUSCRT = MainModule.USUARIO
    '                    objEntidadOP.NTRMCR = HelpClass.NombreMaquina
    '                    objEntidadOP.NRALQT = NumAlquiler
    '                    objEntidadOP.NORINS = OI
    '                    objAlquilerUnidadBLL.Registrar_Operacion_Transporte_Alquiler(objEntidadOP)
    '                End If

    '                objEntidadOPAlq = New AlquilerUnidad
    '                objEntidadOPAlq.NRALQT = NumAlquiler
    '                objEntidadOPAlq.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
    '                dtOpAlquiler = objAlquilerUnidadBLL.Obtener_Operacion_Alquiler_Unidad(objEntidadOPAlq)

    '                If dtOpAlquiler.Rows.Count > 0 Then

    '                    If dtOpAlquiler.Rows(0)("NOPRCN") > 0 Then

    '                        Dim GuiaTranspo As New GuiaTransportista_BLL
    '                        Dim msgError As String = ""
    '                        GuiaTranspo.Validar_GuiaTransportista_ProvAlquiler(cmbCompania.CCMPN_CodigoCompania, NumAlquiler, 1, MainModule.USUARIO, HelpClass.NombreMaquina, msgError)
    '                        If msgError.Length > 0 Then
    '                            MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            Exit Sub
    '                        Else
    '                            Dim objEntidadLiq As New AlquilerUnidad
    '                            objEntidadLiq.NRALQT = NumAlquiler
    '                            objEntidadLiq.CUSCRT = MainModule.USUARIO
    '                            objEntidadLiq.NTRMNL = HelpClass.NombreMaquina
    '                            objAlquilerUnidadBLL.Procesar_Liquidacion_Alquiler(objEntidadLiq)
    '                            msgError = ""
    '                            GuiaTranspo.Validar_GuiaTransportista_ProvAlquiler(gwdDatos.CurrentRow.Cells("CCMPN").Value, NumAlquiler, 2, MainModule.USUARIO, HelpClass.NombreMaquina, msgError)
    '                            If msgError.Length > 0 Then
    '                                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                            Else
    '                                MessageBox.Show("El alquiler se envió correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            End If
    '                        End If

    '                    Else
    '                        MessageBox.Show("No se pudo completar el proceso.No se ha generado la operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        Exit Sub
    '                    End If
    '                End If
    '            End If

    '            If dtOpAlquiler.Rows.Count > 0 Then
    '                gwdDatos.CurrentRow.Cells("NORINS").Value = dtOpAlquiler.Rows(0)("NORINS")
    '                gwdDatos.CurrentRow.Cells("NOPRCN1").Value = dtOpAlquiler.Rows(0)("NOPRCN")
    '                Asignar_Datos()
    '            End If
    '        End If
    '    End If

    'End Sub


#End Region

   

    Private Sub btnProveedorAsignado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProveedorAsignado.Click
        Try
            Dim fProveedorAsignado As frmProveedorAsignado
            fProveedorAsignado = New frmProveedorAsignado(cmbCompania.CCMPN_CodigoCompania)
            txtPlaca.Text = ""
            txtTipo.Text = ""
            If fProveedorAsignado.ShowDialog = Windows.Forms.DialogResult.OK Then
                With fProveedorAsignado
                    txtProveedor.Text = .RUC & " - " & .Proveedor
                    txtProveedor.Tag = .RUC
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEnviarSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarSAP.Click
        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub

            If Obtener_Estado_Alquiler_Aprobado() = "X" Then
                Dim objEntidad As New AlquilerUnidad
                Dim ofrmEnvioPedidoAlquiler As New frmEnvioPedidoAlquiler
                ofrmEnvioPedidoAlquiler.NumAlquiler = gwdDatos.CurrentRow.Cells("NRALQT").Value
                ofrmEnvioPedidoAlquiler.Compania = ("" & gwdDatos.CurrentRow.Cells("CCMPN").Value).ToString.Trim
                ofrmEnvioPedidoAlquiler.proveedor = txtProveedor.Text
                ofrmEnvioPedidoAlquiler.Tipo_recurso = txtTipo.Text
                ofrmEnvioPedidoAlquiler.placa = txtPlaca.Text
                ofrmEnvioPedidoAlquiler.servicio = CType(cmbServicio.Resultado, Ransa.Controls.ServTransp.TD_Obj_ServTransp).pTCMTRF_Descripcion
                ofrmEnvioPedidoAlquiler.ShowDialog()
                If ofrmEnvioPedidoAlquiler.myDialogResult = True Then
                    Listar_Alquiler_Unidad()
                End If
            Else
                MessageBox.Show("Para enviar a SAP eL Alquiler debe ser Aprobado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


    
            'Dim objEntidad As New AlquilerUnidad
            'objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
            'Dim NumAlquiler As Decimal = 0
            'NumAlquiler = gwdDatos.CurrentRow.Cells("NRALQT").Value
            'Dim dtAlquiler As New DataTable
            'Dim objEntidadOPAlq As New AlquilerUnidad
            'objEntidadOPAlq.NRALQT = NumAlquiler
            'Dim dtOpAlquiler As New DataTable
            'objEntidadOPAlq.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            'dtAlquiler = objAlquilerUnidadBLL.Listar_Datos_Liquidacion_Alquiler(objEntidadOPAlq)
            'If Obtener_Estado_Alquiler_Aprobado() = "X" Then

            '    'SAP ----------------------------------------------------------------------
            '    If dtAlquiler.Rows.Count = 0 Then
            '        Generar_OrdenInterna_Operacion_Liquidar()
            '    Else
            '        If dtAlquiler.Rows(0)("NLQDCN") = 0 Then
            '            Generar_OrdenInterna_Operacion_Liquidar()
            '        Else
            '            MessageBox.Show("El alquiler se encuentra enviado al SAP. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        End If
            '    End If
            '    '__________________________________________________________________________

            'Else
            '    MessageBox.Show("Para enviar a SAP eL Alquiler debe ser Aprobado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExportarAlquiler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarAlquiler.Click
        Try
            If (gwdDatos.Rows.Count = 0) Then
                MessageBox.Show("No existen datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim MdataColumna As String = ""
            Dim NPOI As New HelpClass_NPOI_ST
            Dim dtResumen As New DataTable
            dtResumen.Columns.Add("NRALQT").Caption = NPOI.FormatDato("Nro.Alquiler", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("TCMTRT").Caption = NPOI.FormatDato("Proveedor", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TDSDES").Caption = NPOI.FormatDato("Tipo Recurso", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NPLRCS").Caption = NPOI.FormatDato("Placa", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TCMTRF").Caption = NPOI.FormatDato("Servicio", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("FVALIN_S").Caption = NPOI.FormatDato("Fecha de Inicio", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FVALFI_S").Caption = NPOI.FormatDato("Fecha Fin", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("TMNDA").Caption = NPOI.FormatDato("Moneda", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("IMP_TOTAL").Caption = NPOI.FormatDato("Importe Total", HelpClass_NPOI_ST.keyDatoMonto)
            dtResumen.Columns.Add("SESALQ_S").Caption = NPOI.FormatDato("Estado Alquiler", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NORINS").Caption = NPOI.FormatDato("Orden Interna", HelpClass_NPOI_ST.keyDatoTexto)
            'dtResumen.Columns.Add("NLQDCN").Caption = NPOI.FormatDato("Nro.Liquidación", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("CUSCRT").Caption = NPOI.FormatDato("Usuario Creador", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CULUSA").Caption = NPOI.FormatDato("Usuario Actualizador", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("FLGAPR_APR").Caption = NPOI.FormatDato("Aprobación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CUSAPR").Caption = NPOI.FormatDato("Usuario Aprobador", HelpClass_NPOI_ST.keyDatoTexto)
            'dtResumen.Columns.Add("TOBRES2").Caption = NPOI.FormatDato("Observación Aprobador", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CUSRCR").Caption = NPOI.FormatDato("Usuario Cierre", HelpClass_NPOI_ST.keyDatoTexto)
            ' dtResumen.Columns.Add("TOBRES").Caption = NPOI.FormatDato("Observación Cierre", HelpClass_NPOI_ST.keyDatoTexto)

            dtResumen.Columns.Add("TOBS").Caption = NPOI.FormatDato("Obs. alquiler", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TOBRES2").Caption = NPOI.FormatDato("Obs. aprobación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TOBRES").Caption = NPOI.FormatDato("Obs. cierre", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TOBRE3").Caption = NPOI.FormatDato("Obs. envio pedido", HelpClass_NPOI_ST.keyDatoTexto)


            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Fila As Integer = 0 To gwdDatos.Rows.Count - 1
                dr = dtResumen.NewRow
                For Each Col As DataColumn In dtResumen.Columns
                    NameColumna = Col.ColumnName
                    dr(NameColumna) = gwdDatos.Rows(Fila).Cells(NameColumna).Value
                Next
                dtResumen.Rows.Add(dr)
            Next

            Dim oListDtReport As New List(Of DataTable)
            dtResumen.TableName = "Alquiler Unidades"
            oListDtReport.Add(dtResumen.Copy)

            Dim ListTitulo As New List(Of String)
            Dim LisFiltros As New List(Of SortedList)

            ListTitulo.Add("LISTA DE ALQUILER DE UNIDADES")

            NPOI.ExportExcelGeneralMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportarAlquilerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarAlquilerDetalle.Click
        Try
            Dim oDtReporte As New DataTable
            Dim objEntidad As New AlquilerUnidad
            objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
            objEntidad.CDVSN = cmbDivision.Division
            objEntidad.CPLNDV = cmbPlanta.Planta
            objEntidad.SESALQ = cmbEstadoAlq.SelectedValue.ToString.Trim
            objEntidad.NRUCTR = cmbProveedorFiltro.pRucTransportista
            If txtNroAlquiler.Text.Trim = "" Then
                objEntidad.NRALQT = 0
            Else
                objEntidad.NRALQT = CType(txtNroAlquiler.Text, Double)
            End If
            objEntidad.NLQDCN = 0
            If ckbFechaAsignacion.Checked = True Then
                objEntidad.FCHASGI = HelpClass.CFecha_a_Numero8Digitos(dtpFechaAsigInicio.Value)
                objEntidad.FCHASGF = HelpClass.CFecha_a_Numero8Digitos(dtpFechaAsigFin.Value)
            Else
                objEntidad.FCHASGI = 0
                objEntidad.FCHASGF = 0
            End If

            oDtReporte = objAlquilerUnidadBLL.Listar_Unidad_Alquiler_Operaciones_RPT(objEntidad)
            If (oDtReporte.Rows.Count = 0) Then
                MessageBox.Show("No existen datos a exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim MdataColumna As String = ""
            Dim NPOI As New HelpClass_NPOI_SC
            Dim dtResumen As New DataTable
            dtResumen.Columns.Add("NRALQT").Caption = NPOI.FormatDato("Alquiler | Nro. Alquiler", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("TCMTRT").Caption = NPOI.FormatDato("Alquiler | Proveedor", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TDSDES").Caption = NPOI.FormatDato("Alquiler | Tipo Recurso", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NPLRCS").Caption = NPOI.FormatDato("Alquiler | Placa", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("FCHASG").Caption = NPOI.FormatDato("Alquiler | Fecha", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FVALIN").Caption = NPOI.FormatDato("Alquiler | Fecha Inicio", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("FVALFI").Caption = NPOI.FormatDato("Alquiler | Fecha Fin", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("IMP_TOTAL").Caption = NPOI.FormatDato("Alquiler | Importe Total", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("TMNDA").Caption = NPOI.FormatDato("Alquiler | Moneda", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("SESALQ_S").Caption = NPOI.FormatDato("Alquiler | Estado", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CUSRCR").Caption = NPOI.FormatDato("Alquiler | Usuario cierre", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("FLGAPR_APR").Caption = NPOI.FormatDato("Alquiler | Aprobación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CUSAPR").Caption = NPOI.FormatDato("Alquiler | Usuario aprobador", HelpClass_NPOI_ST.keyDatoTexto)
           

            dtResumen.Columns.Add("TOBS").Caption = NPOI.FormatDato("Alquiler |Obs. alquiler", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TOBRES2").Caption = NPOI.FormatDato("Alquiler |Obs. aprobación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TOBRES").Caption = NPOI.FormatDato("Alquiler |Obs. cierre", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TOBRE3").Caption = NPOI.FormatDato("Alquiler |Obs. envio pedido", HelpClass_NPOI_ST.keyDatoTexto)



            dtResumen.Columns.Add("NOPRCN").Caption = NPOI.FormatDato("Operación | Operación", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("FINCOP").Caption = NPOI.FormatDato("Operación | Fecha Operación", HelpClass_NPOI_ST.keyDatoFecha)
            dtResumen.Columns.Add("NORINS").Caption = NPOI.FormatDato("Operación | Orden Interna", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("NORSRT").Caption = NPOI.FormatDato("Operación | O/S", HelpClass_NPOI_ST.keyDatoNumero)
            dtResumen.Columns.Add("CCLNT_S").Caption = NPOI.FormatDato("Operación | Cliente", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("RUTA").Caption = NPOI.FormatDato("Operación | Ruta", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TCMTRT_OP").Caption = NPOI.FormatDato("Operación | Transportista", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NPLCUN").Caption = NPOI.FormatDato("Operación | Placa Tracto", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("NPLCAC").Caption = NPOI.FormatDato("Operación | Placa Acoplado", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("CBRCND").Caption = NPOI.FormatDato("Operación | Conductor", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("SESTOP").Caption = NPOI.FormatDato("Operación | Estado Op.", HelpClass_NPOI_ST.keyDatoTexto)

            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Fila As Integer = 0 To oDtReporte.Rows.Count - 1
                dr = dtResumen.NewRow
                For Each Col As DataColumn In dtResumen.Columns
                    NameColumna = Col.ColumnName
                    dr(NameColumna) = oDtReporte.Rows(Fila).Item(NameColumna)
                Next
                dtResumen.Rows.Add(dr)
            Next
            Dim Visitado As New Hashtable
            Dim Nro_alquiler As String = ""
            For Each Item As DataRow In dtResumen.Rows
                Nro_alquiler = Item("NRALQT")
                If Not Visitado.Contains(Nro_alquiler) Then
                    Visitado.Add(Nro_alquiler, Nro_alquiler)
                Else
                    Item("IMP_TOTAL") = 0
                End If

            Next


            Dim oListDtReport As New List(Of DataTable)
            dtResumen.TableName = "Lista de Alquiler de Unidades y Operaciones"
            oListDtReport.Add(dtResumen.Copy)

            Dim ListTitulo As New List(Of String)
            Dim LisFiltros As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            F.Add(1, "División:| " & cmbDivision.DivisionDescripcion)
            F.Add(2, "Planta:| " & cmbPlanta.DescripcionPlanta)

            LisFiltros.Add(F)

            ListTitulo.Add("ALQUILER DE UNIDADES Y OPERACIONES")
            Dim ListNameCombDuplicado As New List(Of String)
            Dim CombCol As String = "NRALQT:NRALQT/1"
            CombCol = CombCol & "|TCMTRT:NRALQT,TCMTRT/0"
            CombCol = CombCol & "|TDSDES:NRALQT,TDSDES/0|NPLRCS:NRALQT,NPLRCS/0|FCHASG:NRALQT,FCHASG/0"
            CombCol = CombCol & "|FVALIN:NRALQT,FVALIN/0|FVALFI:NRALQT,FVALFI/0|TMNDA:NRALQT,TMNDA/0"
            CombCol = CombCol & "|IMP_TOTAL:NRALQT,IMP_TOTAL/0|SESALQ_S:NRALQT,SESALQ_S/0|CUSRCR:NRALQT,CUSRCR/0"
            CombCol = CombCol & "|FLGAPR_APR:NRALQT,FLGAPR_APR/0|CUSAPR:NRALQT,CUSAPR/0"
            CombCol = CombCol & "|TOBS:NRALQT,TOBS/0|TOBRES2:NRALQT,TOBRES2/0|TOBRES:NRALQT,TOBRES/0|TOBRE3:NRALQT,TOBRE3/0"

            ListNameCombDuplicado.Add(CombCol)

            NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, Nothing, ListNameCombDuplicado)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar1.Click
        Try
            Listar_Alquiler_Unidad()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
 

    Private Sub btnAprobarAlquiler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobarAlquiler.Click

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            If Obtener_Estado_Alquiler_Aprobado() = "X" Then
                MessageBox.Show("El alquiler ya se encuentra aprobado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim objAlquilerUnidad As New AlquilerUnidad
                objAlquilerUnidad.TCMTRT = txtProveedor.Text  'Proveedor
                objAlquilerUnidad.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value 'Numer Alquiler
                objAlquilerUnidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value   ' Cod compañia
                objAlquilerUnidad.CDVSN = gwdDatos.CurrentRow.Cells("CDVSN").Value   'cod division
                objAlquilerUnidad.STPRCS = gwdDatos.CurrentRow.Cells("STPRCS").Value  'Flag Tipo de Recurso
                objAlquilerUnidad.NPLRCS = gwdDatos.CurrentRow.Cells("NPLRCS").Value 'Numero de Placa del Recurso
                objAlquilerUnidad.CULUSA = MainModule.USUARIO  'Usurio Logeo

                Dim frmAprobacionAlquiler As New frmAprobacionAlquiler
                frmAprobacionAlquiler.FechaAsignacion = gwdDatos.CurrentRow.Cells("FCHASG_S").Value
                frmAprobacionAlquiler.FechaVigenciaInicio = gwdDatos.CurrentRow.Cells("FVALIN_S").Value
                frmAprobacionAlquiler.FechaVigenciaFin = gwdDatos.CurrentRow.Cells("FVALFI_S").Value
                frmAprobacionAlquiler.Unidad = txtTipo.Text + " - " + txtPlaca.Text
                frmAprobacionAlquiler.Moneda = cmbMoneda.Text

                frmAprobacionAlquiler.Monto = txtImporte.Text
                frmAprobacionAlquiler.CargarAlquilerAprobacion(objAlquilerUnidad)
                If frmAprobacionAlquiler.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    MessageBox.Show("El alquiler fue aprobado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Listar_Alquiler_Unidad()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarOperacion.Click
        Dim objAlquilerUnidad As New AlquilerUnidad
        Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
        Dim operacion As String = ""
        If Me.gwdDatos.CurrentRow Is Nothing Then Exit Sub
        Try
            objAlquilerUnidad.NRALQT = gwdOperacionesXAlquiler.CurrentRow.Cells("NRALQT1").Value 'Numer Alquiler
            objAlquilerUnidad.NCRRRT = gwdOperacionesXAlquiler.CurrentRow.Cells("NCRRRT").Value   'Numer Operación
            objAlquilerUnidad.CULUSA = MainModule.USUARIO
            objAlquilerUnidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objAlquilerUnidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            operacion = gwdOperacionesXAlquiler.CurrentRow.Cells("NOPRCN").Value
            If MessageBox.Show("Está seguro de eliminar la operación ?" & operacion, "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                objAlquilerUnidadBLL.Eliminar_Operaciones_Alquiler(objAlquilerUnidad)

                Listar_Operaciones_Alquiler()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Obtener_Estado_Alquiler_Aprobado() As String
        Dim strEstado As String = ""
        If Me.gwdDatos.CurrentRow IsNot Nothing Then
            Dim obeAlquilerUnidad As New AlquilerUnidad
            Dim objEntidad As New AlquilerUnidad
            Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
            objEntidad.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value
            objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            obeAlquilerUnidad = objAlquilerUnidad_BLL.Obtener_Datos_Alquiler_Unidad(objEntidad)
            If obeAlquilerUnidad IsNot Nothing Then
                strEstado = obeAlquilerUnidad.FLGAPR.ToString()
            End If
        End If
        Return strEstado
    End Function

  


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If Me.gwdDatos.CurrentRow Is Nothing Then Exit Sub

            Dim strEstado As String = ""
            Dim msgVal As String = ""
            Dim obeAlquilerUnidad As New AlquilerUnidad
            Dim objEntidad As New AlquilerUnidad
            Dim objAlquilerUnidad_BLL As New AlquilerUnidad_BLL
            objEntidad.NRALQT = gwdDatos.CurrentRow.Cells("NRALQT").Value
            objEntidad.CCMPN = gwdDatos.CurrentRow.Cells("CCMPN").Value
            obeAlquilerUnidad = objAlquilerUnidad_BLL.Obtener_Datos_Alquiler_Unidad(objEntidad)

            If obeAlquilerUnidad IsNot Nothing Then
                If obeAlquilerUnidad.SESALQ = "C" Then
                    MessageBox.Show("El alquiler se encuentra cerrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            Dim ofrmVigencia As New frmVigenciaAlquiler
            ofrmVigencia._txtNroAlquiler2 = gwdDatos.CurrentRow.Cells("NRALQT").Value
            ofrmVigencia._tipo = Me.txtTipo.Text
            ofrmVigencia._placa = Me.txtPlaca.Text
            ofrmVigencia._obs = KryptonTextBox3.Text.Trim
            ofrmVigencia._fechaInicio = dtpFechaInicio.Value
            ofrmVigencia._fechaFin = dtpFechaFin.Value
            If ofrmVigencia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Listar_Alquiler_Unidad()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

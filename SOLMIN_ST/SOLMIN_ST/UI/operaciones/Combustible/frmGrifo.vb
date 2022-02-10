Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario
Public Class frmGrifo

#Region "Variable"
  Private gEnum_Mantenimiento As MANTENIMIENTO
#End Region

#Region "Eventos"
  Private Sub frmGrifo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            dtgTarifaGrifo.AutoGenerateColumns = False
            dtgGrifo.AutoGenerateColumns = False
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            HabilitarBotonMantenimiento(gEnum_Mantenimiento)
            Me.Llenar_Combo()
            CargarGrifoProveedor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

  

    Private Sub HabilitarBotonMantenimiento(ByVal opc As MANTENIMIENTO)

        Select Case opc

            Case MANTENIMIENTO.NUEVO

                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnEliminar.Enabled = False
                btnImprimir_1.Enabled = False


                HabilitarEdicion(True)


            Case MANTENIMIENTO.NEUTRAL

                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnEliminar.Enabled = True
                btnImprimir_1.Enabled = True

                HabilitarEdicion(False)


            Case MANTENIMIENTO.EDITAR

                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnEliminar.Enabled = False
                btnImprimir_1.Enabled = False


                HabilitarEdicion(True)

              


        End Select

    End Sub


    Private Sub HabilitarEdicion(edicion As Boolean)
        txtNombreGrifo.Enabled = edicion
        txtNombreAbrev.Enabled = edicion
        ctbUbicacionGeo.Enabled = edicion
        txtLocalidadGrifo.Enabled = edicion
        txtRefCarga.Enabled = edicion
        txtDireccion.Enabled = edicion
        cboGrifoProveedor.Enabled = edicion
    End Sub

    Private Sub CargarGrifoProveedor()
        Dim oListColum As New Hashtable
        Dim obrGrifo As New Grifo_BLL
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim olbeTarifarioGrifo As New List(Of Grifo)
        olbeTarifarioGrifo = obrGrifo.Listar_Grifo_Proveedor()

        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CPRVGR"
        oColumnas.DataPropertyName = "CPRVGR"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DCMPPR"
        oColumnas.DataPropertyName = "DCMPPR"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")


        cboGrifoProveedor.Etiquetas_Form = Etiquetas
        cboGrifoProveedor.DataSource = olbeTarifarioGrifo
        cboGrifoProveedor.ListColumnas = oListColum
        cboGrifoProveedor.Cargas()
        cboGrifoProveedor.ValueMember = "CPRVGR"
        cboGrifoProveedor.DispleyMember = "DCMPPR"





    End Sub


  Private Sub btnAsignarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarTarifa.Click
        Try
            If Me.dtgGrifo.RowCount = 0 OrElse Me.dtgGrifo.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim frm_Tarifa As New frmTarifa
            With frm_Tarifa
                .obeGrifo.CGRFO = Me.dtgGrifo.CurrentRow.Cells("CGRFO").Value
                .obeGrifo.TGRFO = Me.dtgGrifo.CurrentRow.Cells("TGRFO").Value
                .Cantidad = Me.dtgTarifaGrifo.RowCount
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.ListarGrifoTarifario()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
  End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            Me.dtgTarifaGrifo.DataSource = Nothing
            Me.Listar()
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            HabilitarBotonMantenimiento(gEnum_Mantenimiento)

            txtCodGrifo.Text = ""
            txtNombreGrifo.Text = ""
            txtNombreGrifo.Text = ""
            txtNombreAbrev.Text = ""
            ctbUbicacionGeo.Valor = ""
            txtLocalidadGrifo.Text = ""
            txtRefCarga.Text = ""
            txtDireccion.Text = ""
            cboGrifoProveedor.Valor = ""

            

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                If Validar() Then
                    Me.Guardar_Grifo()
                End If
            ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If Validar() Then
                    Me.Modificar_Grifo()
                End If

            
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            HabilitarBotonMantenimiento(gEnum_Mantenimiento)

         
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.txtCodGrifo.Text <> "" Then
                If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
                    Me.Eliminar_Grifo()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

  

    Private Sub btnEliminarTarifa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarTarifa.Click
        Try
            If Me.txtCodGrifo.Text = vbNullString Then Exit Sub
            If Me.dtgTarifaGrifo.CurrentCellAddress.Y < 0 Then Exit Sub
            If Me.dtgTarifaGrifo.Item("SESTVG_D", Me.dtgTarifaGrifo.CurrentCellAddress.Y).Value = "A" Then
                HelpClass.MsgBox("No se puede Eliminar está Activo la Tarifa", MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If HelpClass.RspMsgBox("Desea eliminar este registro?") = MsgBoxResult.Yes Then
                Me.Eliminar_Tarifa_Grifo()
                Me.ListarGrifoTarifario()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    

    

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click, btnImprimir_1.Click

        Try
            Dim obj_Logica_Grifo As New Grifo_BLL
            Dim objDs As New DataSet
            Dim objDt As New DataTable
            Dim objPrintForm As New PrintForm
            Dim objRep As New rptTarifaGrifo
            Dim objParametro As New Hashtable
            If TypeOf sender Is ToolStripButton Then
                If Me.dtgGrifo.RowCount = 0 OrElse Me.dtgGrifo.CurrentCellAddress.Y < 0 Then Exit Sub
                objParametro.Add("PSCGRFO", Me.dtgGrifo.CurrentRow.Cells("CGRFO").Value)
            Else
                objParametro.Add("PSCGRFO", "")
            End If
            objDt = HelpClass.GetDataSetNative(obj_Logica_Grifo.Listar_Tarifa_Actual(objParametro))
            If objDt.Rows.Count = 0 Then
                HelpClass.MsgBox("No hay Tarifas Asignadas")
                Exit Sub
            End If
            objDt.TableName = "RZTR69"
            objDs.Tables.Add(objDt.Copy)
            objRep.SetDataSource(objDs)
            CType(objRep.ReportDefinition.ReportObjects("lblUsuario"), TextObject).Text = MainModule.USUARIO
            objPrintForm.ShowForm(objRep, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
#End Region

#Region "Métodos y Funciones"

    
 

    Private Sub Llenar_Combo()
       

        Dim oListColum As New Hashtable
        Dim obrGrifo As New Grifo_BLL
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim oList As New List(Of LocalidadRuta)
        Dim obj_Logica_Localidad As New NEGOCIO.mantenimientos.LocalidadRuta_BLL
        oList = obj_Logica_Localidad.Listar_Ubigeo_Todos("EZ")
 

        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "CUBGEO"
        oColumnas.DataPropertyName = "CUBGEO"
        oColumnas.HeaderText = "Código"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "UBIGEO"
        oColumnas.DataPropertyName = "UBIGEO"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Código")
        Etiquetas.Add("Descripción")

 

        ctbUbicacionGeo.Etiquetas_Form = Etiquetas
        ctbUbicacionGeo.DataSource = oList
        ctbUbicacionGeo.ListColumnas = oListColum
        ctbUbicacionGeo.Cargas()
        ctbUbicacionGeo.ValueMember = "CUBGEO"
        ctbUbicacionGeo.DispleyMember = "UBIGEO"


    End Sub

    Private Sub Listar()
        Dim olbrGrifo As New Grifo_BLL
        Dim olbeGrifo As New List(Of Grifo)
        olbeGrifo = olbrGrifo.Listar_Grifos_Todos(txtNombreBusqueda.Text.Trim)
        Me.dtgGrifo.DataSource = olbeGrifo

    End Sub

    

    Private Function Validar() As Double
        Dim strError As String = ""
        If Me.txtNombreGrifo.Text.Trim = vbNullString Then
            strError += "* Nombre del Grifo" & Chr(13)
        End If
        'If Me.txtNombreAbrev.Text.Trim = vbNullString Then
        '    strError += "* Nombre Abreviado " & Chr(13)
        'End If
        'If Me.txtNroRUC.Text.Trim = vbNullString Then
        '    strError += "* N° RUC" & Chr(13)
        'End If
        'If Me.ctbUbicacionGeo.NoHayCodigo Then
        '    strError += "* Ubicación Geografica" & Chr(13)
        'End If
        If ctbUbicacionGeo.Resultado Is Nothing Then
            strError += "* Ubicación Geográfica" & Chr(13)
        End If
        If Me.txtLocalidadGrifo.Text.Trim = vbNullString Then
            strError += "* Localidad Grifo" & Chr(13)
        End If

        If cboGrifoProveedor.Resultado Is Nothing Then
            strError += "* Razón Social" & Chr(13)
        End If
        'If txtRefCarga.Text.Trim = "" Then
        '    strError += "* Código Referencia" & Chr(13)
        'End If

        If strError <> "" Then
            MessageBox.Show("Debe ingresar : " & Chr(10) & strError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function
 

    Private Sub ListarGrifoTarifario()
        Dim olbeTarifarioGrifo As New List(Of Grifo)
        If Me.dtgGrifo.CurrentCellAddress.Y < 0 Then Exit Sub

        Dim obrGrifo As New Grifo_BLL
        Dim obeGrifo As New Grifo
        With obeGrifo
            .CGRFO = Me.dtgGrifo.CurrentRow.Cells("CGRFO").Value
        End With
        olbeTarifarioGrifo = obrGrifo.Listar_Tarifa_Grifo(obeGrifo)
        Me.dtgTarifaGrifo.DataSource = olbeTarifarioGrifo

    End Sub

    Private Sub Detalle_Grifo()
        If Me.dtgGrifo.CurrentCellAddress.Y < 0 Then Exit Sub

        With Me.dtgGrifo.CurrentRow
            txtCodGrifo.Text = .Cells("CGRFO").Value
            txtCodGrifo.Tag = Me.dtgGrifo.CurrentRow.Index
            txtNombreGrifo.Text = .Cells("TGRFO").Value
            txtNombreAbrev.Text = .Cells("TAGRFO").Value
            'txtNroRUC.Text = .Cells("NRUCGR").Value
            'ctbUbicacionGeo.Codigo = .Cells("CUBGEO").Value
            ctbUbicacionGeo.Valor = .Cells("CUBGEO").Value
            txtLocalidadGrifo.Text = .Cells("TLCLGR").Value

            txtRefCarga.Text = .Cells("REFCNT").Value
            txtDireccion.Text = .Cells("DREGRF").Value
            cboGrifoProveedor.Valor = .Cells("CPRVGR").Value

        End With

    End Sub

    Private Sub Guardar_Grifo()
        Dim obrGrifo As New Grifo_BLL
        Dim obeGrifo As New Grifo

    

        With obeGrifo
            .TGRFO = txtNombreGrifo.Text
            .TAGRFO = txtNombreAbrev.Text
            '.NRUCGR = txtNroRUC.Text
            .CUBGEO = CType(ctbUbicacionGeo.Resultado, LocalidadRuta).CUBGEO
            .TLCLGR = txtLocalidadGrifo.Text.Trim
            .REFCNT = txtRefCarga.Text.Trim
            .DREGRF = txtDireccion.Text.Trim
            .CPRVGR = CType(cboGrifoProveedor.Resultado, Grifo).CPRVGR

          
            .CULUSA = MainModule.USUARIO
        End With
        Dim IdGrifo As Decimal = 0
        Dim msg As String = ""
        msg = obrGrifo.Registrar_Grifo(obeGrifo, IdGrifo)
        If msg <> "" Then
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            MessageBox.Show("Grifo generado: " & IdGrifo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'Me.AccionCancelar()
        Me.Listar()
       
    End Sub

    Private Sub Modificar_Grifo()
        Dim obrGrifo As New Grifo_BLL
        Dim obeGrifo As New Grifo
        Dim msg As String = ""
        With obeGrifo
            .CGRFO = Me.txtCodGrifo.Text
            .TGRFO = txtNombreGrifo.Text
            .TAGRFO = txtNombreAbrev.Text
            '.NRUCGR = txtNroRUC.Text
            '.CUBGEO = ctbUbicacionGeo.Codigo
            .CUBGEO = CType(ctbUbicacionGeo.Resultado, LocalidadRuta).CUBGEO
            .TLCLGR = txtLocalidadGrifo.Text
            .REFCNT = txtRefCarga.Text.Trim
            .DREGRF = txtDireccion.Text.Trim
            .CPRVGR = CType(cboGrifoProveedor.Resultado, Grifo).CPRVGR
          
            .CULUSA = MainModule.USUARIO
        End With
        msg = obrGrifo.Modificar_Grifo(obeGrifo)
        If msg <> "" Then
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        HabilitarBotonMantenimiento(gEnum_Mantenimiento)

        Me.Listar()
        
    End Sub

    Private Sub Eliminar_Grifo()
        Dim obrGrifo As New Grifo_BLL
        Dim obeGrifo As New Grifo

        With obeGrifo
            .CGRFO = Me.txtCodGrifo.Text
            .FULTAC = HelpClass.TodayNumeric
            .HULTAC = HelpClass.NowNumeric
            .CULUSA = MainModule.USUARIO
        End With
        obrGrifo.Eliminar_Grifo(obeGrifo)
        Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
        HabilitarBotonMantenimiento(gEnum_Mantenimiento)


        Me.Listar()
       
    End Sub

    Private Sub Eliminar_Tarifa_Grifo()
        Dim obrGrifo As New Grifo_BLL
        Dim obeGrifo As New Grifo

        With obeGrifo
            .CGRFO = Me.txtCodGrifo.Text
            .CTPCMB = Me.dtgTarifaGrifo.CurrentRow.Cells("CTPCMB_D").Value
            .NCRRTR = Me.dtgTarifaGrifo.CurrentRow.Cells("NCRRTR_D").Value
            .FULTAC = HelpClass.TodayNumeric
            .HULTAC = HelpClass.NowNumeric
            .CULUSA = MainModule.USUARIO
        End With
        obrGrifo.Eliminar_Tarifa_Grifo(obeGrifo)
      
    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSADI = "" Then
            Me.btnNuevo.Visible = False

        End If
        If objEntidad.STSCHG = "" Then
            Me.btnGuardar.Visible = False

        End If
        If objEntidad.STSADI = "" And objEntidad.STSCHG = "" Then
            Me.btnCancelar.Visible = False

        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False

        End If
        If objEntidad.STSOP1 = "" Then
            Me.btnAsignarTarifa.Visible = False

        End If
        If objEntidad.STSOP2 = "" Then
            Me.btnEliminarTarifa.Visible = False

        End If

    End Sub

#End Region


    Private Sub dtgGrifo_SelectionChanged(sender As Object, e As EventArgs) Handles dtgGrifo.SelectionChanged
        Try
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            HabilitarBotonMantenimiento(gEnum_Mantenimiento)

            Detalle_Grifo()
            ListarGrifoTarifario()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)

            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Resultado"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Resultado"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Resultado"))
            'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            Dim dtExportar As New DataTable
            For Each item As DataGridViewColumn In dtgGrifo.Columns
                If item.Visible = True Then
                    dtExportar.Columns.Add(item.Name)
                End If

            Next
            Dim dr As DataRow
            For Each item As DataGridViewRow In dtgGrifo.Rows
                dr = dtExportar.NewRow
                For Each Columns As DataColumn In dtExportar.Columns
                    If dtgGrifo.Columns(Columns.ColumnName) IsNot Nothing Then
                        dr(Columns.ColumnName) = item.Cells(Columns.ColumnName).Value
                    End If
                Next
                dtExportar.Rows.Add(dr)
            Next
            For Each item As DataColumn In dtExportar.Columns
                If dtgGrifo.Columns(item.ColumnName) IsNot Nothing Then
                    item.ColumnName = dtgGrifo.Columns(item.ColumnName).HeaderText
                End If
            Next

            'objDt = CType(Me.dgvCargaVale.DataSource, DataTable).Copy
            'ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dtgGrifo, objDt))
            ODs.Tables.Add(dtExportar)
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If dtgGrifo.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            HabilitarBotonMantenimiento(gEnum_Mantenimiento)

            
            Dim obrGrifo As New Grifo_BLL
            Dim IdGrifo As Decimal = dtgGrifo.CurrentRow.Cells("CGRFO").Value
            Dim CantReg As Decimal = obrGrifo.Listar_Grifo_Validacion_Edicion(IdGrifo)
            If CantReg = 0 Then
                txtNombreGrifo.Enabled = True
                cboGrifoProveedor.Enabled = True
            Else
                txtNombreGrifo.Enabled = False
                cboGrifoProveedor.Enabled = False
            End If
 

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class


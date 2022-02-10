Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports System.Data
Imports System.Collections.Generic
Imports Ransa.Utilitario
Public Class frmRecursoEquipo
    Private bolBuscar As Boolean = False
    Private gEnumOpcMan As Opcion = Opcion.Neutral
    Enum Opcion
        Neutral
        Nuevo
        Modificar
    End Enum
#Region " Atributos "

#End Region
#Region " Eventos "
    Private Sub frmRecursoEquipo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Compania()
        HabilitarBoton(Opcion.Neutral)
        Estado_Controles(False)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(Opcion.Neutral)
            Listar_Recurso_Equipo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        gEnumOpcMan = Opcion.Nuevo
        Estado_Controles(True)
        Limpiar_Controles()
        HabilitarBoton(Opcion.Nuevo)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try

            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            gEnumOpcMan = Opcion.Modificar

            HabilitarBoton(Opcion.Modificar)
            Estado_Controles(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try
            Select Case gEnumOpcMan
                Case Opcion.Nuevo
                    If ValidarRecursoEquipo() = 1 Then
                        Registrar_Equipo()
                    End If

                Case Opcion.Modificar
                    If ValidarRecursoEquipo() = 1 Then
                        Modificar_Equipo()
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            If MessageBox.Show("Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Eliminar_Equipo()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(Opcion.Neutral)
            'Asignar_Datos()
            Estado_Controles(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub



    Private Sub gwdDatos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(Opcion.Neutral)
            Asignar_Datos()
            Estado_Controles(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
        Try
            If Me.gwdDatos.Rows.Count > 0 Then
                Me.gwdDatos.CurrentRow.Selected = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPesoRecurso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoRecurso.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case Else : e.Handled = True
        End Select
    End Sub
#End Region
#Region " Procedimiento "
    Private Sub HabilitarBoton(ByVal op As Opcion)
        Select Case op
            Case Opcion.Neutral
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Visible = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = True
                'Me.Estado_Controles(False)

            Case Opcion.Nuevo
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False

            Case Opcion.Modificar
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False

        End Select

    End Sub

    Private Sub Estado_Controles(ByVal lbool_estado As Boolean)
        Me.txtNumPlacaRecurso.Enabled = lbool_estado
        If Me.gEnumOpcMan = Opcion.Modificar Then
            Me.txtNumPlacaRecurso.Enabled = Not lbool_estado
        End If
        Me.txtColorUnidad.Enabled = lbool_estado
        Me.txtFechaFabricacion.Enabled = lbool_estado
        Me.txtMarcaModelo.Enabled = lbool_estado
        Me.txtPesoRecurso.Enabled = lbool_estado
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub Limpiar_Controles()
        Me.txtColorUnidad.Text = ""
        Me.txtFechaFabricacion.Text = ""
        Me.txtMarcaModelo.Text = ""
        Me.txtNumPlacaRecurso.Text = ""
        Me.txtPesoRecurso.Text = ""
        Me.HeaderDatos.ValuesPrimary.Heading = ""
    End Sub

    'Private Sub Cargar_Tipo_Recurso()
    '    Dim oListColum As New Hashtable
    '    Dim oColumnas As New DataGridViewTextBoxColumn
    '    Dim Etiquetas As New List(Of String)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "TCRVTA"
    '    oColumnas.DataPropertyName = "TCRVTA"
    '    oColumnas.HeaderText = "Negocio"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    oListColum.Add(1, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "CCNTCS"
    '    oColumnas.DataPropertyName = "CCNTCS"
    '    oColumnas.HeaderText = "Cód. CC"
    '    oListColum.Add(2, oColumnas)

    '    oColumnas = New DataGridViewTextBoxColumn
    '    oColumnas.Name = "TCNTCS"
    '    oColumnas.DataPropertyName = "TCNTCS"
    '    oColumnas.HeaderText = "Centro Costo"
    '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    oListColum.Add(3, oColumnas)

    '    Etiquetas.Add("Cod. CC")
    '    Etiquetas.Add("Centro Costo")
    '    Dim objRecursoEquipo As New RecursoEquipo
    '    objRecursoEquipo.CCMPN = cmbCompania.CCMPN_CodigoCompania
    '    Dim objRecursoEquipoBLL As New RecursoEquipo_BLL
    '    cmbTipoRecurso.DataSource = Nothing
    '    cmbTipoRecurso.DataSource = objRecursoEquipoBLL.Listar_Tipo_Recurso_Equipo(objRecursoEquipo)
    '    Me.cmbTipoRecurso.ListColumnas = oListColum
    '    Me.cmbTipoRecurso.Etiquetas_Form = Etiquetas
    '    Me.cmbTipoRecurso.Cargas()
    '    Me.cmbTipoRecurso.Limpiar()
    '    Me.cmbTipoRecurso.ValueMember = "CCNTCS"
    '    Me.cmbTipoRecurso.DispleyMember = "TCNTCS"
    'End Sub

    Private Sub Registrar_Equipo()
        Dim objEntidad As New RecursoEquipo
        Dim objTracto As New RecursoEquipo_BLL

        objEntidad.NPLRCS = Me.txtNumPlacaRecurso.Text
        'objEntidad.NEJSUN = IIf(Me.txtNumEjes.Text = "", 0, Me.txtNumEjes.Text)
        'objEntidad.NSRCHU = Me.txtNumChasis.Text
        'objEntidad.NSRMTU = Me.txtSerieMotor.Text
        objEntidad.FFBRUN = IIf(Me.txtFechaFabricacion.Text = "", 0, Me.txtFechaFabricacion.Text)
        objEntidad.TCLRUN = Me.txtColorUnidad.Text
        'objEntidad.TCRRUN = Me.txtCarroceriaUnidad.Text
        'objEntidad.NCPCRU = IIf(Me.txtCapCargaUnidad.Text = "", 0, Me.txtCapCargaUnidad.Text)
        'objEntidad.CTIEQP = IIf(Me.txtCodigoTipoRecurso.Codigo = "", 0, Me.txtCodigoTipoRecurso.Codigo)
        objEntidad.QPSOTR = IIf(Me.txtPesoRecurso.Text = "", 0, Me.txtPesoRecurso.Text)
        objEntidad.TMRCTR = Me.txtMarcaModelo.Text
        'objEntidad.NRGMT1 = Me.txtNumEmpadMTC.Text
        'objEntidad.NTERPM = Me.txtNroRPM.Text
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania

        Dim v_NPLRCS As String = objEntidad.NPLRCS
        objEntidad = objTracto.Registrar_Recurso_Equipo(objEntidad)

        If objEntidad.NPLRCS = "-1" Then ' -1 : El tracto existe en la tabla
            objEntidad.NPLRCS = v_NPLRCS
            objEntidad.CULUSA = objEntidad.CUSCRT
            objEntidad.FULTAC = objEntidad.FCHCRT
            objEntidad.HULTAC = objEntidad.HRACRT
            objEntidad.NTRMNL = objEntidad.NTRMCR
            objEntidad = objTracto.Modificar_Recurso_Equipo(objEntidad)
        End If

        If objEntidad.NPLRCS = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            gEnumOpcMan = Opcion.Neutral
            Listar_Recurso_Equipo()
        End If
    End Sub

    Private Sub Modificar_Equipo()
        Dim objEntidad As New RecursoEquipo
        Dim objRecursoEquipo As New RecursoEquipo_BLL


        objEntidad.NPLRCS = Me.txtNumPlacaRecurso.Text
        'objEntidad.NEJSUN = IIf(Me.txtNumEjes.Text = "", 0, Me.txtNumEjes.Text)
        'objEntidad.NSRCHU = Me.txtNumChasis.Text
        'objEntidad.NSRMTU = Me.txtSerieMotor.Text
        objEntidad.FFBRUN = IIf(Me.txtFechaFabricacion.Text = "", 0, Me.txtFechaFabricacion.Text)
        objEntidad.TCLRUN = Me.txtColorUnidad.Text
        'objEntidad.TCRRUN = Me.txtCarroceriaUnidad.Text
        'objEntidad.NCPCRU = IIf(Me.txtCapCargaUnidad.Text = "", 0, Me.txtCapCargaUnidad.Text)
        'objEntidad.CTIEQP = Me.txtCodigoTipoRecurso.Codigo
        objEntidad.QPSOTR = IIf(Me.txtPesoRecurso.Text = "", 0, Me.txtPesoRecurso.Text)
        objEntidad.TMRCTR = Me.txtMarcaModelo.Text
        'objEntidad.NRGMT1 = Me.txtNumEmpadMTC.Text
        'objEntidad.NTERPM = Me.txtNroRPM.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        objEntidad = objRecursoEquipo.Modificar_Recurso_Equipo(objEntidad)

        If objEntidad.NPLRCS = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnumOpcMan = Opcion.Neutral
            Listar_Recurso_Equipo()
        End If
    End Sub

    Private Sub Eliminar_Equipo()
        Dim objEntidad As New RecursoEquipo
        Dim objEquipo As New RecursoEquipo_BLL

        objEntidad.NPLRCS = Me.txtNumPlacaRecurso.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        objEntidad = objEquipo.Eliminar_Recurso_Equipo(objEntidad)

        If objEntidad.NPLRCS = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        Else
            Me.gEnumOpcMan = Opcion.Neutral
            Listar_Recurso_Equipo()
        End If
    End Sub

    Private Sub Asignar_Datos()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

        Limpiar_Controles()

        If gwdDatos.CurrentRow IsNot Nothing Then
            Dim olbeEntidad As New List(Of RecursoEquipo)
            Dim obeEntidad As New RecursoEquipo
            Dim objTracto As New RecursoEquipo_BLL
            obeEntidad.NPLRCS = gwdDatos.CurrentRow.Cells("NPLRCS").Value
            obeEntidad.CCMPN = cmbCompania.CCMPN_CodigoCompania
            olbeEntidad = objTracto.Obtener_Recurso_Equipo(obeEntidad)
            If olbeEntidad.Count = 0 Then Exit Sub
            Me.txtNumPlacaRecurso.Text = olbeEntidad.Item(0).NPLRCS
            'Me.txtNumEjes.Text = olbeEntidad.Item(0).NEJSUN
            'Me.txtNumChasis.Text = olbeEntidad.Item(0).NSRCHU
            'Me.txtSerieMotor.Text = olbeEntidad.Item(0).NSRMTU
            Me.txtFechaFabricacion.Text = olbeEntidad.Item(0).FFBRUN
            Me.txtColorUnidad.Text = olbeEntidad.Item(0).TCLRUN
            'Me.txtCarroceriaUnidad.Text = olbeEntidad.Item(0).TCRRUN
            'Me.txtCapCargaUnidad.Text = olbeEntidad.Item(0).NCPCRU
            'If olbeEntidad.Item(0).CTIEQP.Trim.Equals("") Then
            '    Me.txtCodigoTipoRecurso.Limpiar()
            'Else
            '    Me.txtCodigoTipoRecurso.Codigo = olbeEntidad.Item(0).CTIEQP
            'End If
            Me.txtPesoRecurso.Text = olbeEntidad.Item(0).QPSOTR
            Me.txtMarcaModelo.Text = olbeEntidad.Item(0).TMRCTR
            'Me.txtNumEmpadMTC.Text = olbeEntidad.Item(0).NRGMT1
            'Me.txtNroRPM.Text = olbeEntidad.Item(0).NTERPM

            Me.HeaderDatos.ValuesPrimary.Heading = "Información de Recurso Equipo / Placa: " & olbeEntidad.Item(0).NPLRCS
        End If

    End Sub

    Private Sub Listar_Recurso_Equipo()
        Limpiar_Controles()
        Dim objEquipo As New RecursoEquipo_BLL
        Dim objEntidad As New RecursoEquipo
        objEntidad.NPLRCS = Me.txtBuscar.Text.Trim
        objEntidad.CCMPN = Me.cmbCompania.CCMPN_CodigoCompania
        Me.gwdDatos.AutoGenerateColumns = False
        Me.gwdDatos.DataSource = objEquipo.Buscar_Recurso_Equipo(objEntidad)
    End Sub

    Private Function ValidarRecursoEquipo() As Integer
        If txtNumPlacaRecurso.Text = "" Then
            MsgBox("Ingrese la placa.", MsgBoxStyle.Exclamation)
            Return 0
            'ElseIf txtCodigoTipoRecurso.Codigo = "" Then
            '    MsgBox("Debe seleccionar el tipo de recurso.", MsgBoxStyle.Exclamation)
            '    Return 0
        End If
        Return 1
    End Function
#End Region


    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            Dim oDtReporte As New DataTable
            Dim MdataColumna As String = ""
            Dim NPOI As New HelpClass_NPOI_ST
            Dim dtResumen As New DataTable
            dtResumen.Columns.Add("NPLRCS").Caption = NPOI.FormatDato("Placa", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("FFBRUN").Caption = NPOI.FormatDato("Año Fabricación", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TCLRUN").Caption = NPOI.FormatDato("Color unidad", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("QPSOTR").Caption = NPOI.FormatDato("Peso", HelpClass_NPOI_ST.keyDatoTexto)
            dtResumen.Columns.Add("TMRCTR").Caption = NPOI.FormatDato("Marca/Modelo", HelpClass_NPOI_ST.keyDatoTexto)
          
            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Each Item As DataGridViewRow In gwdDatos.Rows
                dr = dtResumen.NewRow
                For Each Col As DataColumn In dtResumen.Columns
                    NameColumna = Col.ColumnName
                    If dtResumen.Columns(NameColumna) IsNot Nothing Then
                        dr(NameColumna) = Item.Cells(NameColumna).Value
                    End If
                Next
                dtResumen.Rows.Add(dr)
            Next

            Dim oListDtReport As New List(Of DataTable)
            dtResumen.TableName = "EQUIPOS"
            oListDtReport.Add(dtResumen.Copy)

            Dim ListTitulo As New List(Of String)
            Dim LisFiltros As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.CCMPN_Descripcion)
            LisFiltros.Add(F)
            ListTitulo.Add("LISTADO DE EQUIPOS")
            NPOI.ExportExcelGeneralMultiple(oListDtReport, ListTitulo, Nothing, LisFiltros, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

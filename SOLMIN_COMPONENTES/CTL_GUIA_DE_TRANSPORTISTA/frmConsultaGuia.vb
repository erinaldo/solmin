Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmConsultaGuia

  Private _PLANTA As String = ""
  Private _COMPANIA As String = ""
  Private _TIPOGUIA As Int16 = 0
  Private _COD_TRANSPORTISTA As Int32 = 0
  Private _GUIA_TRANSPORTISTA As Int64 = 0
  Private _CLIENTE As Int32 = 0
  Private _USUARIO As String = ""
  Private _TIPO_VIAJE As Int16 = 0
    'Private _objTable As DataTable
  Private _NOPRCN As Int64 = 0
    Private Objeto_Entidad_Guia As GuiaTransportista
    Public pDialogOK As Boolean = False
  Public Property Guia_Transporte() As GuiaTransportista
    Get
      Return Objeto_Entidad_Guia
    End Get
    Set(ByVal value As GuiaTransportista)
      Objeto_Entidad_Guia = value
    End Set
  End Property

  Public WriteOnly Property Operacion() As Int64
    Set(ByVal value As Int64)
      _NOPRCN = value
    End Set
  End Property

    'Public WriteOnly Property objTable() As DataTable
    '  Set(ByVal value As DataTable)
    '    _objTable = value
    '  End Set
    'End Property

  Public WriteOnly Property TIPO_VIAJE() As Int16
    Set(ByVal value As Int16)
      _TIPO_VIAJE = value
    End Set
  End Property

  Public WriteOnly Property CLIENTE() As Int32
    Set(ByVal value As Int32)
      _CLIENTE = value
    End Set
  End Property

  Public WriteOnly Property GUIA_TRANSPORTISTA() As Int64
    Set(ByVal value As Int64)
      _GUIA_TRANSPORTISTA = value
    End Set
  End Property

  Public WriteOnly Property COD_TRANSPORTISTA() As Int32
    Set(ByVal value As Int32)
      _COD_TRANSPORTISTA = value
    End Set
  End Property

  Public WriteOnly Property TIPO_GUIA() As Int16
    Set(ByVal value As Int16)
      _TIPOGUIA = value
    End Set
  End Property

  Public WriteOnly Property PLANTA() As String
    Set(ByVal value As String)
      _PLANTA = value
    End Set
  End Property

  Public WriteOnly Property COMPANIA() As String
    Set(ByVal value As String)
      _COMPANIA = value
    End Set
  End Property

  Public WriteOnly Property USUARIO() As String
    Set(ByVal value As String)
      _USUARIO = value
    End Set
    End Property

    Private _Division As String
    Public Property DIVISION() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property
   


    Private Sub frmConsultaGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dtgGuiaRemision.AutoGenerateColumns = False
        If _TIPOGUIA = 1 Then
            Me.dtgGuiaRemision.Columns("NGUIRM_S").HeaderText = "N° Guía Proveedor"
            Me.dtgGuiaRemision.Columns("FGUIRM_0").HeaderText = "Fecha Ingreso"
            Me.dtgGuiaRemision.Columns("TCMPCL_0").HeaderText = "Proveedor"
            Me.lblGuia.Text = "Guía Proveedor"
            Me.txtFiltroGuiaProveedor.Visible = True
            'Me.lblNombre.Text = "Proveedor"
        Else
            Me.txtFiltroGuiaRemision.Visible = True
            Me.txtGuiaRemision.Visible = False
            Me.lblGuiaRemision.Visible = False
        End If
        'Else
        Me.UcCliente_GuiaRemision.CCMPN = _COMPANIA
        Me.UcCliente_GuiaRemision.pCargar(Me._CLIENTE)
        If Me._TIPO_VIAJE = 0 Then
            Me.btnBuscaOrdenServicio.Visible = False
            Me.txtOperacion.Visible = False
            Me.lblOperacion.Visible = False
            Me.txtOperacion.Text = Me._NOPRCN
        End If

        CargarPlanta()

    End Sub




    'Private Sub txtFiltroGuiaRemision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltroGuiaRemision.KeyPress
    '    If e.KeyChar = "." Then
    '        e.Handled = True
    '        Exit Sub
    '    End If
    '    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    'End Sub

    Private Sub txtFiltroGuiaRemision_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroGuiaRemision.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txtFiltroGuiaRemision.Text.Trim.Equals("") Then Exit Sub
                Me.btnBuscar_Click(Nothing, Nothing)
                If Me.dtgGuiaRemision.RowCount = 1 Then
                    Me.dtgGuiaRemision.Item("SELECCIONAR", 0).Value = True
                End If
            End If
        Catch : End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            If Me.UcCliente_GuiaRemision.pCodigo = 0 Then
                HelpClass.MsgBox("Ingrese Cliente", MessageBoxIcon.Information)
                Exit Sub
            End If
            If _TIPOGUIA = 0 Then
                Me.Listar_Guias_Cliente()
            Else
                Me.Listar_Guias_Cliente_Proveedor()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  

    End Sub

    Private Sub CargarPlanta()
        Me.cmbPlanta.Usuario = Me._USUARIO
        Me.cmbPlanta.CodigoCompania = Me._COMPANIA
        'Me.cmbPlanta.CodigoDivision = IIf("" & DIVISION.ToString.Trim = "", "T", DIVISION)
        Me.cmbPlanta.CodigoDivision = "R"
        Me.cmbPlanta.PlantaDefault = Me._PLANTA
        Me.cmbPlanta.pActualizar()
    End Sub

    Private Sub Listar_Guias_Cliente()
        dtgGuiaRemision.AutoGenerateColumns = False
        Dim obj_Logica As New GuiaTransportista_BLL
        Dim obj_Entidad As New Hashtable
        'Dim dwvrow As DataGridViewRow
        'Try

        If Me.lblGuia.Checked Then
            If Me.txtFiltroGuiaRemision.Text.Trim = "" Then
                HelpClass.MsgBox("Ingrese Guía Remisión", MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        obj_Entidad.Add("CCMPN", Me._COMPANIA)
        'obj_Entidad.Add("CPLNDV", Me._PLANTA)
        obj_Entidad.Add("CPLNDV", cmbPlanta.Planta)
        obj_Entidad.Add("CCLNT", Me.UcCliente_GuiaRemision.pCodigo)
        'obj_Entidad.Add("NGUIRM", IIf(Me.lblGuia.Checked = True, Me.txtFiltroGuiaRemision.Text, 0))
        obj_Entidad.Add("NGUIRM", IIf(Me.lblGuia.Checked = True, Me.txtFiltroGuiaRemision.Text.Trim, ""))
        obj_Entidad.Add("FECINI", IIf(Me.dtpFechaFiltroInicio.Enabled = True, CType(HelpClass.CtypeDate(Me.dtpFechaFiltroInicio.Value), Double), 0))
        obj_Entidad.Add("FECFIN", IIf(Me.dtpFechaFiltroFin.Enabled = True, CType(HelpClass.CtypeDate(Me.dtpFechaFiltroFin.Value), Double), 0))
        'Me.dtgGuiaRemision.Rows.Clear()
        dtgGuiaRemision.DataSource = Nothing
        'Dim cant_reg As Integer = 0
        Dim oList As New List(Of GuiaTransportista)
        oList = obj_Logica.Listar_Guias_x_Transportista(obj_Entidad)
        dtgGuiaRemision.DataSource = oList

        'For Each objEntidad As GuiaTransportista In obj_Logica.Listar_Guias_x_Transportista(obj_Entidad)
        '    dwvrow = New DataGridViewRow
        'dwvrow.CreateCells(Me.dtgGuiaRemision)
        'dwvrow.Cells(0).Value = False
        'dwvrow.Cells(1).Value = objEntidad.NGUIRM_S
        'dwvrow.Cells(2).Value = objEntidad.FGUIRM_S
        'dwvrow.Cells(3).Value = objEntidad.TCMPCL
        'dwvrow.Cells(4).Value = objEntidad.CCLNT
        'dwvrow.Cells(5).Value = objEntidad.CPRVCL
        'dwvrow.Cells(6).Value = objEntidad.NGUIRM
        'Me.dtgGuiaRemision.Rows.Add(dwvrow)



        'dwvrow.CreateCells(Me.dtgGuiaRemision)
        'Me.dtgGuiaRemision.Rows.Add(dwvrow)
        'cant_reg = dtgGuiaRemision.Rows.Count - 1
        'dtgGuiaRemision.Rows(cant_reg).Cells("SELECCIONAR").Value = False
        'dtgGuiaRemision.Rows(cant_reg).Cells("NGUIRM_S").Value = objEntidad.NGUIRM_S
        'dtgGuiaRemision.Rows(cant_reg).Cells("FGUIRM_0").Value = objEntidad.FGUIRM_S
        'dtgGuiaRemision.Rows(cant_reg).Cells("TCMPCL_0").Value = objEntidad.TCMPCL
        'dtgGuiaRemision.Rows(cant_reg).Cells("CCLNT_0").Value = objEntidad.CCLNT
        'dtgGuiaRemision.Rows(cant_reg).Cells("CPRVCL_0").Value = objEntidad.CPRVCL
        'dtgGuiaRemision.Rows(cant_reg).Cells("NGUIRM_0").Value = objEntidad.NGUIRM

        'Next
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Listar_Guias_Cliente_Proveedor()
        Dim obj_Logica As New GuiaTransportista_BLL
        Dim obj_Entidad As New Hashtable
        'Dim dwvrow As DataGridViewRow
        'Try
        If Me._TIPOGUIA = 0 Then
            If Me.lblGuia.Checked Then
                If Me.txtFiltroGuiaRemision.Text.Trim = "" Then
                    HelpClass.MsgBox("Ingrese Guía Remisión", MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Else
            If Me.lblGuia.Checked Then
                If Me.txtFiltroGuiaProveedor.Text.Trim = "" Then
                    HelpClass.MsgBox("Ingrese Guía Proveedor", MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        End If

        obj_Entidad.Add("CCMPN", Me._COMPANIA)
        'obj_Entidad.Add("CPLNDV", Me._PLANTA)
        obj_Entidad.Add("CPLNDV", cmbPlanta.Planta)
        obj_Entidad.Add("CCLNT", Me.UcCliente_GuiaRemision.pCodigo)
        obj_Entidad.Add("NGUIRM", Me.txtFiltroGuiaProveedor.Text.Trim)
        obj_Entidad.Add("FECINI", IIf(Me.dtpFechaFiltroInicio.Enabled = True, CType(HelpClass.CtypeDate(Me.dtpFechaFiltroInicio.Value), Double), 0))
        obj_Entidad.Add("FECFIN", IIf(Me.dtpFechaFiltroFin.Enabled = True, CType(HelpClass.CtypeDate(Me.dtpFechaFiltroFin.Value), Double), 0))
        'Me.dtgGuiaRemision.Rows.Clear()
        dtgGuiaRemision.DataSource = Nothing

        Dim oList As New List(Of GuiaTransportista)
        oList = obj_Logica.Listar_Guias_x_Transportista_Proveedor(obj_Entidad)
        dtgGuiaRemision.DataSource = oList

        'For Each objEntidad As GuiaTransportista In obj_Logica.Listar_Guias_x_Transportista_Proveedor(obj_Entidad)
        '    dwvrow = New DataGridViewRow
        '    dwvrow.CreateCells(Me.dtgGuiaRemision)
        '    dwvrow.Cells(0).Value = False
        '    dwvrow.Cells(1).Value = objEntidad.NGUIRM_S.Trim
        '    dwvrow.Cells(2).Value = objEntidad.FGUIRM_S
        '    dwvrow.Cells(3).Value = objEntidad.TCMPCL
        '    dwvrow.Cells(4).Value = objEntidad.CCLNT
        '    dwvrow.Cells(5).Value = objEntidad.CPRVCL
        '    dwvrow.Cells(6).Value = objEntidad.NGUIRM
        '    Me.dtgGuiaRemision.Rows.Add(dwvrow)
        'Next
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub lblGuiaRemi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGuia.CheckedChanged
        If Me._TIPOGUIA = 0 Then
            If Me.lblGuia.Checked = True Then
                Me.txtFiltroGuiaRemision.Enabled = True
                Me.dtpFechaFiltroInicio.Enabled = False
                Me.dtpFechaFiltroFin.Enabled = False
            Else
                Me.txtFiltroGuiaRemision.Enabled = False
                Me.dtpFechaFiltroInicio.Enabled = True
                Me.dtpFechaFiltroFin.Enabled = True
            End If
        Else
            If Me.lblGuia.Checked = True Then
                Me.txtFiltroGuiaProveedor.Enabled = True
                Me.dtpFechaFiltroInicio.Enabled = False
                Me.dtpFechaFiltroFin.Enabled = False
            Else
                Me.txtFiltroGuiaProveedor.Enabled = False
                Me.dtpFechaFiltroInicio.Enabled = True
                Me.dtpFechaFiltroFin.Enabled = True
            End If
        End If

    End Sub

    Private Sub dtgGuiaRemision_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgGuiaRemision.CellDoubleClick
        If e.RowIndex = -1 And e.ColumnIndex = 0 Then
            If Me.dtgGuiaRemision.RowCount = 0 Then Exit Sub
            Dim lintEstado As Boolean = Me.dtgGuiaRemision.Item(0, 0).Value
            For lint_Contador As Integer = 0 To Me.dtgGuiaRemision.RowCount - 1
                Me.dtgGuiaRemision.Item(0, lint_Contador).Value = Not lintEstado
                Me.dtgGuiaRemision.EndEdit()
            Next

        End If
    End Sub

    Private Function Validar_Check_Grilla(ByVal dtgGrilla As ComponentFactory.Krypton.Toolkit.KryptonDataGridView) As Boolean
        Dim lbool_Estado As Boolean = False
        For lint_Contador As Integer = 0 To dtgGrilla.RowCount - 1
            If dtgGrilla.Item(0, lint_Contador).Value = True Then
                lbool_Estado = True
                Exit For
            End If
        Next
        Return lbool_Estado
    End Function

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Try
            pDialogOK = True
            Dim obj_Table As DataTable
            'Dim objHash As Hashtable
            If _TIPOGUIA = 0 Then
                Me.dtgGuiaRemision.CommitEdit(DataGridViewDataErrorContexts.Commit)
                If Me.Validar_Check_Grilla(Me.dtgGuiaRemision) = False Then
                    HelpClass.MsgBox("FALTA SELECCIONAR GUIA DE REMISION", MessageBoxIcon.Information)
                    Exit Sub
                End If
                If Me._TIPO_VIAJE = 1 Then
                    If Me.txtOperacion.Text.Trim = "" Then
                        HelpClass.MsgBox("FALTA ASIGNAR OPERACION", MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
                Dim obj_Logica As New GuiaTransportista_BLL
                Dim obj_EntidadGuia As GuiaTransportista
                Dim frmMovimiento As frmMovimiento
                'Dim obj_Table As DataTable
                Dim lintContador As Int32 = 0
                'Try

                'SELECCIONAR
                For lint_Contador As Integer = 0 To Me.dtgGuiaRemision.RowCount - 1
                    'If CBool(Me.dtgGuiaRemision.Item(0, lint_Contador).FormattedValue) = True Then
                    If CBool(Me.dtgGuiaRemision.Item("SELECCIONAR", lint_Contador).FormattedValue) = True Then
                        obj_EntidadGuia = New GuiaTransportista
                        'Llenando los datos de la guia de Anexo
                        obj_EntidadGuia.CTRMNC = Me._COD_TRANSPORTISTA
                        obj_EntidadGuia.NGUIRM = Me._GUIA_TRANSPORTISTA
                        obj_EntidadGuia.NRGUCL = Me.dtgGuiaRemision.Item("NGUIRM_0", lint_Contador).Value

                        obj_EntidadGuia.NGUIRS = Me.dtgGuiaRemision.Item("NGUIRS", lint_Contador).Value
                        obj_EntidadGuia.CTDGRM = Me.dtgGuiaRemision.Item("CTDGRM", lint_Contador).Value
                        obj_EntidadGuia.CTPCRG = "GR"


                        obj_EntidadGuia.FCGUCL = CType(HelpClass.CtypeDate(Me.dtgGuiaRemision.Item("FGUIRM_0", lint_Contador).Value), Double)
                        obj_EntidadGuia.CCLNT = Me.dtgGuiaRemision.Item("CCLNT_0", lint_Contador).Value
                        obj_EntidadGuia.CPRVCL = 0
                        obj_EntidadGuia.FLAG_PSOVOL = _TIPOGUIA
                        'obj_EntidadGuia.FULTAC = HelpClass.TodayNumeric
                        'obj_EntidadGuia.HULTAC = HelpClass.NowNumeric
                        obj_EntidadGuia.CULUSA = Me._USUARIO
                        obj_EntidadGuia.NTRMNL = ""
                        obj_EntidadGuia.CCMPN = Me._COMPANIA
                        obj_EntidadGuia.CDVSN = "R"
                        'obj_EntidadGuia.CPLNDV = Me._PLANTA
                        obj_EntidadGuia.CPLNDV = cmbPlanta.Planta

                        obj_Table = New DataTable
                        obj_Table = obj_Logica.Lista_Guia_Salida_Zona_GR(obj_EntidadGuia)
                        If obj_Table.Rows.Count > 1 Then
                            frmMovimiento = New frmMovimiento
                            With frmMovimiento
                                .Tabla = obj_Table
                                .ShowDialog()
                                obj_EntidadGuia.NRGUSA = .Guia_Salida
                            End With
                        Else
                            If obj_Table.Rows.Count = 0 Then
                                HelpClass.MsgBox("No existe información de Bultos", MessageBoxIcon.Information)
                                Exit For
                            Else
                                obj_EntidadGuia.NRGUSA = obj_Table.Rows(0).Item("NRGUSA")
                            End If

                        End If
                        If obj_EntidadGuia.NRGUSA = 0 Then Exit Sub
                        'REALIZAR REVISION 21-03-2012
                        obj_EntidadGuia.NOPRCN = Me.txtOperacion.Text
                        'obj_EntidadGuia.NRSERI = 0
                        'obj_EntidadGuia.NPRGUI = 0
                        'Proceso de registro
                        'obj_Logica.Registrar_GuiasCliente_Automatico(obj_EntidadGuia)
                        obj_Logica.Registrar_GuiasCliente_Automatico_Origen(obj_EntidadGuia)


                        '--PENDIENTE DE MODIFICACION

                        'objHash = New Hashtable
                        'objHash.Add("NOPRCN", obj_EntidadGuia.NOPRCN)
                        'objHash.Add("NGUIRM", obj_EntidadGuia.NRGUCL)
                        'objHash.Add("FGUIRM", Me.dtgGuiaRemision.Item("FGUIRM_0", lint_Contador).Value)
                        'Me.Generar_Carga_Guia_Transporte(objHash)

                        lintContador += 1
                        'Me.dtgGuiaRemision.Item(0, lint_Contador).Value = False
                        Me.dtgGuiaRemision.Item("SELECCIONAR", lint_Contador).Value = False
                        Me.dtgGuiaRemision.EndEdit()
                    End If
                Next
                If lintContador > 0 Then
                    HelpClass.MsgBox("El Proceso culminó Satisfactoriamente", MessageBoxIcon.Information)
                End If
                'Catch ex As Exception
                '    HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
                'End Try

            Else
                If Me.txtGuiaRemision.Text.Trim = "" OrElse Me.txtGuiaRemision.Text.Trim = 0 Then
                    HelpClass.MsgBox("Ingresar Guía Remisión", MessageBoxIcon.Information)
                    Exit Sub
                End If
                Me.dtgGuiaRemision.CommitEdit(DataGridViewDataErrorContexts.Commit)
                If Me.Validar_Check_Grilla(Me.dtgGuiaRemision) = False Then
                    HelpClass.MsgBox("Falta Seleccionar Guía", MessageBoxIcon.Information)
                    Exit Sub
                End If


                Dim obj_Logica As New GuiaTransportista_BLL
                Dim obj_EntidadGuia As GuiaTransportista
                'Dim frmMovimiento As frmMovimiento
                'Dim obj_Table As DataTable
                Dim lintContador As Int32 = 0
                'Try
                For lint_Contador As Integer = 0 To Me.dtgGuiaRemision.RowCount - 1
                    If CBool(Me.dtgGuiaRemision.Item(0, lint_Contador).FormattedValue) = True Then
                        obj_EntidadGuia = New GuiaTransportista
                        'Llenando los datos de la guia de Anexo
                        obj_EntidadGuia.CTRMNC = Me._COD_TRANSPORTISTA
                        obj_EntidadGuia.NGUIRM = Me._GUIA_TRANSPORTISTA

                        obj_EntidadGuia.NRGUCL = Me.txtGuiaRemision.Text.Trim
                        obj_EntidadGuia.NGUIRS = Me.txtGuiaRemision.Text.ToUpper

                        obj_EntidadGuia.CTDGRM = "F"
                        obj_EntidadGuia.CTPCRG = "GP"

                        'obj_EntidadGuia.TOBS = Me.dtgGuiaRemision.Item("NGUIRM_S", lint_Contador).Value ' guia proveedor
                        obj_EntidadGuia.TOBS = Me.dtgGuiaRemision.Item("NGUIRS", lint_Contador).Value ' guia proveedor
                        obj_EntidadGuia.FCGUCL = CType(HelpClass.CtypeDate(Me.dtgGuiaRemision.Item("FGUIRM_0", lint_Contador).Value), Double)
                        obj_EntidadGuia.CCLNT = Me.dtgGuiaRemision.Item("CCLNT_0", lint_Contador).Value
                        obj_EntidadGuia.CPRVCL = Me.dtgGuiaRemision.Item("CPRVCL_0", lint_Contador).Value
                        obj_EntidadGuia.FLAG_PSOVOL = _TIPOGUIA
                        'obj_EntidadGuia.FULTAC = HelpClass.TodayNumeric
                        'obj_EntidadGuia.HULTAC = HelpClass.NowNumeric
                        obj_EntidadGuia.CULUSA = Me._USUARIO
                        obj_EntidadGuia.NTRMNL = ""
                        obj_EntidadGuia.CCMPN = Me._COMPANIA
                        obj_EntidadGuia.CDVSN = "R"
                        'obj_EntidadGuia.CPLNDV = Me._PLANTA
                        obj_EntidadGuia.CPLNDV = cmbPlanta.Planta

                        obj_EntidadGuia.NOPRCN = Me.txtOperacion.Text
                        'obj_Table = New DataTable
                        'obj_Table = obj_Logica.Lista_Movimiento_Bulto_Zona_GP(obj_EntidadGuia)
                        'If obj_Table.Rows.Count > 1 Then
                        '    frmMovimiento = New frmMovimiento
                        '    With frmMovimiento
                        '        .Tabla = obj_Table
                        '        .ShowDialog()
                        '        obj_EntidadGuia.NRGUSA = .Guia_Salida
                        '    End With
                        'Else
                        '    obj_EntidadGuia.NRGUSA = obj_Table.Rows(0).Item("NRGUSA")
                        'End If

                        'obj_EntidadGuia.NRSERI = 0
                        'obj_EntidadGuia.NPRGUI = 0
                        'Proceso de registro
                        'obj_Logica.Registrar_GuiasCliente_Automatico(obj_EntidadGuia)
                        obj_Logica.Registrar_GuiasCliente_Automatico_Origen(obj_EntidadGuia)
                        'objHash = New Hashtable
                        'objHash.Add("NOPRCN", obj_EntidadGuia.NOPRCN)
                        'objHash.Add("NGUIRM", obj_EntidadGuia.NRGUCL)
                        'objHash.Add("FGUIRM", Me.dtgGuiaRemision.Item("FGUIRM_0", lint_Contador).Value)
                        'Me.Generar_Carga_Guia_Transporte(objHash)

                        lintContador += 1
                        Me.dtgGuiaRemision.Item(0, lint_Contador).Value = False
                        Me.dtgGuiaRemision.EndEdit()
                    End If
                Next

                If lintContador > 0 Then
                    HelpClass.MsgBox("El Proceso culminó Satisfactoriamente", MessageBoxIcon.Information)
                    '  Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
                'Catch ex As Exception
                '    HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
                'End Try

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      


    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub txtGuiaRemision_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiaRemision.KeyPress
    '    If e.KeyChar = "." Then
    '        e.Handled = True
    '        Exit Sub
    '    End If
    '    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    'End Sub

    Private Sub btnBuscaOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaOrdenServicio.Click
        Dim frmListaoperacion As New frmConsultaOperacion
        With frmListaoperacion
            '.Tabla = Me._objTable.Copy
            If .ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Me.txtOperacion.Text = .Operacion
        End With
    End Sub

    Private Sub Generar_Carga_Guia_Transporte(ByVal objHash As Hashtable)
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim sGuiaPrincipal As Int64 = 0
        Dim oHash As New Hashtable
        Dim intEstatus As Int16 = 0
        Dim dFechaGuiaPrincipal As Date = Date.Now
        Dim sRelacionGuiasSeleccionada As String = ""
        Dim intCMRCDR As Integer = 0
        Dim strTCMRCD As String = ""

        oHash.Add("NOPRCN", objHash("NOPRCN"))
        oHash.Add("NGUIRM", objHash("NGUIRM"))
        oHash.Add("CCMPN", Me._COMPANIA)

        intEstatus = Objeto_Logica.Validar_Operacion_Guia_Remision(oHash, intCMRCDR, strTCMRCD)

        If intEstatus = 0 Then

            'LLENANDO EL dtgGuiasPendientes  
            sGuiaPrincipal = objHash("NGUIRM")
            dFechaGuiaPrincipal = objHash("FGUIRM")

            Dim oTemp As New TD_Obj_InfGRemCargada
            With oTemp
                .pCTRMNC_CodigoTransportista = Objeto_Entidad_Guia.CTRMNC
                .pNGUIRM_NroGuiaTransportista = Objeto_Entidad_Guia.NGUIRM
                .pNGUITR_GuiaRemisionCargada = sGuiaPrincipal
                .pFGUITR_FechaGuiaRemision = dFechaGuiaPrincipal
                .pRELGUI_RelacionGuiaHijas = sRelacionGuiasSeleccionada
                .pCCLNT1_CodigoCliente = Me._CLIENTE 'Objeto_Entidad_Guia.CCLNT
                .pCLCLOR_CodigoLocalidadOrigen = Objeto_Entidad_Guia.CLCLOR
                .pTCMLCO_LocalidadOrigen = Objeto_Entidad_Guia.TCMLCO
                .pCLCLDS_CodigoLocalidadDestino = Objeto_Entidad_Guia.CLCLDS
                .pTCMLCD_LocalidadDestino = Objeto_Entidad_Guia.TCMLCD
                .pNOPRCN_NroOperacion = objHash("NOPRCN") 'Objeto_Entidad_Guia.NOPRCN
                .pNLQDCN_NroLiquidacion = 0
                .pCTRSPT_Transportista = Objeto_Entidad_Guia.CTRSPT
                .pTCMTRT_RazSocialTransportista = Objeto_Entidad_Guia.TCMTRT ' Me.cboTransportista.pRazonSocial
                .pNPLVHT_Tracto = Objeto_Entidad_Guia.NPLCTR
                .pCBRCNT_Brevete = Objeto_Entidad_Guia.CBRCNT
                .pCMRCDR_Mercaderia = intCMRCDR 'Objeto_Entidad_Guia.CMRCDR Me.gwdSolicitud.Item("D_CMRCDR", int_Indice).Value
                .pTAMRCD_DetalleMercaderia = strTCMRCD 'Objeto_Entidad_Guia.TCMRCD Me.gwdSolicitud.Item("D_TCMRCD", int_Indice).Value
                .pFRCGRM_FechaRecepGuiaRemision = Now
                .pQGLGSL_CantidadGlsGasolina = Objeto_Entidad_Guia.QGLGSL
                .pQGLDSL_CantidadGlsDiesel = Objeto_Entidad_Guia.QGLDSL
                .pNRHJCR_NroHojasCargui = Objeto_Entidad_Guia.NRHJCR
                .pCPRCN1_CodigoPropietarioContenedor1 = ""
                .pNSRCN1_SerieContenedor1 = ""
                .pCPRCN2_CodigoPropietarioContenedor2 = ""
                .pNSRCN2_SerieContenedor2 = ""
                .pFLLGCM_FechaLlegadaCamion = Now
                .pFSLDCM_FechaSalidaCamion = Now
                .pQKLMRC_KilometrosRecorridos = Objeto_Entidad_Guia.QKMREC
                .pQHRSRV_CantidadHorasServicio = 0
                .pQBLRMS_CantidadBultosRemision = Objeto_Entidad_Guia.QMRCMC
                .pPBRTOR_PesoBrutoRemision = IIf(Objeto_Entidad_Guia.QPSOBR = 0, Objeto_Entidad_Guia.PMRCMC, Objeto_Entidad_Guia.QPSOBR)
                If Objeto_Entidad_Guia.QPSOBR <> 0 And Objeto_Entidad_Guia.PMRCMC <> 0 Then
                    .pPTRAOR_PesoTaraRemision = Objeto_Entidad_Guia.QPSOBR - Objeto_Entidad_Guia.PMRCMC
                    .pPTRDST_PesoTaraRecepcion = Objeto_Entidad_Guia.QPSOBR - Objeto_Entidad_Guia.PMRCMC
                Else
                    .pPTRAOR_PesoTaraRemision = 0
                    .pPTRDST_PesoTaraRecepcion = 0
                End If
                .pQVLMOR_VolumenRemision = Objeto_Entidad_Guia.QVLMOR
                .pQBLRCP_CantidadBultosRecepcion = Objeto_Entidad_Guia.QMRCMC
                .pPBRDST_PesoBrutoRecepcion = .pPBRTOR_PesoBrutoRemision
                .pQVLMDS_VolumenRecepcion = Objeto_Entidad_Guia.QVLMOR
                .pMMCUSR_Usuario = Me._USUARIO
                .pNTRMNL_Terminal = ""
                .pCCMPN_Compania = Me._COMPANIA
            End With

            Dim bResultado As Boolean = True
            Dim sErrorMesage As String = ""
            Dim resultado As Int32 = 0
            bResultado = Objeto_Logica.Registrar_GuiaRemisionLiqTransp(oTemp, sErrorMesage)
            If Not bResultado Or sErrorMesage <> "" Then
                MessageBox.Show(sErrorMesage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If

    End Sub

End Class

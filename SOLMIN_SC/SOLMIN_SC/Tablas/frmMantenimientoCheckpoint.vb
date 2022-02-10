Imports SOLMIN_SC.Negocio
Imports System.Web
Imports SOLMIN_SC.Entidad

Public Class frmMantenimientoCheckpoint

#Region "Atributos"
    Private oCliente As Negocio.clsCliente
    Private oCheckPoint As clsCheckPoint
    Private bolBuscarCheck As Boolean
    Private bolBuscarCheck2 As Boolean
    Private strSeguimiento As String
    Private oEstado As clsEstado
    Private intPosicion As Integer
    Public BuscarDatosDefault As Boolean = False
    Private _ACCION As String

    Private _CodCliente As String

    Private _Cliente_Secundario As Boolean = False

    Public Property CodCliente() As String
        Get
            Return _CodCliente
        End Get
        Set(ByVal value As String)
            _CodCliente = value
        End Set
    End Property

    Private _CodTipoCheckpoint As String
    Public Property CodTipoCheckpoint() As String
        Get
            Return _CodTipoCheckpoint
        End Get
        Set(ByVal value As String)
            _CodTipoCheckpoint = value
        End Set
    End Property

    Private _CodCheckpoint As String
    Public Property CodCheckpoint() As String
        Get
            Return _CodCheckpoint
        End Get
        Set(ByVal value As String)
            _CodCheckpoint = value
        End Set
    End Property

    Private strCompania As String

    Property Compania()
        Get
            Return Me.strCompania
        End Get
        Set(ByVal value)
            Me.strCompania = value
        End Set
    End Property
    Private strDivision As String
    Property Division()
        Get
            Return Me.strDivision
        End Get
        Set(ByVal value)
            Me.strDivision = value
        End Set
    End Property

    Private strEstado As String


    Private _Estado As String
    Property Estado()
        Get
            Return Me._Estado
        End Get
        Set(ByVal value)
            Me._Estado = value
        End Set
    End Property

    Private _NomSeguimiento As String

    Property NomSeguimiento()
        Get
            Return Me._NomSeguimiento
        End Get
        Set(ByVal value)
            Me._NomSeguimiento = value
        End Set
    End Property


    Private _SESTRG2 As String

    Property SESTRG2()
        Get
            Return Me._SESTRG2
        End Get
        Set(ByVal value)
            Me._SESTRG2 = value
        End Set
    End Property

    Private _SESTRG As String

    Property SESTRG()
        Get
            Return Me._SESTRG
        End Get
        Set(ByVal value)
            Me._SESTRG = value
        End Set
    End Property

    Private _NroPresentacion As String

    Property NroPresentacion()
        Get
            Return Me._NroPresentacion
        End Get
        Set(ByVal value)
            Me._NroPresentacion = value
        End Set
    End Property


#End Region

#Region "Metodos y Funciones"

    Private Sub CargarTipoCheckMantenimiento()
        bolBuscarCheck = False
        Dim dtCheckPoint As New DataTable
        oCheckPoint = New clsCheckPoint()
        Dim dr As DataRow
        dtCheckPoint.Columns.Add("VALVAR")
        dtCheckPoint.Columns.Add("NOMVAR")
        dr = dtCheckPoint.NewRow
        dr("VALVAR") = ""
        dr("NOMVAR") = "TODOS"
        dtCheckPoint.Rows.Add(dr)
        'dtCheckPoint = oCheckPoint.Cargar_Tipo_CheckPoint(-1)
        'Dim NumFila As Int32 = dtCheckPoint.Rows.Count - 1
        'Dim VALVAR As String = ""
        cmbTipoCheckpoint.DataSource = dtCheckPoint
        cmbTipoCheckpoint.ValueMember = "VALVAR"
        bolBuscarCheck = True
        cmbTipoCheckpoint.DisplayMember = "NOMVAR"
        cmbTipoCheckpoint.SelectedValue = ""
    End Sub

    Private Sub CargarTipoCheckMantenimiento_SIL()
        bolBuscarCheck = False
        Dim dtCheckPoint As New DataTable
        oCheckPoint = New clsCheckPoint()
        dtCheckPoint = oCheckPoint.Cargar_Tipo_CheckPoint(-1)
        Dim NumFila As Int32 = dtCheckPoint.Rows.Count - 1
        Dim VALVAR As String = ""
        dtCheckPoint.Rows.RemoveAt(3)
        dtCheckPoint.Rows.RemoveAt(2)
        cmbTipoCheckpoint.DataSource = dtCheckPoint
        cmbTipoCheckpoint.ValueMember = "VALVAR"
        bolBuscarCheck = True
        cmbTipoCheckpoint.DisplayMember = "NOMVAR"
        cmbTipoCheckpoint.Refresh()


    End Sub
  
    Public Sub CargarDatos()
        cmbTipoCheckpoint.SelectedValue = Me.CodTipoCheckpoint
        Cargar_Checkpoint(Nothing, Nothing)
        'cmbCheckpoint.SelectedValue = Me.CodCheckpoint
        _Cliente_Secundario = True
        UcCheckpoint.Valor = Me.CodCheckpoint
        cmbDivision.pHabilitado = False
        txtNomSeguimiento.Text = Me.NomSeguimiento
        If Me.SESTRG2 = "A" Then
            chbEstadoSeguimiento.Checked = 1
        Else
            chbEstadoSeguimiento.Checked = 0
        End If
        'If Me.SESTRG = "A" Then
        '    'chbEstadoCheckpoint.Checked = 1
        'Else
        '    'chbEstadoCheckpoint.Checked = 0
        'End If
        txtOrdenCheckPoint.Text = Me.NroPresentacion
        _ACCION = "Update"
    End Sub

    Private Sub Buscar_CheckPoint_X_Cliente_Sec()
        'Dim intCont As Integer
        Dim oDt As New DataTable

        oCheckPoint = New clsCheckPoint()
        'oCheckPoint.Compania = Me.Compania
        'oCheckPoint.Division = Me.Division
        txtOrdenCheckPoint.Text = 0
        Dim obeCheckPoint As New beCheckPoint
        obeCheckPoint = CType(UcCheckpoint.Resultado, beCheckPoint)

        oDt = oCheckPoint.Buscar_CheckPoint_X_Cliente_Sec(Me.CodCliente, Me.cmbTipoCheckpoint.SelectedValue, obeCheckPoint.PNNESTDO, Me.Compania, Me.Division)
        'oDt = oCheckPoint.Buscar_CheckPoint_X_Cliente_Sec(Me.CodCliente, Me.cmbTipoCheckpoint.SelectedValue, Me.cmbCheckpoint.SelectedValue, Me.Compania, Me.Division)
        'oDt = oCheckPoint.Buscar_CheckPoint_X_Cliente(Me.CodCliente, Me.cmbTipoCheckpoint.SelectedValue, Me.Estado, Me.cmbCheckpoint.SelectedValue)
        If oDt Is Nothing Then
            _ACCION = "Insert"
        Else
            'With oDt
            If oDt.Rows.Count > 0 Then
                txtOrdenCheckPoint.Text = String.Empty
                cmbTipoCheckpoint.SelectedValue = oDt.Rows(0).Item("CEMB").ToString.Trim
                _Cliente_Secundario = True
                UcCheckpoint.Valor = oDt.Rows(0).Item("NESTDO").ToString.Trim
                txtNomSeguimiento.Text = oDt.Rows(0).Item("TCOLUM").ToString.Trim
                txtOrdenCheckPoint.Text = oDt.Rows(0).Item("NSEPRE").ToString.Trim
                If oDt.Rows(0).Item("SESTRG").ToString.Trim = "A" Then
                    chbEstadoSeguimiento.Checked = 1
                Else
                    chbEstadoSeguimiento.Checked = 0
                End If
                _ACCION = "Update"
                'KryptonLabel1.Visible = True

                'For intCont = 0 To .Rows.Count - 1
                '  cmbTipoCheckpoint.SelectedValue = .Rows(intCont).Item("CEMB").ToString.Trim
                '_Cliente_Secundario = True
                'UcCheckpoint.Valor = .Rows(intCont).Item("NESTDO").ToString.Trim

                'cmbCheckpoint.SelectedValue = .Rows(intCont).Item("NESTDO").ToString.Trim
                'txtNomSeguimiento.Text = .Rows(intCont).Item("TCOLUM").ToString.Trim

                'txtOrdenCheckPoint.Text = .Rows(intCont).Item("NSEPRE").ToString.Trim

                'If .Rows(intCont).Item("SESTRG").ToString.Trim = "A" Then
                '    chbEstadoSeguimiento.Checked = 1
                'Else
                '    chbEstadoSeguimiento.Checked = 0
                'End If

                'If .Rows(intCont).Item("ASIGNADO").ToString.Trim = "A" Then
                '    'chbEstadoCheckpoint.Checked = 1
                'Else
                '    'chbEstadoCheckpoint.Checked = 0
                'End If
                'Next intCont
                '_ACCION = "Update"
                'txtOrdenCheckPoint.Visible = True
                'KryptonLabel1.Visible = True
            Else
                _ACCION = "Insert"
                'txtOrdenCheckPoint.Visible = False
                'KryptonLabel1.Visible = False
                chbEstadoSeguimiento.Checked = True
            End If
            'End With
        End If
    End Sub

    'Private Sub Guardar()

    '    Dim strEstadoSeg As String
    '    Dim strEstadoCheck As String
    '    'Try
    '        If chbEstadoSeguimiento.Checked Then
    '            strEstadoSeg = "A"
    '        Else
    '            strEstadoSeg = "*"
    '        End If
    '        strEstadoCheck = "A"
    '        If CType(UcCheckpoint.Resultado, beCheckPoint).PNNESTDO And txtNomSeguimiento.Text <> vbNullString Then
    '            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '            If _ACCION = "Insert" Then
    '                oCheckPoint.Mant_CheckPoint_X_Cliente(Me.Compania, Me.Division, "I", Me.CodCliente, CType(UcCheckpoint.Resultado, beCheckPoint).PNNESTDO, txtNomSeguimiento.Text, strEstadoCheck, strEstadoSeg, 0)
    '                Me.DialogResult = Windows.Forms.DialogResult.OK
    '                MessageBox.Show("Registro Agregado.")
    '            'Me.DialogResult = Windows.Forms.DialogResult.OK
    '            Else
    '                If _ACCION = "Update" Then
    '                    oCheckPoint.Mant_CheckPoint_X_Cliente(Me.Compania, Me.Division, "M", Me.CodCliente, CType(UcCheckpoint.Resultado, beCheckPoint).PNNESTDO, txtNomSeguimiento.Text, strEstadoCheck, strEstadoSeg, Me.txtOrdenCheckPoint.Text.Trim())
    '                    Me.DialogResult = Windows.Forms.DialogResult.OK
    '                    MessageBox.Show("Registro Modificado.")
    '                'Me.DialogResult = Windows.Forms.DialogResult.OK
    '                End If
    '            End If
    '            'Me.Cursor = System.Windows.Forms.Cursors.Default
    '        Else
    '            'Me.Cursor = System.Windows.Forms.Cursors.Default
    '            HelpUtil.MsgBox("Debe colocar el nombre del checkpoint para el cliente")
    '        End If
    '    'Catch ex As Exception
    '    '    'Me.Cursor = System.Windows.Forms.Cursors.Default
    '    '    HelpUtil.MsgBox(ex.Message)
    '    'End Try
    'End Sub


#End Region

#Region "Eventos"

    Private Sub Buscar_CheckPoint_X_Cliente()
        'Dim intCont As Integer
        Dim oDt As New DataTable
        oCheckPoint = New clsCheckPoint()
        'oCheckPoint.Compania = Me.Compania
        'oCheckPoint.Division = Me.Division
        oDt = oCheckPoint.Buscar_CheckPoint_X_Cliente(Me.CodCliente, Me.CodTipoCheckpoint, Me.Estado, Me.CodCheckpoint, Me.Compania, Me.Division)
        If oDt Is Nothing Then
            txtOrdenCheckPoint.Text = 0
            _ACCION = "Insert"
        Else
            'With oDt
            If oDt.Rows.Count > 0 Then
                cmbTipoCheckpoint.SelectedValue = oDt.Rows(0).Item("CEMB").ToString.Trim
                _Cliente_Secundario = True
                UcCheckpoint.Valor = oDt.Rows(0).Item("NESTDO").ToString.Trim
                txtNomSeguimiento.Text = oDt.Rows(0).Item("TCOLUM").ToString.Trim
                txtOrdenCheckPoint.Text = oDt.Rows(0).Item("NSEPRE").ToString.Trim
                If oDt.Rows(0).Item("SESTRG").ToString.Trim = "A" Then
                    chbEstadoSeguimiento.Checked = 1
                Else
                    chbEstadoSeguimiento.Checked = 0
                End If
                'For intCont = 0 To .Rows.Count - 1
                'cmbTipoCheckpoint.SelectedValue = .Rows(intCont).Item("CEMB").ToString.Trim

                '_Cliente_Secundario = True
                'UcCheckpoint.Valor = .Rows(intCont).Item("NESTDO").ToString.Trim

                ''cmbCheckpoint.SelectedValue = .Rows(intCont).Item("NESTDO").ToString.Trim
                'txtNomSeguimiento.Text = .Rows(intCont).Item("TCOLUM").ToString.Trim
                'txtOrdenCheckPoint.Text = .Rows(intCont).Item("NSEPRE").ToString.Trim

                'If .Rows(intCont).Item("SESTRG").ToString.Trim = "A" Then
                '    chbEstadoSeguimiento.Checked = 1
                'Else
                '    chbEstadoSeguimiento.Checked = 0
                'End If

                'If .Rows(intCont).Item("ASIGNADO").ToString.Trim = "A" Then
                '    'chbEstadoCheckpoint.Checked = 1
                'Else
                '    'chbEstadoCheckpoint.Checked = 0
                'End If
                'Next intCont
            End If
            'End With
            _ACCION = "Update"
        End If

    End Sub

    Private Sub frmMantenimientoCheckpoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbDivision.Compania = strCompania
            cmbDivision.Usuario = HelpUtil.UserName
            cmbDivision.DivisionDefault = strDivision
            cmbDivision.pActualizar()
            cmbDivision.Refresh()
            cmbDivision.pHabilitado = False
            cmbDivision_SelectionChangeCommitted(Nothing)
            oCheckPoint = New clsCheckPoint()
            'Me.CargarTipoCheckMantenimiento()
            _ACCION = "Insert"
            If (BuscarDatosDefault = False) Then
                CargarDatos()
                'Else
                'Buscar_CheckPoint_X_Cliente_Sec()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub cmbTipoCheckpoint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoCheckpoint.SelectedIndexChanged
    '    If _ACCION = "Insert" Then
    '        txtOrdenCheckPoint.Text = String.Empty
    '        txtNomSeguimiento.Text = String.Empty
    '    End If
    '    If bolBuscarCheck Then
    '        bolBuscarCheck2 = False
    '        'cmbCheckpoint.DataSource = oCheckPoint.Lista_CheckPoint_X_Tipo(cmbTipoCheckpoint.SelectedValue) 'filtro_CheckPoint_X_Tipo

    '        Dim beCheck As beCheckPoint
    '        Dim Lista As List(Of beCheckPoint)
    '        Lista = New List(Of beCheckPoint)

    '        For Each dr As DataRow In oCheckPoint.Lista_CheckPoint_X_Tipo(cmbTipoCheckpoint.SelectedValue).Rows
    '            beCheck = New beCheckPoint

    '            beCheck.PNNESTDO = dr("NESTDO")
    '            beCheck.PSTDESES = dr("TDESES")

    '            Lista.Add(beCheck)
    '        Next

    '        Dim oListColum As New Hashtable
    '        Dim oColumnas As New DataGridViewTextBoxColumn
    '        oColumnas.Name = "PNNESTDO"
    '        oColumnas.DataPropertyName = "PNNESTDO"
    '        oColumnas.HeaderText = "Código"
    '        oListColum.Add(1, oColumnas)
    '        oColumnas = New DataGridViewTextBoxColumn
    '        oColumnas.Name = "PSTDESES"
    '        oColumnas.DataPropertyName = "PSTDESES"
    '        oColumnas.HeaderText = "Descripción"
    '        oListColum.Add(2, oColumnas)

    '        If Not Lista Is Nothing Then
    '            UcCheckpoint.DataSource = Lista
    '        Else
    '            UcCheckpoint.DataSource = Nothing
    '        End If
    '        UcCheckpoint.ListColumnas = oListColum
    '        UcCheckpoint.Cargas()
    '        UcCheckpoint.Limpiar()
    '        UcCheckpoint.ValueMember = "PNNESTDO"
    '        UcCheckpoint.DispleyMember = "PSTDESES"

    '        'cmbCheckpoint.ValueMember = "NESTDO"
    '        'cmbCheckpoint.DisplayMember = "TDESES"

    '        'If (cmbTipoCheckpoint.Text <> "" And CType(UcCheckpoint.Resultado, beCheckPoint).PSTDESES.Trim <> "") Then
    '        '    'If (BuscarDatosDefault = False) Then
    '        '    Buscar_CheckPoint_X_Cliente_Sec()
    '        '    ' End If
    '        'End If

    '        'txtNomSeguimiento.Text = CType(UcCheckpoint.Resultado, beCheckPoint).PSTDESES

    '        'txtCodigo.Text = cmbCheckpoint.SelectedValue.ToString.Trim
    '        bolBuscarCheck2 = True
    '    End If

    'End Sub

    Private Sub Cargar_Checkpoint(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoCheckpoint.SelectionChangeCommitted
        Try
            If _ACCION = "Insert" Then
                txtOrdenCheckPoint.Text = String.Empty
                txtNomSeguimiento.Text = String.Empty
            End If
            If bolBuscarCheck Then
                bolBuscarCheck2 = False
                'cmbCheckpoint.DataSource = oCheckPoint.Lista_CheckPoint_X_Tipo(cmbTipoCheckpoint.SelectedValue) 'filtro_CheckPoint_X_Tipo

                Dim beCheck As beCheckPoint
                Dim Lista As List(Of beCheckPoint)
                Lista = New List(Of beCheckPoint)

                Dim dtCheckpointDivision As New DataTable
                'dtCheckpointDivision = New DataTable
                dtCheckpointDivision = oCheckPoint.Lista_CheckPoint_X_Division(cmbDivision.Division)

                For Each dr As DataRow In dtCheckpointDivision.Rows
                    beCheck = New beCheckPoint

                    If cmbDivision.Division = "S" Then
                        If cmbTipoCheckpoint.SelectedValue = dr("CEMB") Then
                            beCheck.PNNESTDO = dr("NESTDO")
                            beCheck.PSTDESES = dr("TDESES")
                            Lista.Add(beCheck)
                        End If
                    Else
                        beCheck.PNNESTDO = dr("NESTDO")
                        beCheck.PSTDESES = dr("TDESES")
                        Lista.Add(beCheck)
                    End If
                Next

                Dim oListColum As New Hashtable
                Dim oColumnas As New DataGridViewTextBoxColumn
                oColumnas.Name = "PNNESTDO"
                oColumnas.DataPropertyName = "PNNESTDO"
                oColumnas.HeaderText = "Código"
                oListColum.Add(1, oColumnas)
                oColumnas = New DataGridViewTextBoxColumn
                oColumnas.Name = "PSTDESES"
                oColumnas.DataPropertyName = "PSTDESES"
                oColumnas.HeaderText = "Descripción"
                oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                oListColum.Add(2, oColumnas)

                If Lista.Count > 0 Then
                    UcCheckpoint.DataSource = Lista
                Else
                    UcCheckpoint.DataSource = Nothing
                End If
                UcCheckpoint.ListColumnas = oListColum
                UcCheckpoint.Cargas()
                UcCheckpoint.Limpiar()
                UcCheckpoint.ValueMember = "PNNESTDO"
                UcCheckpoint.DispleyMember = "PSTDESES"

                'cmbCheckpoint.ValueMember = "NESTDO"
                'cmbCheckpoint.DisplayMember = "TDESES"

                'If (cmbTipoCheckpoint.Text <> "" And CType(UcCheckpoint.Resultado, beCheckPoint).PSTDESES.Trim <> "") Then
                '    If (BuscarDatosDefault = False) Then
                '        Buscar_CheckPoint_X_Cliente_Sec()
                '    End If
                'End If

                'txtNomSeguimiento.Text = CType(UcCheckpoint.Resultado, beCheckPoint).PSTDESES

                'txtCodigo.Text = cmbCheckpoint.SelectedValue.ToString.Trim
                bolBuscarCheck2 = True

                txtOrdenCheckPoint.Text = String.Empty
                txtNomSeguimiento.Text = String.Empty

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

     

    End Sub


    'Private Sub cmbCheckpoint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'If _ACCION = "Insert" Then
    '    txtOrdenCheckPoint.Text = String.Empty
    'End If
    'If bolBuscarCheck2 Then
    '    Me.txtNomSeguimiento.Text = Me.cmbCheckpoint.Text.Trim()
    '    If (cmbTipoCheckpoint.Text <> "" And cmbCheckpoint.Text <> "") Then
    '        Buscar_CheckPoint_X_Cliente_Sec()
    '        'txtCodigo.Text = cmbCheckpoint.SelectedValue
    '    End If

    'End If

    'End Sub

    Private Function Validar() As String
        Dim msgvalidar As String = ""
        txtNomSeguimiento.Text = txtNomSeguimiento.Text.Trim
        If UcCheckpoint.Resultado Is Nothing Then
            msgvalidar = "*CheckPoint"
        End If
        If txtNomSeguimiento.Text.Length = 0 Then
            msgvalidar = msgvalidar & Chr(13) & "*Descripción CheckPoint"
        End If
        msgvalidar = msgvalidar.Trim
        Return msgvalidar
    End Function
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        'Guardar()
        Dim msgvalidar As String = ""

        Try
            Dim strEstadoSeg As String
            Dim strEstadoCheck As String
            'Try
            'If chbEstadoSeguimiento.Checked Then
            '    strEstadoSeg = "A"
            'Else
            '    strEstadoSeg = "*"
            'End If
            strEstadoSeg = IIf(chbEstadoSeguimiento.Checked = True, "A", "*")
            strEstadoCheck = "A"
            msgvalidar = Validar()
            If msgvalidar.Length > 0 Then
                MessageBox.Show("Falta Ingresar:" & Chr(13) & msgvalidar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'if 
            'If CType(UcCheckpoint.Resultado, beCheckPoint).PNNESTDO AndAlso txtNomSeguimiento.Text <> vbNullString Then
            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If _ACCION = "Insert" Then
                oCheckPoint.Mant_CheckPoint_X_Cliente(Me.Compania, Me.Division, "I", Me.CodCliente, CType(UcCheckpoint.Resultado, beCheckPoint).PNNESTDO, txtNomSeguimiento.Text.Trim, strEstadoCheck, strEstadoSeg, Val(txtOrdenCheckPoint.Text))
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'MessageBox.Show("Registro Agregado.")
                'Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If _ACCION = "Update" Then
                    oCheckPoint.Mant_CheckPoint_X_Cliente(Me.Compania, Me.Division, "M", Me.CodCliente, CType(UcCheckpoint.Resultado, beCheckPoint).PNNESTDO, txtNomSeguimiento.Text.Trim, strEstadoCheck, strEstadoSeg, Val(txtOrdenCheckPoint.Text.Trim))
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    'MessageBox.Show("Registro Modificado.")
                    'Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
            'Me.Cursor = System.Windows.Forms.Cursors.Default
            'Else
            '    'Me.Cursor = System.Windows.Forms.Cursors.Default
            '    HelpUtil.MsgBox("Debe colocar el nombre del checkpoint para el cliente")
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    'Private Sub cmbDivision_Seleccionar(ByVal obeDivision As Ransa.TYPEDEF.UbicacionPlanta.Division.beDivision) Handles cmbDivision.Seleccionar
    '    Try
    '        If cmbDivision.Division = "S" Then
    '            Me.CargarTipoCheckMantenimiento_SIL()
    '        Else
    '            Me.CargarTipoCheckMantenimiento()
    '        End If

    '        Cargar_Checkpoint(Nothing, Nothing)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted
        Try
            If cmbDivision.Division = "S" Then
                CargarTipoCheckMantenimiento_SIL()
            Else
                CargarTipoCheckMantenimiento()
            End If
            Cargar_Checkpoint(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UcCheckpoint_CambioDeTexto(ByVal objData As System.Object) Handles UcCheckpoint.CambioDeTexto
        Try
            If _Cliente_Secundario = True Then
                _Cliente_Secundario = False
                Exit Sub
            End If
            If _ACCION = "Insert" Then
                txtOrdenCheckPoint.Text = String.Empty
            End If
            If bolBuscarCheck2 Then
                If UcCheckpoint.Resultado Is Nothing Then
                    Me.txtNomSeguimiento.Text = ""
                    Exit Sub
                End If
                Me.txtNomSeguimiento.Text = CType(UcCheckpoint.Resultado, beCheckPoint).PSTDESES.Trim  'Me.cmbCheckpoint.Text.Trim()
                'If (cmbTipoCheckpoint.Text <> "" And cmbCheckpoint.Text <> "") Then

                If (cmbTipoCheckpoint.Text <> "" And UcCheckpoint.Resultado IsNot Nothing) Then
                    Buscar_CheckPoint_X_Cliente_Sec()
                    'txtCodigo.Text = cmbCheckpoint.SelectedValue
                End If
            End If
            chbEstadoSeguimiento.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      
    End Sub
    'Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub txtOrdenCheckPoint_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrdenCheckPoint.KeyPress
        Dim Text As New TextBox
        Text = CType(sender, TextBox)
        Text.Tag = "3-0"
        If HelpUtil.SoloNumerosConDecimal(Text, CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub
End Class

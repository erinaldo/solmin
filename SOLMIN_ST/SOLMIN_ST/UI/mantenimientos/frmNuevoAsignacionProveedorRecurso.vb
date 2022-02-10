Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES

Public Class frmNuevoAsignacionProveedorRecurso
    Private strCompania As String = ""
    Private strRucProveedor As String = ""
    Private strProveedor As String = ""
    Private objProveedorBLL As New Proveedor_BLL
    Private strDivision As String = ""
    Sub New(ByVal Compania As String, ByVal Division As String, ByVal RucProveedor As String, ByVal Proveedor As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        strCompania = Compania
        strRucProveedor = RucProveedor
        strProveedor = Proveedor
        strDivision = Division
    End Sub
    Private Sub frmNuevoAsignacionProveedorRecurso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Cargar_Proveedor()
            txtProveedor.Text = strRucProveedor & " - " & strProveedor
            txtProveedor.Tag = strRucProveedor
            Cargar_Tipo_Recurso()
            Cargar_Placa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub Cargar_Proveedor()
    '    If strRucProveedor <> "" Then
    '        Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    '        obeProveedor.pCCMPN_Compania = strCompania
    '        obeProveedor.pNRUCTR_RucTransportista = strRucProveedor
    '        cboProveedor.pCargar(obeProveedor)
    '    Else
    '        Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
    '        obeProveedor.pCCMPN_Compania = strCompania
    '        'obeProveedor.pNRUCTR_RucTransportista = strRucProveedor
    '        cboProveedor.pCargar(obeProveedor)
    '    End If
    'End Sub

    Private Sub Cargar_Tipo_Recurso()
        cmbTipoRecurso.DataSource = objProveedorBLL.Listar_Tipos(strCompania, "TIRSO")
        cmbTipoRecurso.ValueMember = "CCMPRN"
        cmbTipoRecurso.DisplayMember = "TDSDES"
        cmbTipoRecurso.SelectedValue = "T"
        ''Cargar_Placa()
    End Sub

    Private Sub Cargar_Placa()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obeProveedor As New Proveedor
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        If cmbTipoRecurso.SelectedValue.ToString.Trim = "T" Then

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PLACA"
            oColumnas.DataPropertyName = "PLACA"
            oColumnas.HeaderText = "Placa"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            oListColum.Add(1, oColumnas) '4

            'oColumnas = New DataGridViewTextBoxColumn
            'oColumnas.Name = "CTITRA"
            'oColumnas.DataPropertyName = "CTITRA"
            'oColumnas.HeaderText = "Cod. Tipo Tracto"
            'oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            ''oColumnas.Visible = True
            'oListColum.Add(2, oColumnas) '1

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TDETRA"
            oColumnas.DataPropertyName = "TDETRA"
            oColumnas.HeaderText = "Tipo Tracto"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'oColumnas.Visible = True
            oListColum.Add(2, oColumnas) '2

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TMRCTR"
            oColumnas.DataPropertyName = "TMRCTR"
            oColumnas.HeaderText = "Marca"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'oColumnas.Visible = True
            oListColum.Add(3, oColumnas) '3


            Etiquetas.Add("Placa")
            'Etiquetas.Add("Cod. Tipo Tracto")
            Etiquetas.Add("Tipo Tracto")
            Etiquetas.Add("Marca")

            With obeProveedor
                .CCMPN = strCompania
                .STPRCS = cmbTipoRecurso.SelectedValue.ToString.Trim
            End With


            Me.ucResponsable.Etiquetas_Form = Etiquetas
            Me.ucResponsable.DataSource = objProveedorBLL.Listar_Placa(obeProveedor)
            Me.ucResponsable.ListColumnas = oListColum
            Me.ucResponsable.Cargas()
            Me.ucResponsable.DispleyMember = "TDETRA"
            Me.ucResponsable.ValueMember = "PLACA"

        ElseIf cmbTipoRecurso.SelectedValue.ToString.Trim = "A" Then

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PLACA"
            oColumnas.DataPropertyName = "PLACA"
            oColumnas.HeaderText = "Placa"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            oListColum.Add(1, oColumnas)

            'oColumnas = New DataGridViewTextBoxColumn
            'oColumnas.Name = "CTIACP"
            'oColumnas.DataPropertyName = "CTIACP"
            'oColumnas.HeaderText = "Cod. Tipo Acoplado"
            'oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            ''oColumnas.Visible = True
            'oListColum.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TDEACP"
            oColumnas.DataPropertyName = "TDEACP"
            oColumnas.HeaderText = "Tipo Acoplado"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'oColumnas.Visible = True
            oListColum.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TMRCVH"
            oColumnas.DataPropertyName = "TMRCVH"
            oColumnas.HeaderText = "Marca"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'oColumnas.Visible = True
            oListColum.Add(3, oColumnas)

            Etiquetas.Add("Placa")
            'Etiquetas.Add("Cod. Tipo Acoplado")
            Etiquetas.Add("Tipo Acoplado")
            Etiquetas.Add("Marca")

            With obeProveedor
                .CCMPN = strCompania
                .STPRCS = cmbTipoRecurso.SelectedValue.ToString.Trim
            End With


            Me.ucResponsable.Etiquetas_Form = Etiquetas
            Me.ucResponsable.DataSource = objProveedorBLL.Listar_Placa(obeProveedor)
            Me.ucResponsable.ListColumnas = oListColum
            Me.ucResponsable.Cargas()
            Me.ucResponsable.DispleyMember = "TDEACP"
            Me.ucResponsable.ValueMember = "PLACA"
        ElseIf cmbTipoRecurso.SelectedValue.ToString.Trim = "E" Then

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PLACA"
            oColumnas.DataPropertyName = "PLACA"
            oColumnas.HeaderText = "Placa"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            oListColum.Add(1, oColumnas)

            'oColumnas = New DataGridViewTextBoxColumn
            'oColumnas.Name = "CTIEQP"
            'oColumnas.DataPropertyName = "CTIEQP"
            'oColumnas.HeaderText = "Cod. Tipo Equipo"
            'oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            ''oColumnas.Visible = True
            'oListColum.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TDEEQP"
            oColumnas.DataPropertyName = "TDEEQP"
            oColumnas.HeaderText = "Tipo Equipo"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'oColumnas.Visible = True
            oListColum.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "TMRCTR"
            oColumnas.DataPropertyName = "TMRCTR"
            oColumnas.HeaderText = "Marca"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'oColumnas.Visible = True
            oListColum.Add(3, oColumnas)

            Etiquetas.Add("Placa")
            'Etiquetas.Add("Cod. Tipo Equipo")
            Etiquetas.Add("Tipo Equipo")
            Etiquetas.Add("Marca")

            With obeProveedor
                .CCMPN = strCompania
                .STPRCS = cmbTipoRecurso.SelectedValue.ToString.Trim
            End With


            Me.ucResponsable.Etiquetas_Form = Etiquetas
            Me.ucResponsable.DataSource = objProveedorBLL.Listar_Placa(obeProveedor)
            Me.ucResponsable.ListColumnas = oListColum
            Me.ucResponsable.Cargas()
            Me.ucResponsable.DispleyMember = "TDEEQP"
            Me.ucResponsable.ValueMember = "PLACA"

            'Else

            '    oColumnas = New DataGridViewTextBoxColumn
            '    oColumnas.Name = "PLACA"
            '    oColumnas.DataPropertyName = "PLACA"
            '    oColumnas.HeaderText = "Placa"
            '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            '    oListColum.Add(1, oColumnas)

            '    'oColumnas = New DataGridViewTextBoxColumn
            '    'oColumnas.Name = "CTIACP"
            '    'oColumnas.DataPropertyName = "CTIACP"
            '    'oColumnas.HeaderText = "Cod. Tipo Equipo"
            '    'oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            '    ''oColumnas.Visible = True
            '    'oListColum.Add(2, oColumnas)

            '    oColumnas = New DataGridViewTextBoxColumn
            '    oColumnas.Name = "TDEACP"
            '    oColumnas.DataPropertyName = "TDEACP"
            '    oColumnas.HeaderText = "Tipo Equipo"
            '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            '    'oColumnas.Visible = True
            '    oListColum.Add(2, oColumnas)

            '    oColumnas = New DataGridViewTextBoxColumn
            '    oColumnas.Name = "TMRCVH"
            '    oColumnas.DataPropertyName = "TMRCVH"
            '    oColumnas.HeaderText = "Marca"
            '    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            '    'oColumnas.Visible = True
            '    oListColum.Add(3, oColumnas)

            '    Etiquetas.Add("Placa")
            '    'Etiquetas.Add("Cod. Tipo Equipo")
            '    Etiquetas.Add("Tipo Equipo")
            '    Etiquetas.Add("Marca")

            '    Me.ucResponsable.Etiquetas_Form = Etiquetas
            '    Me.ucResponsable.DataSource = Nothing
            '    Me.ucResponsable.ListColumnas = oListColum
            '    Me.ucResponsable.Cargas()
        End If



    End Sub

    Private Function Validar_Datos_Obligatorio() As Boolean
        Dim strMensajeError As String = ""

        If txtProveedor.Text.Trim = "" Then strMensajeError &= "* Ingrese proveedor" & vbNewLine
        If cmbTipoRecurso.SelectedValue = "" Then strMensajeError &= "* Seleccione recurso" & vbNewLine
        If txtPlaca.Text.ToString.Trim = "" Then strMensajeError &= "* Seleccione Placa" & vbNewLine

        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Private Function ExisteEnProveedorActual(ByVal NRUCTR As String, ByVal dt As DataTable) As Boolean
        'NRUCTR
        Dim existe As Boolean = False
        For Each Item As DataRow In dt.Rows
            If ("" & Item("NRUCTR")).ToString.Trim = NRUCTR Then
                existe = True
                Exit For
            End If
        Next
        Return existe
    End Function

    Private Sub BuscarEnProveedorOtro(ByVal NRUCTR As String, ByRef PROV As String, ByVal dt As DataTable)
        PROV = ""
        For Each Item As DataRow In dt.Rows
            If ("" & Item("NRUCTR")).ToString.Trim <> NRUCTR Then
                PROV = ("" & Item("NRUCTR")).ToString.Trim & " - " & ("" & Item("TCMTRT")).ToString.Trim
                Exit For
            End If
        Next
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Validar_Datos_Obligatorio() Then Exit Sub

            Dim objEntidad As New Proveedor
            objEntidad.CCMPN = strCompania
            objEntidad.NRUCTR = txtProveedor.Tag
            objEntidad.STPRCS = cmbTipoRecurso.SelectedValue.ToString.Trim
            objEntidad.NPLRCS = txtPlaca.Text.Trim
            objEntidad.CUSCRT = MainModule.USUARIO
            objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CDVSN = strDivision
            Dim strMensajeError As String = ""
            Dim dtPlacAsig As New DataTable
            dtPlacAsig = objProveedorBLL.Listar_Placa_Recurso_Asignado(strCompania, cmbTipoRecurso.SelectedValue.ToString.Trim, txtPlaca.Text.Trim)

            If ExisteEnProveedorActual(txtProveedor.Tag, dtPlacAsig) = True Then
                MessageBox.Show("El proveedor ya se encuentra asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim asignadoOtro As String = ""
            BuscarEnProveedorOtro(txtProveedor.Tag, asignadoOtro, dtPlacAsig)
            If asignadoOtro.Length > 0 Then
                If MessageBox.Show("La placa se encuentra asignado al proveedor " & asignadoOtro & Chr(13) & "Desea reasignarlo a " & txtProveedor.Text & " ?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    objProveedorBLL.Registrar_Asignacion_Proveedor_Recurso(objEntidad, "SI")
                    DialogResult = Windows.Forms.DialogResult.Yes
                End If

            Else
                objProveedorBLL.Registrar_Asignacion_Proveedor_Recurso(objEntidad, "NO")
                DialogResult = Windows.Forms.DialogResult.Yes
            End If

            'Listar_Placa_Recurso_Asignado
            'If objProveedorBLL.Validar_Existe_Placa_Proveedor(objEntidad, strMensajeError) Then
            '    If objProveedorBLL.Registrar_Asignacion_Proveedor_Recurso(objEntidad) = 1 Then
            '        MessageBox.Show("Se registró satifactoriamente", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        DialogResult = Windows.Forms.DialogResult.Yes
            '    End If
            'Else
            '    If strMensajeError.Contains("?") = True Then
            '        If MsgBox(strMensajeError, MsgBoxStyle.OkCancel, "Mantenimiento") = MsgBoxResult.Ok Then
            '            objEntidad.NRUCTR = ""
            '            If objProveedorBLL.Eliminar_Asignacion_Proveedor_Recurso(objEntidad) = 1 Then
            '                objEntidad.NRUCTR = txtProveedor.Tag
            '                If objProveedorBLL.Registrar_Asignacion_Proveedor_Recurso(objEntidad) = 1 Then
            '                    MessageBox.Show("Se registró satifactoriamente", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '                    DialogResult = Windows.Forms.DialogResult.Yes
            '                End If
            '            End If
            '        End If
            '    Else
            '        MessageBox.Show(strMensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    End If

            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ucResponsable_CambioDeTexto(ByVal objData As Object) Handles ucResponsable.CambioDeTexto
        Try
            If ucResponsable.Resultado IsNot Nothing Then
                txtPlaca.Text = CType(ucResponsable.Resultado, Proveedor).PLACA
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbTipoRecurso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoRecurso.SelectedIndexChanged
        Try
            txtPlaca.Text = ""
            Cargar_Placa()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

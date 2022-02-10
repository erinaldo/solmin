Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Public Class frmZonaAlmacen
    Dim obeZonaAlmacen As beZonaAlmacen
    Private Sub frmZonaAlmacen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"

        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        Me.dgvZonas.AutoGenerateColumns = False

    End Sub

    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            CType(objData, beAlmacen).PNCPLNFC = UcPLanta_Cmb011.Planta
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
        If validar() = True Then
            buscar()
        End If
    End Sub
    Private Sub buscar()
        Dim obeZonaAlmacen As New beZonaAlmacen
        Dim obrZonaAlmacen As New brZonaAlmacen
      
        obeZonaAlmacen.PSCTPALM = CType(Me.txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
        obeZonaAlmacen.PSCALMC = CType(Me.txtAlmacen.Resultado, beAlmacen).PSCALMC
        dgvZonas.DataSource = obrZonaAlmacen.listar_Zona_Almacen(obeZonaAlmacen)
    End Sub
    Private Function validar() As Boolean
        Dim strMensajeError As String = ""
        If txtTipoAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Tipo de Almacén" & vbNewLine
        If txtAlmacen.Resultado Is Nothing Then strMensajeError &= "Debe seleccionar un Almacén." & vbNewLine
        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ofrmAddZona As New frmAddZona
        ofrmAddZona.PNCPLNDV = Me.UcPLanta_Cmb011.Planta
        ofrmAddZona.PSCTPALM = CType(Me.txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
        ofrmAddZona.PSCALMC = CType(Me.txtAlmacen.Resultado, beAlmacen).PSCALMC
        ofrmAddZona.PNBOTTON = 1
        If ofrmAddZona.ShowDialog = Windows.Forms.DialogResult.OK Then
            buscar()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dgvZonas.RowCount = 0 Then Exit Sub
        Dim ofrmAddZona As New frmAddZona
        ofrmAddZona.PNCPLNDV = Me.UcPLanta_Cmb011.Planta
        ofrmAddZona.PNBOTTON = 2
        toEntity()
        ofrmAddZona.pbeZonaAlmacen = obeZonaAlmacen
        If ofrmAddZona.ShowDialog = Windows.Forms.DialogResult.OK Then
            buscar()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Desea Eliminar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            eliminar()
        End If
    End Sub
    Private Sub toEntity()
        Dim intX As Integer = Me.dgvZonas.CurrentCellAddress.Y
        obeZonaAlmacen = New beZonaAlmacen
        obeZonaAlmacen.PSCTPALM = Me.dgvZonas.Item("PSCTPALM", intX).Value
        obeZonaAlmacen.PSCALMC = Me.dgvZonas.Item("PSCALMC", intX).Value
        obeZonaAlmacen.PSCZNALM = Me.dgvZonas.Item("PSCZNALM", intX).Value
        obeZonaAlmacen.PSTCMZNA = Me.dgvZonas.Item("PSTCMZNA", intX).Value
        obeZonaAlmacen.PSTABZNA = Me.dgvZonas.Item("PSTABZNA", intX).Value
        obeZonaAlmacen.PNQARMTS = Me.dgvZonas.Item("PNQARMTS", intX).Value
        obeZonaAlmacen.PSSDISAT = Me.dgvZonas.Item("PSSDISAT", intX).Value
    End Sub
    Private Sub eliminar()

        Dim obrZonaAlmacen As New brZonaAlmacen
        Try
            toEntity()
            If obrZonaAlmacen.mantenimiento_zona_almacem(obeZonaAlmacen, 3) > 0 Then
                MessageBox.Show("se eliminó correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                buscar()
            Else
                MessageBox.Show("Error al grabar", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub UcPLanta_Cmb011_Seleccionar(ByVal obePlanta As Ransa.TYPEDEF.UbicacionPlanta.Planta.bePlanta) Handles UcPLanta_Cmb011.Seleccionar
    '    Me.txtTipoAlmacen.Valor = ""
    '    Me.txtAlmacen.Valor = ""
    '    Me.dgvZonas.DataSource = Nothing
    'End Sub
    Private Sub UcPLanta_Cmb011_Seleccionar(ByVal obePlanta As Ransa.Controls.UbicacionPlanta.Planta.bePlanta) Handles UcPLanta_Cmb011.Seleccionar
        Me.txtTipoAlmacen.Valor = ""
        Me.txtAlmacen.Valor = ""
        Me.dgvZonas.DataSource = Nothing
    End Sub

End Class

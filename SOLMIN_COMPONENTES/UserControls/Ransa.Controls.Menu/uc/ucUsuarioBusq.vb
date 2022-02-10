Imports System.Windows.Forms
Imports Ransa.Utilitario
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine




Public Class ucUsuarioBusq

#Region "Ver Botones"
  Public Event EventChanged()
  Public Event pSelectionFilaUsuarioChanged()
  Public Event pBuscarUsuario()
  Public Event pMostrarUsuario()
  Private _pnumReg As Int64 = 0
  Private oTab As clsTabs
  Dim activo As New Boolean

  Private isCheckOpcion As Boolean = False
  Private isCheckPlanta As Boolean = False
  Private isCheckCliente As Boolean = False


  Public Property pnumReg() As Int64
    Get
      Return _pnumReg
    End Get
    Set(ByVal value As Int64)
      _pnumReg = value
    End Set
  End Property

  Private _pInfo_SESTRG As String = ""
  Public Property pInfo_SESTRG() As String
    Get
      Return _pInfo_SESTRG
    End Get
    Set(ByVal value As String)
      _pInfo_SESTRG = value
    End Set
  End Property

  Private _pInfo_MMCUSR As String = ""
  Public Property pInfo_MMCUSR() As String
    Get
      Return _pInfo_MMCUSR
    End Get
    Set(ByVal value As String)
      _pInfo_MMCUSR = value
    End Set
  End Property

  Private _pInfo_MMNUSR As String = ""
  Public Property pInfo_MMNUSR() As String
    Get
      Return _pInfo_MMNUSR
    End Get
    Set(ByVal value As String)
      _pInfo_MMNUSR = value
    End Set
  End Property

  Public Property pVerBotonNuevo() As Boolean
    Get
      Return btnNuevo.Visible
    End Get
    Set(ByVal value As Boolean)
      btnNuevo.Visible = value
    End Set
  End Property
  Public Property pVerBotonModificar() As Boolean
    Get
      Return btnModificar.Visible
    End Get
    Set(ByVal value As Boolean)
      btnModificar.Visible = value
    End Set
  End Property
  Public Property pVerBotonEliminar() As Boolean
    Get
      Return btnEliminar.Visible
    End Get
    Set(ByVal value As Boolean)
      btnEliminar.Visible = value
    End Set
  End Property

  Public Property pVerBotonExportar() As Boolean
    Get
      Return ddbExportar.Visible
    End Get
    Set(ByVal value As Boolean)
      ddbExportar.Visible = value
    End Set
  End Property

  Public Property pVerBotonBuscar() As Boolean
    Get
      Return btnBuscar.Visible
    End Get
    Set(ByVal value As Boolean)
      btnBuscar.Visible = value
    End Set
  End Property
#End Region

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Dim oFrmManUsuario As New FrmManUsuario
    Try
      oFrmManUsuario.pEstado = FrmManUsuario.Estado.Nuevo
      If oFrmManUsuario.ShowDialog = DialogResult.OK Then
        pActualizarDatos(txtUsuario.Text, txtNombre.Text)
      End If
      oFrmManUsuario.Dispose()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    Dim oFrmManUsuario As New FrmManUsuario
    Try
      If dgvUsuarios.CurrentRow IsNot Nothing And dgvUsuarios.Rows.Count > 0 Then
        Dim lint_indice As Integer = Me.dgvUsuarios.CurrentCellAddress.Y
        oFrmManUsuario.pbeUsuario.PSMMCUSR = Me.dgvUsuarios.Item("MMCUSR", lint_indice).Value.ToString.Trim
        oFrmManUsuario.pbeUsuario.PSMMNUSR = Me.dgvUsuarios.Item("MMNUSR", lint_indice).Value.ToString.Trim

        oFrmManUsuario.pbeUsuario.PSMMCAII = Me.dgvUsuarios.Item("MMCAII", lint_indice).Value.ToString.Trim
        oFrmManUsuario.pbeUsuario.PSMMCMII = Me.dgvUsuarios.Item("MMCMII", lint_indice).Value.ToString.Trim
        oFrmManUsuario.pbeUsuario.PSCOROCC = Me.dgvUsuarios.Item("COROCC", lint_indice).Value.ToString.Trim
        oFrmManUsuario.pbeUsuario.PSCCMPOR = Me.dgvUsuarios.Item("CCMPOR", lint_indice).Value.ToString.Trim
        oFrmManUsuario.pbeUsuario.PSCDVSNU = Me.dgvUsuarios.Item("CDVSNU", lint_indice).Value.ToString.Trim
        oFrmManUsuario.pbeUsuario.PSMMTUSR = Me.dgvUsuarios.Item("MMTUSR", lint_indice).Value.ToString.Trim
        oFrmManUsuario.pbeUsuario.PNCNVUSR = Me.dgvUsuarios.Item("CNVUSR", lint_indice).Value
        oFrmManUsuario.pbeUsuario.PSSORGZN = Me.dgvUsuarios.Item("SORGZN", lint_indice).Value.ToString.Trim

        oFrmManUsuario.pEstado = FrmManUsuario.Estado.Modificar
        If oFrmManUsuario.ShowDialog() = DialogResult.OK Then
          pActualizarDatos(txtUsuario.Text, txtNombre.Text)

        End If
        oFrmManUsuario.Dispose()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    Try
      Dim oclsUsuario_DAL As New clsUsuario_DAL
      Dim obeUsuario As New beUsuario
      If dgvUsuarios.CurrentRow IsNot Nothing And dgvUsuarios.Rows.Count > 0 Then
        Dim lint_indice As Integer = Me.dgvUsuarios.CurrentCellAddress.Y
        obeUsuario.PSMMCUSR = Me.dgvUsuarios.Item("MMCUSR", lint_indice).Value.ToString.Trim()
        If MessageBox.Show("¿Está seguro de eliminar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
          If oclsUsuario_DAL.Eliminar_Usuarios(obeUsuario) = 1 Then
            pActualizarTabsNothing()
            pActualizarDatos(txtUsuario.Text, txtNombre.Text)

          Else
            MessageBox.Show("No se pudo eliminar", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
          End If
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
    Try
      Dim oclsUsuario_DAL As New clsUsuario_DAL
      Dim obeUsuario As New beUsuario
      If dgvUsuarios.CurrentRow IsNot Nothing And dgvUsuarios.Rows.Count > 0 Then
        Dim lint_indice As Integer = Me.dgvUsuarios.CurrentCellAddress.Y
        obeUsuario.PSMMCUSR = Me.dgvUsuarios.Item("MMCUSR", lint_indice).Value.ToString.Trim()
        If MessageBox.Show("¿Está seguro de restaurar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
          If oclsUsuario_DAL.Restaurar_Usuarios(obeUsuario) = 1 Then
            pActualizarTabsNothing()
            pActualizarDatos(txtUsuario.Text, txtNombre.Text)

          End If
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    Public Sub pCargar()
    LlenarEstado()
    _pInfo_MMCUSR = txtUsuario.Text.Trim.ToString.ToUpper
    _pInfo_MMNUSR = txtNombre.Text.Trim.ToString.ToUpper
    pActualizarDatos(_pInfo_MMCUSR, _pInfo_MMNUSR)

    End Sub

  Public Sub pActualizarDatos(ByVal _pInfo_MMCUSR As String, ByVal _pInfo_MMNUSR As String)
    dgvUsuarios.AutoGenerateColumns = False
    dgvUsuarios.DataSource = Nothing
    Dim listbeUsuario As New List(Of beUsuario)
    Dim obeUsuario As New beUsuario
    Dim oclsUsuario_DAL As New clsUsuario_DAL
    Dim dt As New DataTable
    oTab = New clsTabs
    pActualizarTabsNothing()

      obeUsuario.PSMMCUSR = (_pInfo_MMCUSR).ToUpper
      obeUsuario.PSMMNUSR = (_pInfo_MMNUSR).ToUpper
      If cboEstado.SelectedValue = "A" Then
        obeUsuario.PSSESTRG = "A"
      Else
        obeUsuario.PSSESTRG = "*"
    End If

    obeUsuario.PageSize = Me.UcPaginacion1.PageSize
    obeUsuario.PageNumber = Me.UcPaginacion1.PageNumber

    listbeUsuario = oclsUsuario_DAL.Listar_Usuarios(obeUsuario)
    dgvUsuarios.DataSource = listbeUsuario
    If dgvUsuarios.Rows.Count = 0 Then
      pdgvUsuariosHabilitar()
    Else
      UcPaginacion1.PageCount = Me.dgvUsuarios.Item("PageCount", 0).Value.ToString.Trim()
    End If

    '_pnumReg = dgvUsuarios.Rows.Count

  End Sub

  Public Sub pdgvUsuariosHabilitar()
    Dim EstadoNuevo As Boolean = cboEstado.SelectedValue = "A"
    btnNuevo.Enabled = EstadoNuevo
    btnModificar.Enabled = False
    btnEliminar.Enabled = False
    btnManEliminar.Enabled = False
    btnManModificar.Enabled = False
    btnVerPerfil.Enabled = False
    btnManNuevo.Enabled = False
    btnRestablecer.Enabled = False
    pActualizarTabsNothing()
  End Sub

    Public Sub pActualizarTabsNothing()
        Me.dgvAccesoCliente.Rows.Clear()
        Me.dgvAccesoOpcion.Rows.Clear()
        Me.dgvAccesoPlanta.Rows.Clear()
    End Sub

  Private Sub dgvUsuarios_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvUsuarios.SelectionChanged
    Try
      _pInfo_MMCUSR = ""
      Dim sestrg As Char
      If dgvUsuarios.CurrentRow IsNot Nothing Then
        _pInfo_MMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim
        sestrg = ("" & Me.dgvUsuarios.CurrentRow.Cells("SESTRG").Value).ToString.Trim
        oTab = New clsTabs
        Cargar_Informacion_TabPages()
        If sestrg <> "*" Then
          Estado("A")
        Else
          Estado("I")
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
            pActualizarDatos(txtUsuario.Text, txtNombre.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub

  Private Sub Buscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown, txtNombre.KeyDown
    Try
            If e.KeyCode = Keys.Enter Then
                pActualizarDatos(txtUsuario.Text, txtNombre.Text)
            End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub LlenarEstado()
    Dim dt As New DataTable
    dt.Columns.Add("Display")
    dt.Columns.Add("Value")
    Dim dr As DataRow

    dr = dt.NewRow
    dr("Display") = "Activo"
    dr("Value") = "A"
    dt.Rows.Add(dr)

    dr = dt.NewRow
    dr("Display") = "Inactivo"
    dr("Value") = "I"
    dt.Rows.Add(dr)

    cboEstado.DataSource = dt
    cboEstado.DisplayMember = "Display"
    cboEstado.ValueMember = "Value"
    cboEstado.SelectedValue = "A"
  End Sub

  Private Sub Cargar_Informacion_TabPages()
    Dim TabActivo As Int32 = TabControl1.SelectedIndex
    Dim TabName = TabControl1.TabPages(TabActivo).Name

    btncheck.Image = My.Resources.btnNoMarcarItems

    If Not oTab.Tab_Cargado(TabActivo) Then
      Me.Cursor = Cursors.WaitCursor
      Select Case TabName
        Case "TabOpcion"
          Cargar_AccesoOpcion()
        Case "TabCliente"
          Cargar_AccesoCliente()
        Case "TabPlanta"
          Cargar_AccesoPlanta()
      End Select
      oTab.Cargar_Tab(TabActivo)
      Me.Cursor = Cursors.Default
    End If

  End Sub

  Private Sub Cargar_AccesoOpcion()

    Dim obeUsuario As New beUsuario
    Dim oclsUsuario_DAL As New clsUsuario_DAL

    dgvAccesoOpcion.AutoGenerateColumns = False
    dgvAccesoOpcion.DataSource = Nothing
    If dgvUsuarios.CurrentRow IsNot Nothing Then

      obeUsuario.PSMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
      obeUsuario.PSMMCAPL_CodApl = Uc_CboAplicacion.pPSMMCAPL
      obeUsuario.PSMMCMNU_CodMnu = Uc_CboMenu.pPSMMCMNU

      obeUsuario.PageNumber = UcPaginacion2.PageNumber
      obeUsuario.PageSize = UcPaginacion2.PageSize
      Me.dgvAccesoOpcion.Rows.Clear()
      Dim NumPaginas As Int64 = 0

      Dim dt As DataTable = oclsUsuario_DAL.Listar_Usuarios_X_AccesoOpcion(obeUsuario, NumPaginas)
      For indice As Integer = 0 To dt.Rows.Count - 1
        Me.dgvAccesoOpcion.Rows.Add(1)
        Me.dgvAccesoOpcion.Item("CHK_OPCION", indice).Value = False
        Me.dgvAccesoOpcion.Item("MMCAPL", indice).Value = dt.Rows(indice).Item("MMCAPL")
        Me.dgvAccesoOpcion.Item("MMCMNU", indice).Value = dt.Rows(indice).Item("MMCMNU")
        Me.dgvAccesoOpcion.Item("MMCOPC", indice).Value = dt.Rows(indice).Item("MMCOPC")
        Me.dgvAccesoOpcion.Item("MMCUSR1", indice).Value = dt.Rows(indice).Item("MMCUSR")
        Me.dgvAccesoOpcion.Item("DES_APLC", indice).Value = dt.Rows(indice).Item("DES_APLC")
        Me.dgvAccesoOpcion.Item("DES_MENU", indice).Value = dt.Rows(indice).Item("DES_MENU")
        Me.dgvAccesoOpcion.Item("DES_OPCN", indice).Value = dt.Rows(indice).Item("DES_OPCN")
        Me.dgvAccesoOpcion.Item("STSVIS", indice).Value = dt.Rows(indice).Item("STSVIS")
        Me.dgvAccesoOpcion.Item("STSADI", indice).Value = dt.Rows(indice).Item("STSADI")
        Me.dgvAccesoOpcion.Item("STSCHG", indice).Value = dt.Rows(indice).Item("STSCHG")
        Me.dgvAccesoOpcion.Item("STSELI", indice).Value = dt.Rows(indice).Item("STSELI")
        Me.dgvAccesoOpcion.Item("STSOP1", indice).Value = dt.Rows(indice).Item("STSOP1")
        Me.dgvAccesoOpcion.Item("STSOP2", indice).Value = dt.Rows(indice).Item("STSOP2")
        Me.dgvAccesoOpcion.Item("STSOP3", indice).Value = dt.Rows(indice).Item("STSOP3")
      Next
      If dgvAccesoOpcion.Rows.Count > 0 Then
        UcPaginacion2.PageCount = NumPaginas
            End If
        Else

            dgvAccesoOpcion.AutoGenerateColumns = False
            Me.dgvAccesoOpcion.Rows.Clear()

        End If

  End Sub

  Private Sub Cargar_AccesoCliente()
    Dim obeUsuario As New beUsuario
    Dim oclsUsuario_DAL As New clsUsuario_DAL
    dgvAccesoCliente.AutoGenerateColumns = False
    dgvAccesoCliente.DataSource = Nothing
    If dgvUsuarios.CurrentRow IsNot Nothing Then
      obeUsuario.PSMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
    End If
    Me.dgvAccesoCliente.Rows.Clear()

    Dim dt As DataTable = oclsUsuario_DAL.Listar_Usuarios_X_AccesoCliente(obeUsuario)
    For indice As Integer = 0 To dt.Rows.Count - 1
      Me.dgvAccesoCliente.Rows.Add(1)
      Me.dgvAccesoCliente.Item("CHK_CLIENTE", indice).Value = False
      Me.dgvAccesoCliente.Item("MMCUSR2", indice).Value = dt.Rows(indice).Item("MMCUSR").ToString.Trim
      Me.dgvAccesoCliente.Item("CCLNT", indice).Value = dt.Rows(indice).Item("CCLNT")
      Me.dgvAccesoCliente.Item("CPLNDV", indice).Value = dt.Rows(indice).Item("CPLNDV")
      Me.dgvAccesoCliente.Item("TCMPCL", indice).Value = dt.Rows(indice).Item("TCMPCL").ToString.Trim
      Me.dgvAccesoCliente.Item("TRFRCL", indice).Value = dt.Rows(indice).Item("TRFRCL").ToString.Trim
      Me.dgvAccesoCliente.Item("CINTER", indice).Value = dt.Rows(indice).Item("CINTER").ToString.Trim
      Me.dgvAccesoCliente.Item("TPLNTA", indice).Value = dt.Rows(indice).Item("TPLNTA").ToString.Trim
    Next

  End Sub

  Private Sub Cargar_AccesoPlanta()

    Dim obeUsuario As New beUsuario
    Dim oclsUsuario_DAL As New clsUsuario_DAL
    dgvAccesoPlanta.AutoGenerateColumns = False
    dgvAccesoPlanta.DataSource = Nothing
    If dgvUsuarios.CurrentRow IsNot Nothing Then
      obeUsuario.PSMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
    End If
    Me.dgvAccesoPlanta.Rows.Clear()

    Dim dt As DataTable = oclsUsuario_DAL.Listar_Usuarios_X_AccesoPlanta(obeUsuario)
    For indice As Integer = 0 To dt.Rows.Count - 1
      Me.dgvAccesoPlanta.Rows.Add(1)
      Me.dgvAccesoPlanta.Item("CHK_PLANTA", indice).Value = False
      Me.dgvAccesoPlanta.Item("MMCUSR3", indice).Value = dt.Rows(indice).Item("MMCUSR").ToString.Trim
      Me.dgvAccesoPlanta.Item("CCMPN", indice).Value = dt.Rows(indice).Item("CCMPN").ToString.Trim
      Me.dgvAccesoPlanta.Item("CPLNDV1", indice).Value = dt.Rows(indice).Item("CPLNDV")
      Me.dgvAccesoPlanta.Item("CDVSN", indice).Value = dt.Rows(indice).Item("CDVSN").ToString.Trim
      Me.dgvAccesoPlanta.Item("COMPANIA", indice).Value = dt.Rows(indice).Item("COMPANIA").ToString.Trim
      Me.dgvAccesoPlanta.Item("DIVISION", indice).Value = dt.Rows(indice).Item("DIVISION").ToString.Trim
      Me.dgvAccesoPlanta.Item("PLANTA", indice).Value = dt.Rows(indice).Item("PLANTA").ToString.Trim
      Me.dgvAccesoPlanta.Item("MMCAPL1", indice).Value = dt.Rows(indice).Item("MMCAPL").ToString.Trim
      Me.dgvAccesoPlanta.Item("CRGVTA", indice).Value = dt.Rows(indice).Item("CRGVTA").ToString.Trim
      Me.dgvAccesoPlanta.Item("CSCDSP", indice).Value = dt.Rows(indice).Item("CSCDSP").ToString.Trim
    Next

  End Sub

  Private Sub Seleccionar_Estado(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstado.SelectionChangeCommitted
    Try
      pActualizarDatos(txtUsuario.Text, txtNombre.Text)

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Public Sub Estado(ByVal estado As Char)
    Try
      If estado = "A" Then
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnManEliminar.Enabled = True
        btnManNuevo.Enabled = True
        btnManModificar.Enabled = True
        btnVerPerfil.Enabled = True
        btnRestablecer.Enabled = False

      Else
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnManEliminar.Enabled = False
        btnManNuevo.Enabled = False
        btnManModificar.Enabled = False
        btnVerPerfil.Enabled = False
        btnRestablecer.Enabled = True
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
    Try
      Cargar_Informacion_TabPages()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnManNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManNuevo.Click

    Try
      Dim TabActivo As Int32 = TabControl1.SelectedIndex
      Dim TabName = TabControl1.TabPages(TabActivo).Name
      Select Case TabName
        Case "TabOpcion"
          Dim oFrmManAccesoOpcion As New FrmManAccesoOpcion
          If dgvUsuarios.CurrentRow IsNot Nothing Then
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
            If oFrmManAccesoOpcion.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoOpcion()
            End If
          End If
          oFrmManAccesoOpcion.Dispose()
        Case "TabCliente"
          Dim oFrmManCliente As New FrmManCliente
          If dgvUsuarios.CurrentRow IsNot Nothing Then
            oFrmManCliente.pbeAccesoCliente.PSMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
            If oFrmManCliente.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoCliente()
            End If
          End If

          oFrmManCliente.Dispose()
        Case "TabPlanta"
          Dim oFrmManPlanta As New FrmManPlanta
          If dgvUsuarios.CurrentRow IsNot Nothing Then
            oFrmManPlanta.pbeAccesoPlanta.PSMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
            If oFrmManPlanta.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoPlanta()
            End If
          End If

          oFrmManPlanta.Dispose()
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnManEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManEliminar.Click
    Try
      Dim TabActivo As Int32 = TabControl1.SelectedIndex
      Dim TabName = TabControl1.TabPages(TabActivo).Name
      dgvAccesoOpcion.EndEdit()
      dgvAccesoCliente.EndEdit()
      dgvAccesoPlanta.EndEdit()

      Select Case TabName

        Case "TabOpcion"
          If HaySeleccionOpcion() = True Then
            If dgvAccesoOpcion.CurrentRow IsNot Nothing And dgvAccesoOpcion.Rows.Count > 0 Then
              If MessageBox.Show("Está seguro de eliminar " & Chr(13) & " todos los registros seleccionados ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim obeAccesoOpcion As beAccesoOpcion
                Dim oclsUsuario_DAL As New clsUsuario_DAL
                Dim Fila As Int32 = 0
                Dim retorno As Int32 = 0
                For Fila = 0 To dgvAccesoOpcion.RowCount - 1
                  If dgvAccesoOpcion.Rows(Fila).Cells("CHK_OPCION").Value = True Then
                    obeAccesoOpcion = New beAccesoOpcion
                    obeAccesoOpcion.PSMMCUSR = Me.dgvAccesoOpcion.Item("MMCUSR1", Fila).Value.ToString.Trim()
                    obeAccesoOpcion.PSMMCAPL = Me.dgvAccesoOpcion.Item("MMCAPL", Fila).Value.ToString.Trim()
                    obeAccesoOpcion.PSMMCMNU = Me.dgvAccesoOpcion.Item("MMCMNU", Fila).Value.ToString.Trim()
                    obeAccesoOpcion.PNMMCOPC = Me.dgvAccesoOpcion.Item("MMCOPC", Fila).Value.ToString.Trim()
                    retorno = oclsUsuario_DAL.Eliminar_Opciones_X_Usuario(obeAccesoOpcion)
                  End If
                Next
                                'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                                Cargar_AccesoOpcion()
              End If
            End If
          Else
            MessageBox.Show("Debe seleccionar al menos un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
          End If

        Case "TabCliente"

          If HaySeleccionCliente() = True Then

            If dgvAccesoCliente.CurrentRow IsNot Nothing And dgvAccesoCliente.Rows.Count > 0 Then
              If MessageBox.Show("Está seguro de eliminar " & Chr(13) & " todos los registros seleccionados ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim obeAccesoCliente As beAccesoCliente
                Dim objclsUsuario_DAL As New clsUsuario_DAL
                Dim Fila As Int32 = 0
                Dim retorno As Int32 = 0
                For Fila = 0 To dgvAccesoCliente.RowCount - 1
                  If dgvAccesoCliente.Rows(Fila).Cells("CHK_CLIENTE").Value = True Then
                    obeAccesoCliente = New beAccesoCliente
                    obeAccesoCliente.PSMMCUSR = Me.dgvAccesoCliente.Item("MMCUSR2", Fila).Value.ToString.Trim()
                    obeAccesoCliente.PNCCLNT = Me.dgvAccesoCliente.Item("CCLNT", Fila).Value.ToString.Trim()
                    retorno = objclsUsuario_DAL.Eliminar_Opciones_X_Cliente(obeAccesoCliente)
                  End If
                Next
                                'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                                Cargar_AccesoCliente()
              End If
            End If
          Else
            MessageBox.Show("Debe seleccionar al menos un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
          End If

        Case "TabPlanta"

          If HaySeleccionPlanta() = True Then
            If dgvAccesoPlanta.CurrentRow IsNot Nothing And dgvAccesoPlanta.Rows.Count > 0 Then
              If MessageBox.Show("Está seguro de eliminar " & Chr(13) & " todos los registros seleccionados  ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim objUsuario_DAL As New clsUsuario_DAL
                Dim obeAccesoPlanta As beAccesoPlanta
                Dim Fila As Int32 = 0
                Dim retorno As Int32 = 0
                For Fila = 0 To dgvAccesoPlanta.RowCount - 1
                  If dgvAccesoPlanta.Rows(Fila).Cells("CHK_PLANTA").Value = True Then
                    obeAccesoPlanta = New beAccesoPlanta
                    obeAccesoPlanta.PSMMCUSR = Me.dgvAccesoPlanta.Item("MMCUSR3", Fila).Value.ToString.Trim()
                    obeAccesoPlanta.PSCCMPN = Me.dgvAccesoPlanta.Item("CCMPN", Fila).Value.ToString.Trim()
                    obeAccesoPlanta.PSCDVSN = Me.dgvAccesoPlanta.Item("CDVSN", Fila).Value.ToString.Trim()
                    obeAccesoPlanta.PNCPLNDV = Me.dgvAccesoPlanta.Item("CPLNDV1", Fila).Value.ToString.Trim()
                    retorno = objUsuario_DAL.Eliminar_Opciones_X_Planta(obeAccesoPlanta)
                  End If
                Next
                                'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                                Cargar_AccesoPlanta()
              End If
            End If
          Else
            MessageBox.Show("Debe seleccionar al menos un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
          End If
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try


  End Sub

  Private Sub Modificar_AccesoOpcion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManModificar.Click
    Try
      Dim TabActivo As Int32 = TabControl1.SelectedIndex
      Dim TabName = TabControl1.TabPages(TabActivo).Name
      Select Case TabName
        Case "TabOpcion"

          Dim oFrmManAccesoOpcion As New FrmManAccesoOpcion
          If dgvAccesoOpcion.CurrentRow IsNot Nothing And dgvAccesoOpcion.Rows.Count > 0 Then
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSMMCUSR = ("" & Me.dgvAccesoOpcion.CurrentRow.Cells("MMCUSR1").Value).ToString.Trim.ToUpper
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSMMCAPL = ("" & Me.dgvAccesoOpcion.CurrentRow.Cells("MMCAPL").Value).ToString.Trim.ToUpper
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSMMCMNU = ("" & Me.dgvAccesoOpcion.CurrentRow.Cells("MMCMNU").Value).ToString.Trim.ToUpper
            oFrmManAccesoOpcion.pbeAccesoOpcion.PNMMCOPC = Me.dgvAccesoOpcion.CurrentRow.Cells("MMCOPC").Value

            oFrmManAccesoOpcion.pbeAccesoOpcion.PSSTSVIS = Me.dgvAccesoOpcion.CurrentRow.Cells("STSVIS").Value
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSSTSADI = Me.dgvAccesoOpcion.CurrentRow.Cells("STSADI").Value
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSSTSCHG = Me.dgvAccesoOpcion.CurrentRow.Cells("STSCHG").Value
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSSTSELI = Me.dgvAccesoOpcion.CurrentRow.Cells("STSELI").Value

            oFrmManAccesoOpcion.pbeAccesoOpcion.PSSTSOP1 = Me.dgvAccesoOpcion.CurrentRow.Cells("STSOP1").Value
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSSTSOP2 = Me.dgvAccesoOpcion.CurrentRow.Cells("STSOP2").Value
            oFrmManAccesoOpcion.pbeAccesoOpcion.PSSTSOP3 = Me.dgvAccesoOpcion.CurrentRow.Cells("STSOP3").Value

            oFrmManAccesoOpcion.pEstado = FrmManUsuario.Estado.Modificar
            If oFrmManAccesoOpcion.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoOpcion()
            End If
          End If

        Case "TabPlanta"

          Dim oFrmManPlanta As New FrmManPlanta

          If dgvAccesoPlanta.CurrentRow IsNot Nothing And dgvAccesoPlanta.Rows.Count > 0 Then

            oFrmManPlanta.pbeAccesoPlanta.PSMMCUSR = ("" & Me.dgvAccesoPlanta.CurrentRow.Cells("MMCUSR3").Value).ToString.Trim.ToUpper
            oFrmManPlanta.pbeAccesoPlanta.PSCCMPN = ("" & Me.dgvAccesoPlanta.CurrentRow.Cells("CCMPN").Value).ToString.Trim.ToUpper
            oFrmManPlanta.pbeAccesoPlanta.PNCPLNDV = Me.dgvAccesoPlanta.CurrentRow.Cells("CPLNDV1").Value

            oFrmManPlanta.pbeAccesoPlanta.PSCDVSN = ("" & Me.dgvAccesoPlanta.CurrentRow.Cells("CDVSN").Value).ToString.Trim.ToString

            oFrmManPlanta.pbeAccesoPlanta.PSMMCAPL = Me.dgvAccesoPlanta.CurrentRow.Cells("MMCAPL1").Value
            oFrmManPlanta.pbeAccesoPlanta.PSCRGVTA = Me.dgvAccesoPlanta.CurrentRow.Cells("CRGVTA").Value
            oFrmManPlanta.pbeAccesoPlanta.PSCSCDSP = Me.dgvAccesoPlanta.CurrentRow.Cells("CSCDSP").Value

            oFrmManPlanta.pEstado = FrmManPlanta.Estado.Modificar
            If oFrmManPlanta.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoPlanta()

            End If
          End If


        Case "TabCliente"

          Dim oFrmManCliente As New FrmManCliente

          If dgvAccesoCliente.CurrentRow IsNot Nothing And dgvAccesoCliente.Rows.Count > 0 Then
            oFrmManCliente.pbeAccesoCliente.PSMMCUSR = ("" & Me.dgvAccesoCliente.CurrentRow.Cells("MMCUSR2").Value).ToString.Trim.ToUpper
            oFrmManCliente.pbeAccesoCliente.PNCCLNT = Me.dgvAccesoCliente.CurrentRow.Cells("CCLNT").Value

            oFrmManCliente.pbeAccesoCliente.PSTCMPCL = ("" & Me.dgvAccesoCliente.CurrentRow.Cells("TCMPCL").Value).ToString.Trim.ToUpper
            oFrmManCliente.pbeAccesoCliente.PSTRFRCL = ("" & Me.dgvAccesoCliente.CurrentRow.Cells("TRFRCL").Value).ToString.Trim.ToUpper

            oFrmManCliente.pbeAccesoCliente.PSCINTER = ("" & Me.dgvAccesoCliente.CurrentRow.Cells("CINTER").Value).ToString.Trim.ToUpper

            oFrmManCliente.pbeAccesoCliente.PSTPLNTA = ("" & Me.dgvAccesoCliente.CurrentRow.Cells("TPLNTA").Value).ToString.Trim.ToUpper

            oFrmManCliente.pEstado = FrmManCliente.Estado.Modificar
            If oFrmManCliente.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoCliente()
            End If
          End If

      End Select

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Poner_Check_Todo_Opcion(ByVal blnEstado As Boolean)
    Dim intCont As Integer
    For intCont = 0 To dgvAccesoOpcion.RowCount - 1
      dgvAccesoOpcion.Rows(intCont).Cells("CHK_OPCION").Value = blnEstado
    Next
  End Sub

  Private Sub Poner_Check_Todo_Cliente(ByVal blnEstado As Boolean)
    Dim intCont As Integer
    For intCont = 0 To dgvAccesoCliente.RowCount - 1
      dgvAccesoCliente.Rows(intCont).Cells("CHK_CLIENTE").Value = blnEstado
    Next
  End Sub

  Private Sub Poner_Check_Todo_Planta(ByVal blnEstado As Boolean)
    Dim intCont As Integer
    For intCont = 0 To dgvAccesoPlanta.RowCount - 1
      dgvAccesoPlanta.Rows(intCont).Cells("CHK_PLANTA").Value = blnEstado
    Next
  End Sub

  Private Function HaySeleccionOpcion() As Boolean
    dgvAccesoOpcion.EndEdit()
    Dim intCont As Integer
    Dim HaySeleccionadosOpcion As Boolean = False
    For intCont = 0 To dgvAccesoOpcion.RowCount - 1
      If dgvAccesoOpcion.Rows(intCont).Cells("CHK_OPCION").Value = True Then
        HaySeleccionadosOpcion = True
        Exit For
      End If
    Next
    Return HaySeleccionadosOpcion
  End Function

  Private Function HaySeleccionPlanta() As Boolean
    dgvAccesoPlanta.EndEdit()
    Dim intCont As Integer
    Dim HaySeleccionadosPlanta As Boolean = False
    For intCont = 0 To dgvAccesoPlanta.RowCount - 1
      If dgvAccesoPlanta.Rows(intCont).Cells("CHK_PLANTA").Value = True Then
        HaySeleccionadosPlanta = True
        Exit For
      End If
    Next
    Return HaySeleccionadosPlanta
  End Function

  Private Function HaySeleccionCliente() As Boolean

    dgvAccesoCliente.EndEdit()
    Dim intCont As Integer
    Dim HaySeleccionadosCliente As Boolean = False
    For intCont = 0 To dgvAccesoCliente.RowCount - 1
      If dgvAccesoCliente.Rows(intCont).Cells("CHK_CLIENTE").Value = True Then
        HaySeleccionadosCliente = True
        Exit For
      End If
    Next
    Return HaySeleccionadosCliente
  End Function

  Private Sub btnVerPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPerfil.Click
    Try

      Dim TabActivo As Int32 = TabControl1.SelectedIndex
      Dim TabName = TabControl1.TabPages(TabActivo).Name

      Select Case TabName
        Case "TabOpcion"

          Dim oFrmPerfilOpciones As New FrmPerfilOpciones
          If dgvUsuarios.CurrentRow IsNot Nothing Then
            oFrmPerfilOpciones.pMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
            If oFrmPerfilOpciones.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoOpcion()
            End If
          End If

        Case "TabPlanta"

          Dim oFrmPerfilPlanta As New FrmPerfilPlanta
          If dgvUsuarios.CurrentRow IsNot Nothing Then
            oFrmPerfilPlanta.pMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
            If oFrmPerfilPlanta.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoPlanta()
            End If
          End If

        Case "TabCliente"

          Dim oFrmPerfilCliente As New FrmPerfilCliente
          If dgvUsuarios.CurrentRow IsNot Nothing Then
            oFrmPerfilCliente.pMMCUSR = ("" & Me.dgvUsuarios.CurrentRow.Cells("MMCUSR").Value).ToString.Trim.ToUpper
            If oFrmPerfilCliente.ShowDialog = DialogResult.OK Then
                            'pActualizarDatos(txtUsuario.Text, txtNombre.Text)
                            Cargar_AccesoCliente()
            End If
          End If

      End Select

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnBuscarOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOP.Click
    Try
      Cargar_AccesoOpcion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cargar_Menus() Handles Uc_CboAplicacion.InformationChanged
    Try

      Uc_CboMenu.pPSMMCAPL = Uc_CboAplicacion.pPSMMCAPL
      Uc_CboMenu.pClear()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub UcPaginacion1_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion1.PageChanged
    Try
      pActualizarDatos(txtUsuario.Text, txtNombre.Text)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    'Private Sub Graficar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvUsuarios.CellFormatting
    '  Try

    '    ' Grafico clientes
    '    If e.ColumnIndex = 12 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '      Dim bmp As New Bitmap(200, 20)
    '      Dim grafico As Graphics = Graphics.FromImage(bmp)
    '      grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '      If e.Value > 0 Then
    '        Dim rec As New Rectangle(50, 5, Math.Round(e.Value * 0.51), 10)
    '        Dim deg As New LinearGradientBrush(rec, Color.Yellow, Color.OrangeRed, LinearGradientMode.BackwardDiagonal)
    '        grafico.FillRectangle(deg, rec)
    '      End If
    '      e.Value = bmp
    '    End If

    '    ' Grafico plantas
    '    If e.ColumnIndex = 11 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '      Dim bmp As New Bitmap(200, 20)
    '      Dim grafico As Graphics = Graphics.FromImage(bmp)
    '      grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '      If e.Value > 0 Then
    '        Dim rec As New Rectangle(50, 5, Math.Round(e.Value * 0.51, 0), 10)
    '        Dim deg As New LinearGradientBrush(rec, Color.Yellow, Color.Green, LinearGradientMode.BackwardDiagonal)
    '        grafico.FillRectangle(deg, rec)
    '      End If
    '      e.Value = bmp
    '    End If

    '    'Grafico opciones
    '    If e.ColumnIndex = 10 AndAlso e.RowIndex > -1 AndAlso e.Value IsNot Nothing Then
    '      Dim bmp As New Bitmap(400, 20)
    '      Dim grafico As Graphics = Graphics.FromImage(bmp)
    '      grafico.DrawString(String.Format("{0}", e.Value), New Font("Arial", 8), Brushes.Black, 5, 5)
    '      If e.Value > 0 Then

    '        If e.Value > 24 Then
    '          Dim rec As New Rectangle(50, 5, Math.Round(e.Value * 0.04), 10)
    '          Dim deg As New LinearGradientBrush(rec, Color.Aqua, Color.Blue, LinearGradientMode.BackwardDiagonal)
    '          grafico.FillRectangle(deg, rec)
    '        Else
    '          Dim rec As New Rectangle(50, 5, 1, 10)
    '          Dim deg As New LinearGradientBrush(rec, Color.Aqua, Color.Blue, LinearGradientMode.BackwardDiagonal)
    '          grafico.FillRectangle(deg, rec)
    '        End If
    '      End If
    '      e.Value = bmp
    '    End If
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub

  Private Sub Check_Opciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvAccesoOpcion.ColumnHeaderMouseClick
    Try

      If e.ColumnIndex = 0 And e.RowIndex = -1 Then
        dgvAccesoOpcion.EndEdit()
        isCheckOpcion = Not isCheckOpcion
        Poner_Check_Todo_Opcion(isCheckOpcion)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub Check_Plantas(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvAccesoPlanta.ColumnHeaderMouseClick

    Try

      If e.ColumnIndex = 0 And e.RowIndex = -1 Then
        dgvAccesoPlanta.EndEdit()
        isCheckPlanta = Not isCheckPlanta
        Poner_Check_Todo_Planta(isCheckPlanta)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub


  Private Sub Check_Clientes(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvAccesoCliente.ColumnHeaderMouseClick
    Try

      If e.ColumnIndex = 0 And e.RowIndex = -1 Then
        dgvAccesoCliente.EndEdit()
        isCheckCliente = Not isCheckCliente
        Poner_Check_Todo_Cliente(isCheckCliente)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub UcPaginacion2_PageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcPaginacion2.PageChanged
    Try
      Cargar_AccesoOpcion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub ExportarParcial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarParcial.Click

    Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
      Dim dtExport As New DataTable
      Dim ColName As String = ""
      Dim MdataColumna As String = ""

      Dim TableName As String = ""
      Dim ColTitle As String = ""
      Dim TipoDato As String = ""

      If dgvUsuarios.Rows.Count > 0 Then
        For Each Item As DataGridViewColumn In dgvUsuarios.Columns
          ColTitle = Item.HeaderText.Trim
          ColName = Item.Name
          TipoDato = ""
          If Item.Visible = True Then
            If ColName.Contains("OPCIONES") Or ColName.Contains("PLANTAS") Or ColName.Contains("CLIENTES") Then
                            TipoDato = NPOI_SC.keyDatoNumero
            Else
                            TipoDato = NPOI_SC.keyDatoTexto
            End If
            dtExport.Columns.Add(ColName)
                        MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
            dtExport.Columns(ColName).Caption = MdataColumna
          End If
        Next

        Dim dr As DataRow
        For Fila As Integer = 0 To dgvUsuarios.Rows.Count - 1
          dr = dtExport.NewRow
          For Columna As Integer = 0 To dtExport.Columns.Count - 1
            ColName = dtExport.Columns(Columna).ColumnName
            If (dgvUsuarios.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
              dr(ColName) = dgvUsuarios.Rows(Fila).Cells(ColName).Value
            End If
          Next
          dtExport.Rows.Add(dr)
        Next
                'Dim oLisParametros As New SortedList
                'oLisParametros(0) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
                'oLisParametros(1) = "Hora:|" & Now.ToString("hh:mm:ss")
        Dim Estado As String
        If cboEstado.SelectedValue = "A" Then
          Estado = "ACTIVOS"
        Else
          Estado = "INACTIVOS"
        End If
                'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtExport, String.Format("LISTADO DE USUARIOS {0}", Estado), Nothing, oLisParametros)


                Dim ListaDatatable As New List(Of DataTable)
                ListaDatatable.Add(dtExport.Copy)

                Dim LisFiltros As New List(Of SortedList)
                Dim itemSortedList As SortedList

                itemSortedList = New SortedList
                itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
                itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
                LisFiltros.Add(itemSortedList)

                Dim ListTitulo As New List(Of String)
                ListTitulo.Add(String.Format("LISTADO DE USUARIOS {0}", Estado))
                NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)



      End If


    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub ExportarTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarTotal.Click

    Try

      dgvUsuarios.AutoGenerateColumns = False
      dgvUsuarios.DataSource = Nothing
      Dim listbeUsuario As New List(Of beUsuario)
      Dim obeUsuario As New beUsuario
      Dim oclsUsuario_DAL As New clsUsuario_DAL

      pActualizarTabsNothing()

      obeUsuario.PSMMCUSR = "" 'todos
      obeUsuario.PSMMNUSR = "" 'todos
      If cboEstado.SelectedValue = "A" Then
        obeUsuario.PSSESTRG = "A"
      Else
        obeUsuario.PSSESTRG = "*"
      End If
      listbeUsuario = oclsUsuario_DAL.Listar_Usuarios_Total(obeUsuario)
      dgvUsuarios.DataSource = listbeUsuario

      ' Exportar todos los usuarios

            Dim NPOI_SC As New HelpClass_NPOI_SC
      Dim dtExport As New DataTable
      Dim ColName As String = ""
      Dim MdataColumna As String = ""

      Dim TableName As String = ""
      Dim ColTitle As String = ""
      Dim TipoDato As String = ""

      For Each Item As DataGridViewColumn In dgvUsuarios.Columns
        ColTitle = Item.HeaderText.Trim
        ColName = Item.Name
        TipoDato = ""
        If Item.Visible = True Then
          If ColName.Contains("OPCIONES") Or ColName.Contains("PLANTAS") Or ColName.Contains("CLIENTES") Then
                        TipoDato = NPOI_SC.keyDatoNumero
          Else
                        TipoDato = NPOI_SC.keyDatoTexto
          End If
          dtExport.Columns.Add(ColName)
                    MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
          dtExport.Columns(ColName).Caption = MdataColumna
        End If
      Next

      Dim dr As DataRow
      For Fila As Integer = 0 To dgvUsuarios.Rows.Count - 1
        dr = dtExport.NewRow
        For Columna As Integer = 0 To dtExport.Columns.Count - 1
          ColName = dtExport.Columns(Columna).ColumnName
          If (dgvUsuarios.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
            dr(ColName) = dgvUsuarios.Rows(Fila).Cells(ColName).Value
          End If
        Next
        dtExport.Rows.Add(dr)
      Next

            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(1) = "Hora:|" & Now.ToString("hh:mm:ss")
      Dim Estado As String
      If cboEstado.SelectedValue = "A" Then
        Estado = "ACTIVOS"
      Else
        Estado = "INACTIVOS"
      End If
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtExport, String.Format("LISTADO DE USUARIOS {0}", Estado), Nothing, oLisParametros)


            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExport.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add(String.Format("LISTADO DE USUARIOS {0}", Estado))
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


      pActualizarDatos(txtUsuario.Text, txtNombre.Text)

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
    Try

      Dim dt As New DataTable
      Dim ds As New DataSet
      Dim obeUsuario As New beUsuario
      Dim oclsUsuario_DAL As New clsUsuario_DAL

      obeUsuario.PSMMCUSR = txtUsuario.Text
      obeUsuario.PSMMNUSR = txtNombre.Text

      If cboEstado.SelectedValue = "A" Then
        obeUsuario.PSSESTRG = "A"
      Else
        obeUsuario.PSSESTRG = "*"
      End If
      dt = oclsUsuario_DAL.Reporte_Usuarios(obeUsuario)
      dt.TableName = "USUARIOS"
      Dim ofrmReporte As New frmReporte
      Dim ocrusuarios As New crUsuarios
      ds.Tables.Add(dt)
      ocrusuarios.SetDataSource(ds)
      ofrmReporte.crvReporte.ReportSource = ocrusuarios
      ofrmReporte.ShowDialog()
    Catch ex As Exception

    End Try
  End Sub

End Class

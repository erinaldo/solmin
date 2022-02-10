Imports SOLMIN_SC.NEGOCIO
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text
Imports System.IO
Imports Ransa.Utilitario.UCPaginacion
Imports SOLMIN_SC.Utilitario.HelpClassUtility

Public Class frmEmbarcador

#Region "Variables"
  Dim objNegocio As New Negocio.clsEmbarcador

  Private dtPrincipal As New DataTable
  Private TotalPaginas As Integer

  Private texto_Guardar As String = "Guardar"
  Private texto_Modificar As String = "Modificar"
  Private texto_Registrar As String = "Registrar"

  Enum Mantenimiento
    Inicio
    Edicion
    Nuevo
    Inactivo
  End Enum

#End Region

    Private Sub Buscar_Embarcador()
        Dim objLogica As New Negocio.clsEmbarcador()
        Dim objEntidad As New Entidad.beEmbarcador()
        UcPaginacion.PageNumber = 1
        If Me.txtCodBusqueda.Text = Nothing Then
            objEntidad.PNCAGNCR_INI = 0
            objEntidad.PNCAGNCR_FIN = 999999
        Else
            objEntidad.PNCAGNCR_INI = Val(Me.txtCodBusqueda.Text)
            objEntidad.PNCAGNCR_FIN = Val(Me.txtCodBusqueda.Text)
        End If
        objEntidad.PSTNMAGC = Me.txtEmbarcador.Text.ToUpper.Trim
        If (Me.cmbEstado.SelectedValue = "1") Then
            objEntidad.PSSESTRG = "A"
        ElseIf (Me.cmbEstado.SelectedValue = "2") Then
            objEntidad.PSSESTRG = "*"
        End If
        Dim dtResultado As New DataTable
        dtResultado = objLogica.Buscar_Embarcador(objEntidad)
        dtPrincipal = dtResultado.Copy
        TotalPaginas = HelpUtil.Numero_Paginas(dtPrincipal, UcPaginacion.PageSize)
        UcPaginacion.PageCount = TotalPaginas

    End Sub


    Private Sub HabilitarBotonMantenimiento(ByVal opc As Mantenimiento)

        Dim Estado As String = ""
        Estado = cmbEstado.SelectedValue
        '1 : Activo
        '2 : Inactivo

        Select Case opc

            Case Mantenimiento.Inicio

                txtCodigo.Text = ""
                txtAgenciaDeCarga.Text = ""
                txtDireccion.Text = ""
                cmbPais.SelectedValue = -1D

                txtCodigo.Enabled = False
                txtAgenciaDeCarga.Enabled = False
                txtDireccion.Enabled = False
                cmbPais.Enabled = False

                btnGuardar.Enabled = True
                btnGuardar.Text = texto_Modificar
                btnCancelar.Enabled = False
                btnEliminar.Enabled = True

                Select Case Estado
                    Case "1"
                        btnNuevo.Enabled = True
                        btnRestablecer.Enabled = False
                    Case "2"
                        btnNuevo.Enabled = False
                        btnRestablecer.Enabled = True
                        btnGuardar.Enabled = False
                        btnEliminar.Enabled = False

                End Select

            Case Mantenimiento.Nuevo

                txtAgenciaDeCarga.Enabled = True
                txtDireccion.Enabled = True
                cmbPais.Enabled = True
                txtCodigo.Text = ""
                txtAgenciaDeCarga.Text = ""
                txtDireccion.Text = ""
                cmbPais.SelectedValue = -1D
                txtCodigo.Focus()

                btnRestablecer.Enabled = False
                btnEliminar.Enabled = False
                btnCancelar.Enabled = True
                btnGuardar.Enabled = True
                btnGuardar.Text = texto_Registrar
                btnNuevo.Enabled = False
                txtCodigo.Enabled = False

            Case Mantenimiento.Edicion

                btnGuardar.Text = texto_Guardar
                btnNuevo.Enabled = False
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnRestablecer.Enabled = False


                txtCodigo.Enabled = False
                txtAgenciaDeCarga.Enabled = True
                txtDireccion.Enabled = True
                cmbPais.Enabled = True

        End Select

    End Sub

    Private Sub btnBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Embarcador()
            ListarEmbarcadores()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub frmEmbarcador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Me.dtgEmbarcador.AutoGenerateColumns = False
      HabilitarBotonMantenimiento(Mantenimiento.Inicio)
      Llenar_Paises()
      LlenarEstado()
      cmbEstado_SelectionChangeCommitted(cmbEstado, Nothing)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub txtEmbarcador_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmbarcador.KeyPress

    Try
      If e.KeyChar = Chr(13) Then
        btnBusqueda_Click(btnBuscar, Nothing)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub txtCodBusqueda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBusqueda.KeyPress

    Try
      If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
        e.Handled = True
      End If
      Select Case AscW(e.KeyChar)
        Case 8
          e.Handled = False
        Case 13
          btnBusqueda_Click(btnBuscar, Nothing)
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub SeleccionarRegistro()
    If dtgEmbarcador.CurrentRow IsNot Nothing Then
      Dim lint_indice As Integer = Me.dtgEmbarcador.CurrentCellAddress.Y
      Me.txtCodigo.Text = Me.dtgEmbarcador.Item("CAGNCR", lint_indice).Value.ToString.Trim
      Me.txtAgenciaDeCarga.Text = ("" & Me.dtgEmbarcador.Item("TNMAGC", lint_indice).Value).ToString.Trim
      Me.txtDireccion.Text = ("" & Me.dtgEmbarcador.Item("TDIRAC", lint_indice).Value).ToString.Trim

      Dim CPAIS As Decimal = Me.dtgEmbarcador.Item("CPAIS", lint_indice).Value
      If CPAIS = 0 Then
        Me.cmbPais.SelectedValue = -1D
      ElseIf CPAIS > 0 Then
        Me.cmbPais.SelectedValue = CPAIS
      End If
    Else

      Me.txtCodigo.Clear()
      txtAgenciaDeCarga.Clear()
      txtDireccion.Clear()
      Me.cmbPais.SelectedValue = -1D
    End If
  End Sub

  Private Sub Llenar_Paises()
    Dim oBL_Pais As New Negocio.clsPais
    Dim obePais As bePais
    Dim oListPaisOrigen As New List(Of bePais)

    oListPaisOrigen = oBL_Pais.Listar_Pais
    obePais = New bePais
    obePais.PNCPAIS = -1
    obePais.PSTCMPPS = "::Seleccione::"
    oListPaisOrigen.Insert(0, obePais)

    Me.cmbPais.DataSource = oListPaisOrigen
    Me.cmbPais.ValueMember = "PNCPAIS"
    Me.cmbPais.DisplayMember = "PSTCMPPS"
    Me.cmbPais.SelectedValue = -1D

  End Sub

    Public Sub Registrar_Registro()

        Dim objLogica As New Negocio.clsEmbarcador()
        Dim objEntidad As New Entidad.beEmbarcador()

        objEntidad.PSTNMAGC = Me.txtAgenciaDeCarga.Text.Trim
        objEntidad.PSTDIRAC = Me.txtDireccion.Text.Trim

        Dim PNCPAIS As Decimal = 0
        PNCPAIS = Me.cmbPais.SelectedValue
        If PNCPAIS = -1D Then
            objEntidad.PNCPAIS = 0
        ElseIf PNCPAIS > 0 Then
            objEntidad.PNCPAIS = PNCPAIS
        End If

        If objNegocio.Registrar_Embarcador(objEntidad) = 1 Then
            MessageBox.Show("Registro ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Embarcador()
            ListarEmbarcadores()
        End If
    End Sub

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    txtAgenciaDeCarga.Text = txtAgenciaDeCarga.Text.Trim
    If txtAgenciaDeCarga.Text = "" Then
      sbMensaje.AppendLine("* Agencia de Carga")
    End If
    Return sbMensaje.ToString
  End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            Dim TextoOpcion As String = btnGuardar.Text

            Select Case TextoOpcion
                Case texto_Modificar
                    If dtgEmbarcador.CurrentRow IsNot Nothing Then
                        HabilitarBotonMantenimiento(Mantenimiento.Edicion)
                    End If
                Case texto_Guardar
                    Dim msgValidacion As String = Valida_Campos()
                    If msgValidacion.Length > 0 Then
                        MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        Modificar_Registro()
                    End If
                Case texto_Registrar
                    Dim msgValidacion As String = Valida_Campos()
                    If msgValidacion.Length > 0 Then
                        MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        Registrar_Registro()
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Try
      HabilitarBotonMantenimiento(Mantenimiento.Nuevo)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub Modificar_Registro()
    Dim objEntidad As New Entidad.beEmbarcador()

    objEntidad.PNCAGNCR = Me.txtCodigo.Text
    objEntidad.PSTNMAGC = Me.txtAgenciaDeCarga.Text.Trim
    objEntidad.PSTDIRAC = Me.txtDireccion.Text.Trim

    Dim PNCPAIS As Decimal = 0
    PNCPAIS = Me.cmbPais.SelectedValue
    If PNCPAIS = -1D Then
      objEntidad.PNCPAIS = 0
    ElseIf PNCPAIS > 0 Then
      objEntidad.PNCPAIS = PNCPAIS
    End If
    If objNegocio.Actualizar_Embarcador(objEntidad) = 1 Then
            MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      HabilitarBotonMantenimiento(Mantenimiento.Inicio)
      Buscar_Embarcador()
      ListarEmbarcadores()
    End If
  End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            SeleccionarRegistro()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
 

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If dtgEmbarcador.CurrentRow IsNot Nothing Then
                If MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If objNegocio.Eliminar_Embarcador(Me.txtCodigo.Text) = 1 Then
                        MessageBox.Show("Registro eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        HabilitarBotonMantenimiento(Mantenimiento.Inicio)
                        Buscar_Embarcador()
                        ListarEmbarcadores()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
    Try
      If dtgEmbarcador.CurrentRow IsNot Nothing Then
        If MessageBox.Show("Desea restablecer el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          If objNegocio.Restablecer_Embarcador(Me.txtCodigo.Text) = 1 Then
            MessageBox.Show("Registro restablecido", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Embarcador()
            ListarEmbarcadores()
          End If
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub


  Private Sub txtAgenciaDeCarga_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAgenciaDeCarga.KeyPress, txtDireccion.KeyPress

    If e.KeyChar = ChrW(Keys.Enter) Then
      e.Handled = True
      SendKeys.Send("{TAB}")
    End If
  End Sub


 

  Private Sub LlenarEstado()

    Dim dt As New DataTable
    dt.Columns.Add("Display")
    dt.Columns.Add("Value")
    Dim dr As DataRow

    dr = dt.NewRow
    dr("Display") = "Activo"
    dr("Value") = "1"
    dt.Rows.Add(dr)

    dr = dt.NewRow
    dr("Display") = "Inactivo"
    dr("Value") = "2"
    dt.Rows.Add(dr)

    cmbEstado.DataSource = dt
    cmbEstado.DisplayMember = "Display"
    cmbEstado.ValueMember = "Value"
    cmbEstado.SelectedValue = "1"

  End Sub

  Private Sub cmbEstado_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectionChangeCommitted
    Try
      HabilitarBotonMantenimiento(Mantenimiento.Inicio)
      Buscar_Embarcador()
      ListarEmbarcadores()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
    Try
      TotalPaginas = HelpUtil.Numero_Paginas(dtPrincipal, UcPaginacion.PageSize)
      UcPaginacion.PageCount = TotalPaginas
      ListarEmbarcadores()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Sub ListarEmbarcadores()
    Me.dtgEmbarcador.DataSource = Nothing
        dtgEmbarcador.DataSource = HelpUtil.PaginarDatos(dtPrincipal, UcPaginacion.PageSize, UcPaginacion.PageNumber)
        SeleccionarRegistro()
  End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim odtCheckPointExportar As New DataTable
            Dim MdataColumna As String = ""

            If Me.dtgEmbarcador.RowCount = 0 OrElse Me.dtgEmbarcador.CurrentCellAddress.Y < 0 Then Exit Sub
            If dtgEmbarcador.Rows.Count = 0 Then Exit Sub
            odtCheckPointExportar.Columns.Add("CAGNCR")
            MdataColumna = NPOI_SC.FormatDato("Codigo", NPOI_SC.keyDatoTexto)
            odtCheckPointExportar.Columns("CAGNCR").Caption = MdataColumna

            odtCheckPointExportar.Columns.Add("TNMAGC")
            MdataColumna = NPOI_SC.FormatDato("Agencia de Carga", NPOI_SC.keyDatoTexto)
            odtCheckPointExportar.Columns("TNMAGC").Caption = MdataColumna

            odtCheckPointExportar.Columns.Add("TDIRAC")
            MdataColumna = NPOI_SC.FormatDato("Dirección", NPOI_SC.keyDatoTexto)
            odtCheckPointExportar.Columns("TDIRAC").Caption = MdataColumna

            odtCheckPointExportar.Columns.Add("TCMPPS")
            MdataColumna = NPOI_SC.FormatDato("País", NPOI_SC.keyDatoTexto)
            odtCheckPointExportar.Columns("TCMPPS").Caption = MdataColumna

            odtCheckPointExportar.Columns.Add("SESTRG_DESC")
            MdataColumna = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)
            odtCheckPointExportar.Columns("SESTRG_DESC").Caption = MdataColumna
            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Each drDatos As DataRow In dtPrincipal.Rows
                dr = odtCheckPointExportar.NewRow
                For Each dcColumna As DataColumn In odtCheckPointExportar.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos(NameColumna)
                Next
                odtCheckPointExportar.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(1) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(2) = "Hora:|" & Now.ToString("hh:mm:ss")
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtCheckPointExportar, "LISTADO DE EMBARCADORES ", Nothing, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtCheckPointExportar.Copy)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTADO DE EMBARCADORES ")

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList
            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Embarcador()
            ListarEmbarcadores()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    'Private Sub dtgEmbarcador_CellClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgEmbarcador.CellClick
    '  Try
    '    If e.RowIndex < 0 Or Me.dtgEmbarcador.CurrentCellAddress.Y < 0 Then
    '      Exit Sub
    '    End If
    '    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '    SeleccionarRegistro()
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub
    'Private Sub dtgEmbarcador_CurrentCellChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgEmbarcador.CurrentCellChanged
    '  Try
    '    If Me.dtgEmbarcador.CurrentCellAddress.Y < 0 Then
    '      Exit Sub
    '    End If
    '    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '    SeleccionarRegistro()
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub


    'Private Sub dtgEmbarcador_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgEmbarcador.KeyUp
    '  Try
    '    If dtgEmbarcador.CurrentCellAddress.Y < 0 Then Exit Sub
    '    Select Case e.KeyCode
    '      Case Keys.Enter, Keys.Up, Keys.Down
    '        HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '        SeleccionarRegistro()
    '    End Select
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub

    Private Sub dtgEmbarcador_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgEmbarcador.SelectionChanged
        HabilitarBotonMantenimiento(Mantenimiento.Inicio)
        SeleccionarRegistro()
    End Sub
End Class

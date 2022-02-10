Imports SOLMIN_SC.Negocio
Imports System.IO
Imports Ransa.Utilitario.UCPaginacion
Imports SOLMIN_SC.Utilitario.HelpClassUtility
Imports SOLMIN_SC.Entidad.beVapores
Imports System.Data.SqlClient
Imports Ransa.Utilitario
Imports System.Text

Public Class frmVapores

    Dim objNegocio As New Negocio.clsVapores
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

    Private Sub HabilitarBotonMantenimiento(ByVal opc As Mantenimiento)

        Dim Estado As String = ""
        Estado = cmbEstado.SelectedValue
        '1 : Activo
        '2 : Inactivo
        Select Case opc

            Case Mantenimiento.Inicio

                txtCodigo.Text = ""
                txtDesCompl.Text = ""
                txtDesAbrev.Text = ""
                txtCantTonBruto.Text = ""

                txtCodigo.Enabled = False
                txtDesCompl.Enabled = False
                txtDesAbrev.Enabled = False
                txtCantTonBruto.Enabled = False

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

                txtCodigo.Enabled = True
                txtDesCompl.Enabled = True
                txtDesAbrev.Enabled = True
                txtCantTonBruto.Enabled = True
                txtCodigo.Text = ""
                txtDesCompl.Text = ""
                txtDesAbrev.Text = ""
                txtCantTonBruto.Text = ""
                txtCodigo.Focus()


                btnRestablecer.Enabled = False
                btnEliminar.Enabled = False
                btnCancelar.Enabled = True
                btnGuardar.Enabled = True
                btnGuardar.Text = texto_Registrar
                btnNuevo.Enabled = False


            Case Mantenimiento.Edicion

                btnGuardar.Text = texto_Guardar
                btnNuevo.Enabled = False
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnRestablecer.Enabled = False

                btnRestablecer.Enabled = False
                txtCodigo.Enabled = False
                txtDesCompl.Enabled = True
                txtDesAbrev.Enabled = True
                txtCantTonBruto.Enabled = True


        End Select

    End Sub

  Sub Buscar_Vapores()

    Dim objLogica As New Negocio.clsVapores()
    Dim objEntidad As New Entidad.beVapores()

    UcPaginacion.PageNumber = 1

    objEntidad.PSCVPRCN = Me.txtCodBusqueda.Text.Trim.ToUpper
    objEntidad.PSTCMPVP = Me.txtVapor.Text.Trim.ToUpper
    If (Me.cmbEstado.SelectedValue = "1") Then
      objEntidad.PSSESTRG = "A"
    ElseIf (Me.cmbEstado.SelectedValue = "2") Then
      objEntidad.PSSESTRG = "*"
    End If

    Dim dtResultado As New DataTable
    dtResultado = objLogica.Buscar_Vapores(objEntidad)
    dtPrincipal = dtResultado.Copy
    TotalPaginas = HelpUtil.Numero_Paginas(dtPrincipal, UcPaginacion.PageSize)
    UcPaginacion.PageCount = TotalPaginas

  End Sub

  Private Sub frmVapores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      Me.dtgVapores.AutoGenerateColumns = False
      HabilitarBotonMantenimiento(Mantenimiento.Inicio)
      LlenarEstado()
      cmbEstado_SelectionChangeCommitted(cmbEstado, Nothing)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub



  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    txtCodigo.Text = txtCodigo.Text.Trim
    txtDesCompl.Text = txtDesCompl.Text.Trim
    If txtCodigo.Text.Trim = "" Then
      sbMensaje.AppendLine("* Código")
    End If
    If txtDesCompl.Text.Trim = "" Then
      sbMensaje.AppendLine("* Descripción Completa")
    End If
    Return sbMensaje.ToString
  End Function


  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Try

      Dim TextoOpcion As String = btnGuardar.Text

      Select Case TextoOpcion

        Case texto_Modificar
          If dtgVapores.CurrentRow IsNot Nothing Then
            HabilitarBotonMantenimiento(Mantenimiento.Edicion)
          End If

        Case texto_Guardar
          Dim msgValidacion1 As String = Valida_Campos()
          If msgValidacion1.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion1, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

  Private Sub txtVapor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVapor.KeyPress, txtCodBusqueda.KeyPress
    Try
      If e.KeyChar = Chr(13) Then
        btnBuscar_Click(btnBuscar, Nothing)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    'Private Sub dtgVapores_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgVapores.CellClick
    '  Try
    '    If e.RowIndex < 0 Or Me.dtgVapores.CurrentCellAddress.Y < 0 Then
    '      Exit Sub
    '    End If
    '    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '    SeleccionarRegistro()
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub

    'Private Sub dtgVapores_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgVapores.KeyUp
    '  Try
    '    If dtgVapores.CurrentCellAddress.Y < 0 Then Exit Sub
    '    Select Case e.KeyCode
    '      Case Keys.Enter, Keys.Up, Keys.Down
    '        HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '        SeleccionarRegistro()
    '    End Select
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub

    'Private Sub dtgVapores_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgVapores.CurrentCellChanged
    '  Try
    '    If dtgVapores.CurrentRow IsNot Nothing Then
    '      If Me.dtgVapores.CurrentCellAddress.Y < 0 Then
    '        Exit Sub
    '      End If
    '      HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '      SeleccionarRegistro()
    '    End If
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub


  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Try
      HabilitarBotonMantenimiento(Mantenimiento.Nuevo)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Registrar_Registro()

    Dim objEntidad As New Entidad.beVapores()
    Dim caso As Integer

    If txtCantTonBruto.Text = "" Then
      txtCantTonBruto.Text = "0"
    End If

    Dim msgValidacion As String = ""

    objEntidad.PSCVPRCN = Me.txtCodigo.Text.ToUpper.Trim
    objEntidad.PSTCMPVP = Me.txtDesCompl.Text.Trim
        objEntidad.PSNTRMNL = HelpClass.NombreMaquina
    objEntidad.PSTABRVP = Me.txtDesAbrev.Text.Trim
    objEntidad.PNQTNLBR = Val(Me.txtCantTonBruto.Text.Trim)

    caso = objNegocio.Registrar_Vapores(objEntidad)

    Select Case caso
      Case 1
        msgValidacion = "Registro ingresado"
        MessageBox.Show(msgValidacion, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        HabilitarBotonMantenimiento(Mantenimiento.Inicio)
        Buscar_Vapores()
        ListarVapores()
      Case 2
        msgValidacion = String.Format("{0}{1}{2}", "Código duplicado - Vapor Activo", Chr(13), "Ingrese otro código")
        MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Case 3
        msgValidacion = String.Format("{0}{1}{2}{3}{4}", "Código duplicado - Vapor Inactivo", Chr(13), "Ingrese otro código o", Chr(13), "puede restablecer el registro")
        MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Select

  End Sub

  Private Sub Modificar_Registro()
    Dim objEntidad As New Entidad.beVapores()

    If txtCantTonBruto.Text = "" Then
      txtCantTonBruto.Text = "0"
    End If

    objEntidad.PSCVPRCN = Me.txtCodigo.Text.Trim
    objEntidad.PSTCMPVP = Me.txtDesCompl.Text.Trim
    objEntidad.PSTABRVP = Me.txtDesAbrev.Text.Trim
        objEntidad.PSNTRMNL = HelpClass.NombreMaquina
    objEntidad.PNQTNLBR = Val(Me.txtCantTonBruto.Text.Trim)

    If objNegocio.Actualizar_Vapores(objEntidad) = 1 Then
      MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      HabilitarBotonMantenimiento(Mantenimiento.Inicio)
      Buscar_Vapores()
      ListarVapores()

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
      If dtgVapores.CurrentRow IsNot Nothing Then
        If MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          If objNegocio.Eliminar_Vapores(Me.txtCodigo.Text.ToUpper.Trim) = 1 Then
            MessageBox.Show("Registro eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Vapores()
            ListarVapores()
          End If
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
    Try
      If dtgVapores.CurrentRow IsNot Nothing Then
        If MessageBox.Show("¿Desea restablecer el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          If objNegocio.Restablecer_Vapores(Me.txtCodigo.Text.ToUpper.Trim) = 1 Then
            MessageBox.Show("Registro restablecido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Buscar_Vapores()
            ListarVapores()
          End If
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress, txtDesCompl.KeyPress, txtDesAbrev.KeyPress
    If e.KeyChar = ChrW(Keys.Enter) Then
      e.Handled = True
      SendKeys.Send("{TAB}")
    End If
  End Sub

  Private Sub SeleccionarRegistro()
    If dtgVapores.CurrentRow IsNot Nothing Then
      Dim lint_indice As Integer = Me.dtgVapores.CurrentCellAddress.Y
      Me.txtCodigo.Text = Me.dtgVapores.Item("CVPRCN", lint_indice).Value.ToString.Trim
      Me.txtDesCompl.Text = ("" & Me.dtgVapores.Item("TCMPVP", lint_indice).Value).ToString.Trim
      Me.txtDesAbrev.Text = ("" & Me.dtgVapores.Item("TABRVP", lint_indice).Value).ToString.Trim
      Me.txtCantTonBruto.Text = Me.dtgVapores.Item("QTNLBR", lint_indice).Value
    Else
      Me.txtCodigo.Text = ""
      Me.txtDesCompl.Text = ""
      Me.txtDesAbrev.Text = ""
      Me.txtCantTonBruto.Text = ""
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
      Buscar_Vapores()
      ListarVapores()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
    Try
      TotalPaginas = HelpUtil.Numero_Paginas(dtPrincipal, UcPaginacion.PageSize)
      UcPaginacion.PageCount = TotalPaginas
      ListarVapores()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    Sub ListarVapores()
        Me.dtgVapores.DataSource = Nothing
        dtgVapores.DataSource = HelpUtil.PaginarDatos(dtPrincipal, UcPaginacion.PageSize, UcPaginacion.PageNumber)
        SeleccionarRegistro()
    End Sub


  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      HabilitarBotonMantenimiento(Mantenimiento.Inicio)
      Buscar_Vapores()
            ListarVapores()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim odtExportar As New DataTable
      Dim MdataColumna As String = ""

      If Me.dtgVapores.RowCount = 0 OrElse Me.dtgVapores.CurrentCellAddress.Y < 0 Then Exit Sub
      If dtgVapores.Rows.Count = 0 Then Exit Sub

            odtExportar.Columns.Add("CVPRCN")
            MdataColumna = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("CVPRCN").Caption = MdataColumna

            odtExportar.Columns.Add("TCMPVP")
            MdataColumna = NPOI_SC.FormatDato("Descripción Completa", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("TCMPVP").Caption = MdataColumna

            odtExportar.Columns.Add("TABRVP")
            MdataColumna = NPOI_SC.FormatDato("Descripción Abreviada", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("TABRVP").Caption = MdataColumna

            odtExportar.Columns.Add("QTNLBR")
            MdataColumna = NPOI_SC.FormatDato("Capacidad de Carga", NPOI_SC.keyDatoNumero)
            odtExportar.Columns("QTNLBR").Caption = MdataColumna

            odtExportar.Columns.Add("SESTRG_DESC")
            MdataColumna = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoTexto)
            odtExportar.Columns("SESTRG_DESC").Caption = MdataColumna

      Dim dr As DataRow

      Dim NameColumna As String = ""
      For Each drDatos As DataRow In dtPrincipal.Rows
                dr = odtExportar.NewRow
                For Each dcColumna As DataColumn In odtExportar.Columns
                    NameColumna = dcColumna.ColumnName
                    dr(NameColumna) = drDatos(NameColumna)
                Next
                odtExportar.Rows.Add(dr)
            Next
            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtExportar.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTADO DE VAPORES")
            ' HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtCheckPointExportar, "LISTADO DE VAPORES", Nothing, oLisParametros)
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  
  
    Private Sub dtgVapores_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgVapores.SelectionChanged
        Try
            'If e.RowIndex < 0 Or Me.dtgVapores.CurrentCellAddress.Y < 0 Then
            '    Exit Sub
            'End If
            ' If dtgVapores.DataSource IsNot Nothing Then
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            SeleccionarRegistro()
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class


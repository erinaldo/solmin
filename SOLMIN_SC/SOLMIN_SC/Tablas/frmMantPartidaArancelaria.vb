Imports Ransa.Utilitario
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text
Imports System.IO
Imports Ransa.Utilitario.UCPaginacion
Imports SOLMIN_SC.Utilitario.HelpClassUtility

Public Class frmMantPartidaArancelaria

#Region "Declaracion de variables"
  Private oPartidaArancelaria As New SOLMIN_SC.Entidad.bePartidaArancelaria
  Private oPartidaAracelariaNeg As New SOLMIN_SC.Negocio.clsPartidaArancelaria
  Private dtPartidas As DataTable
  Private TotalPaginas As Integer

  Private texto_Guardar As String = "Guardar"
  Private texto_Modificar As String = "Modificar"
  Private texto_Registrar As String = "Registrar"


#End Region

#Region "Procedimientos y funciones"
  Private Sub Carga_partidas(ByVal sCodigo As String, ByVal sDescripcion As String)

    UcPaginacion.PageNumber = 1

    oPartidaArancelaria = New SOLMIN_SC.Entidad.bePartidaArancelaria
    oPartidaArancelaria.PSCPTDAR = IIf(sCodigo.Length = 0, "*", sCodigo.Trim)
    oPartidaArancelaria.PSTDEPTD = sDescripcion.Trim
    dtPartidas = oPartidaAracelariaNeg.Lista_Partidas_Arancelarias(oPartidaArancelaria)

    'dtgPartida.DataSource = dtPartidas

    TotalPaginas = HelpUtil.Numero_Paginas(dtPartidas, UcPaginacion.PageSize)
    UcPaginacion.PageCount = TotalPaginas
    'If dtPartidas.Rows.Count = 0 Then
    '  'fLimpiarControles()
    'End If

    End Sub



  'Private Sub fLimpiarControles()
  '  txtCodigoMante.Text = String.Empty
  '  txtDescripcion.Text = String.Empty
  '  txtPorcentaje.Text = String.Empty
  'End Sub

  Private Function fValidaCodigo(ByVal Codigo As String) As Boolean
    Dim bRetorno As Boolean = False
    oPartidaArancelaria = New SOLMIN_SC.Entidad.bePartidaArancelaria
    oPartidaArancelaria.PSCPTDAR = IIf(Codigo.Length = 0, "*", Codigo.Trim)
    If oPartidaAracelariaNeg.Lista_Partidas_Arancelarias(oPartidaArancelaria).Rows.Count > 0 Then
      bRetorno = True
    End If
    Return bRetorno
  End Function

  'Private Sub pMuestraDatos()
  '  Dim lnFila As Integer = 0
  '  Dim CPTDAR As String = String.Empty
  '  If Me.dtgPartida.RowCount > 0 Then

  '    Try
  '      lnFila = dtgPartida.CurrentCell.RowIndex
  '    Catch ex As Exception
  '      lnFila = 0
  '    End Try

  '    If btnEliminar.Visible = True Then
  '      txtCodigoMante.Text = Me.dtgPartida("CPTDAR", lnFila).Value
  '      txtDescripcion.Text = Me.dtgPartida("TDEPTD", lnFila).Value
  '      txtPorcentaje.Text = Me.dtgPartida("PRARAN", lnFila).Value
  '      txtCodigoMante.Enabled = False
  '    End If
  '  End If

  '  If dtPartidas.Rows.Count = 0 Then
  '    fLimpiarControles()
  '  End If
  'End Sub

  Enum Mantenimiento
    Inicio
    Edicion
    Nuevo
    Inactivo
  End Enum

  Private Sub HabilitarBotonMantenimiento(ByVal opc As Mantenimiento)

    Dim Estado As String = ""
    ' Estado = cmbEstado.SelectedValue
    '1 : Activo
    '2 : Inactivo

    Select Case opc

      Case Mantenimiento.Inicio

        txtCodigoMante.Text = ""
        txtDescripcion.Text = ""
        txtPorcentaje.Text = ""

        txtCodigoMante.Enabled = False
        txtDescripcion.Enabled = False
        txtPorcentaje.Enabled = False

        btnGuardar.Enabled = True
        btnGuardar.Text = texto_Modificar
        btnCancelar.Enabled = False
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True
        ' btnRestablecer.Enabled = False

      Case Mantenimiento.Nuevo

        txtCodigoMante.Enabled = True
        txtDescripcion.Enabled = True
        txtPorcentaje.Enabled = True

        txtCodigoMante.Text = ""
        txtDescripcion.Text = ""
        txtPorcentaje.Text = ""

        'btnRestablecer.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnGuardar.Text = texto_Registrar
        txtCodigoMante.Focus()
        btnNuevo.Enabled = False

      Case Mantenimiento.Edicion

        btnGuardar.Text = texto_Guardar
        btnNuevo.Enabled = False
        btnCancelar.Enabled = True
        btnEliminar.Enabled = False
        'btnRestablecer.Enabled = False

        txtCodigoMante.Enabled = False
        txtDescripcion.Enabled = True
        txtPorcentaje.Enabled = True

    End Select

  End Sub

  Private Sub SeleccionarRegistro()
    'Dim CPTDAR As String = String.Empty

    If dtgPartida.CurrentRow IsNot Nothing Then

      Dim lint_indice As Integer = Me.dtgPartida.CurrentCellAddress.Y
      Me.txtCodigoMante.Text = Me.dtgPartida.Item("CPTDAR", lint_indice).Value.ToString.Trim
      Me.txtDescripcion.Text = ("" & Me.dtgPartida.Item("TDEPTD", lint_indice).Value).ToString.Trim
      Me.txtPorcentaje.Text = ("" & Me.dtgPartida.Item("PRARAN", lint_indice).Value)
      'txtCodigoMante.Enabled = False
    Else
      Me.txtCodigoMante.Text = ""
      Me.txtDescripcion.Text = ""
      Me.txtPorcentaje.Text = ""

    End If
  End Sub

#End Region

#Region "Eventos de Control"

  'Private Sub dtgPartida_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  '  Try
  '    SeleccionarRegistro()
  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try

  'End Sub


  'Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  txtCodigoMante.Enabled = True
  '  fLimpiarControles()
  '  btnEliminar.Visible = False
  '  btnCancelar.Visible = True
  '  btnNuevo.Visible = False
  'End Sub

  'Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Try
  '    oPartidaArancelaria = New SOLMIN_SC.Entidad.bePartidaArancelaria
  '    If txtCodigoMante.Text.Trim.Length = 0 Then
  '      HelpUtil.MsgBox("Ingrese Código Partida")

  '      If txtPorcentaje.Text.Trim.Length = 0 Then
  '        txtPorcentaje.Text = String.Empty
  '      End If

  '      txtCodigoMante.Text = String.Empty
  '      Exit Sub
  '    End If

  '    If txtPorcentaje.Text.Trim.Length = 0 Then
  '      HelpUtil.MsgBox("Ingrese Descripción")
  '      txtPorcentaje.Text = String.Empty
  '      Exit Sub
  '    End If

  '    If txtPorcentaje.Text.Length = 0 Then
  '      HelpUtil.MsgBox("Ingrese un valor porcentual")
  '      txtPorcentaje.Focus()
  '      Exit Sub
  '    End If

  '    If txtCodigoMante.Enabled = True Then
  '      If fValidaCodigo(txtCodigoMante.Text) Then
  '        HelpUtil.MsgBox("Código de partida ya existe")
  '        Exit Sub
  '      End If
  '    End If


  '    oPartidaArancelaria.PSCPTDAR = txtCodigoMante.Text.Trim
  '    oPartidaArancelaria.PSTDEPTD = txtPorcentaje.Text.Trim
  '    oPartidaArancelaria.PNPRARAN = IIf(txtPorcentaje.Text.Length = 0, "0", txtPorcentaje.Text)
  '    oPartidaArancelaria.PSUSUARIO = HelpUtil.UserName
  '    oPartidaAracelariaNeg.Guardar_Partidas_Arancelarias(oPartidaArancelaria)
  '    HelpUtil.MsgBox("Se guardó el registo satisfactoriamente")
  '    btnEliminar.Visible = True
  '    btnCancelar.Visible = False
  '    btnNuevo.Visible = True
  '    Carga_partidas(txtCodBusqueda.Text, txtDescripcion.Text)
  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try
  'End Sub

  'Private Sub txtPorcentaje_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
  '  Dim dig As Integer = Len(txtPorcentaje.Text & e.KeyChar)
  '  Dim a, esDecimal, NumDecimales As Integer
  '  Dim esDec As Boolean
  '  Try

  '    ' se verifica si es un digito o un punto 
  '    If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
  '      e.Handled = False
  '    ElseIf Char.IsControl(e.KeyChar) Then
  '      e.Handled = False
  '      Return
  '    Else
  '      e.Handled = True
  '    End If

  '    ' se verifica que el primer digito ingresado no sea un punto al seleccionar
  '    If txtPorcentaje.SelectedText <> "" Then
  '      If e.KeyChar = "." Then
  '        e.Handled = True
  '        Return
  '      End If
  '    End If
  '    If dig = 1 And e.KeyChar = "." Then
  '      e.Handled = True
  '      Return
  '    End If
  '    'aqui se hace la verificacion cuando es seleccionado el valor del texto
  '    'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
  '    If txtPorcentaje.SelectedText = "" Then
  '      ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
  '      Dim inti As Integer = 0
  '      Dim intc As Integer = 0
  '      For a = 0 To dig - 1
  '        Dim car As String = CStr(txtPorcentaje.Text & e.KeyChar)
  '        inti = car.IndexOf(".")
  '        If inti > 3 Then

  '          e.Handled = True
  '        End If

  '        If car.Substring(a, 1) = "." Then
  '          esDec = True
  '        End If

  '        If esDec = False And intc = 3 Then
  '          e.Handled = True
  '        End If
  '        intc = intc + 1

  '      Next

  '      ''''
  '      esDec = False


  '      For a = 0 To dig - 1
  '        Dim car As String = CStr(txtPorcentaje.Text & e.KeyChar)
  '        If car.Substring(a, 1) = "." Then
  '          esDecimal = esDecimal + 1
  '          esDec = True
  '        End If
  '        If esDec = True Then
  '          NumDecimales = NumDecimales + 1
  '        End If
  '        ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
  '        If NumDecimales >= 4 Or esDecimal >= 2 Then
  '          e.Handled = True
  '        End If
  '      Next
  '    End If
  '  Catch ex As Exception

  '  End Try
  'End Sub

  'Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Try
  '    Dim lnFila As Integer = 0
  '    Dim CPTDAR As String = String.Empty

  '    If dtgPartida.RowCount > 0 Then
  '      lnFila = dtgPartida.CurrentCell.RowIndex

  '      CPTDAR = Me.dtgPartida("CPTDAR", lnFila).Value

  '      If CPTDAR = String.Empty Then

  '        HelpUtil.MsgBox("No ha seleccionado ningun registro")
  '        Exit Sub
  '      End If

  '      If MsgBox("¿Desea Eliminar el Registro " & "  " & CPTDAR & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

  '        oPartidaArancelaria = New SOLMIN_SC.Entidad.bePartidaArancelaria
  '        oPartidaArancelaria.PSCPTDAR = txtCodigoMante.Text.Trim
  '        oPartidaArancelaria.PSUSUARIO = HelpUtil.UserName
  '        oPartidaAracelariaNeg.Elimina_Partidas_Arancelarias(oPartidaArancelaria)
  '        HelpUtil.MsgBox("Se Eliminó el registo satisfactoriamente")
  '        fLimpiarControles()
  '        Carga_partidas(txtCodBusqueda.Text, txtDescripcion.Text)
  '      End If
  '    End If

  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try


  'End Sub

  'Private Sub txtCodigoMante_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
  '  If e.KeyCode = Keys.Enter Then
  '    txtPorcentaje.Focus()
  '  End If
  'End Sub

  'Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
  '  Try
  '    If e.KeyCode = Keys.Enter Then
  '      Carga_partidas(txtCodBusqueda.Text, txtDescripcion.Text)
  '    End If
  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try

  'End Sub

  'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Try
  '    Carga_partidas(txtCodBusqueda.Text, txtDescripcion.Text)
  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try
  'End Sub

  'Private Sub dtgPartida_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Try

  '    ' pMuestrDatos()
  '    SeleccionarRegistro()
  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try
  'End Sub

  'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  btnEliminar.Visible = True
  '  btnCancelar.Visible = False
  '  btnNuevo.Visible = True
  '  SeleccionarRegistro()
  'End Sub

  'Private Sub txtDescripcionFiltro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
  '  Try
  '    If e.KeyCode = Keys.Enter Then
  '      Carga_partidas(txtCodBusqueda.Text, txtDescripcion.Text)
  '    End If
  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try
  'End Sub
#End Region

  Private Sub frmMantPartidaArancelaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      dtgPartida.AutoGenerateColumns = False
      HabilitarBotonMantenimiento(Mantenimiento.Inicio)
      Carga_partidas(txtCodBusqueda.Text.Trim, txtDescripcionFiltro.Text.Trim)
      ListarPartida()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

    'Private Sub btnBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '  Try
    '    ' pMuestrDatos()
    '    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    '    Carga_partidas(txtCodBusqueda.Text.Trim, txtDescripcionFiltro.Text.Trim)
    '    ListarPartida()
    '    ' SeleccionarRegistro()
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try
    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            SeleccionarRegistro()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgPartida_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPartida.CellClick
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            SeleccionarRegistro()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgPartida_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgPartida.CurrentCellChanged
        Try
            ' pMuestrDatos()
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            SeleccionarRegistro()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim lnFila As Integer = 0
            Dim CPTDAR As String = String.Empty

            If dtgPartida.RowCount > 0 Then
                lnFila = dtgPartida.CurrentCell.RowIndex

                CPTDAR = Me.dtgPartida("CPTDAR", lnFila).Value

                If CPTDAR = String.Empty Then

                    HelpUtil.MsgBox("No ha seleccionado ningún registro")
                    Exit Sub
                End If

                If MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    oPartidaArancelaria = New SOLMIN_SC.Entidad.bePartidaArancelaria
                    oPartidaArancelaria.PSCPTDAR = txtCodigoMante.Text.Trim
                    oPartidaArancelaria.PSUSUARIO = HelpUtil.UserName
                    oPartidaAracelariaNeg.Elimina_Partidas_Arancelarias(oPartidaArancelaria)
                    MessageBox.Show("Registro eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
                    Carga_partidas(txtCodBusqueda.Text.Trim, txtDescripcionFiltro.Text.Trim)
                    ListarPartida()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            HabilitarBotonMantenimiento(Mantenimiento.Nuevo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    txtCodigoMante.Text = txtCodigoMante.Text.Trim
    txtDescripcion.Text = txtDescripcion.Text.Trim
    If txtCodigoMante.Text = "" Then
      sbMensaje.AppendLine("* Código de Partida")
    End If
    If txtDescripcion.Text = "" Then
      sbMensaje.AppendLine("* Descripción")
    End If
    Return sbMensaje.ToString
  End Function

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            oPartidaArancelaria = New SOLMIN_SC.Entidad.bePartidaArancelaria

            Dim TextoOpcion As String = btnGuardar.Text

            Select Case TextoOpcion
                Case texto_Modificar
                    If dtgPartida.CurrentRow IsNot Nothing Then
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
            'If txtCodigoMante.Text.Trim.Length = 0 Then
            '  HelpUtil.MsgBox("Ingrese Código Partida")

            '  If txtPorcentaje.Text.Trim.Length = 0 Then
            '    txtPorcentaje.Text = String.Empty
            '  End If

            '  txtCodigoMante.Text = String.Empty
            '  Exit Sub
            'End If

            'If txtPorcentaje.Text.Trim.Length = 0 Then
            '  HelpUtil.MsgBox("Ingrese Descripción")
            '  txtPorcentaje.Text = String.Empty
            '  Exit Sub
            'End If

            'If txtPorcentaje.Text.Length = 0 Then
            '  HelpUtil.MsgBox("Ingrese un valor porcentual")
            '  txtPorcentaje.Focus()
            '  Exit Sub
            'End If

            'If txtCodigoMante.Enabled = True Then
            '  If fValidaCodigo(txtCodigoMante.Text) Then
            '    HelpUtil.MsgBox("Código de partida ya existe")
            '    Exit Sub
            '  End If
            'End If

            'oPartidaArancelaria.PSCPTDAR = txtCodigoMante.Text.Trim
            'oPartidaArancelaria.PSTDEPTD = txtPorcentaje.Text.Trim
            'oPartidaArancelaria.PNPRARAN = IIf(txtPorcentaje.Text.Length = 0, "0", txtPorcentaje.Text)
            'oPartidaArancelaria.PSUSUARIO = HelpUtil.UserName
            'oPartidaAracelariaNeg.Guardar_Partidas_Arancelarias(oPartidaArancelaria)
            'HelpUtil.MsgBox("Se guardó el registo satisfactoriamente")
            'btnEliminar.Visible = True
            'btnCancelar.Visible = False
            'btnNuevo.Visible = True
            'Carga_partidas(txtCodBusqueda.Text, txtDescripcion.Text)
            'ListarPartida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub Registrar_Registro()
    oPartidaArancelaria = New SOLMIN_SC.Entidad.bePartidaArancelaria

    'If txtCodigoMante.Enabled = True Then
    If fValidaCodigo(txtCodigoMante.Text.Trim) = True Then
      HelpUtil.MsgBox("El Código de partida de Arancel ya existe")
      Exit Sub
    End If
    'End If
    oPartidaArancelaria.PSCPTDAR = txtCodigoMante.Text.Trim
    oPartidaArancelaria.PSTDEPTD = txtDescripcion.Text.Trim
    oPartidaArancelaria.PNPRARAN = IIf(txtPorcentaje.Text.Length = 0, "0", txtPorcentaje.Text)
    oPartidaArancelaria.PSUSUARIO = HelpUtil.UserName
    oPartidaAracelariaNeg.Guardar_Partidas_Arancelarias(oPartidaArancelaria)
    MessageBox.Show("Registro ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'btnEliminar.Visible = True
    'btnCancelar.Visible = False
    'btnNuevo.Visible = True
    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    Carga_partidas(txtCodBusqueda.Text.Trim, txtDescripcionFiltro.Text.Trim)
    ListarPartida()
  End Sub

  Private Sub Modificar_Registro()
    oPartidaArancelaria = New SOLMIN_SC.Entidad.bePartidaArancelaria
    Dim palabra As String = txtDescripcion.Text.Trim
    'If txtCodigoMante.Enabled = False Then
    oPartidaArancelaria.PSCPTDAR = txtCodigoMante.Text.Trim
    oPartidaArancelaria.PSTDEPTD = txtDescripcion.Text.Trim
    oPartidaArancelaria.PNPRARAN = IIf(txtPorcentaje.Text.Length = 0, "0", txtPorcentaje.Text)
    oPartidaArancelaria.PSUSUARIO = HelpUtil.UserName
    oPartidaAracelariaNeg.Guardar_Partidas_Arancelarias(oPartidaArancelaria)
    MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'btnEliminar.Visible = True
    'btnCancelar.Visible = False
    'btnNuevo.Visible = True
    HabilitarBotonMantenimiento(Mantenimiento.Inicio)
    Carga_partidas(txtCodBusqueda.Text.Trim, txtDescripcionFiltro.Text.Trim)
    ListarPartida()
    'End If

  End Sub

  'Private Sub txtPorcentaje_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
  '  Dim dig As Integer = Len(txtPorcentaje.Text & e.KeyChar)
  '  Dim a, esDecimal, NumDecimales As Integer
  '  Dim esDec As Boolean
  '  Try

  '    ' se verifica si es un digito o un punto 
  '    If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
  '      e.Handled = False
  '    ElseIf Char.IsControl(e.KeyChar) Then
  '      e.Handled = False
  '      Return
  '    Else
  '      e.Handled = True
  '    End If

  '    ' se verifica que el primer digito ingresado no sea un punto al seleccionar
  '    If txtPorcentaje.SelectedText <> "" Then
  '      If e.KeyChar = "." Then
  '        e.Handled = True
  '        Return
  '      End If
  '    End If
  '    If dig = 1 And e.KeyChar = "." Then
  '      e.Handled = True
  '      Return
  '    End If
  '    'aqui se hace la verificacion cuando es seleccionado el valor del texto
  '    'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
  '    If txtPorcentaje.SelectedText = "" Then
  '      ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
  '      Dim inti As Integer = 0
  '      Dim intc As Integer = 0
  '      For a = 0 To dig - 1
  '        Dim car As String = CStr(txtPorcentaje.Text & e.KeyChar)
  '        inti = car.IndexOf(".")
  '        If inti > 3 Then

  '          e.Handled = True
  '        End If

  '        If car.Substring(a, 1) = "." Then
  '          esDec = True
  '        End If

  '        If esDec = False And intc = 3 Then
  '          e.Handled = True
  '        End If
  '        intc = intc + 1
  '      Next

  '      ''''
  '      esDec = False

  '      For a = 0 To dig - 1
  '        Dim car As String = CStr(txtPorcentaje.Text & e.KeyChar)
  '        If car.Substring(a, 1) = "." Then
  '          esDecimal = esDecimal + 1
  '          esDec = True
  '        End If
  '        If esDec = True Then
  '          NumDecimales = NumDecimales + 1
  '        End If
  '        ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
  '        If NumDecimales >= 4 Or esDecimal >= 2 Then
  '          e.Handled = True
  '        End If
  '      Next
  '    End If
  '  Catch ex As Exception

  '  End Try
  'End Sub

  'Private Sub txtCodigoMante_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoMante.KeyDown
  '  If e.KeyCode = Keys.Enter Then
  '    txtPorcentaje.Focus()
  '  End If
  'End Sub

  'Private Sub txtCodBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBusqueda.KeyDown
  '  Try
  '    If e.KeyCode = Keys.Enter Then
  '      Carga_partidas(txtCodBusqueda.Text, txtDescripcionFiltro.Text)
  '    End If
  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try

  'End Sub

  'Private Sub txtDescripcionFiltro_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcionFiltro.KeyDown
  '  Try
  '    If e.KeyCode = Keys.Enter Then
  '      Carga_partidas(txtCodBusqueda.Text, txtDescripcion.Text)
  '    End If
  '  Catch ex As Exception
  '    HelpUtil.MsgBox("Error : " & ex.ToString)
  '  End Try
  'End Sub

  Private Sub UcPaginacion_PageChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPaginacion.PageChanged
        Try
            TotalPaginas = HelpUtil.Numero_Paginas(dtPartidas, UcPaginacion.PageSize)
            UcPaginacion.PageCount = TotalPaginas
            ListarPartida()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub
  Sub ListarPartida()
    Me.dtgPartida.DataSource = Nothing
    dtgPartida.DataSource = HelpUtil.PaginarDatos(dtPartidas, UcPaginacion.PageSize, UcPaginacion.PageNumber)
  End Sub

    'Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim NPOI As New HelpClass_NPOI_SC
    '        Dim odtCheckPointExportar As New DataTable
    '        Dim MdataColumna As String = ""

    '        If Me.dtgPartida.RowCount = 0 OrElse Me.dtgPartida.CurrentCellAddress.Y < 0 Then Exit Sub
    '        If dtgPartida.Rows.Count = 0 Then Exit Sub
    '        odtCheckPointExportar.Columns.Add("CPTDAR")
    '        MdataColumna = NPOI.FormatDato("Código", HelpClass_NPOI_SC.keyDatoTexto)
    '        odtCheckPointExportar.Columns("CPTDAR").Caption = MdataColumna

    '        odtCheckPointExportar.Columns.Add("TDEPTD")
    '        MdataColumna = NPOI.FormatDato("Descripción de la Partida", HelpClass_NPOI_SC.keyDatoTexto)
    '        odtCheckPointExportar.Columns("TDEPTD").Caption = MdataColumna

    '        odtCheckPointExportar.Columns.Add("PRARAN")
    '        MdataColumna = NPOI.FormatDato("Porcentaje de Arancel", HelpClass_NPOI_SC.keyDatoTexto)
    '        odtCheckPointExportar.Columns("PRARAN").Caption = MdataColumna
    '        Dim dr As DataRow
    '        Dim NameColumna As String = ""
    '        For Each drDatos As DataRow In dtPartidas.Rows
    '            dr = odtCheckPointExportar.NewRow
    '            For Each dcColumna As DataColumn In odtCheckPointExportar.Columns
    '                NameColumna = dcColumna.ColumnName
    '                dr(NameColumna) = drDatos(NameColumna)
    '            Next
    '            odtCheckPointExportar.Rows.Add(dr)
    '        Next
    '        Dim oLisParametros As New SortedList
    '        oLisParametros(1) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
    '        oLisParametros(2) = "Hora:|" & Now.ToString("hh:mm:ss")
    '        NPOI.ExportExcelGeneralReleaseV01(odtCheckPointExportar, "LISTADO DE PARTIDAS ARANCELARIAS ", oLisParametros)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

  Private Sub txtCodBusqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBusqueda.KeyPress
    Try
      If e.KeyChar = Chr(13) Then
        Carga_partidas(txtCodBusqueda.Text.Trim, txtDescripcionFiltro.Text.Trim)
        ListarPartida()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtDescripcionFiltro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionFiltro.KeyPress
    Try
      If e.KeyChar = Chr(13) Then
        Carga_partidas(txtCodBusqueda.Text.Trim, txtDescripcionFiltro.Text.Trim)
        ListarPartida()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodigoMante_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoMante.KeyPress, txtDescripcion.KeyPress, txtPorcentaje.KeyPress
    If e.KeyChar = ChrW(Keys.Enter) Then
      e.Handled = True
      SendKeys.Send("{TAB}")
    End If
  End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim odtCheckPointExportar As New DataTable
            Dim MdataColumna As String = ""

            If Me.dtgPartida.RowCount = 0 OrElse Me.dtgPartida.CurrentCellAddress.Y < 0 Then Exit Sub
            If dtgPartida.Rows.Count = 0 Then Exit Sub
            odtCheckPointExportar.Columns.Add("CPTDAR")
            MdataColumna = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoTexto)
            odtCheckPointExportar.Columns("CPTDAR").Caption = MdataColumna

            odtCheckPointExportar.Columns.Add("PRARAN")
            MdataColumna = NPOI_SC.FormatDato("Porcentaje de Arancel", NPOI_SC.keyDatoTexto)
            odtCheckPointExportar.Columns("PRARAN").Caption = MdataColumna

            odtCheckPointExportar.Columns.Add("TDEPTD")
            MdataColumna = NPOI_SC.FormatDato("Descripción de la Partida", NPOI_SC.keyDatoTexto)
            odtCheckPointExportar.Columns("TDEPTD").Caption = MdataColumna

         
            Dim dr As DataRow
            Dim NameColumna As String = ""
            For Each drDatos As DataRow In dtPartidas.Rows
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
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(odtCheckPointExportar, "LISTADO DE PARTIDAS ARANCELARIAS ", Nothing, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(odtCheckPointExportar.Copy)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("PARTIDAS ARANCELARIOS")

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
            ' pMuestrDatos()
            HabilitarBotonMantenimiento(Mantenimiento.Inicio)
            Carga_partidas(txtCodBusqueda.Text.Trim, txtDescripcionFiltro.Text.Trim)
            ListarPartida()
            ' SeleccionarRegistro()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


  
End Class

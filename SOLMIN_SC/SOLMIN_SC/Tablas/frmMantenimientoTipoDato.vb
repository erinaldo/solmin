Imports ComponentFactory.Krypton.Toolkit
Public Class frmMantenimientoTipoDato

#Region "Comun"
    Private oTipoDato As New SOLMIN_SC.Entidad.beTipoDato
    Private oTipoDatoNeg As New SOLMIN_SC.Negocio.clsTipoDato
    Private Crud As Integer = 0
    Enum Tipos
        Nuevo = 1
        Modifica = 2
        Elimina = 3
    End Enum
    Private Sub frmMantenimientoTipoDato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carga_TipoDato()
        fInhabilitaDescripcion()
        fInhabilitaGuardar()
    End Sub

    Private Sub fInhabilitaBotones()
        btnNuevo.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnCancelar.Visible = False
        btnGuardar.Visible = False
    End Sub
    Private Sub fHabilitaInicializaBotones()
        btnNuevo.Visible = True
        btnModificar.Visible = True
        btnEliminar.Visible = True
    End Sub
    Private Sub fInhabilitaDescripcion()
        txtDescripcionTipoDato.Enabled = False
    End Sub
    Private Sub fHabilitaDescripcion()
        txtDescripcionTipoDato.Enabled = True
        txtDescripcionTipoDato.Focus()
        fInhabilitaBotones()
        fHabilitaGuardar()
    End Sub
    Private Sub fHabilitaGuardar()
        btnGuardar.Visible = True
        btnCancelar.Visible = True
    End Sub
    Private Sub fInhabilitaGuardar()
        btnGuardar.Visible = False
        btnCancelar.Visible = False
        fHabilitaInicializaBotones()
    End Sub
  'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
  '    fInhabilitaGuardar()
  '    fInhabilitaDescripcion()
  '    Carga_TipoDato()
  'End Sub

  Private Sub txtDescripcionTipoDato_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    txtDescripcionTipoDato.Text = txtDescripcionTipoDato.Text.ToUpper
  End Sub
#End Region
#Region "Consulta"
  'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
  '    fHabilitaInicializaBotones()
  '    Carga_TipoDato()
  'End Sub
    Private Sub txtFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFiltro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            fHabilitaInicializaBotones()
            Carga_TipoDato()
        End If
    End Sub
    Public Sub Carga_TipoDato()
        Try
            oTipoDato.PSTDSTPD = txtFiltro.Text
            Dim dtTipoDato As DataTable = oTipoDatoNeg.Lista_TipoDato(oTipoDato)
            dtgTipoDato.AutoGenerateColumns = False
            dtgTipoDato.DataSource = dtTipoDato
        Catch ex As Exception
            HelpUtil.MsgBox("Error : " & ex.ToString)
        End Try
    End Sub
  'Private Sub dtgTipoDato_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  '  If e.RowIndex > -1 Then
  '    Dim objTipoDato As New SOLMIN_SC.Entidad.beTipoDato
  '    objTipoDato.PNNTPODT = Me.dtgTipoDato.Rows(e.RowIndex).Cells("NTPODT").Value
  '    objTipoDato.PSTDSTPD = Me.dtgTipoDato.Rows(e.RowIndex).Cells("TDSTPD").Value
  '    Carga_TipoDatoDetalle(objTipoDato)
  '  End If
  'End Sub

  'Private Sub dtgTipoDato_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
  '  If e.RowIndex > -1 Then
  '    Dim objTipoDato As New SOLMIN_SC.Entidad.beTipoDato
  '    objTipoDato.PNNTPODT = Me.dtgTipoDato.Rows(e.RowIndex).Cells("NTPODT").Value
  '    objTipoDato.PSTDSTPD = Me.dtgTipoDato.Rows(e.RowIndex).Cells("TDSTPD").Value
  '    Carga_TipoDatoDetalle(objTipoDato)
  '  End If
  'End Sub

    Public Sub Carga_TipoDatoDetalle(ByVal objTipoDato As SOLMIN_SC.Entidad.beTipoDato)
        Try
            oTipoDato.PNNTPODT = objTipoDato.PNNTPODT

            txtCodigoTipoDato.Text = objTipoDato.PNNTPODT
            txtDescripcionTipoDato.Text = objTipoDato.PSTDSTPD.Trim

            Dim dtTipoDatoDetalle As DataTable = oTipoDatoNeg.Lista_TipoDatoDetalle(oTipoDato)
            dtgTipoDatoDetalle.AutoGenerateColumns = False
            dtgTipoDatoDetalle.DataSource = dtTipoDatoDetalle
        Catch ex As Exception
            HelpUtil.MsgBox("Error : " & ex.Message.ToString)
        End Try
    End Sub
#End Region
#Region "CRUD"

  'Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
  '  Select Case Me.TabControl1.SelectedIndex
  '    Case 0
  '      If Crud = Tipos.Nuevo Then
  '        If txtDescripcionTipoDato.Text = "" Then
  '          HelpUtil.MsgBox("Ingrese Descripción")
  '          Exit Sub
  '        End If
  '        oTipoDato.PSTDSTPD = txtDescripcionTipoDato.Text
  '        oTipoDatoNeg.Inserta_TipoDato(oTipoDato)
  '        Carga_TipoDato()
  '        fInhabilitaDescripcion()
  '      ElseIf Crud = Tipos.Modifica Then
  '        If txtDescripcionTipoDato.Text = "" Then
  '          HelpUtil.MsgBox("Ingrese Descripción")
  '          Exit Sub
  '        End If
  '        oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
  '        oTipoDato.PSTDSTPD = txtDescripcionTipoDato.Text
  '        oTipoDatoNeg.Actualiza_TipoDato(oTipoDato)
  '        Carga_TipoDato()
  '        fInhabilitaDescripcion()
  '      Else
  '        Exit Sub
  '      End If
  '    Case 1
  '      Guardar_DetalleTipoDato()
  '  End Select
  '  fInhabilitaGuardar()
  'End Sub

  Private Sub Guardar_DetalleTipoDato()
    Try
      oTipoDatoNeg.Inserta_TipoDatoDetalle(oTipoDato)
    Catch ex As Exception
      HelpUtil.MsgBox("Error : " & ex.Message.ToString)
    End Try
  End Sub
  'Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
  '  Select Case Me.TabControl1.SelectedIndex
  '    'Modificar
  '    Case 0
  '      fHabilitaDescripcion()
  '      Crud = Tipos.Modifica
  '    Case 1
  '      If dtgTipoDatoDetalle.Rows.Count = 0 Then Exit Sub
  '      oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
  '      oTipoDato.PSTDSTPD = txtDescripcionTipoDato.Text
  '      oTipoDato.PNNCODRG = dtgTipoDatoDetalle.CurrentRow.Cells("NCODRG_1").Value
  '      oTipoDato.PSTDSCRG = dtgTipoDatoDetalle.CurrentRow.Cells("TDSCRG_1").Value
  '      oTipoDato.PNCCLNT = dtgTipoDatoDetalle.CurrentRow.Cells("CCLNT1").Value
  '      oTipoDato.PNQCNTN = dtgTipoDatoDetalle.CurrentRow.Cells("QCNTN").Value
  '      Dim frmActualiza As New frmMantDetalleTipoDato(oTipoDato)
  '      frmActualiza.StartPosition = FormStartPosition.CenterScreen
  '      frmActualiza.ShowInTaskbar = False
  '      If frmActualiza.ShowDialog() = Windows.Forms.DialogResult.OK Then
  '        Carga_TipoDatoDetalle(oTipoDato)
  '      End If
  '  End Select
  'End Sub

  'Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
  '  Select Case Me.TabControl1.SelectedIndex
  '    Case 0
  '      If dtgTipoDato.Rows.Count = 0 Then Exit Sub
  '      oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
  '      If MsgBox("¿Desea Eliminar Este Registro? " & Chr(13) & "Tipo : " & oTipoDato.PNNTPODT, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
  '        Dim iValida As Integer = oTipoDatoNeg.Eliminar_TipoDato(oTipoDato)
  '        If iValida = -1 Then
  '          HelpUtil.MsgBox("Hubo un Error al Intentar Eliminar el Registro")
  '        ElseIf iValida = 0 Then
  '          HelpUtil.MsgBox("No Se Puede Eliminar. El registro tiene Asociado Detalles de Tipo")
  '        Else
  '          '-------------------------------------------------
  '        End If
  '        Carga_TipoDato()
  '      End If
  '    Case 1
  '      If dtgTipoDatoDetalle.Rows.Count = 0 Then Exit Sub
  '      oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
  '      oTipoDato.PNNCODRG = dtgTipoDatoDetalle.CurrentRow.Cells("NCODRG_1").Value
  '      If MsgBox("¿Desea Eliminar Este Registro? " & Chr(13) & "Tipo : " & oTipoDato.PNNTPODT & Chr(13) & "Cod Detalle : " & oTipoDato.PNNCODRG, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
  '        Dim iValida As Integer = oTipoDatoNeg.Eliminar_TipoDatoDetalle(oTipoDato)
  '        If iValida = -1 Then
  '          HelpUtil.MsgBox("Hubo un Error al Intentar Eliminar el Registro")
  '        ElseIf iValida = 0 Then
  '          HelpUtil.MsgBox("No Se Puede Eliminar. El registro esta asociado a un Embarque")
  '        Else
  '          '-------------------------------------------------
  '        End If
  '        Carga_TipoDatoDetalle(oTipoDato)
  '      End If
  '  End Select
  'End Sub
#End Region

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    Select Case Me.TabControl1.SelectedIndex
      'Modificar
      Case 0
        fHabilitaDescripcion()
        Crud = Tipos.Modifica
      Case 1
        If dtgTipoDatoDetalle.Rows.Count = 0 Then Exit Sub
        oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
        oTipoDato.PSTDSTPD = txtDescripcionTipoDato.Text
        oTipoDato.PNNCODRG = dtgTipoDatoDetalle.CurrentRow.Cells("NCODRG_1").Value
        oTipoDato.PSTDSCRG = dtgTipoDatoDetalle.CurrentRow.Cells("TDSCRG_1").Value
        oTipoDato.PNCCLNT = dtgTipoDatoDetalle.CurrentRow.Cells("CCLNT1").Value
        oTipoDato.PNQCNTN = dtgTipoDatoDetalle.CurrentRow.Cells("QCNTN").Value
        Dim frmActualiza As New frmMantDetalleTipoDato(oTipoDato)
        frmActualiza.StartPosition = FormStartPosition.CenterScreen
        frmActualiza.ShowInTaskbar = False
        If frmActualiza.ShowDialog() = Windows.Forms.DialogResult.OK Then
          Carga_TipoDatoDetalle(oTipoDato)
        End If
    End Select
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Select Case Me.TabControl1.SelectedIndex
      Case 0
        If Crud = Tipos.Nuevo Then
          If txtDescripcionTipoDato.Text = "" Then
            HelpUtil.MsgBox("Ingrese Descripción")
            Exit Sub
          End If
          oTipoDato.PSTDSTPD = txtDescripcionTipoDato.Text
          oTipoDatoNeg.Inserta_TipoDato(oTipoDato)
          Carga_TipoDato()
          fInhabilitaDescripcion()
        ElseIf Crud = Tipos.Modifica Then
          If txtDescripcionTipoDato.Text = "" Then
            HelpUtil.MsgBox("Ingrese Descripción")
            Exit Sub
          End If
          oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
          oTipoDato.PSTDSTPD = txtDescripcionTipoDato.Text
          oTipoDatoNeg.Actualiza_TipoDato(oTipoDato)
          Carga_TipoDato()
          fInhabilitaDescripcion()
        Else
          Exit Sub
        End If
      Case 1
        Guardar_DetalleTipoDato()
    End Select
    fInhabilitaGuardar()
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    Select Case Me.TabControl1.SelectedIndex
      Case 0
        If dtgTipoDato.Rows.Count = 0 Then Exit Sub
        oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
        If MsgBox("¿Desea Eliminar Este Registro? " & Chr(13) & "Tipo : " & oTipoDato.PNNTPODT, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
          Dim iValida As Integer = oTipoDatoNeg.Eliminar_TipoDato(oTipoDato)
          If iValida = -1 Then
            HelpUtil.MsgBox("Hubo un Error al Intentar Eliminar el Registro")
          ElseIf iValida = 0 Then
            HelpUtil.MsgBox("No Se Puede Eliminar. El registro tiene Asociado Detalles de Tipo")
          Else
            '-------------------------------------------------
          End If
          Carga_TipoDato()
        End If
      Case 1
        If dtgTipoDatoDetalle.Rows.Count = 0 Then Exit Sub
        oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
        oTipoDato.PNNCODRG = dtgTipoDatoDetalle.CurrentRow.Cells("NCODRG_1").Value
        If MsgBox("¿Desea Eliminar Este Registro? " & Chr(13) & "Tipo : " & oTipoDato.PNNTPODT & Chr(13) & "Cod Detalle : " & oTipoDato.PNNCODRG, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
          Dim iValida As Integer = oTipoDatoNeg.Eliminar_TipoDatoDetalle(oTipoDato)
          If iValida = -1 Then
            HelpUtil.MsgBox("Hubo un Error al Intentar Eliminar el Registro")
          ElseIf iValida = 0 Then
            HelpUtil.MsgBox("No Se Puede Eliminar. El registro esta asociado a un Embarque")
          Else
            '-------------------------------------------------
          End If
          Carga_TipoDatoDetalle(oTipoDato)
        End If
    End Select
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    fInhabilitaGuardar()
    fInhabilitaDescripcion()
    Carga_TipoDato()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    fHabilitaInicializaBotones()
    Carga_TipoDato()
  End Sub

  Private Sub dtgTipoDato_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgTipoDato.CellClick
    If e.RowIndex > -1 Then
      Dim objTipoDato As New SOLMIN_SC.Entidad.beTipoDato
      objTipoDato.PNNTPODT = Me.dtgTipoDato.Rows(e.RowIndex).Cells("NTPODT").Value
      objTipoDato.PSTDSTPD = Me.dtgTipoDato.Rows(e.RowIndex).Cells("TDSTPD").Value
      Carga_TipoDatoDetalle(objTipoDato)
    End If
  End Sub

  Private Sub dtgTipoDato_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgTipoDato.CellEnter

    If e.RowIndex > -1 Then
      Dim objTipoDato As New SOLMIN_SC.Entidad.beTipoDato
      objTipoDato.PNNTPODT = Me.dtgTipoDato.Rows(e.RowIndex).Cells("NTPODT").Value
      objTipoDato.PSTDSTPD = Me.dtgTipoDato.Rows(e.RowIndex).Cells("TDSTPD").Value
      Carga_TipoDatoDetalle(objTipoDato)
    End If
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

    Select Case Me.TabControl1.SelectedIndex
      Case 0
        fHabilitaDescripcion()
        txtDescripcionTipoDato.Text = ""
        txtCodigoTipoDato.Text = ""
        Crud = Tipos.Nuevo
      Case 1
        oTipoDato.PNNTPODT = txtCodigoTipoDato.Text
        oTipoDato.PSTDSTPD = txtDescripcionTipoDato.Text.Trim
        oTipoDato.PNNCODRG = 0
        Dim frmActualiza As New frmMantDetalleTipoDato(oTipoDato)
        frmActualiza.StartPosition = FormStartPosition.CenterScreen
        frmActualiza.ShowInTaskbar = False
        If frmActualiza.ShowDialog() = Windows.Forms.DialogResult.OK Then
          Carga_TipoDatoDetalle(oTipoDato)
        End If
    End Select

  End Sub
End Class

Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmGuiaRemision_Facturacion

#Region "Atributos"
  Private _NGUIRM As New Double
  Private _CTRMNC As New Double
#End Region

#Region "Propiedades"

  Public Property NGUIRM() As Double
    Get
      Return _NGUIRM
    End Get
    Set(ByVal value As Double)
      _NGUIRM = value
    End Set
  End Property

  Public Property CTRMNC() As Double
    Get
      Return _CTRMNC
    End Get
    Set(ByVal value As Double)
      _CTRMNC = value
    End Set
  End Property

#End Region

  Private Sub Salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub Listar_Guia_Remision()
    Dim Objeto_Entidad As New GuiaTransportista
    Dim objanexoGuiaCliente As New GuiaTransportista_BLL
    Dim dwvrow As New DataGridViewRow

    'LIMPIANDO EL dtgGuiasSeleccionadas
    Me.gwdGuiasRemision.Rows.Clear()

    Objeto_Entidad.CTRMNC = CTRMNC
    Objeto_Entidad.NGUIRM = NGUIRM

    'LLENANDO EL dtgGuiasSeleccionadas
    For Each objEntidad As GuiaTransportista In objanexoGuiaCliente.Listar_Guias_Anexas_Cliente(Objeto_Entidad)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.gwdGuiasRemision)
      dwvrow.Cells(1).Value = objEntidad.NGUIRM
      dwvrow.Cells(2).Value = objEntidad.NRGUCL
      dwvrow.Cells(3).Value = objEntidad.TCMPCL
      dwvrow.Cells(4).Value = objEntidad.FCGUCL_S
      dwvrow.Cells(5).Value = objEntidad.CCLNT
      If objEntidad.SESTRG = "S" Then
        dwvrow.Cells(0).Value = True
        dwvrow.Cells(0).ReadOnly = True
        dwvrow.DefaultCellStyle.BackColor = Color.YellowGreen
      End If
      Me.gwdGuiasRemision.Rows.Add(dwvrow)
    Next
  End Sub

  Private Sub frmGuiaRemision_Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Listar_Guia_Remision()
  End Sub

  Private Sub txtCantidadBultos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadBultos.KeyPress
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtPesoBruto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoBruto.KeyPress
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtPesoNeto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoNeto.KeyPress
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub txtVolumen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumen.KeyPress
    If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
  End Sub

  Private Sub gwdGuiasRemision_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdGuiasRemision.CellClick
    If e.RowIndex = -1 Then Exit Sub
    If e.ColumnIndex = 0 Then
      Me.Limpiar_Check()
      Me.gwdGuiasRemision.Item(0, e.RowIndex).Value = True
      If Me.gwdGuiasRemision.Rows(e.RowIndex).DefaultCellStyle.BackColor <> Color.YellowGreen Then
        Me.gwdGuiasRemision.Enabled = False
      End If
    End If

  End Sub

  Private Sub Limpiar_Check()
    Me.gwdGuiasRemision.CommitEdit(DataGridViewDataErrorContexts.Commit)
    For lint_Contador As Integer = 0 To Me.gwdGuiasRemision.RowCount - 1
      If Me.gwdGuiasRemision.Rows(lint_Contador).DefaultCellStyle.BackColor <> Color.YellowGreen Then
        Me.gwdGuiasRemision.Item(0, lint_Contador).Value = False
      End If
    Next
  End Sub

  Private Function Validar_Inputs() As Boolean
    Dim lstr_validacion As String = ""
    Dim lbool_existe_error As Boolean = False

    If Me.txtCantidadBultos.TextLength = 0 Then
      lstr_validacion += "* CANTIDAD BULTOS " & Chr(13)
    End If

    If Me.txtPesoBruto.TextLength = 0 Then
      lstr_validacion += "* PESO BRUTO" & Chr(13)
    End If

    If Me.txtPesoNeto.TextLength = 0 Then
      lstr_validacion += "* PESO NETO " & Chr(13)
    End If

    If Me.txtVolumen.TextLength = 0 Then
      lstr_validacion += "* VOLUMEN " & Chr(13)
    End If

    If lstr_validacion <> "" Then
      HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
      lbool_existe_error = True
    End If
    Return lbool_existe_error
  End Function

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Limpiar_Check()
    Me.gwdGuiasRemision.Enabled = True
  End Sub

  Private Sub btnAgregarGuiaRemision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGuiaRemision.Click
    If Validar_Inputs() Then Exit Sub

  End Sub
End Class

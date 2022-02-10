Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data
'****************************************************************************************************
'** Autor: Juan De Dios
'** Fecha de Creación: 26/08/2009 
'** Descripción: Capa de presentación.
'****************************************************************************************************
Public Class frmBuscarSolicitud

  Private Sub frmBuscarSolicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.gwdDatos.AutoGenerateColumns = False
    Me.Listar_Solicitud()
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        txtCliente.pUsuario = USUARIO
  End Sub

  Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click, btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub Listar_Solicitud()
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Dim objParamList As New List(Of String)
    Dim dwvrow As DataGridViewRow
    Dim lstr_fecha As String = ""
    Dim lstr_estado As String
    If Me.dtpFechaCarga.Enabled = True Then
      lstr_fecha = HelpClass.CtypeDate(Me.dtpFechaCarga.Value)
    End If
    If Me.rbTodos.Checked = True Then
      lstr_estado = ""
    Else
      lstr_estado = "P"
    End If
    objParamList.Add(Me.txtNroSolicitud.Text)
        objParamList.Add(txtCliente.pCodigo)
    objParamList.Add(lstr_fecha)
    objParamList.Add(lstr_estado)
    
    Me.gwdDatos.Rows.Clear()
    For Each obj_Entidad As Solicitud_Transporte In obj_Logica.Listar_Cliente_Solicitud(objParamList)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.gwdDatos)
      dwvrow.Cells(0).Value = obj_Entidad.NCSOTR
      dwvrow.Cells(1).Value = obj_Entidad.CCLNT
      dwvrow.Cells(2).Value = obj_Entidad.TCMPCL
      dwvrow.Cells(3).Value = obj_Entidad.CUNDVH
      dwvrow.Cells(4).Value = obj_Entidad.CTPOSR
      dwvrow.Cells(5).Value = obj_Entidad.QSLCIT
      dwvrow.Cells(6).Value = obj_Entidad.QATNDR
      dwvrow.Cells(7).Value = obj_Entidad.CLCLDS
      dwvrow.Cells(8).Value = obj_Entidad.SESSLC
      If obj_Entidad.QSLCIT = obj_Entidad.QATNDR Then dwvrow.DefaultCellStyle.BackColor = Color.Yellow
      If obj_Entidad.QSLCIT < obj_Entidad.QATNDR Then dwvrow.DefaultCellStyle.BackColor = Color.Red
      Me.gwdDatos.Rows.Add(dwvrow)
    Next
    Me.txtNroSolicitud.Focus()
    If Me.gwdDatos.RowCount > 0 Then Me.gwdDatos.CurrentRow.Selected = False
  End Sub

  Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
    Me.Listar_Solicitud()
  End Sub
  
 

  Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTodos.CheckedChanged
    If Me.rbTodos.Checked = True Then
      Me.rbPendiente.Checked = False
    End If
  End Sub

  Private Sub rbPendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPendiente.CheckedChanged
    If Me.rbPendiente.Checked = True Then
      Me.rbTodos.Checked = False
    End If
  End Sub

  Private Sub rbPendiente_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rbPendiente.KeyUp
    If e.KeyCode = Keys.Enter Then
      Me.rbPendiente.Checked = True
    End If
  End Sub

  Private Sub rbTodos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rbTodos.KeyUp
    If e.KeyCode = Keys.Enter Then
      Me.rbTodos.Checked = True
    End If
  End Sub

  Private Sub checkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFecha.CheckedChanged
    If Me.checkFecha.Checked = True Then
      Me.dtpFechaCarga.Enabled = True
    Else
      Me.dtpFechaCarga.Enabled = False
    End If
  End Sub

  Private Sub checkFecha_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles checkFecha.KeyUp
    If e.KeyCode = Keys.Enter Then
      If Me.checkFecha.Checked = False Then
        Me.checkFecha.Checked = True
      Else
        Me.checkFecha.Checked = False
      End If
    End If
  End Sub

  Private Sub gwdatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    If e.KeyCode = Keys.F2 Then
      Me.Retornar_Datos()
    End If
  End Sub

  Private Sub gwdatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    If Me.gwdDatos.RowCount > 0 Then
      Me.gwdDatos.CurrentRow.Selected = False
    End If
  End Sub

  Private Sub gwdatos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.DoubleClick
    Me.Retornar_Datos()
  End Sub

  Private Sub Retornar_Datos()
    If Me.gwdDatos.CurrentCellAddress.Y = -1 Then
      Exit Sub
    End If
    If Me.gwdDatos.Rows(Me.gwdDatos.CurrentCellAddress.Y).Cells(0).Value Is DBNull.Value Then
      Exit Sub
    End If
    
    Me.TextExtra = Me.gwdDatos.Item(0, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString & " : " & Me.gwdDatos.Item(2, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString & " - " & Me.gwdDatos.Item(1, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
    Me.DialogResult = Windows.Forms.DialogResult.OK

  End Sub

  Private Sub txtNroSolicitud_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroSolicitud.TextChanged
    If Me.txtNroSolicitud.Text.Length > 0 Then
      Me.rbTodos.Checked = True
      Me.rbPendiente.Checked = False
    Else
      Me.rbPendiente.Checked = True
      Me.rbTodos.Checked = False
    End If
  End Sub

  Private Sub txtNroSolicitud_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroSolicitud.KeyPress
    Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
    KeyAscii = CShort(HelpClass.SoloNumeros(KeyAscii))
    If KeyAscii = 0 Then
      e.Handled = True
    End If
  End Sub

End Class

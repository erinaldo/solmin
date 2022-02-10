Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Collections
Imports System.Data

Public Class frmOperacionesAgenciaRansa

  Private Sub Procesar_Busqueda(ByVal sender As Object)

    Dim validacion As String = ""
    Dim objVistaDatos As New Data.DataView
    Dim objTablaDatos As New Data.DataTable
    Dim objLista As New List(Of String)
    Dim objOrdenServicio As New OrdenServicioAgenciaRansa_BLL()

    objLista.Add(Me.txtClienteFiltro.pCodigo)
    objLista.Add(Me.txtOrdenServicio.Text)
    objLista.Add("FZ")
    objLista.Add("A")
    objLista.Add(1)
    objLista.Add(1)

    If TypeOf sender Is ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup Then
      objLista.Add(HelpClass.DateConvert(Me.dtpFechaInicio.Value))
      objLista.Add(HelpClass.DateConvert(Me.dtpFechaFin.Value))
    End If

    objTablaDatos = objOrdenServicio.Listar_Ordenes_Servicio_Agencia_Ransa(objLista)

    If objTablaDatos.Rows.Count <= 0 Then
      Exit Sub
    Else
      Me.dtgDatos.DataSource = objTablaDatos
      Formato_Grilla_Busqueda()
    End If

  End Sub

  Private Sub Formato_Grilla_Busqueda()
    Me.dtgDatos.Columns(0).HeaderText = "Orden Servicio"
    Me.dtgDatos.Columns(1).HeaderText = "Fecha Registro "
    Me.dtgDatos.Columns(2).HeaderText = "Operación"
    Me.dtgDatos.Columns(3).HeaderText = "Cliente"
    Me.dtgDatos.Columns(4).HeaderText = "Referencia"
    Me.dtgDatos.Columns(5).HeaderText = "Producto"
    Me.dtgDatos.Columns(6).HeaderText = "Regimen Aduana"
    Me.dtgDatos.Columns(7).HeaderText = "Tipo Operacion"
    Me.dtgDatos.Columns(8).HeaderText = "Observaciones"
    Me.dtgDatos.Columns(9).HeaderText = "Cod Régimen"
    Me.dtgDatos.Columns(10).HeaderText = "Cod Operación"
    Me.dtgDatos.Columns(11).HeaderText = "Transaccion"
    Me.dtgDatos.Columns(12).HeaderText = "Estado"
  End Sub

  Private Sub txtOrdenServicio_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrdenServicio.KeyUp

    If e.KeyCode = Keys.Enter Then
      Me.Procesar_Busqueda(sender)
    End If

  End Sub

  'Private Sub dtgDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellDoubleClick

  '  If Me.dtgDatos.RowCount <= 0 Then
  '    Exit Sub
  '  End If

  '  If e.RowIndex < 0 Then
  '    Exit Sub
  '  End If

  '  Me.Mostar_Orden_Agencias()

  'End Sub

  Private Sub btnProcesarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarBusqueda.Click
    Procesar_Busqueda(sender)
  End Sub

  'Private Sub btnAsignarOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Me.Mostar_Orden_Agencias()
  'End Sub

  'Private Sub Mostar_Orden_Agencias()

  '  If Me.dtgDatos.CurrentCellAddress.Y < 0 Then
  '    Exit Sub
  '  End If

  '  'obteniendo el indice de la fila seleccionada
  '  Dim indice As Integer = Me.dtgDatos.CurrentCellAddress.Y
  '  Dim lstr_ordenservicio_agencias As String = Me.dtgDatos.Item(0, indice).Value
  '  Dim lstr_operacion_agencias As String = Me.dtgDatos.Item(11, indice).Value

  '  If HelpClass.RspMsgBox("Desea registrar una operación de trasporte con la O/S de Agencias Ransa Nro " + lstr_ordenservicio_agencias) = Windows.Forms.DialogResult.Yes Then

  '    Dim objfrmAsignacionOperacion As New frmAsignacionOperacion
  '    objfrmAsignacionOperacion.ShowForm(lstr_ordenservicio_agencias, lstr_operacion_agencias, Me)

  '  Else
  '    HelpClass.MsgBox("Operación Cancelada")
  '    Exit Sub
  '  End If

  'End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub
End Class

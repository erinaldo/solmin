Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data
'****************************************************************************************************
'** Autor: Juan De Dios
'** Fecha de Creación: 27/08/2009 
'** Descripción: Capa de presentación.
'****************************************************************************************************
Public Class frmBuscarVehiculo

  Private Sub frmBuscarVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.gwdDatos.AutoGenerateColumns = False
    Me.Cargar_Combo()
    Me.ctbTransportista.Codigo = "20100039207"
    For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
      Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    Next
  End Sub

  Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub btnProcesarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarConsulta.Click
    If Me.txtNroPlaca.TextLength > 0 Or Me.ctbTipoCarroceria.Texto.TextLength > 0 Or Me.ctbTransportista.Texto.TextLength > 0 Then
      Me.Listar()
      Me.gwdDatos.Focus()
    End If
  End Sub

  Private Sub Cargar_Combo()
    Dim obj_Logica_Carroceria As New TipoCarroceria_BLL
    Dim obj_Logica_Transporte As New Transportista_BLL
    Try
      With ctbTipoCarroceria
                .DataSource = HelpClass.GetDataSetNative(obj_Logica_Carroceria.Listar_TipoCarroceria("EZ"))
        .KeyField = "CTPCRA"
        .ValueField = "TCMCRA"
        .DataBind()
      End With
      With ctbTransportista
        .DataSource = HelpClass.GetDataSetNative(obj_Logica_Transporte.Listar_TransportistaCbo())
        .KeyField = "NRUCTR"
        .ValueField = "TCMTRT"
        .DataBind()
      End With
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Listar()
    Dim obj_Logica As New Detalle_Solicitud_Transporte_BLL
    Dim objEntidad As New Detalle_Solicitud_Transporte
    Dim dwvrow As DataGridViewRow
    objEntidad.NPLNJT = Me.Tag.ToString
    objEntidad.NPLCUN = Me.txtNroPlaca.Text.Trim
    objEntidad.CTITRA = Me.ctbTipoCarroceria.Codigo.Trim
    objEntidad.NRUCTR = Me.ctbTransportista.Codigo.Trim
    Me.gwdDatos.Rows.Clear()
    For Each obj_Entidad As Detalle_Solicitud_Transporte In obj_Logica.Listar_Vehiculo_Solicitud(objEntidad)
      dwvrow = New DataGridViewRow
      dwvrow.CreateCells(Me.gwdDatos)
      dwvrow.Cells(0).Value = obj_Entidad.NPLCUN
      dwvrow.Cells(1).Value = obj_Entidad.CTPCRA
      dwvrow.Cells(2).Value = obj_Entidad.TCMCRA
      dwvrow.Cells(3).Value = obj_Entidad.NRUCTR
      dwvrow.Cells(4).Value = obj_Entidad.TCMTRT
      dwvrow.Cells(8).Value = obj_Entidad.CTRSPT
      dwvrow.Cells(6).Value = obj_Entidad.SESTCM
      dwvrow.Cells(7).Value = obj_Entidad.SEGUIMIENTO
      dwvrow.Cells(8).Value = obj_Entidad.GPSLAT
      dwvrow.Cells(9).Value = obj_Entidad.GPSLON
      dwvrow.Cells(10).Value = obj_Entidad.FECGPS
      dwvrow.Cells(11).Value = obj_Entidad.HORGPS
      If obj_Entidad.SESTRG > 0 Then
        dwvrow.DefaultCellStyle.BackColor = Color.YellowGreen
      End If
      If obj_Entidad.SEGUIMIENTO <> "" Then
        dwvrow.Cells(12).Value = My.Resources.button_ok1
      Else
        dwvrow.Cells(12).Value = My.Resources.Nada_1
      End If
      dwvrow.Cells(13).Value = obj_Entidad.CTITRA
      Me.gwdDatos.Rows.Add(dwvrow)
    Next
  End Sub

  Private Sub gwdDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
    If e.RowIndex < 0 Then
      Exit Sub
    End If
    Try
      If e.ColumnIndex = 12 Then
        If Me.gwdDatos.Item(7, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString <> "" Then
          Dim objGpsBrowser As New frmMapa
          With objGpsBrowser
            .Latitud = Me.gwdDatos.Item(8, e.RowIndex).Value
            .Longitud = Me.gwdDatos.Item(9, e.RowIndex).Value
            .Fecha = Me.gwdDatos.Item(10, e.RowIndex).Value
                        .Hora = gwdDatos.Item(11, e.RowIndex).Value
            .WindowState = FormWindowState.Maximized
            .ShowForm(.Latitud, .Longitud, Me)
          End With
        End If
      Else
        Me.Retorno_Datos()
      End If
    Catch : End Try
  End Sub

  Private Sub gwdatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatos.KeyUp
    If e.KeyCode = Keys.F2 Then
      Me.Retorno_Datos()
    End If
  End Sub

  Private Sub gwdatos_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gwdDatos.DataBindingComplete
    If Me.gwdDatos.RowCount > 0 Then
      Me.gwdDatos.CurrentRow.Selected = False
    End If
  End Sub

  Private Sub Retorno_Datos()
    Try
      If Me.gwdDatos.CurrentCellAddress.Y = -1 Then
        Exit Sub
      End If
      If Me.gwdDatos.Rows(Me.gwdDatos.CurrentCellAddress.Y).Cells(0).Value Is DBNull.Value Then
        Exit Sub
      End If
      If Me.gwdDatos.CurrentRow.DefaultCellStyle.BackColor <> Color.YellowGreen Then
        Me.TextExtra = Me.gwdDatos.Item(0, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString & " : " & Me.gwdDatos.Item(13, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString & "-" & Me.gwdDatos.Item(3, Me.gwdDatos.CurrentCellAddress.Y).Value.ToString
        Me.DialogResult = Windows.Forms.DialogResult.OK
      End If
    Catch : End Try
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.btn_cerrar_Click(Nothing, Nothing)
  End Sub
 
End Class

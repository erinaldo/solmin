Imports System.Data
Imports System.Collections.Generic
Public Class FrmAplicacion
    Private AplicacionBL As New Aplicacion_BL
    Private LAplica As New List(Of AplicacionBE)
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private Sub FrmAplicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdAplicacion_Datos.AutoGenerateColumns = False
        Listar()
        Limpiar_Controles()
        Estado_Controles(False)
    End Sub
    Private Sub Listar()
        LAplica = AplicacionBL.Lista_Aplicacion()
    End Sub
    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtAplicacion_Codigo.Enabled = lbool_Estado
        Me.txtAplicacion_Nombre.Enabled = lbool_Estado
    End Sub
    Private Sub Limpiar_Controles()
        Me.txtAplicacion_Codigo.Text = ""
        Me.txtAplicacion_Nombre.Text = ""
    End Sub
    Private Sub Buscar(ByVal MatchBusca As Predicate(Of AplicacionBE))
        Me.gwdAplicacion_Datos.DataSource = LAplica.FindAll(MatchBusca)
    End Sub
    Private match As New Predicate(Of AplicacionBE)(AddressOf Busca)
    Private Function Busca(ByVal Aplicacion_BE As AplicacionBE) As Boolean
        If Aplicacion_BE.MMDAPL.Trim.ToUpper.IndexOf(Me.txtAplicacion_Buscar.Text.Trim.ToUpper) <> -1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicacion_Buscar.Click
        Buscar(match)
    End Sub
  Private Function Asignar_Valor() As AplicacionBE
    Dim obj_Entidad As New AplicacionBE
    obj_Entidad.MMCAPL = Me.txtAplicacion_Codigo.Text.Trim
    obj_Entidad.MMDAPL = Me.txtAplicacion_Nombre.Text.Trim
    If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
      obj_Entidad.CUSCRT = MainModule.USUARIO
      obj_Entidad.FCHCRT = HelpClass.TodayNumeric
      obj_Entidad.HRACRT = HelpClass.NowNumeric
            obj_Entidad.NTRMCR = ""
    Else
      obj_Entidad.CULUSA = MainModule.USUARIO
      obj_Entidad.FULTAC = HelpClass.TodayNumeric
      obj_Entidad.HULTAC = HelpClass.NowNumeric
            obj_Entidad.NTRMNL = ""
    End If
    Return obj_Entidad
  End Function
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicacion_Nuevo.Click
        Limpiar_Controles()
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        Me.txtAplicacion_Codigo.ReadOnly = False
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicacion_Cancelar.Click
        If Me.txtAplicacion_Codigo.Enabled <> False Then
            Limpiar_Controles()
            Estado_Controles(False)
        End If
    End Sub
    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicacion_Eliminar.Click
        If Me.txtAplicacion_Codigo.Enabled = True Then
            If ValidarContenido() > 0 Then
                If MsgBox("Desea Eliminar este Registro", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                    If AplicacionBL.Elimina_Aplicacion(Asignar_Valor) = 1 Then
                        MsgBox("El Registro se Elimino Satisfactoriamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                    End If
                    Limpiar_Controles()
                    Estado_Controles(False)
                End If
            Else
                MsgBox("Falta Seleccionar Registro")
            End If
        End If
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicacion_Guardar.Click
        If Me.txtAplicacion_Codigo.Enabled = True Then
            If ValidarContenido() > 0 Then
                If gEnum_Mantenimiento > 0 Then
                    If MsgBox("Desea Agregar este Nuevo Registro", MsgBoxStyle.OkCancel, "Nuevo") = MsgBoxResult.Ok Then
                        If AplicacionBL.Registra_Aplicacion(Asignar_Valor) = 1 Then
                            MsgBox("El Registro se Guardo Satisfactoriamente")
                            Listar()
                        Else
                            MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                        End If
                        Limpiar_Controles()
                        Estado_Controles(False)
                    End If
                Else
                    If MsgBox("Desea Modificar este Registro", MsgBoxStyle.OkCancel, "Modificar") = MsgBoxResult.Ok Then
                        If AplicacionBL.Modifica_Aplicacion(Asignar_Valor) = 1 Then
                            MsgBox("El Registro se Guardo Satisfactoriamente")
                            Listar()
                        Else
                            MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                        End If
                        Limpiar_Controles()
                        Estado_Controles(False)
                    End If
                End If
            Else
                MsgBox("Falta Ingresar Datos")
            End If
        End If
    End Sub
    Private Sub gwdAplicacion_Datos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdAplicacion_Datos.CellClick
        If e.RowIndex < 0 Or Me.gwdAplicacion_Datos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Dim lint_indice As Integer = Me.gwdAplicacion_Datos.CurrentCellAddress.Y
        Me.txtAplicacion_Codigo.Text = Me.gwdAplicacion_Datos.Item(0, lint_indice).Value.ToString.Trim
        Me.txtAplicacion_Nombre.Text = Me.gwdAplicacion_Datos.Item(1, lint_indice).Value.ToString.Trim
        Me.txtAplicacion_Codigo.ReadOnly = True
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    End Sub
    Private Function ValidarContenido() As Integer
        If Me.txtAplicacion_Codigo.Text.Trim.Length > 0 Then
            If Me.txtAplicacion_Nombre.Text.Trim.Length > 0 Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function
 
End Class

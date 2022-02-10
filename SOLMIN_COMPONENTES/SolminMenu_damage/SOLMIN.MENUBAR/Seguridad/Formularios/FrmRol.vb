Imports System.Data
Imports System.Collections.Generic
Public Class FrmRol
    Private RolBL As New Rol_BL
    Private LRol As New List(Of RolBE)
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private Sub FrmRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        Listar()
        Estado_Controles(False)
    End Sub
    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.txtRol_Codigo.Enabled = lbool_Estado
        Me.txtRol_Nombre.Enabled = lbool_Estado
    End Sub
    Private Sub Limpiar_Controles()
        Me.txtRol_Codigo.Text = ""
        Me.txtRol_Nombre.Text = ""
    End Sub
    Private Sub Listar()
        LRol = RolBL.Lista_Rol()
    End Sub
    Private Sub Buscar()
        Me.gwdDatos.DataSource = LRol.FindAll(match)
    End Sub
    Private Function BuscarRol(ByVal Rol_BE As RolBE) As Boolean
        If Rol_BE.TOBS.ToUpper.IndexOf(Me.txtRol_Buscar.Text.ToUpper) <> -1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private match As New Predicate(Of RolBE)(AddressOf BuscarRol)
    Private Function Asignar_Valor() As RolBE
        Dim objEntidad As New RolBE
        objEntidad.NCOROL = Me.txtRol_Codigo.Text.Trim
        objEntidad.TOBS = Me.txtRol_Nombre.Text.Trim
        If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            objEntidad.CUSCRT = MainModule.USUARIO
            objEntidad.FCHCRT = HelpClass.TodayNumeric
            objEntidad.HRACRT = HelpClass.NowNumeric
            objEntidad.NTRMCR = HelpClass.NombreMaquina
        Else
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = HelpClass.NombreMaquina
        End If
        Return objEntidad
    End Function
    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.txtRol_Codigo.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtRol_Nombre.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    End Sub
    Private Sub btnRol_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRol_Nuevo.Click
        Limpiar_Controles()
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    End Sub
    Private Sub btnRol_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRol_Eliminar.Click
        If Me.txtRol_Codigo.Enabled = True Then
            If ValidarContenido() > 0 Then
                If MsgBox("Desea Eliminar este Registro", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                    If RolBL.Elimina_Rol(Asignar_Valor) = 1 Then
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
    Private Sub btnRol_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRol_Guardar.Click
        If Me.txtRol_Codigo.Enabled = True Then
            If ValidarContenido() > 0 Then
                If gEnum_Mantenimiento > 0 Then
                    If MsgBox("Desea Agregar este Nuevo Registro", MsgBoxStyle.OkCancel, "Nuevo") = MsgBoxResult.Ok Then
                        If RolBL.Registra_Rol(Asignar_Valor) = 1 Then
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
                        If RolBL.Modifica_Rol(Asignar_Valor) = 1 Then
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
    Private Sub btnRol_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRol_Cancelar.Click
        Limpiar_Controles()
        Estado_Controles(False)
    End Sub
    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRol_Buscar.Click
        Buscar()
    End Sub
    Private Function ValidarContenido()
        If Me.txtRol_Nombre.Text.Length > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class

Imports System.Data
Imports System.Collections.Generic
Public Class FrmMenu
    Private MenuBL As New Menu_BL
    Private LMenu As New List(Of MenuBE)
    Private LAplica As New List(Of AplicacionBE)
    Private Scadena As String
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        CargarCboAplica()
        Listar()
        Limpiar_Controles()
        Estado_Controles(False)
    End Sub
    Private Sub Listar()
        LMenu = MenuBL.Lista_Menu()
        Me.gwdDatos.DataSource = LMenu
    End Sub
    Private Sub CargarCboAplica()
        Dim ApliBL As New Aplicacion_BL
        LAplica = ApliBL.Lista_Aplicacion()
        Me.CboAplica.DataSource = LAplica
        Me.CboAplica.DisplayMember = "MMDAPL"
        Me.CboAplica.ValueMember = "MMCAPL"
    End Sub
    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.CboAplica.Enabled = lbool_Estado
        Me.txtDescripOpcion.Enabled = lbool_Estado
    End Sub
    Private Sub Limpiar_Controles()
        Me.CboAplica.SelectedItem = 0
        Me.txtDescripOpcion.Text = ""
    End Sub
    Private Sub Buscar(ByVal MatchBusca As Predicate(Of MenuBE))
        Dim Lista As List(Of MenuBE) = LMenu.FindAll(MatchBusca)
        Me.gwdDatos.DataSource = Lista
    End Sub
    Private match As New Predicate(Of MenuBE)(AddressOf Busca)
    Private Function Busca(ByVal Menu_BE As MenuBE) As Boolean
        If Menu_BE.MMCAPL.Trim.ToUpper.IndexOf(Me.txtBuscar.Text.Trim.ToUpper) <> -1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        If Me.txtBuscar.Text.Length < 1 Then
            Me.gwdDatos.DataSource = LMenu
        Else
            Buscar(match)
        End If
    End Sub
    Private Function Asignar_Valor() As MenuBE
        Dim Menu_BE As New MenuBE
        Menu_BE.MMCAPL = Me.CboAplica.SelectedValue.ToString.Trim
        Menu_BE.MMTMNU = Me.txtDescripOpcion.Text.Trim
        If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            Menu_BE.MMCMNU = Me.Scadena.Trim
        End If
        Return Menu_BE
    End Function
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar_Controles()
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Limpiar_Controles()
        Estado_Controles(False)
    End Sub
    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.CboAplica.Enabled = True Then
            If ValidarContenido() > 0 Then
                If MsgBox("Desea Eliminar este Registro", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                    If MenuBL.Elimina_Menu(Asignar_Valor) = 1 Then
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
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.CboAplica.Enabled = True Then
            If ValidarContenido() > 0 Then
                If gEnum_Mantenimiento > 0 Then
                    If MsgBox("Desea Agregar este Nuevo Registro", MsgBoxStyle.OkCancel, "Nuevo") = MsgBoxResult.Ok Then
                        If MenuBL.Registra_Menu(Asignar_Valor) = 1 Then
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
                        If MenuBL.Modifica_Menu(Asignar_Valor) = 1 Then
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
    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.CboAplica.SelectedValue = Me.gwdDatos.Item(0, lint_indice).Value.ToString.Trim
        Me.Scadena = Me.gwdDatos.Item(2, lint_indice).Value.ToString.Trim
        Me.txtDescripOpcion.Text = Me.gwdDatos.Item(3, lint_indice).Value.ToString.Trim
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    End Sub
    Private Function ValidarContenido() As Integer
       If Me.txtDescripOpcion.Text.Trim.Length > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function

  Private Sub PanelFiltros_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelFiltros.Paint

  End Sub
End Class

Imports System.Data
Imports System.Collections.Generic
Public Class FrmOpcion
    Private OpcionBL As New Opcion_BL
    Private LOpcion As New List(Of OpcionBE)
    Private LAplica As New List(Of AplicacionBE)
    Private LMenu As New List(Of MenuBE)
    Private Scadena As String
    Private Contador As Integer
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private Sub FrmOpcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        CargarCboAplica()
        CargarCboMenu()
        Listar()
        Limpiar_Controles()
        Estado_Controles(False)
    End Sub
    Private Sub CargarCboAplica()
        Dim ApliBL As New Aplicacion_BL
        LAplica = ApliBL.Lista_Aplicacion()
        Me.CboAplica.DataSource = LAplica
        Me.CboAplica.DisplayMember = "MMDAPL"
        Me.CboAplica.ValueMember = "MMCAPL"
    End Sub
    Private Sub CargarCboMenu()
        Dim MeBL As New Menu_BL
        LMenu = MeBL.Lista_Menu()

        Me.CboMenu.DataSource = LMenu
        Me.CboMenu.DisplayMember = "MMTMNU"
        Me.CboMenu.ValueMember = "MMCMNU"

        Me.CboMenuOpcion.DataSource = LMenu
        Me.CboMenuOpcion.DisplayMember = "MMTMNU"
        Me.CboMenuOpcion.ValueMember = "MMCMNU"
    End Sub
    Private Sub Listar()
        LOpcion = OpcionBL.Lista_Opcion()
        Me.gwdDatos.DataSource = LOpcion
    End Sub
    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)
        Me.CboAplica.Enabled = lbool_Estado
        Me.CboMenuOpcion.Enabled = lbool_Estado
        Me.TxtFormulario.Enabled = lbool_Estado
        Me.TxtClase.Enabled = lbool_Estado
    End Sub
    Private Sub Limpiar_Controles()
        Me.CboAplica.SelectedItem = 0
        Me.TxtFormulario.Text = ""
        Me.TxtClase.Text = ""
    End Sub
    Private Sub Buscar(ByVal MatchBusca As Predicate(Of OpcionBE))
        Dim Lista As List(Of OpcionBE) = LOpcion.FindAll(MatchBusca)
        Me.gwdDatos.DataSource = Lista
    End Sub
    Private match As New Predicate(Of OpcionBE)(AddressOf Busca)
    Private Function Busca(ByVal Opcion_BE As OpcionBE) As Boolean
        If (Opcion_BE.MMCMNU.Trim.ToUpper = Me.CboMenu.SelectedValue.ToString.Trim) And (Opcion_BE.MMDOPC.Trim.ToUpper.IndexOf(Me.txtBuscar.Text.Trim.ToUpper) <> -1) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function Asignar_Valor() As OpcionBE
        Dim Opcion_BE As New OpcionBE
        Opcion_BE.MMCAPL = Me.CboAplica.SelectedValue.ToString.Trim
        Opcion_BE.MMCMNU = Me.CboMenu.SelectedValue.ToString.Trim
        If gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            Opcion_BE.MMCOPC = Me.Scadena.Trim
        End If
        Opcion_BE.MMDOPC = Me.TxtFormulario.Text.Trim
        Opcion_BE.MMNPVB = Me.TxtClase.Text.Trim
        Return Opcion_BE
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
                    If OpcionBL.Elimina_Opcion(Asignar_Valor) = 1 Then
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
                        If OpcionBL.Registra_Opcion(Asignar_Valor) = 1 Then
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
                        If OpcionBL.Modifica_Opcion(Asignar_Valor) = 1 Then
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
    Private Function ValidarContenido() As Integer
        If Me.TxtFormulario.Text <> String.Empty Or Me.TxtClase.Text <> String.Empty Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        If Me.txtBuscar.Text.Length < 1 Then
            Me.gwdDatos.DataSource = LOpcion
        Else
            Buscar(match)
        End If
    End Sub
    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If Contador > 0 Then
            Me.CboAplica.DataSource = LAplica
            Me.CboMenuOpcion.DataSource = LMenu
        End If
        If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.CboAplica.SelectedValue = Me.gwdDatos.Item(0, lint_indice).Value.ToString.Trim
        Me.CboMenuOpcion.SelectedValue = Me.gwdDatos.Item(2, lint_indice).Value.ToString.Trim
        Me.Scadena = Me.gwdDatos.Item(4, lint_indice).Value.ToString.Trim
        Me.TxtFormulario.Text = Me.gwdDatos.Item(5, lint_indice).Value.ToString.Trim
        Me.TxtClase.Text = Me.gwdDatos.Item(6, lint_indice).Value.ToString.Trim
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    End Sub
    Private Sub CboAplica_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboAplica.SelectedValueChanged
        If Me.CboAplica.Enabled = True Then
            Me.CboMenuOpcion.DataSource = LMenu.FindAll(match1)
            Contador = 1
        End If
    End Sub
    Private match1 As New Predicate(Of MenuBE)(AddressOf Busca1)
    Private Function Busca1(ByVal Menu_BE As MenuBE) As Boolean
        If (Menu_BE.MMCAPL.Trim.ToUpper = Me.CboAplica.SelectedValue.ToString.Trim) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class

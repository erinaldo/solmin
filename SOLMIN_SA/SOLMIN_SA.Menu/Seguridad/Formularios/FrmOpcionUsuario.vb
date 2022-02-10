Imports System.Data
Imports System.Collections.Generic
Public Class FrmOpcionUsuario

    Private oObjeto As New TreeViewNodosBE
    Private match As New Predicate(Of TreeViewNodosBE)(AddressOf Busca)

    Private ListUsuario As New List(Of UsuarioBE)
    Private ListOpcionUsuario As New List(Of Usuario_OpcionBE)
    Private ListEliminar As New List(Of Usuario_OpcionBE)

    Private UsuarioBL As New Usuario_BL
    Private UsuarioOpcionBL As New Usuario_Opcion_BL

    Private TreeviewsNodosBL As New TreeViewNodos_BL
    Private lOpcion As New List(Of TreeViewNodosBE)
    Private gEnum_Mantenimiento As New MANTENIMIENTO

    Private Sub FrmOpcionUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        LlenarTreeView(USUARIO)
        CargarListas()
        LlenarCombo()
    End Sub
    Private Sub CargarListas()
        ListUsuario = UsuarioBL.Lista_Usuario()
        ListOpcionUsuario = UsuarioOpcionBL.Lista_Usuario_Opcion()
    End Sub
    Private Sub Limpiar()
        Me.treeViewSesion.Nodes.Clear()
    End Sub
    Private Sub LlenarCombo()
        Me.CboUsuario.DataSource = UsuarioBL.Lista_Usuario()
        Me.CboUsuario.DisplayMember = "MMNUSR"
        Me.CboUsuario.ValueMember = "MMCUSR"
    End Sub
    Private Sub LlenarTreeView(ByVal Usuario As String)
        lOpcion = TreeviewsNodosBL.Lista_Opcion(Usuario)
        ConstruirArbol(ImageFormularios, treeViewSesion, TreeviewsNodosBL.Lista_Aplicacion(Usuario), TreeviewsNodosBL.Lista_Menu(Usuario), lOpcion)
    End Sub
    Private match2 As New Predicate(Of Usuario_OpcionBE)(AddressOf Busca2)
    Public Function Busca2(ByVal UsuarioOpcionBE As Usuario_OpcionBE) As Boolean
        If (UsuarioOpcionBE.MMCOPC.Trim.ToUpper = oObjeto.IdPrincipal.ToString.Trim) And (UsuarioOpcionBE.MMCMNU.Trim.ToUpper = oObjeto.IdSecundario.ToString.Trim) And (UsuarioOpcionBE.MMCAPL.Trim.ToUpper = oObjeto.IdTerciario.ToString.Trim) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private match1 As New Predicate(Of TreeViewNodosBE)(AddressOf Busca1)
    Public Function Busca1(ByVal TreeViewNodos_BE As TreeViewNodosBE) As Boolean
        If (TreeViewNodos_BE.IdSecundario.Trim.ToUpper = oObjeto.IdPrincipal.ToString.Trim) And (TreeViewNodos_BE.IdTerciario.Trim.ToUpper = oObjeto.IdSecundario.ToString.Trim) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub ConstruirArbol(ByVal oImageList As ImageList, ByVal oTreeView As Windows.Forms.TreeView, ByVal lAplica As List(Of TreeViewNodosBE), ByVal lMenu As List(Of TreeViewNodosBE), ByVal lOpcion As List(Of TreeViewNodosBE))
        oTreeView.ImageList = oImageList
        If lAplica IsNot Nothing Then
            For Each oAplica As TreeViewNodosBE In lAplica
                oObjeto = oAplica
                Dim oTreeNoAplica As TreeNode = ConstruirTreeNode(oTreeView, oAplica.Nombre, Nothing)
                oTreeNoAplica.SelectedImageIndex = 0
                oTreeNoAplica.ImageIndex = 0
                Dim tMenu As List(Of TreeViewNodosBE) = lMenu.FindAll(match)

                For Each oMenu As TreeViewNodosBE In tMenu
                    oObjeto = oMenu
                    Dim oTreeNodeMenu As TreeNode = ConstruirTreeNode(oTreeView, oMenu.Nombre, oTreeNoAplica)
                    oTreeNodeMenu.SelectedImageIndex = 1
                    oTreeNodeMenu.ImageIndex = 1
                    Dim tOpcion As List(Of TreeViewNodosBE) = lOpcion.FindAll(match1)

                    For Each oOpcion As TreeViewNodosBE In tOpcion
                        oObjeto = oOpcion
                        Dim oTreeNodeOpcion As TreeNode = ConstruirTreeNode(oTreeView, oOpcion.Nombre, oTreeNodeMenu)
                        oTreeNodeOpcion.SelectedImageIndex = 2
                        oTreeNodeOpcion.ImageIndex = 2
                        If oOpcion.Cheked Then
                            oTreeNodeOpcion.Checked = True
                        Else
                            oTreeNodeOpcion.Checked = False
                        End If
                    Next
                Next
            Next
        End If
    End Sub
    Public Function Busca(ByVal TreeViewNodos_BE As TreeViewNodosBE) As Boolean
        If (TreeViewNodos_BE.IdSecundario.Trim.ToUpper = oObjeto.IdPrincipal.ToString.Trim) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Shared Function ConstruirTreeNode(ByVal oTreeView As Windows.Forms.TreeView, ByVal Nombre As String, ByVal oTreeNode As TreeNode) As TreeNode
        If oTreeNode Is Nothing Then
            Dim NuevoNodo As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(Nombre)
            oTreeView.Nodes.Add(NuevoNodo)
            Return NuevoNodo
        Else
            Dim NodoHijo As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(Nombre)
            oTreeNode.Nodes.Add(NodoHijo)
            Return NodoHijo
        End If
    End Function
    Private Function LlenarAcceso(ByVal Usuario As String) As List(Of Usuario_OpcionBE)
        Dim lAccesoBE As New List(Of Usuario_OpcionBE)
        Dim lTreeViewMetodos As List(Of TreeViewNodosBE) = TreeViewMetodos.ConseguirTablaChekeados(treeViewSesion, lOpcion)
        For Each oTreeViewMetodos As TreeViewNodosBE In lTreeViewMetodos
            If oTreeViewMetodos.Cheked Then
                Dim oAccesoBE As New Usuario_OpcionBE
                oAccesoBE.MMCUSR = Usuario
                oAccesoBE.MMCOPC = oTreeViewMetodos.IdPrincipal.ToString.Trim
                oAccesoBE.MMCMNU = oTreeViewMetodos.IdSecundario.ToString.Trim
                oAccesoBE.MMCAPL = oTreeViewMetodos.IdTerciario.ToString.Trim
                lAccesoBE.Add(oAccesoBE)
            End If
        Next
        Return lAccesoBE
    End Function
    Private Sub CboUsuario_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUsuario.SelectedValueChanged
        If Me.CboUsuario.Enabled = True Then
            ListEliminar.Clear()
            Dim oList As List(Of Usuario_OpcionBE) = ListOpcionUsuario.FindAll(match4)
            For Each oTreeViewNodosBE As TreeViewNodosBE In lOpcion
                oObjeto = oTreeViewNodosBE
                Dim UsuarioOpcionBE As Usuario_OpcionBE = oList.Find(match2)
                If UsuarioOpcionBE IsNot Nothing Then
                    oTreeViewNodosBE.Cheked = True
                    ListEliminar.Add(UsuarioOpcionBE)
                Else
                    oTreeViewNodosBE.Cheked = False
                End If
            Next
            Limpiar()
            ConstruirArbol(ImageFormularios, treeViewSesion, TreeviewsNodosBL.Lista_Aplicacion(MainModule.USUARIO), TreeviewsNodosBL.Lista_Menu(MainModule.USUARIO), lOpcion)
            treeViewSesion.ExpandAll()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.CboUsuario.Enabled = True
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    End Sub

    Private Sub treeViewSesion_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeViewSesion.AfterCheck
        TreeViewMetodos.HabilitarCheked(e.Node.Nodes, e.Node.Checked)
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Me.gwdDatos.DataSource = ListUsuario.FindAll(match3)
    End Sub
    Private match3 As New Predicate(Of UsuarioBE)(AddressOf Busca3)
    Public Function Busca3(ByVal oUsuario_BE As UsuarioBE) As Boolean
        If oUsuario_BE.MMNUSR.ToUpper.Trim.IndexOf(Me.txtBuscar.Text.ToUpper.Trim) <> -1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private match4 As New Predicate(Of Usuario_OpcionBE)(AddressOf Busca4)
    Public Function Busca4(ByVal oUsuarioOpcion_BE As Usuario_OpcionBE) As Boolean
        If oUsuarioOpcion_BE.MMCUSR.ToUpper.Trim = Me.CboUsuario.SelectedValue.ToString.ToUpper.Trim Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick
        If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.CboUsuario.Enabled = True
        Me.CboUsuario.SelectedValue = Me.gwdDatos.Item(7, lint_indice).Value.ToString.Trim

    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.CboUsuario.Enabled = True Then
            If gEnum_Mantenimiento > 0 Then
                If MsgBox("Desea Agregar este Nuevo Permiso", MsgBoxStyle.OkCancel, "Nuevo") = MsgBoxResult.Ok Then
                    UsuarioOpcionBL.Eliminar_Usuario_Opcion(ListEliminar)
                    If UsuarioOpcionBL.Registra_Usuario_Opcion(LlenarAcceso(Me.CboUsuario.SelectedValue.ToString)) = 1 Then
                        MsgBox("El Permiso se Guardo Satisfactoriamente")
                        CargarListas()
                        Limpiar()
                        ConstruirArbol(ImageFormularios, treeViewSesion, TreeviewsNodosBL.Lista_Aplicacion(MainModule.USUARIO), TreeviewsNodosBL.Lista_Menu(MainModule.USUARIO), lOpcion)
                    Else
                        MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                        Limpiar()
                        LlenarTreeView(MainModule.USUARIO)
                        Me.CboUsuario.Enabled = False
                    End If
                End If
            Else
                If MsgBox("Desea Modificar este Usuario", MsgBoxStyle.OkCancel, "Modificar") = MsgBoxResult.Ok Then
                    UsuarioOpcionBL.Eliminar_Usuario_Opcion(ListEliminar)
                    If UsuarioOpcionBL.Registra_Usuario_Opcion(LlenarAcceso(Me.CboUsuario.SelectedValue.ToString)) = 1 Then
                        MsgBox("El Permiso se Guardo Satisfactoriamente")
                        CargarListas()
                        Limpiar()
                        ConstruirArbol(ImageFormularios, treeViewSesion, TreeviewsNodosBL.Lista_Aplicacion(MainModule.USUARIO), TreeviewsNodosBL.Lista_Menu(MainModule.USUARIO), lOpcion)
                    Else
                        MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                        Limpiar()
                        LlenarTreeView(MainModule.USUARIO)
                        Me.CboUsuario.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.CboUsuario.Enabled = True Then
            If MsgBox("Desea Eliminar este Permiso", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                If UsuarioOpcionBL.Eliminar_Usuario_Opcion(ListEliminar) = 1 Then
                    MsgBox("El Registro se Elimino Satisfactoriamente")
                    CargarListas()
                    Limpiar()
                    LlenarTreeView(MainModule.USUARIO)
                    Me.CboUsuario.Enabled = False
                Else
                    MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                    Limpiar()
                    LlenarTreeView(MainModule.USUARIO)
                    Me.CboUsuario.Enabled = False
                End If
            End If
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If Me.CboUsuario.Enabled = True Then
            Me.CboUsuario.Enabled = False
            Limpiar()
            LlenarTreeView(USUARIO)
        End If
    End Sub

    Private Sub gwdDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellContentClick

    End Sub

    Private Sub HeaderDatos_Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles HeaderDatos.Panel.Paint

    End Sub
End Class

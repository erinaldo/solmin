 
Imports System.Data
Imports System.Collections.Generic
Public Class FrmOpcionRol

    Private oObjeto As New TreeViewNodosBE
    Private match As New Predicate(Of TreeViewNodosBE)(AddressOf Busca)

    Private ListRol As New List(Of RolBE)
    Private ListOpcionRol As New List(Of Rol_OpcionBE)
    Private ListEliminar As New List(Of Rol_OpcionBE)

    Private RolBL As New Rol_BL
    Private RolOpcionBL As New Rol_Opcion_BL

    Private listOpcion As New List(Of OpcionBE)
    Private listMenu As New List(Of MenuBE)
    Private listAplica As New List(Of AplicacionBE)

    Private TreeviewsNodosBL As New TreeViewNodos_BL
    Private lOpcion As New List(Of TreeViewNodosBE)
    Private gEnum_Mantenimiento As New MANTENIMIENTO

    Private Sub FrmOpcionRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdOpcionRol_Datos.AutoGenerateColumns = False
        CargarListas()
        LlenarTreeView()
        LlenarCombo()
    End Sub
    Private Sub CargarListas()
        ListRol = RolBL.Lista_Rol()
        ListOpcionRol = RolOpcionBL.Lista_Rol_Opcion()

        Dim objAplica As New Aplicacion_BL
        Dim objMenu As New Menu_BL
        Dim objOpcion As New Opcion_BL

        listOpcion = objOpcion.Lista_Opcion
        listAplica = objAplica.Lista_Aplicacion
        listMenu = objMenu.Lista_Menu
    End Sub
    Private Sub LimpiarTreeView()
        Me.tvwOpcionRol_Acceso.Nodes.Clear()
    End Sub
    Private Sub LlenarCombo()
        Me.CboOpcionRol_Usuario.DataSource = ListRol
        Me.CboOpcionRol_Usuario.DisplayMember = "TOBS"
        Me.CboOpcionRol_Usuario.ValueMember = "NCOROL"
    End Sub
    Private Sub LlenarTreeView()
        lOpcion = TreeviewsNodosBL.Lista_Opcion()
        ConstruirArbol(ImageFormularios, tvwOpcionRol_Acceso, TreeviewsNodosBL.Lista_Aplicacion, TreeviewsNodosBL.Lista_Menu, lOpcion)
    End Sub
    Private match2 As New Predicate(Of Rol_OpcionBE)(AddressOf Busca2)
    Public Function Busca2(ByVal RolOpcionBE As Rol_OpcionBE) As Boolean
        If (RolOpcionBE.MMCOPC.Trim.ToUpper = oObjeto.IdPrincipal.ToString.Trim) And (RolOpcionBE.MMCMNU.Trim.ToUpper = oObjeto.IdSecundario.ToString.Trim) And (RolOpcionBE.MMCAPL.Trim.ToUpper = oObjeto.IdTerciario.ToString.Trim) Then
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
        oTreeView.Sort()
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
    Private Objeto(2) As Object
    Public Sub ConseguirListaCheck(ByVal oTreeView As Windows.Forms.TreeView, ByVal Usuario As String)
        Dim ListRolOpBE As New List(Of Rol_OpcionBE)
        Dim i As Integer = 0
        For Each oTreeNode As TreeNode In oTreeView.Nodes
            If oTreeNode.Nodes IsNot Nothing Then
                For Each pTreeNode As TreeNode In oTreeNode.Nodes
                    If pTreeNode.Nodes IsNot Nothing Then
                        For Each qTreeNode As TreeNode In pTreeNode.Nodes
                            If qTreeNode.Checked Then
                                Dim objBE As New Rol_OpcionBE
                                Objeto(0) = qTreeNode.ToString.Substring(10, qTreeNode.ToString.Length - 10).Trim
                                Objeto(1) = qTreeNode.Parent.ToString.Substring(10, qTreeNode.Parent.ToString.Length - 10).Trim
                                Objeto(2) = qTreeNode.Parent.Parent.ToString.Substring(10, qTreeNode.Parent.Parent.ToString.Length - 10).Trim
                                Dim IdPrincipal As OpcionBE = listOpcion.Find(match8)
                                objBE.MMCOPC = IdPrincipal.MMCOPC
                                objBE.MMCMNU = IdPrincipal.MMCMNU
                                objBE.MMCAPL = IdPrincipal.MMCAPL
                                objBE.CULUSA = MainModule.USUARIO
                                objBE.FULTAC = HelpClass.TodayNumeric
                                objBE.HULTAC = HelpClass.NowNumeric
                                objBE.NTRMNL = HelpClass.NombreMaquina
                                objBE.NCOROL = Usuario.Trim
                                ListRolOpBE.Add(objBE)
                            End If
                        Next
                    End If
                Next
            End If
        Next
        ListInsert = ListRolOpBE
    End Sub
    Private match8 As New Predicate(Of OpcionBE)(AddressOf Busca8)
    Public Function Busca8(ByVal Opcion_BE As OpcionBE) As Boolean
        If (Opcion_BE.MMDOPC.Trim.ToUpper = Objeto(0).ToString.Trim.ToUpper) And (Opcion_BE.MMTMNU.Trim.ToUpper = Objeto(1).ToString.Trim.ToUpper) And (Opcion_BE.MMDAPL.Trim.ToUpper = Objeto(2).ToString.Trim.ToUpper) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub ActivarCheck()
        Dim oList As List(Of Rol_OpcionBE) = ListOpcionRol.FindAll(match4)
        For Each oTreeViewNodosBE As TreeViewNodosBE In lOpcion
            oObjeto = oTreeViewNodosBE
            Dim RolOpcionBE As Rol_OpcionBE = oList.Find(match2)
            If RolOpcionBE IsNot Nothing Then
                oTreeViewNodosBE.Cheked = True
                RolOpcionBE.CULUSA = MainModule.USUARIO
                RolOpcionBE.FULTAC = HelpClass.TodayNumeric
                RolOpcionBE.HULTAC = HelpClass.NowNumeric
                RolOpcionBE.NTRMNL = HelpClass.NombreMaquina
                ListEliminar.Add(RolOpcionBE)
            Else
                oTreeViewNodosBE.Cheked = False
            End If
        Next
        LimpiarTreeView()
        ConstruirArbol(ImageFormularios, tvwOpcionRol_Acceso, TreeviewsNodosBL.Lista_Aplicacion, TreeviewsNodosBL.Lista_Menu, lOpcion)
    End Sub
    Private Sub CboUsuario_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboOpcionRol_Usuario.SelectedValueChanged
        If Me.CboOpcionRol_Usuario.Enabled = True Then
            ListEliminar.Clear()
            ActivarCheck()
        End If
    End Sub
    Private oObjetoRO As New Rol_OpcionBE
    Private ListInsert As New List(Of Rol_OpcionBE)
    Private ListUpdate As New List(Of Rol_OpcionBE)
    Private match5 As New Predicate(Of Rol_OpcionBE)(AddressOf Busca5)
    Public Function Busca5(ByVal RolOpcion_BE As Rol_OpcionBE) As Boolean
        If (RolOpcion_BE.NCOROL.Trim.ToUpper = oObjetoRO.NCOROL.ToString.Trim) And (RolOpcion_BE.MMCAPL.Trim.ToUpper = oObjetoRO.MMCAPL.ToString.Trim) And (RolOpcion_BE.MMCMNU.Trim.ToUpper = oObjetoRO.MMCMNU.ToString.Trim) And (RolOpcion_BE.MMCOPC.Trim.ToUpper = oObjetoRO.MMCOPC.ToString.Trim) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function Verificar_Delete() As List(Of Rol_OpcionBE)
        ListUpdate.Clear()
        For Each RolOpcion As Rol_OpcionBE In ListEliminar
            oObjetoRO = RolOpcion
            Dim oBE As Rol_OpcionBE = ListInsert.Find(match5)
            If oBE IsNot Nothing Then

            Else
                ListUpdate.Add(RolOpcion)
            End If
        Next
        Return ListUpdate
    End Function
    Private Function Verificar_Insert() As List(Of Rol_OpcionBE)
        ListUpdate.Clear()
        For Each RolOpcion As Rol_OpcionBE In ListInsert
            oObjetoRO = RolOpcion
            Dim oBE As Rol_OpcionBE = ListEliminar.Find(match5)
            If oBE IsNot Nothing Then

            Else
                ListUpdate.Add(RolOpcion)
            End If
        Next
        Return ListUpdate
    End Function
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcionRol_Nuevo.Click
        Me.CboOpcionRol_Usuario.Enabled = True
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
    End Sub
    Private Sub treeViewSesion_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwOpcionRol_Acceso.AfterCheck
        TreeViewMetodos.HabilitarCheked(e.Node.Nodes, e.Node.Checked)
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcionRol_Buscar.Click
        Me.gwdOpcionRol_Datos.DataSource = ListRol.FindAll(match3)
    End Sub
    Private match3 As New Predicate(Of RolBE)(AddressOf Busca3)
    Public Function Busca3(ByVal oRol_BE As RolBE) As Boolean
        If oRol_BE.TOBS.ToUpper.Trim.IndexOf(Me.txtOpcionRol_Buscar.Text.ToUpper.Trim) <> -1 And oRol_BE.NCOROL.ToUpper.Trim <> "0" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private match4 As New Predicate(Of Rol_OpcionBE)(AddressOf Busca4)
    Public Function Busca4(ByVal oRolOpcion_BE As Rol_OpcionBE) As Boolean
        If oRolOpcion_BE.NCOROL.ToUpper.Trim = Me.CboOpcionRol_Usuario.SelectedValue.ToString.ToUpper.Trim Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub gwdOpcionRol_Datos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdOpcionRol_Datos.CellClick
        If e.RowIndex < 0 Or Me.gwdOpcionRol_Datos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Dim lint_indice As Integer = Me.gwdOpcionRol_Datos.CurrentCellAddress.Y
        Me.CboOpcionRol_Usuario.Enabled = True
        Me.CboOpcionRol_Usuario.SelectedValue = Me.gwdOpcionRol_Datos.Item(0, lint_indice).Value.ToString.Trim
        gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
    End Sub
    Private Sub btnOpcionRol_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcionRol_Guardar.Click
        If Me.CboOpcionRol_Usuario.Enabled = True Then
            ConseguirListaCheck(tvwOpcionRol_Acceso, Me.CboOpcionRol_Usuario.SelectedValue.ToString.Trim)
            If gEnum_Mantenimiento > 0 Then
                If MsgBox("Desea Agregar este Nuevo Permiso", MsgBoxStyle.OkCancel, "Nuevo") = MsgBoxResult.Ok Then
                    If RolOpcionBL.Registra_Rol_Opcion(ListInsert) = 1 Then
                        MsgBox("El Permiso se Guardo Satisfactoriamente")
                        CargarListas()
                        DesactivarCheck(tvwOpcionRol_Acceso)
                        Estado_Control()
                    Else
                        MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                        DesactivarCheck(tvwOpcionRol_Acceso)
                        Estado_Control()
                    End If
                End If
            Else
                If MsgBox("Desea Modificar este Rol", MsgBoxStyle.OkCancel, "Modificar") = MsgBoxResult.Ok Then
                    If RolOpcionBL.Eliminar_Rol_Opcion(Verificar_Delete) = 1 And RolOpcionBL.Registra_Rol_Opcion(Verificar_Insert) = 1 Then
                        MsgBox("El Permiso se Guardo Satisfactoriamente")
                        CargarListas()
                        DesactivarCheck(tvwOpcionRol_Acceso)
                        Estado_Control()
                    Else
                        MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                        DesactivarCheck(tvwOpcionRol_Acceso)
                        Estado_Control()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnOpcionRol_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcionRol_Eliminar.Click
        If Me.CboOpcionRol_Usuario.Enabled = True Then
            If MsgBox("Desea Eliminar este Permiso", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                If RolOpcionBL.Eliminar_Rol_Opcion(ListEliminar) = 1 Then
                    MsgBox("El Registro se Elimino Satisfactoriamente")
                    CargarListas()
                    DesactivarCheck(tvwOpcionRol_Acceso)
                    Estado_Control()
                Else
                    MsgBox("Ocurrio un Error,Consulte al Area de Sistemas")
                    DesactivarCheck(tvwOpcionRol_Acceso)
                    Estado_Control()
                End If
            End If
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        End If
    End Sub
    Private Sub btnOpcionRol_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcionRol_Cancelar.Click
        Estado_Control()
        DesactivarCheck(tvwOpcionRol_Acceso)
    End Sub
    Public Sub DesactivarCheck(ByVal oTreeView As Windows.Forms.TreeView)
        For Each oTreeNode As TreeNode In oTreeView.Nodes
            If oTreeNode.Nodes IsNot Nothing Then
                If oTreeNode.Checked Then
                    oTreeNode.Checked = False
                End If
                For Each pTreeNode As TreeNode In oTreeNode.Nodes
                    If pTreeNode.Nodes IsNot Nothing Then
                        If pTreeNode.Checked Then
                            pTreeNode.Checked = False
                        End If
                        For Each qTreeNode As TreeNode In pTreeNode.Nodes
                            If qTreeNode.Checked Then
                                qTreeNode.Checked = False
                            End If
                        Next
                    End If
                Next
            End If
        Next
        oTreeView.CollapseAll()
    End Sub
    Private Sub Estado_Control()
        Me.CboOpcionRol_Usuario.Enabled = False
        Me.CboOpcionRol_Usuario.SelectedIndex = 0
    End Sub
End Class

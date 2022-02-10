Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms
Imports System.Data 


    Public Class TreeViewMetodos

        Private lobjeto As List(Of TreeViewNodosBE)
        Private oObjeto As TreeViewNodosBE

        Public Shared Sub HabilitarCheked(ByVal oTreeNodeCollection As TreeNodeCollection, ByVal Habilitar As Boolean)
            If oTreeNodeCollection Is Nothing Then
                Return
            End If
            For Each oTreeNode As TreeNode In oTreeNodeCollection
                oTreeNode.Checked = Habilitar
                HabilitarCheked(oTreeNode.Nodes, Habilitar)
            Next
        End Sub

        Public Shared Function ConseguirTablaChekeados(ByVal oTreeView As Windows.Forms.TreeView, ByVal cTreeViewNodosBE As List(Of TreeViewNodosBE))

            Dim aFormulario As TreeViewNodosBE() = cTreeViewNodosBE.ToArray()
            Dim i As Integer = 0
            For Each oTreeNode As TreeNode In oTreeView.Nodes
                If oTreeNode.Nodes IsNot Nothing Then
                    For Each pTreeNode As TreeNode In oTreeNode.Nodes
                        If pTreeNode.Nodes IsNot Nothing Then
                            For Each qTreeNode As TreeNode In pTreeNode.Nodes
                                If qTreeNode.Checked Then
                                    aFormulario(i).Cheked = True
                                Else
                                    aFormulario(i).Cheked = False
                                End If
                                i += 1
                            Next
                        End If
                    Next
                End If
            Next
            Dim oTreeViewNodosBE As List(Of TreeViewNodosBE) = New List(Of TreeViewNodosBE)
            For Each tTreeViewNodosBE As TreeViewNodosBE In aFormulario
                oTreeViewNodosBE.Add(tTreeViewNodosBE)
            Next
            Return oTreeViewNodosBE
        End Function

        Public Shared Function ConseguirTablaChekeadosLista(ByVal oTreeView As Windows.Forms.TreeView, ByVal cTreeViewNodosBE As List(Of TreeViewNodosBE))
            'Dim aFormulario As TreeViewNodosBE() = cTreeViewNodosBE
            Dim i As Integer = 0
            For Each oTreeNode As TreeNode In oTreeView.Nodes
                If oTreeNode.Nodes IsNot Nothing Then
                    For Each pTreeNode As TreeNode In oTreeNode.Nodes
                        If pTreeNode.Nodes IsNot Nothing Then
                            For Each qTreeNode As TreeNode In pTreeNode.Nodes
                                If qTreeNode.Checked Then
                                    cTreeViewNodosBE(i).Cheked = True
                                Else
                                    cTreeViewNodosBE(i).Cheked = False
                                End If
                                i += 1
                            Next
                        End If
                    Next
                End If
            Next
            Dim oTreeViewNodosBE As List(Of TreeViewNodosBE) = New List(Of TreeViewNodosBE)
            For Each tTreeViewNodosBE As TreeViewNodosBE In cTreeViewNodosBE
                oTreeViewNodosBE.Add(tTreeViewNodosBE)
            Next
            Return oTreeViewNodosBE
        End Function

    End Class

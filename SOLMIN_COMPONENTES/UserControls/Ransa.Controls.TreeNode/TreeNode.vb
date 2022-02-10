Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Public Class TreeNode(Of T As IDrawable)
    Public Data As T
    Public Children As New List(Of TreeNode(Of T))()
    Private Const Hoffset As Single = 5
    Private Const Voffset As Single = 10
    Private Center As PointF
    Public MyFont As Font = Nothing
    'Public MyPen As Pen = Pens.Black
    Public FontBrush As Brush = Brushes.Black
    'Public BgBrush As Brush = Brushes.White
    Public BgBrush As New TextureBrush(New Bitmap("D:\EQUIPO_MINERIA\SOLMIN_ST\SOLMIN_ST\Resources\Almacen.png"))
    Public KM As Single
    Public cLine As Pen
    Public Data_1 As String
    ' Constructor
    Public Sub New(ByVal new_data As T)
        Me.New(new_data, New Font("Arial", 11, FontStyle.Bold), New Single(), New Pen(Color.White), New String(""))
    End Sub

    Public Sub New(ByVal new_data As T, ByVal fg_font As Font, ByVal new_KM As Single, ByVal new_cLine As Pen, ByVal new_Data_1 As String)
        Data = new_data
        MyFont = fg_font
        KM = new_KM
        cLine = new_cLine
        Data_1 = new_Data_1
    End Sub

    ' Add a TreeNode to out Children list.  
    Public Sub AddChild(ByVal child As TreeNode(Of T))
        Children.Add(child)
    End Sub

    'Arrange the node and its children in the allowed area.
    'Set xmin to indicate the right edge of our subtree.
    'Set ymin to indicate the bottom edge of our subtree.
    Public Sub Arrange(ByVal gr As Graphics, ByRef xmin As Single, ByRef ymin As Single, ByVal KM As Single)
        ' See how big this node is.   
        Dim my_size As SizeF = Data.GetSize(gr, MyFont)
        ' Recursively arrange our children,   
        ' allowing room for this node.   
        Dim x As Single = xmin
        'Dim biggest_ymin As Single = ymin + my_size.Height
        'Dim subtree_ymin As Single = ymin + my_size.Height + Voffset
        Dim biggest_ymin As Single
        Dim subtree_ymin As Single
        For Each child As TreeNode(Of T) In Children
            biggest_ymin = child.KM + my_size.Height
            subtree_ymin = child.KM + my_size.Height + Voffset
            ' Arrange this child's subtree.    
            Dim child_ymin As Single = subtree_ymin
            child.Arrange(gr, x, child_ymin, child.KM)
            ' See if this increases the biggest ymin value.    
            If biggest_ymin < child_ymin Then
                biggest_ymin = child_ymin
            End If
            ' Allow room before the next sibling.    
            x += Hoffset
        Next
        ' Remove the spacing after the last child.   
        If Children.Count > 0 Then
            x -= Hoffset
        End If
        ' See if this node is wider than the subtree under it.   
        Dim subtree_width As Single = x - xmin
        If my_size.Width > subtree_width Then
            ' Center the subtree under this node.    
            ' Make the children rearrange themselves    
            ' moved to center their subtrees.   
            x = xmin + (my_size.Width - subtree_width) / 2
            For Each child As TreeNode(Of T) In Children
                ' Arrange this child's subtree.    
                child.Arrange(gr, x, subtree_ymin, child.KM)
                ' Allow room before the next sibling.    
                x += Hoffset
            Next
            ' The subtree's width is this node's width.    
            subtree_width = my_size.Width
        End If
        ' Set this node's center position.   
        Center = New PointF(xmin + subtree_width / 2, ymin + my_size.Height / 2)
        ' Increase xmin to allow room for   
        ' the subtree before returning.   
        xmin += subtree_width
        ' Set the return value for ymin.   
        ymin = biggest_ymin
    End Sub

    ' Draw the subtree rooted at this node  
    ' with the given upper left corner.  
    Public Sub DrawTree(ByVal gr As Graphics, ByRef x As Single, ByVal y As Single, ByVal cNode As Pen, ByVal cLine As Pen, ByVal NomChild As String)
        ' Arrange the tree.   
        Arrange(gr, x, y, KM)
        ' Draw the tree.   
        DrawTree(gr, cNode, cLine, NomChild)
    End Sub
    ' Draw the subtree rooted at this node.  
    Public Sub DrawTree(ByVal gr As Graphics, ByVal cNode As Pen, ByVal cLine As Pen, ByVal NomChild As String)
        ' Draw the links.   
        DrawSubtreeLinks(gr, cNode, NomChild)
        ' Draw the nodes.   
        DrawSubtreeNodes(gr, cLine)
    End Sub
    ' Draw the links for the subtree rooted at this node.  
    Private Sub DrawSubtreeLinks(ByVal gr As Graphics, ByVal cNode As Pen, ByVal NomChild As String)
        'If Children.Count > 0 Then
        '    For i As Integer = 0 To Children.Count
        '        If i = 0 Then
        '            gr.DrawLine(Children.Item(i).cLine, Center, Children.Item(i).Center)
        '        Else
        '            gr.DrawLine(cNode, Center, Children.Item(i).Center)
        '        End If
        '        Children.Item(i).DrawSubtreeLinks(gr, cNode)
        '    Next
        'End If

        For Each child As TreeNode(Of T) In Children
            Dim Node1 As Pen = Pens.Red
            If NomChild = child.Data_1 Then
                gr.DrawLine(Node1, Center, child.Center)
                child.DrawSubtreeLinks(gr, Node1, NomChild)
            Else
                gr.DrawLine(cNode, Center, child.Center)
                child.DrawSubtreeLinks(gr, cNode, NomChild)
            End If
            ' Draw the link between this node this child.    

            ' Recursively make the child draw its subtree nodes.    
            'child.DrawSubtreeLinks(gr, cNode)
        Next
    End Sub
    ' Draw the nodes for the subtree rooted at this node.  
    Private Sub DrawSubtreeNodes(ByVal gr As Graphics, ByVal cLine As Pen)
        'Draw this node.
        Data.Draw(Center.X, Center.Y, gr, cLine, BgBrush, FontBrush, MyFont)
        ' Recursively make the child draw its subtree nodes.   
        For Each child As TreeNode(Of T) In Children
            child.DrawSubtreeNodes(gr, cLine)
        Next
    End Sub
    ' Return the TreeNode at this point (or null if there isn't one there).  
    Public Function NodeAtPoint(ByVal gr As Graphics, ByVal target_pt As PointF) As TreeNode(Of T)
        ' See if the point is under this node.   
        If Data.IsAtPoint(gr, MyFont, Center, target_pt) Then
            Return Me
        End If
        ' See if the point is under a node in the subtree.   
        For Each child As TreeNode(Of T) In Children
            Dim hit_node As TreeNode(Of T) = child.NodeAtPoint(gr, target_pt)
            If hit_node IsNot Nothing Then
                Return hit_node
            End If
        Next
        Return Nothing
    End Function
    ' Delete a target node from this node's subtree.  
    ' Return true if we delete the node.  
    Public Function DeleteNode(ByVal target As TreeNode(Of T)) As Boolean

        ' See if the target is in our subtree.   
        For Each child As TreeNode(Of T) In Children

            ' See if it's the child.    
            If child Is target Then
                ' Delete this child.     
                Children.Remove(child)
                Return True
            End If
            ' See if it's in the child's subtree.   
            If child.DeleteNode(target) Then
                Return True
            End If
        Next
        ' It's not in our subtree.   
        Return False
    End Function
End Class



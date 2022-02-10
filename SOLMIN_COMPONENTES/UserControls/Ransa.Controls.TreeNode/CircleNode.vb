Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing

Public Class CircleNode
    Implements IDrawable

    Public Text As String
    ' Constructor.  
    Public Sub New(ByVal new_text As String)
        Text = new_text
    End Sub

    'Public Function GetSize(ByVal gr As Graphics, ByVal font As Font) As SizeF
    'Return gr.MeasureString(Text, font) + New SizeF(10, 10)
    'End Function

    Private Sub IDrawable_Draw(ByVal x As Single, ByVal y As Single, ByVal gr As Graphics, ByVal pen As Pen, ByVal bg_brush As TextureBrush, ByVal text_brush As Brush, ByVal font As Font) Implements IDrawable.Draw
        ' Fill and draw an ellipse at our location.   
        Dim my_size As SizeF = GetSize(gr, font)
        'Dim rect As New Rectangle(x - my_size.Width / 2, y - my_size.Height / 2, 81, 81)
        Dim rect As New Rectangle(x - my_size.Width / 2, y - my_size.Height / 2, 120, 60)
        'Dim rect As New RectangleF(x - my_size.Width / 2, y - my_size.Height / 2, my_size.Width, my_size.Height)
        'Dim bt_brush As New TextureBrush(New Bitmap("..\SOLMIN_ST\Resources\icon_truck.jpg"))
        bg_brush.WrapMode = Drawing2D.WrapMode.Clamp
        gr.FillRectangle(bg_brush, rect) 'FillEllipse
        gr.DrawImage(bg_brush.Image, rect)
        'gr.DrawRectangle(pen, rect)        'DrawEllipse
        ' Draw the text.   
        Using string_format As New StringFormat()
            string_format.Alignment = StringAlignment.Near
            string_format.LineAlignment = StringAlignment.Near
            gr.DrawString(Text, font, text_brush, x, y - 40, string_format)
        End Using
    End Sub

    ' Return true if the node is above this point. 
    ' Note: The equation for an ellipse with half  
    ' width w and half height h centered at the origin is:  
    '      x*x/w/w + y*y/h/h <= 1.  
    Private Function IDrawable_IsAtPoint(ByVal gr As Graphics, ByVal font As Font, ByVal center_pt As PointF, ByVal target_pt As PointF) As Boolean Implements IDrawable.IsAtPoint
        ' Get our size.   
        Dim my_size As SizeF = GetSize(gr, font)
        ' translate so we can assume the   
        ' ellipse is centered at the origin.   
        target_pt.X -= center_pt.X
        target_pt.Y -= center_pt.Y
        ' Determine whether the target point is under our ellipse.   
        Dim w As Single = my_size.Width / 2
        Dim h As Single = my_size.Height / 2
        Return target_pt.X * target_pt.X / w / w + target_pt.Y * target_pt.Y / h / h <= 1
    End Function

    Public Function GetSize(ByVal gr As System.Drawing.Graphics, ByVal font As System.Drawing.Font) As System.Drawing.SizeF Implements IDrawable.GetSize
        Return gr.MeasureString(Text, font) + New SizeF(35, 25) '(35, 25)
    End Function
End Class
